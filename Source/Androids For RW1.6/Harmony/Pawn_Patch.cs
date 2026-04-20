using Verse;
using Verse.AI;
using Verse.AI.Group;
using HarmonyLib;
using RimWorld;
using System;
using System.Linq;
using System.Collections.Generic;
using RimWorld.Planet;

namespace MOARANDROIDS
{

    internal class Pawn_Patch
    {
        [HarmonyPatch(typeof(Pawn), "Kill")]
        public class Kill
        {
            [HarmonyPrefix]
            public static bool Listener(Pawn __instance, DamageInfo? dinfo, Hediff exactCulprit = null)
            {
                try
                {
                    if (__instance.IsSurrogateAndroid())
                    {
                        Utils.insideKillFuncSurrogate = true;

                        // Se for um surrogate controlado temporariamente, então ele é devolvido à sua facção
                        CompSkyMind csm = Utils.getCachedCSM(__instance);
                        if(csm != null)
                        {
                            //Log.Message("Restitution surrogate a sa faction");
                            csm.tempHackingEnding();
                        }
                    }
                    // Desconecta o usuário morto e não transmite a mensagem
                    Utils.GCATPP.disconnectUser(__instance, false, false);
                    //Log.Message("YOU KILLED "+__instance.LabelCap);
                    // Se for um surrogate android usado
                    if (__instance.IsSurrogateAndroid(true))
                    {
                        // Obtenção do controlador
                        CompAndroidState cas = Utils.getCachedCAS(__instance);
                        if (cas == null)
                            return true;

                        // Fim do modo de controle no controlador
                        CompSurrogateOwner cso = Utils.getCachedCSO(cas.surrogateController);
                        cso.stopControlledSurrogate(__instance,false, false, true);

                        // Reset das variáveis para uma potencial ressurreição futura
                        cas.resetInternalState();

                    }

                    
                    //Log.Message("YOU KILLED END");
                    Utils.insideKillFuncSurrogate = false;
                    return true;
                }
                catch (Exception e)
                {
                    Log.Message("[ATPP] Pawn.Kill(Error) : " + e.Message + " - " + e.StackTrace);

                    if (__instance.IsSurrogateAndroid())
                        Utils.insideKillFuncSurrogate = false;
                    return true;
                }
            }
        }

        [HarmonyPatch(typeof(Pawn), "PreKidnapped")]
        public class PreKidnapped_Patch
        {
            [HarmonyPostfix]
            public static void Listener(Pawn __instance, Pawn kidnapper)
            {
                try
                {
                    if(__instance.def == ThingDefOfAT.M8Mech)
                    {
                        bool activeConn = false;
                        CompSkyCloudCore csc = Utils.getCachedCSC(__instance);
                        csc.isKidnapped = true;

                        if (csc != null) {
                            if (csc.controlledTurrets.Count > 0)
                                activeConn = true;
                            if (!activeConn)
                            {
                                // Verifica se há conexões ativas de mentes/surrogates
                                foreach (var m in csc.storedMinds)
                                {
                                    CompSurrogateOwner cso = Utils.getCachedCSO(m);
                                    if (cso != null && cso.isThereSX())
                                    {
                                        activeConn = true;
                                        break;
                                    }
                                }
                            }

                            // Se houver conexões ativas, então programe um desligamento aleatório
                            if (activeConn)
                            {
                                csc.KidnappedPendingDisconnectionGT = Find.TickManager.TicksGame + Rand.Range(Settings.nbMinHoursBeforeKidnappedM8Disconnected*2500, Settings.nbMaxHoursBeforeKidnappedM8Disconnected*2500);
                            }
                        }
                    }
                    else if ((__instance.IsAndroidTier() || __instance.VXChipPresent() || __instance.IsSurrogateAndroid()))
                    {
                        // Desconecta o usuário de força, se for o caso
                        Utils.GCATPP.disconnectUser(__instance);
                    }
                }
                catch(Exception e)
                {
                    Log.Message("[ATPP] Pawn.PreKidnapped(Error) : " + e.Message + " - " + e.StackTrace);
                }
            }
        }

        [HarmonyPatch(typeof(Pawn), "ButcherProducts")]
        public class ButcherProducts_Patch
        {
            [HarmonyPostfix]
            public static void Listener(Pawn butcher, float efficiency, Pawn __instance)
            {
                if (__instance.IsAndroidTier())
                    Utils.lastButcheredPawnIsAndroid = true;
                else
                    Utils.lastButcheredPawnIsAndroid = false;
            }
        }

        // Patch usado para remover surrogates da lista mapPawns (somente se a configuração relacionada estiver habilitada) E registrar surrogate na lista listerSurrogates
        [HarmonyPatch(typeof(Pawn), "SpawnSetup")]
        public class SpawnSetup_Patch
        {
            [HarmonyPostfix]
            public static void Listener(Map map, bool respawningAfterLoad, Pawn __instance)
            {
                if (__instance.IsSurrogateAndroid())
                {
                    CompAndroidState cas = Utils.getCachedCAS(__instance);
                    if (cas != null)
                    {
                        if(__instance.Downed)
                            Utils.addDownedSurrogateToLister(__instance);

                        if (Settings.hideInactiveSurrogates)
                        {
                            // Remove surrogate da lista principal somente se for um surrogate inativo
                            if (cas.surrogateController == null)
                            {
                                // Esconde somente surrogate no mapa do jogador
                                if (map != null && map.IsPlayerHome)
                                    map.mapPawns.DeRegisterPawn(__instance);
                            }
                        }
                    }
                }
                // Define uma necessidade de descanso falsa para prevenir erros
                if (__instance.IsAndroidTier() && __instance.needs != null)
                {
                    __instance.needs.rest = new Need_Rest_Fake(__instance);
                }
            }
        }

        
        static private Pawn Pawn_GetGizmosPrevPawn;
        static private CompSkyMind Pawn_GetGizmosPrevCSM;
        static private bool Pawn_GetGizmosPrevIsPoweredAnimalAndroids;

