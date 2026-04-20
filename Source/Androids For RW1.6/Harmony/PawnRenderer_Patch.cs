using Verse;
using Verse.AI;
using Verse.AI.Group;
using HarmonyLib;
using RimWorld;
using System.Collections.Generic;
using System.Linq;
using System;
using UnityEngine;

namespace MOARANDROIDS
{
    internal class ATPP_PawnRenderer_Patch
    {
        [HarmonyPatch(typeof(PawnRenderer), "LayingFacing")]
        public class LayingFacing_Patch
        {
            [HarmonyPostfix]
            public static void Listener(Pawn ___pawn, ref Rot4 __result)
            {
                if (___pawn.def.defName == Utils.M7 || ___pawn.def.defName == Utils.M8)
                    __result = Rot4.South;
            }
        }


        [HarmonyPatch(typeof(PawnRenderer), "RenderPawnInternal")]
        public class ATPP_RenderPawnInternal_Patch
        {
            [HarmonyPostfix]
            public static void Listener(PawnRenderer __instance, PawnDrawParms parms)
            {
                try
                {
                    Pawn pawn = parms.pawn;
                    if (pawn == null) return;

                    CompAndroidState cas = Utils.getCachedCAS(pawn);

                    bool shouldDraw = pawn.def.defName == Utils.TX2
                        || pawn.def.defName == Utils.TX2I
                        || pawn.def.defName == Utils.TX2KI
                        || pawn.def.defName == Utils.TX3I
                        || pawn.def.defName == Utils.TX4I
                        || (pawn.def.defName == Utils.TX2K && cas != null && (cas.TXHurtedHeadSet || cas.TXHurtedHeadSet2))
                        || (pawn.def.defName == Utils.TX3 && cas != null && (cas.TXHurtedHeadSet || cas.TXHurtedHeadSet2))
                        || (pawn.def.defName == Utils.TX4 && cas != null && (cas.TXHurtedHeadSet || cas.TXHurtedHeadSet2));

                    if (!shouldDraw || parms.dead || parms.flags.FlagSet(PawnRenderFlags.HeadStump))
                        return;

                    Rot4 facing = parms.facing;
                    if (facing == Rot4.North) return;

                    Vector3 rootLoc = new Vector3(parms.matrix.m03, parms.matrix.m13, parms.matrix.m23);
                    Quaternion quaternion = Quaternion.identity;

                    Vector3 a = rootLoc;
                    a.y += 0.0281250011f;

                    Vector3 b = quaternion * __instance.BaseHeadOffsetAt(facing);
                    Vector3 loc = a + b + new Vector3(0f, 0.01f, 0f);

                    Mesh mesh = facing == Rot4.West ? MeshPool.plane10Flip : MeshPool.plane10;
                    bool isHorizontal = facing.IsHorizontal;

                    int type = 1;
                    if (cas != null && cas.TXHurtedHeadSet)
                        type = 2;
                    else if (cas != null && (cas.TXHurtedHeadSet2
                        || pawn.def.defName == Utils.TX2I
                        || pawn.def.defName == Utils.TX2KI
                        || pawn.def.defName == Utils.TX3I
                        || pawn.def.defName == Utils.TX4I))
                        type = 3;

                    Color color = new Color(0.9450f, 0.76862f, 0.05882f);

                    if (pawn.def.defName == Utils.TX3 || pawn.def.defName == Utils.TX4
                        || pawn.def.defName == Utils.TX3I || pawn.def.defName == Utils.TX4I)
                        color = new Color(0f, 0.972549f, 0.972549f);

                    if (pawn.Drafted
                        || (pawn.Faction != null && pawn.Faction.HostileTo(Faction.OfPlayer))
                        || pawn.def.defName == Utils.TX2K
                        || pawn.def.defName == Utils.TX2KI)
                        color = new Color(0.75f, 0f, 0f, 1f);

                    string gender = pawn.gender == Gender.Female ? "F" : "M";

                    if (isHorizontal)
                        GenDraw.DrawMeshNowOrLater(mesh, loc, quaternion, Tex.getEyeGlowEffect(color, gender, type, 0).MatSingle, true);
                    else
                        GenDraw.DrawMeshNowOrLater(mesh, loc, quaternion, Tex.getEyeGlowEffect(color, gender, type, 1).MatSingle, true);
                }
                catch (Exception e)
                {
                    Log.Message("[ATPP] PawnRenderer.RenderPawnInternal " + e.Message + " " + e.StackTrace);
                }
            }
        }
    }
}