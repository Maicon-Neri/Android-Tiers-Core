using HarmonyLib;
using RimWorld;
using RimWorld.Planet;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Verse;

namespace MOARANDROIDS
{
    internal class ColonistBar_Patch
    {
        private static readonly List<Map> tmpMaps = new List<Map>();
        private static readonly List<Pawn> tmpPawns = new List<Pawn>();
        private static readonly List<Caravan> tmpCaravans = new List<Caravan>();
        private static readonly HashSet<Pawn> tmpStoredMinds = new HashSet<Pawn>();

        [HarmonyPatch(typeof(ColonistBar), "CheckRecacheEntries")]
        public class CheckRecacheEntries_Patch
        {
            [HarmonyPrefix]
            public static bool Prefix(
                ColonistBar __instance,
                ref bool ___entriesDirty,
                List<ColonistBar.Entry> ___cachedEntries,
                List<Vector2> ___cachedDrawLocs,
                List<int> ___cachedReorderableGroups,
                ColonistBarColonistDrawer ___drawer,
                ColonistBarDrawLocsFinder ___drawLocsFinder,
                ref float ___cachedScale)
            {
                if (!___entriesDirty)
                    return false;

                ___entriesDirty = false;

                try
                {
                    RecacheEntries(___cachedEntries, ___cachedDrawLocs, ___cachedReorderableGroups, ___drawer, ___drawLocsFinder, ref ___cachedScale);
                }
                catch (Exception e)
                {
                    Log.Error("[ATPP] ColonistBar.CheckRecacheEntries recovered from " + e.GetType().Name + ": " + e.Message + "\n" + e.StackTrace);
                    ___cachedEntries.Clear();
                    ___cachedDrawLocs.Clear();
                    ___cachedReorderableGroups.Clear();
                    ___cachedScale = 1f;
                    ___drawer.Notify_RecachedEntries();
                }
                finally
                {
                    tmpMaps.Clear();
                    tmpPawns.Clear();
                    tmpCaravans.Clear();
                    tmpStoredMinds.Clear();
                }

                return false;
            }

            private static void RecacheEntries(
                List<ColonistBar.Entry> cachedEntries,
                List<Vector2> cachedDrawLocs,
                List<int> cachedReorderableGroups,
                ColonistBarColonistDrawer drawer,
                ColonistBarDrawLocsFinder drawLocsFinder,
                ref float cachedScale)
            {
                cachedEntries.Clear();
                int groupsCount = 0;

                foreach (Pawn mind in Utils.GetSkyCloudStoredMinds())
                {
                    if (mind != null)
                        tmpStoredMinds.Add(mind);
                }

                if (Find.PlaySettings != null && Find.PlaySettings.showColonistBar)
                {
                    RecacheMapEntries(cachedEntries, ref groupsCount);
                    RecacheCaravanEntries(cachedEntries, ref groupsCount);
                }

                cachedReorderableGroups.Clear();
                for (int i = 0; i < cachedEntries.Count; i++)
                    cachedReorderableGroups.Add(-1);

                drawer.Notify_RecachedEntries();
                drawLocsFinder.CalculateDrawLocs(cachedDrawLocs, out cachedScale, groupsCount);
            }

            private static void RecacheMapEntries(List<ColonistBar.Entry> cachedEntries, ref int groupsCount)
            {
                tmpMaps.Clear();
                if (Find.Maps != null)
                    tmpMaps.AddRange(Find.Maps.Where(map => map != null));

                tmpMaps.SortBy((Map x) => !x.IsPlayerHome, (Map x) => x.uniqueID);

                for (int i = 0; i < tmpMaps.Count; i++)
                {
                    tmpPawns.Clear();
                    Map map = tmpMaps[i];

                    if (map.mapPawns != null)
                    {
                        AddDisplayablePawns(tmpPawns, map.mapPawns.FreeColonists);
                        AddDisplayablePawns(tmpPawns, map.mapPawns.ColonySubhumansControllable);
                        AddCarriedColonistCorpses(tmpPawns, map.mapPawns.AllPawnsSpawned);
                    }

                    AddSpawnedColonistCorpses(tmpPawns, map);
                    EnsureDisplayOrders(tmpPawns);
                    PlayerPawnsDisplayOrderUtility.Sort(tmpPawns);

                    foreach (Pawn pawn in tmpPawns)
                        cachedEntries.Add(new ColonistBar.Entry(pawn, map, groupsCount));

                    if (!tmpPawns.Any())
                        cachedEntries.Add(new ColonistBar.Entry(null, map, groupsCount));

                    groupsCount++;
                }
            }