        [HarmonyPatch(typeof(Pawn), "GetGizmos")]
        public class GetGizmos_Patch
        {
            [HarmonyPostfix]
            public static void Listener(Pawn __instance, ref IEnumerable<Gizmo> __result)
            {
                // Caching para aumentar o desempenho em pawns selecionados
                if(__instance != Pawn_GetGizmosPrevPawn)
                {
                    Pawn_GetGizmosPrevPawn = __instance;
                    Pawn_GetGizmosPrevCSM = Utils.getCachedCSM(__instance);
                    Pawn_GetGizmosPrevIsPoweredAnimalAndroids = __instance.IsPoweredAnimalAndroids();
                }

                // M7/M8 não expõem botões de habilidade do RimWorld, mas ainda precisam dos
                // gizmos do Android Tiers anexados abaixo.
                if (Utils.IsM7OrM8(__instance))
                {
                    __result = __result.Where(gizmo => gizmo == null || !(gizmo is Command_Ability));
                }

                // Se for prisioneiro e possuir um VX2, obteremos os GIZMOS associados OU infectados
                if ((__instance.IsPrisoner) || (Pawn_GetGizmosPrevCSM != null && Pawn_GetGizmosPrevCSM.Hacked == 1))
                {
                    IEnumerable<Gizmo> tmp;

                    // Se possuir uma VX2
                    if (__instance.VXChipPresent())
                    {
                        CompSurrogateOwner cso = Utils.getCachedCSO(__instance);
                        if (cso != null)
                        {
                            tmp = cso.CompGetGizmosExtra();
                            if (tmp != null)
                                __result = __result.Concat(tmp);
                        }
                    }

                    // Se for um android prisioneiro ou infectado
                    if (__instance.IsAndroidTier())
                    {
                        CompAndroidState cas = Utils.getCachedCAS(__instance);

                        if (cas != null)
                        {
                            tmp = cas.CompGetGizmosExtra();
                            if (tmp != null)
                                __result = __result.Concat(tmp);
                        }
                    }

                    if (Pawn_GetGizmosPrevCSM != null && Pawn_GetGizmosPrevCSM.Hacked == -1)
                    {
                        tmp = Pawn_GetGizmosPrevCSM.CompGetGizmosExtra();
                        if (tmp != null)
                            __result = __result.Concat(tmp);
                    }
                }

                // Se for um animal possuído pelo jogador
                if (Pawn_GetGizmosPrevIsPoweredAnimalAndroids)
                {
                    CompAndroidState cas = null;
                    cas = Utils.getCachedCAS(__instance);
                    if (cas != null)
                    {
                        IEnumerable<Gizmo> tmp = cas.CompGetGizmosExtra();
                        if (tmp != null)
                            __result = __result.Concat(tmp);
                    }
                }

                if (__instance.Faction == Faction.OfPlayer && !__instance.Dead && !__instance.Destroyed)
                {
                    CompSurrogateOwner cso = Utils.getCachedCSO(__instance);
                    if (cso != null)
                        __result = AppendUniqueGizmos(__result, cso.CompGetGizmosExtra());

                    CompSkyMind csm = Utils.getCachedCSM(__instance);
                    if (csm != null && csm.Hacked == -1)
                        __result = AppendUniqueGizmos(__result, csm.CompGetGizmosExtra());

                    CompAndroidState cas = Utils.getCachedCAS(__instance);
                    if (cas != null)
                        __result = AppendUniqueGizmos(__result, cas.CompGetGizmosExtra());

                    CompSkyCloudCore csc = Utils.getCachedCSC(__instance);
                    if (csc != null)
                        __result = AppendUniqueGizmos(__result, csc.CompGetGizmosExtra());
                }
            }

            private static IEnumerable<Gizmo> AppendUniqueGizmos(IEnumerable<Gizmo> baseGizmos, IEnumerable<Gizmo> extraGizmos)
            {
                if (extraGizmos == null)
                    return baseGizmos;

                List<Gizmo> gizmos = baseGizmos?.ToList() ?? new List<Gizmo>();

                foreach (Gizmo gizmo in extraGizmos)
                {
                    if (gizmo == null || ContainsEquivalentGizmo(gizmos, gizmo))
                        continue;

                    gizmos.Add(gizmo);
                }

                return gizmos;
            }

            private static bool ContainsEquivalentGizmo(List<Gizmo> gizmos, Gizmo candidate)
            {
                Command candidateCommand = candidate as Command;
                if (candidateCommand == null)
                    return gizmos.Contains(candidate);

                foreach (Gizmo gizmo in gizmos)
                {
                    Command command = gizmo as Command;
                    if (command == null)
                        continue;

                    if (command.GetType() == candidateCommand.GetType() && command.defaultLabel == candidateCommand.defaultLabel)
                        return true;
                }

                return false;
            }
        }
    }
}
