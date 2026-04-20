using HarmonyLib;
using RimWorld;
using System;
using Verse;

namespace MOARANDROIDS
{
    internal class IncidentWorker_RaidEnemy_Patch
    {
        [HarmonyPatch(typeof(IncidentWorker_RaidEnemy), "ResolveRaidStrategy")]
        public class ResolveRaidStrategy_Patch
        {
            [HarmonyPrefix]
            public static bool Prefix(IncidentParms parms, PawnGroupKindDef groupKind)
            {
                if (parms?.faction?.def == null || parms.raidStrategy != null)
                    return true;

                if (Array.IndexOf(Utils.ExceptionATFactions, parms.faction.def.defName) < 0)
                    return true;

                RaidStrategyDef immediateAttack = DefDatabase<RaidStrategyDef>.GetNamed("ImmediateAttack", false);
                if (immediateAttack == null)
                    return true;

                parms.raidStrategy = immediateAttack;
                return false;
            }
        }
    }
}
