using Verse;
using Verse.AI;
using Verse.AI.Group;
using HarmonyLib;
using RimWorld;
using System.Collections.Generic;
using System.Linq;
using System;

namespace MOARANDROIDS
{
    internal class StartingPawnUtility_Patch

    {
        [HarmonyPatch(typeof(ScenPart_ConfigPage_ConfigureStartingPawns), "GenerateStartingPawns")]
        public class GenerateAndroidStartingPawnRequests_Patch
        {
            [HarmonyPostfix]
            public static void Listener(ScenPart_ConfigPage_ConfigureStartingPawns __instance)
            {
                try
                {
                    if (!Utils.IsAndroidPlayerScenario())
                        return;

                    FactionDef factionDef = Utils.CurrentScenarioPlayerFactionDef();
                    if (factionDef == null)
                        return;

                    int pawnCount = Traverse.Create(__instance).Field("pawnCount").GetValue<int>();
                    int pawnChoiceCount = Traverse.Create(__instance).Field("pawnChoiceCount").GetValue<int>();
                    if (pawnChoiceCount < pawnCount)
                        pawnChoiceCount = pawnCount;

                    List<PawnKindDef> selectedKinds = AndroidScenarioSelectedKinds(factionDef.defName, pawnCount);
                    List<PawnKindDef> choicePool = AndroidScenarioChoicePool(factionDef.defName);

                    if (selectedKinds.Count == 0 || choicePool.Count == 0)
                        return;

                    List<PawnGenerationRequest> requests = new List<PawnGenerationRequest>();
                    foreach (PawnKindDef kind in selectedKinds)
                        requests.Add(AndroidStarterRequest(kind));

                    while (requests.Count < pawnChoiceCount)
                        requests.Add(AndroidStarterRequest(choicePool.RandomElement()));

                    Traverse.Create(typeof(StartingPawnUtility)).Field("StartingAndOptionalPawnGenerationRequests").SetValue(requests);
                }
                catch (Exception e)
                {
                    Log.Error("[ATPP] ScenPart_ConfigPage_ConfigureStartingPawns.GenerateStartingPawns " + e.Message + " " + e.StackTrace);
                }
            }

            private static PawnGenerationRequest AndroidStarterRequest(PawnKindDef kind)
            {
                return Utils.NewPawnGenerationRequest(kind, Faction.OfPlayer, PawnGenerationContext.PlayerStarter, -1, true, false, false, false, true, TutorSystem.TutorialMode, 20f, false, true, true, false, false, false, false);
            }

            private static List<PawnKindDef> AndroidScenarioSelectedKinds(string factionDefName, int pawnCount)
            {
                List<PawnKindDef> kinds = new List<PawnKindDef>();
                if (factionDefName == "PlayerColonyAndroid")
                {
                    AddKind(kinds, "AndroidT1ColonistGeneral");
                    AddKind(kinds, "AndroidT2ColonistGeneral");
                    AddKind(kinds, "AndroidT3ColonistGeneral");
                }
                else if (factionDefName == "AndroidTiers_PlayerColonyROM")
                {
                    AddKind(kinds, "AndroidT4ColonistGeneral");
                }
                else if (factionDefName == "AndroidTiers_PlayerColonyApocalypse")
                {
                    AddKind(kinds, "M8MechPawn");
                }

                List<PawnKindDef> pool = AndroidScenarioChoicePool(factionDefName);
                while (kinds.Count < pawnCount && pool.Count != 0)
                    kinds.Add(pool.RandomElement());

                if (kinds.Count > pawnCount)
                    kinds.RemoveRange(pawnCount, kinds.Count - pawnCount);

                return kinds;
            }

