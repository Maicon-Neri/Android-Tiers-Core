using HarmonyLib;
using RimWorld;
using Verse;
using Verse.AI;

namespace MOARANDROIDS
{
    internal class MapGenJobSafety_Patch
    {
        private static bool PawnHasUsableMap(Pawn pawn)
        {
            return pawn != null
                && !pawn.Destroyed
                && pawn.MapHeld != null
                && pawn.PositionHeld.IsValid;
        }

        [HarmonyPatch(typeof(Pawn_JobTracker), "CheckForJobOverride")]
        public class CheckForJobOverride_Patch
        {
            [HarmonyPrefix]
            public static bool Prefix(Pawn ___pawn)
            {
                return PawnHasUsableMap(___pawn);
            }
        }

        [HarmonyPatch(typeof(JobGiver_FleeDanger), "TryGiveJob")]
        public class JobGiver_FleeDanger_TryGiveJob_Patch
        {
            [HarmonyPrefix]
            public static bool Prefix(Pawn pawn, ref Job __result)
            {
                if (PawnHasUsableMap(pawn))
                    return true;

                __result = null;
                return false;
            }
        }
    }
}
