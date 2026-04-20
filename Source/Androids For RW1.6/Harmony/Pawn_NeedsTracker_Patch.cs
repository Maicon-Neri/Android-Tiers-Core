using Verse;
using HarmonyLib;
using RimWorld;
using System;

namespace MOARANDROIDS
{
    internal class Pawn_NeedsTracker_Patch
    {
        /*
         * PostFix evitando a atribuição de need comfort e outdoor aos T1 e T2 e a higiene a todos os robôs
         */
        [HarmonyPatch(typeof(Pawn_NeedsTracker), "ShouldHaveNeed")]
        public class ShouldHaveNeed_Patch
        {
            [HarmonyPrefix]
            public static bool Prefix(NeedDef nd, ref bool __result, Pawn ___pawn)
            {
                try
                {
                    if (___pawn != null && nd != null && nd.defName != null)
                    {
                        if (Utils.IsM7OrM8(___pawn))
                        {
                            __result = ___pawn.def.defName == Utils.M7 && ___pawn.IsSurrogateAndroid() && nd.defName == "Food";
                            return false;
                        }

                        if (___pawn.IsAndroidTier())
                        {
                            __result = AndroidShouldHaveNeed(___pawn, nd);
                            return false;
                        }

                        // Evita o crash Vanilla do RimWorld 1.4+ quando o M7Mech/Surrogate (sem pawn.story) tenta avaliar certas necessidades
                        if (___pawn.story == null && (nd.defName == "Mood" || nd.defName == "Joy" || nd.defName == "Comfort" || nd.defName == "Outdoors" || nd.defName == "Beauty" || nd.defName == "RoomSize"))
                        {
                            __result = false;
                            return false;
                        }
                    }
                }
                catch (Exception e)
                {
                    Log.Message("[ATPP] Pawn_StoryTracker.ShouldHaveNeed Prefix : " + e.Message + " - " + e.StackTrace);
                }

                return true;
            }

            private static bool AndroidShouldHaveNeed(Pawn pawn, NeedDef nd)
            {
                string needName = nd.defName;
                bool advancedAndroids = pawn.IsAdvancedAndroidTier();

                if (needName.StartsWith("Chemical_", StringComparison.Ordinal)
                    || needName == "Rest"
                    || needName == "Hygiene"
                    || needName == "Bladder"
                    || needName == "DBHThirst")
                    return false;

                if (needName == "Food")
                    return pawn.RaceProps != null && pawn.RaceProps.foodType != FoodTypeFlags.None && pawn.RaceProps.baseHungerRate > 0f;

                if (needName == "Outdoors")
                    return !pawn.IsBasicAndroidTier();

                if (needName == "Beauty")
                    return pawn.def.defName != "Android1Tier";

                if (needName == "Comfort")
                    return advancedAndroids && !Settings.removeComfortNeedForT3T4;

                if (needName == "Mood" || needName == "Joy" || needName == "RoomSize")
                    return pawn.RaceProps?.Humanlike == true && pawn.story != null;

                return false;
            }

            [HarmonyPostfix]
            public static void Listener(NeedDef nd, ref bool __result, Pawn ___pawn)
            {
                try
                {
                    bool isAndroid = ___pawn.IsAndroidTier();

                    //Se não for um androide, retorna
                    if (!isAndroid)
                        return;

                    bool advancedAndroids = ___pawn.IsAdvancedAndroidTier();

                    if ((___pawn.IsBasicAndroidTier()
                        && (nd.defName == "Outdoors" ))
                        || (___pawn.def.defName == "Android1Tier" && nd.defName == "Beauty")
                        || (isAndroid && (nd.defName == "Hygiene" || nd.defName == "Bladder" || nd.defName ==  "DBHThirst"))
                        || (nd.defName == "Comfort" && (!advancedAndroids || (advancedAndroids && Settings.removeComfortNeedForT3T4))))
                    {
                        __result = false;
                    }

                    //Activation besoin de bouffe pour les M7 surrogates (SM7)
                    if (___pawn.def.defName == "M7Mech" && ___pawn.IsSurrogateAndroid() && nd.defName == "Food")
                        __result = true;
                }
                catch(Exception e)
                {
                    Log.Message("[ATPP] Pawn_StoryTracker.ShouldHaveNeed : " + e.Message + " - " + e.StackTrace);
                }
            }
        }


        /*[HarmonyPatch(typeof(Pawn_NeedsTracker), "NeedsTrackerTick")]
        public class NeedsTrackerTick_Patch
        {
            [HarmonyPostfix]
            public static void Listener(Pawn ___pawn)
            {
                CompSurrogateOwner cso = ___pawn.TryGetComp<CompSurrogateOwner>();
                if (cso != null && cso.skyCloudHost != null)
                {
                    Log.Message("Pawn_NeedsTracker " + ___pawn.LabelCap);
                }
            }
        }*/
    }
}