            private static List<PawnKindDef> AndroidScenarioChoicePool(string factionDefName)
            {
                List<PawnKindDef> kinds = new List<PawnKindDef>();
                if (factionDefName == "PlayerColonyAndroid")
                {
                    AddKind(kinds, "AndroidT1ColonistGeneral");
                    AddKind(kinds, "AndroidT1ColonistGeneral");
                    AddKind(kinds, "AndroidT2ColonistGeneral");
                    AddKind(kinds, "AndroidT2ColonistGeneral");
                    AddKind(kinds, "AndroidT3ColonistGeneral");
                    AddKind(kinds, "AndroidT4ColonistGeneral");
                }
                else if (factionDefName == "AndroidTiers_PlayerColonyROM")
                {
                    AddKind(kinds, "AndroidT2ColonistGeneral");
                    AddKind(kinds, "AndroidT3ColonistGeneral");
                    AddKind(kinds, "AndroidT3ColonistGeneral");
                    AddKind(kinds, "AndroidT4ColonistGeneral");
                    AddKind(kinds, "AndroidT4ColonistGeneral");
                }
                else if (factionDefName == "AndroidTiers_PlayerColonyApocalypse")
                {
                    AddKind(kinds, "M8MechPawn");
                    AddKind(kinds, "M8MechPawn");
                    AddKind(kinds, "AndroidT1ColonistGeneral");
                    AddKind(kinds, "AndroidT2ColonistGeneral");
                    AddKind(kinds, "AndroidT3ColonistGeneral");
                    AddKind(kinds, "AndroidT4ColonistGeneral");
                }

                return kinds;
            }

            private static void AddKind(List<PawnKindDef> kinds, string defName)
            {
                PawnKindDef kind = DefDatabase<PawnKindDef>.GetNamedSilentFail(defName);
                if (kind != null)
                    kinds.Add(kind);
            }
        }

        [HarmonyPatch(typeof(StartingPawnUtility), "NewGeneratedStartingPawn")]
        public class NewGeneratedStartingPawn_Patch
        {
            public static bool Prepare()
            {
                return false;
            }

            [HarmonyAfter(new string[] { "rimworld.rwmods.androidtiers" })]
            [HarmonyPostfix]
            public static void Listener(ref Pawn __result)
            {
                if (__result == null)
                {
                    return;
                }
                if (Faction.OfPlayer.def.basicMemberKind.defName != "AndroidT2ColonistGeneral")
                {
                    return;
                }
                else
                {
                    Random rnd = new Random();
                    PawnGenerationRequest request;
                    string pkd = "";
                    if (!Utils.TXSERIE_LOADED)
                    {
                        switch (rnd.Next(1, 3))
                        {
                            case 1:
                                pkd = "AndroidT2ColonistGeneral";
                                break;
                            case 2:
                                pkd = "AndroidT1ColonistGeneral";
                                break;
                            default:
                                pkd = Faction.OfPlayer.def.basicMemberKind.defName;
                                break;
                        }
                    }
                    else
                    {
                        switch (rnd.Next(1, 5))
                        {
                            case 1:
                                pkd = "AndroidT2ColonistGeneral";
                                break;
                            case 2:
                                pkd = "AndroidT1ColonistGeneral";
                                break;
                            case 3:
                                pkd = "ATPP_Android2ITXKind";
                                break;
                            case 4:
                                pkd = "ATPP_Android2TXKind";
                                break;
                            default:
                                pkd = Faction.OfPlayer.def.basicMemberKind.defName;
                                break;
                        }
                    }
                    request = Utils.NewPawnGenerationRequest(DefDatabase<PawnKindDef>.GetNamed(pkd, false), Faction.OfPlayer, PawnGenerationContext.PlayerStarter, -1, true, false, false, false, true, TutorSystem.TutorialMode, 20f, false, true, true, false, false, false, false);
                    __result = null;
                    try
                    {
                        __result = PawnGenerator.GeneratePawn(request);
                    }
                    catch (Exception e)
                    {
                        Log.Error("[ATPP] StartingPawnUtility.NewGeneratedStartingPawn " + e.Message+" "+e.StackTrace);
                        __result = PawnGenerator.GeneratePawn(request);
                    }
                    __result.relations.everSeenByPlayer = true;
                    PawnComponentsUtility.AddComponentsForSpawn(__result);
                }
            }
        }
    }
}
