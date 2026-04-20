using Verse;
using Verse.AI;
using Verse.AI.Group;
using HarmonyLib;
using RimWorld;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Reflection;

namespace MOARANDROIDS
{
    internal class PawnGraphicSet_Patch

    {
        [HarmonyPatch(typeof(PawnRenderTree), "SetupDynamicNodes")]
        public class SetupDynamicNodesPrefix_Patch
        {
            [HarmonyPrefix]
            public static bool Prefix(PawnRenderTree __instance)
            {
                Pawn pawn = Traverse.Create(__instance).Field("pawn").GetValue<Pawn>();
                if (pawn?.story?.bodyType == null)
                {
                    return true;
                }

                if (Utils.ExceptionBodyTypeDefnameAndroidWithSkinMale.Contains(pawn.story.bodyType.defName))
                {
                    Utils.insideResolveApparelGraphicsLastBodyTypeDef = pawn.story.bodyType;
                    pawn.story.bodyType = BodyTypeDefOf.Male;
                }
                else if (Utils.ExceptionBodyTypeDefnameAndroidWithSkinFemale.Contains(pawn.story.bodyType.defName))
                {
                    Utils.insideResolveApparelGraphicsLastBodyTypeDef = pawn.story.bodyType;
                    pawn.story.bodyType = BodyTypeDefOf.Female;
                }

                return true;
            }
        }

        [HarmonyPatch(typeof(PawnRenderTree), "SetupDynamicNodes")]
        public class SetupDynamicNodesPostfix_Patch
        {
            [HarmonyPostfix]
            public static void Postfix(PawnRenderTree __instance)
            {
                if(Utils.insideResolveApparelGraphicsLastBodyTypeDef != null)
                {
                    Pawn pawn = Traverse.Create(__instance).Field("pawn").GetValue<Pawn>();
                    if (pawn?.story != null)
                    {
                        pawn.story.bodyType = Utils.insideResolveApparelGraphicsLastBodyTypeDef;
                    }
                    Utils.insideResolveApparelGraphicsLastBodyTypeDef = null;
                }
            }
        }
    }
}