            private static void RecacheCaravanEntries(List<ColonistBar.Entry> cachedEntries, ref int groupsCount)
            {
                tmpCaravans.Clear();
                if (Find.WorldObjects?.Caravans != null)
                    tmpCaravans.AddRange(Find.WorldObjects.Caravans.Where(caravan => caravan != null));

                tmpCaravans.SortBy((Caravan x) => x.ID);

                for (int i = 0; i < tmpCaravans.Count; i++)
                {
                    Caravan caravan = tmpCaravans[i];
                    if (!caravan.IsPlayerControlled)
                        continue;

                    tmpPawns.Clear();
                    AddDisplayablePawns(tmpPawns, caravan.PawnsListForReading);
                    PlayerPawnsDisplayOrderUtility.Sort(tmpPawns);

                    foreach (Pawn pawn in tmpPawns)
                    {
                        if (pawn.IsColonist || pawn.IsColonySubhumanPlayerControlled)
                            cachedEntries.Add(new ColonistBar.Entry(pawn, null, groupsCount));
                    }

                    groupsCount++;
                }
            }

            private static void AddSpawnedColonistCorpses(List<Pawn> pawns, Map map)
            {
                List<Thing> corpses = map?.listerThings?.ThingsInGroup(ThingRequestGroup.Corpse);
                if (corpses == null)
                    return;

                for (int i = 0; i < corpses.Count; i++)
                {
                    if (corpses[i] is Corpse corpse && !corpse.IsDessicated())
                    {
                        Pawn innerPawn = corpse.InnerPawn;
                        if (innerPawn != null && innerPawn.IsColonist)
                            AddDisplayablePawn(pawns, innerPawn);
                    }
                }
            }

            private static void AddCarriedColonistCorpses(List<Pawn> pawns, IReadOnlyList<Pawn> carriers)
            {
                if (carriers == null)
                    return;

                for (int i = 0; i < carriers.Count; i++)
                {
                    Pawn carrier = carriers[i];
                    Corpse corpse = carrier?.carryTracker?.CarriedThing as Corpse;
                    Pawn innerPawn = corpse?.InnerPawn;
                    if (corpse != null && !corpse.IsDessicated() && innerPawn != null && innerPawn.IsColonist)
                        AddDisplayablePawn(pawns, innerPawn);
                }
            }

            private static void AddDisplayablePawns(List<Pawn> pawns, IEnumerable<Pawn> candidates)
            {
                if (candidates == null)
                    return;

                foreach (Pawn pawn in candidates)
                    AddDisplayablePawn(pawns, pawn);
            }

            private static void AddDisplayablePawn(List<Pawn> pawns, Pawn pawn)
            {
                if (!CanDisplayPawn(pawn) || pawns.Contains(pawn))
                    return;

                pawns.Add(pawn);
            }

            private static bool CanDisplayPawn(Pawn pawn)
            {
                if (pawn == null || pawn.Destroyed)
                    return false;

                if (tmpStoredMinds.Contains(pawn))
                    return false;

                if (Settings.hideInactiveSurrogates && pawn.IsSurrogateAndroid(false, true))
                    return false;

                EnsurePlayerSettings(pawn);
                return pawn.playerSettings != null;
            }

            private static void EnsureDisplayOrders(List<Pawn> pawns)
            {
                if (pawns.Count == 0)
                    return;

                int maxDisplayOrder = 0;
                foreach (Pawn pawn in pawns)
                {
                    if (pawn?.playerSettings != null)
                        maxDisplayOrder = Mathf.Max(maxDisplayOrder, pawn.playerSettings.displayOrder);
                }

                foreach (Pawn pawn in pawns)
                {
                    if (pawn.playerSettings.displayOrder == Pawn_PlayerSettings.UnsetDisplayOrder)
                    {
                        maxDisplayOrder++;
                        pawn.playerSettings.displayOrder = maxDisplayOrder;
                    }
                }
            }

            private static void EnsurePlayerSettings(Pawn pawn)
            {
                if (pawn == null || pawn.playerSettings != null || pawn.Faction != Faction.OfPlayer)
                    return;

                pawn.playerSettings = new Pawn_PlayerSettings(pawn);
            }
        }
    }
}
