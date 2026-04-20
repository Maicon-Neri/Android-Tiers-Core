# Relatório de Modificações: Versão 1.3 vs 1.6 (Com Código)

### Alerts/Alert_Hot2Devices.cs
```diff
--- v1.3/Alerts/Alert_Hot2Devices.cs
+++ v1.6/Alerts/Alert_Hot2Devices.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using System.Collections.Generic;
 using Verse;
```

### Alerts/Alert_Hot3Devices.cs
```diff
--- v1.3/Alerts/Alert_Hot3Devices.cs
+++ v1.6/Alerts/Alert_Hot3Devices.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using System.Collections.Generic;
 using Verse;
```

### Alerts/Alert_UnsecurisedClients.cs
```diff
--- v1.3/Alerts/Alert_UnsecurisedClients.cs
+++ v1.6/Alerts/Alert_UnsecurisedClients.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using System.Collections.Generic;
 using Verse;
```

### AndroidTiers.cs
```diff
--- v1.3/AndroidTiers.cs
+++ v1.6/AndroidTiers.cs
@@ -1,3 +1,3 @@
-﻿using HarmonyLib;
+using HarmonyLib;
 using System.Reflection;
 using Verse;
@@ -100,10 +100,4 @@
             }
 
-            if(ModLister.HasActiveModWithName("[1.0] Android tiers - Gynoids"))
-            {
-                Utils.ANDROIDTIERSGYNOID_LOADED = true;
-                Log.Message("[ATPP] Android Tiers Gynoids found");
-            }
-
             Assembly qee = AppDomain.CurrentDomain.GetAssemblies().FirstOrDefault((Assembly assembly) => assembly.FullName.ToLower().StartsWith("questionableethicsenhanced"));
             if (qee != null)
@@ -137,3 +131,3 @@
         }
     }
-}+}
```

### Buildings/Building_ReloadStation.cs
```diff
--- v1.3/Buildings/Building_ReloadStation.cs
+++ v1.6/Buildings/Building_ReloadStation.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using System.Collections.Generic;
 using System.Linq;
@@ -26,5 +26,5 @@
                 return new FloatMenuOption("CannotUseNoPath".Translate(), null, MenuOptionPriority.Default, null, null, 0f, null, null);
             }
-            if (base.Spawned && base.Map.gameConditionManager.ConditionIsActive(GameConditionDefOf.SolarFlare))
+            if (base.Spawned && base.Map.gameConditionManager.ConditionIsActive(Utils.SolarFlare))
             {
                 return new FloatMenuOption("CannotUseSolarFlare".Translate(), null, MenuOptionPriority.Default, null, null, 0f, null, null);
@@ -76,5 +76,5 @@
         }
 
-        public override IEnumerable<FloatMenuOption> GetMultiSelectFloatMenuOptions(List<Pawn> selPawns)
+        public override IEnumerable<FloatMenuOption> GetMultiSelectFloatMenuOptions(IEnumerable<Pawn> selPawns)
         {
             FloatMenuOption failureReason = null;
```

### ChoiceLetter/ChoiceLetter_RansomDemand.cs
```diff
--- v1.3/ChoiceLetter/ChoiceLetter_RansomDemand.cs
+++ v1.6/ChoiceLetter/ChoiceLetter_RansomDemand.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using System.Collections.Generic;
 using Verse;
```

### ChoiceLetter/ChoiceLetter_RansomwareDemand.cs
```diff
--- v1.3/ChoiceLetter/ChoiceLetter_RansomwareDemand.cs
+++ v1.6/ChoiceLetter/ChoiceLetter_RansomwareDemand.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using System.Collections.Generic;
 using Verse;
```

### CompProperties_SpawnPawn.cs
```diff
--- v1.3/CompProperties_SpawnPawn.cs
+++ v1.6/CompProperties_SpawnPawn.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using RimWorld;
 using Verse;
```

### Components/CompAndroidPod.cs
```diff
--- v1.3/Components/CompAndroidPod.cs
+++ v1.6/Components/CompAndroidPod.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using Verse;
 using RimWorld;
@@ -34,5 +34,5 @@
                 return 0;
             else
-                return getCurrentAndroidPowerConsumed() + cpt.Props.basePowerConsumption;
+                return getCurrentAndroidPowerConsumed() + cpt.Props.PowerConsumption;
         }
 
@@ -52,5 +52,5 @@
             foreach (var cp in bed.CurOccupants)
             {
-                //Il sagit d'un android 
+                // Verifica se é android
                 if (cp != null && cp.IsAndroidTier())
                 {
@@ -58,4 +58,5 @@
                 }
             }
+            // Retorna a quantidade de energia consumida pelos androids
             return ret;
         }
```

### Components/CompAndroidState.cs
```diff
--- v1.3/Components/CompAndroidState.cs
+++ v1.6/Components/CompAndroidState.cs
@@ -55,4 +55,7 @@
         public override void PostDraw()
         {
+            if (!(parent is Pawn))
+                return;
+
             Material avatar = null;
             Vector3 vector;
@@ -82,6 +85,8 @@
         {
             base.PostDrawExtraSelectionOverlays();
-
-            //Dessin liaison entre controlleur et SX
+            if (!(parent is Pawn))
+                return;
+
+            // Desenho da ligação entre o controlador e o SX
             if ( (surrogateController != null && isSurrogate && surrogateController.Map == parent.Map)  )
             {
@@ -109,5 +114,8 @@
 
             init = true;
-            currentPawn = (Pawn)parent;
+            currentPawn = parent as Pawn;
+            if (currentPawn == null)
+                return;
+
             csm = Utils.getCachedCSM(currentPawn);
             isAndroidWithSkin = Utils.ExceptionAndroidWithSkinList.Contains(currentPawn.def.defName);
@@ -129,5 +137,5 @@
             else
             {
-                //Check if there is no weird stuff about noHost on nonSurrogates
+                // Verifica se há algo estranho sobre noHost em não-surrogados
                 Hediff he = currentPawn.health.hediffSet.GetFirstHediffOfDef(HediffDefOf.ATPP_NoHost);
                 if (he != null)
@@ -135,5 +143,5 @@
             }
 
-            //Suppression traits blacklistés le cas echeant
+            // Remoção de traços banidos, se aplicável
             if (isAndroidTier && (!isSurrogate || (isSurrogate && surrogateController != null && surrogateController.IsAndroidTier())))
                 Utils.removeMindBlacklistedTrait(currentPawn);
@@ -145,5 +153,5 @@
             if (isAndroidTier)
             {
-                //Remove ideo if there is no surrogate controller contected (OR controller is basic android) OR the android is basic OR it's a surrogate (implied without host)
+                // Remove o ideo se não houver um controlador de surrogate conectado (OU o controlador é um androide básico) OU o androide é básico OU é um surrogate (implicado sem host)
                 if ((surrogateController == null || surrogateController.IsBasicAndroidTier()) && (currentPawn.IsBasicAndroidTier() || isSurrogate ))
                 {
@@ -174,5 +182,5 @@
                     }
                 }
-                //Starting du délais de rusting
+                // Iniciando o prazo de ferrugem
                 if (!dontRust)
                 {
@@ -204,22 +212,22 @@
                 Pawn cpawn = currentPawn;
 
-                //Si VX0 dans une session en cours alors on chope le pawn permuté controleur
+                // Se VX0 estiver em uma sessão ativa, pega o pawn controlador permutado
                 if (surrogateController != null)
                     cpawn = surrogateController;
 
-                //Reset du child et adulthood si VX0 organic
-                if (isSurrogate && isOrganic && cpawn.story != null && cpawn.story.adulthood != null)
-                {
-                    if (cpawn.story.childhood != null)
-                    {
-                        Backstory bs = null;
-
-                        BackstoryDatabase.TryGetWithIdentifier("MercenaryRecruit", out bs);
+                // Reset do childhood e adulthood se VX0 for orgânico
+                if (isSurrogate && isOrganic && cpawn.story != null && cpawn.story.Adulthood != null)
+                {
+                    if (cpawn.story.Childhood != null)
+                    {
+                        BackstoryDef bs = null;
+
+                        bs = Utils.GetBackstoryByIdentifier("MercenaryRecruit", BackstorySlot.Childhood);
                         if (bs != null)
-                            cpawn.story.childhood = bs;
-                    }
-
-                    cpawn.story.adulthood = null;
-                    //Reset incapable of
+                            cpawn.story.Childhood = bs;
+                    }
+
+                    cpawn.story.Adulthood = null;
+                    // Reseta incapaz de
                     Utils.ResetCachedIncapableOf(cpawn);
                 }
@@ -246,5 +254,5 @@
                 surrogateControllerCAS = Utils.getCachedCAS(surrogateController);
 
-            //Reconexion auto au LWPN le cas echeant
+            // Reconexão automática ao LWPN, se aplicável
             if (Utils.POWERPP_LOADED)
             {
@@ -262,6 +270,8 @@
         {
             base.CompTickRare();
-
-            //Init for pawns in caravans
+            if (!(parent is Pawn))
+                return;
+
+            // Init para pawns em caravanas
             if (!init)
             {
@@ -274,4 +284,7 @@
         {
             base.CompTick();
+            if (!(parent is Pawn))
+                return;
+
             if (parent.Map == null || !parent.Spawned)
                 return;
@@ -285,10 +298,10 @@
 
 
-            //Reconnection auto de l'etranger à son surrogate que si pas de solar flare en cours et toujours dans un Lord (Si le cas d'un ennemis check de l'etat de son Lord)
+            // Reconexão automática do estrangeiro ao seu surrogate apenas se não houver solar flare em curso e ainda estiver em um Lord (Se o caso de um inimigo verificar o estado do seu Lord)
             if ( (GT % 120 == 0))
             {
                 checkUploadInterruptStuffTick(GT);
 
-                //Check android battery explosion (overload)
+                // Verifica explosão de bateria de android (sobrecarga)
                 if (batteryExplosionEndingGT != -1 && batteryExplosionEndingGT < GT)
                 {
@@ -312,5 +325,5 @@
 
         /*
-         * If the surrogateis is controlled by an external controller and disconnected from it, check if we can reconnect him and re-add him into the lord
+         * Se o surrogate estiver controlado por um controlador externo e desconectado dele, verifique se podemos reconectá-lo e adicioná-lo novamente ao senhor
          */
         public void checkExternalControllerReconnection()
@@ -318,6 +331,6 @@
             if (externalController != null)
             {
-                //Disconnection of externalControler if he is connected and there is a solarFlare (SkyMind infrastructures powered-off)
-                if (surrogateController != null && Find.World.gameConditionManager.ConditionIsActive(GameConditionDefOf.SolarFlare))
+                // Desconexão do controlador externo se ele estiver conectado e houver uma solar flare (infraestruturas SkyMind desligadas)
+                if (surrogateController != null && Find.World.gameConditionManager.ConditionIsActive(Utils.SolarFlare))
                 {
                     CompSurrogateOwner cso = Utils.getCachedCSO(externalController);
@@ -327,5 +340,5 @@
                  && csm != null && csm.hacked != 3
                      //&& !externalController.Faction.HostileTo(Faction.OfPlayer)
-                     && !Find.World.gameConditionManager.ConditionIsActive(GameConditionDefOf.SolarFlare))
+                     && !Find.World.gameConditionManager.ConditionIsActive(Utils.SolarFlare))
                 {
                     Lord lordInvolved = null;
@@ -342,8 +355,8 @@
 
 
-                    //If non-player controller of the surrogate id dead OR hacked surrogate had one when it still exists but it is no longer active
+                    // Se o controlador não-jogador do surrogate estiver morto OU o surrogate hackeado tinha um quando ainda existe, mas não está mais ativo
                     if (externalController.Dead || (csm != null && csm.hackOrigFaction.HostileTo(Faction.OfPlayer) && lordInvolved == null && !currentPawn.IsPrisoner))
                     {
-                        //Addition of NoHost because as in externalController mode we have not reset the hediff to avoid the weird bug that when attempting to integrate enemies hacked has a lord its bug when it was down
+                        // Adição de NoHost porque, como no modo externalController, não resetamos o hediff para evitar o bug estranho que, ao tentar integrar inimigos hackeados, tem um senhor, seu bug quando estava caído
                         addNoRemoteHostHediff();
                         externalController = null;
@@ -354,8 +367,8 @@
                         try
                         {
-                            //Try auto-reconnect to surrogate to his external controller (with this time the connection init malus)
+                            // Tenta reconectar automaticamente o surrogate ao seu controlador externo (com desta vez o malus de inicialização da conexão)
                             CompSurrogateOwner cso = Utils.getCachedCSO(externalController);
                             cso.setControlledSurrogate((Pawn)parent, true, true);
-                            currentPawn.mindState.Reset();
+                            currentPawn.mindState.Reset(clearInspiration: false, clearMentalState: true, wasDowned: false);
                             currentPawn.mindState.duty = null;
                             currentPawn.jobs.StopAll();
@@ -421,8 +434,9 @@
                 int nb = 0;
 
-                //Chance que nanite fail
+                // Chance de échec des nanites
                 if (!Rand.Chance(Settings.percentageNanitesFail))
                 {
-                    //Le cas echeant on enleve le rusting
+                    // Dans le cas échéant, on enlève le vieillissement
+                    // Caso contrário, remova o envelhecimento
                     clearRusted();
 
@@ -609,5 +623,5 @@
                         Utils.changeTXBodyType(cp, 1);
                         Utils.changeHARCrownType(cp, "Average_Hurted");
-                        cp.Drawer.renderer.graphics.ResolveAllGraphics();
+                        Utils.ResolvePawnGraphics(cp);
                         PortraitsCache.SetDirty(cp);
                     }
@@ -621,5 +635,5 @@
                         Utils.changeTXBodyType(cp, 2);
                         Utils.changeHARCrownType(cp, "Average_Hurted2");
-                        cp.Drawer.renderer.graphics.ResolveAllGraphics();
+                        Utils.ResolvePawnGraphics(cp);
                         PortraitsCache.SetDirty(cp);
                     }
@@ -637,5 +651,5 @@
                             Utils.changeTXBodyType(cp, 0);
                             Utils.changeHARCrownType(cp, "Average_Normal");
-                            cp.Drawer.renderer.graphics.ResolveAllGraphics();
+                            Utils.ResolvePawnGraphics(cp);
                             PortraitsCache.SetDirty(cp);
                         }
@@ -660,5 +674,5 @@
                                 Utils.changeTXBodyType(cp, 0);
                             }
-                            cp.Drawer.renderer.graphics.ResolveAllGraphics();
+                            Utils.ResolvePawnGraphics(cp);
                             PortraitsCache.SetDirty(cp);
                         }
@@ -670,5 +684,5 @@
                         cp.story.GetType().GetField("headGraphicPath", BindingFlags.NonPublic | BindingFlags.Instance).SetValue(cp.story, Utils.lastResolveAllGraphicsHeadGraphicPath);
                         Utils.lastResolveAllGraphicsHeadGraphicPath = null;
-                        /*cp.Drawer.renderer.graphics.ResolveAllGraphics();
+                        /*Utils.ResolvePawnGraphics(cp);
                         PortraitsCache.SetDirty(cp);*/
                     }
@@ -699,5 +713,5 @@
                 Pawn cp = (Pawn)parent;
 
-                //Entitées qui ne rust pas on degage et check avant de faire le menage des rust malplacés
+                // Entidades que nao enferrujam sao removidas e verificadas antes de limpar a ferrugem mal posicionada
                 if (!isAndroidTIer || isAndroidWithSkin || dontRust)
                 {
@@ -725,5 +739,6 @@
                 else
                 {
-                    //Reprise de la rouille interrompue
+
+                    // ferrugem interrompida
                     if (paintingRustGT == -3 && !paintingIsRusted)
                     {
@@ -738,8 +753,8 @@
                     }
 
-                    //Lancement paint auto 1jour avant la fin d'expiration du timeout
+                    // Lançamento da pintura automática 1 dia antes do fim da expiração do timeout
                     if (Settings.allowAutoRepaint && (!cp.IsPrisoner || Settings.allowAutoRepaintForPrisoners) && !autoPaintStarted && paintingRustGT <= 60000)
                     {
-                        //Déduction recipeDef
+                        // Dedução recipeDef
                         AndroidPaintColor color = (AndroidPaintColor)customColor;
                         string paintRecipeDefname = "";
@@ -792,15 +807,15 @@
                         if (recipe != null)
                         {
-                            //Renouvellement auto de la peinture (ajout operation auto)
-                            cp.health.surgeryBills.AddBill(new Bill_Medical(recipe));
+                            // Renovação automática da pintura (adição de operação automática)
+                            cp.health.surgeryBills.AddBill(new Bill_Medical(recipe, null));
                             autoPaintStarted = true;
                         }
                     }
 
-                    //Rouille de la peinture ?
+                    // Ferrugem da pintura?
                     if (paintingRustGT == 0 || (paintingRustGT == -1 && cp.health.hediffSet.GetFirstHediffOfDef(HediffDefOf.ATPP_Rusted) == null))
                     {
                         paintingIsRusted = true;
-                        cp.Drawer.renderer.graphics.ResolveAllGraphics();
+                        Utils.ResolvePawnGraphics(cp);
                         PortraitsCache.SetDirty(cp);
                         cp.health.AddHediff(HediffDefOf.ATPP_Rusted);
@@ -812,5 +827,5 @@
                         if (!paintingIsRusted)
                         {
-                            //Cas aberrant (possede hediff de rusted alors que pas rusted)
+                            // Caso aberrante (possui hediff de rusted alors que pas rusted)
                             Hediff cRusted = cp.health.hediffSet.GetFirstHediffOfDef(HediffDefOf.ATPP_Rusted);
                             if (cRusted != null)
@@ -851,5 +866,5 @@
             paintingRustGT = (Rand.Range(Settings.minDaysAndroidPaintingCanRust, Settings.maxDaysAndroidPaintingCanRust) * 60000);
 
-            pawn.Drawer.renderer.graphics.ResolveAllGraphics();
+            Utils.ResolvePawnGraphics(pawn);
             if (Find.ColonistBar != null)
             {
@@ -858,5 +873,5 @@
 
 
-            //Retire du hediff de rouille
+            // Remove o hediff de rouille
             Hediff he = pawn.health.hediffSet.GetFirstHediffOfDef(HediffDefOf.ATPP_Rusted);
             if (he != null)
@@ -866,5 +881,5 @@
         /*public void checkSolarFlareStuff()
         {
-            //Androids avec une peau pas affectés par le solarflare
+            //Androids avec une peau pas affectÃ©s par le solarflare
             if (Settings.disableSolarFlareEffect || currentPawn.health == null || currentPawn.def.defName == Utils.TX2 || currentPawn.def.defName == Utils.TX3 || currentPawn.def.defName == Utils.TX4)
                 return;
@@ -872,5 +887,5 @@
             if (!isOrganic || currentPawn.VXAndVX0ChipPresent())
             {
-                bool solarFlareRunning = Find.World.gameConditionManager.ConditionIsActive(GameConditionDefOf.SolarFlare);
+                bool solarFlareRunning = Find.World.gameConditionManager.ConditionIsActive(Utils.SolarFlare);
 
                 if (currentPawn.health.hediffSet.GetFirstHediffOfDef(HediffDefOf.ATPP_SolarFlareAndroidImpact) == null)
@@ -884,5 +899,5 @@
                 return;
             Hediff he = currentPawn.health.hediffSet.GetFirstHediffOfDef(HediffDefOf.ATPP_SolarFlareAndroidImpact);
-            //Remove previous AT2.x SolarFlare hediff
+            // Remove o hediff de SolarFlare anterior
             if (he != null && !(he is Hediff_SolarFlare))
             {
@@ -927,7 +942,7 @@
 
 
-        public override void PostDeSpawn(Map map)
-        {
-            base.PostDeSpawn(map);
+        public override void PostDeSpawn(Map map, DestroyMode mode)
+        {
+            base.PostDeSpawn(map, mode);
 
             if(Utils.POWERPP_LOADED && connectedLWPN != null)
@@ -941,5 +956,5 @@
             }
 
-            //Si surrogate on notifis le changement de map de ce dernier pour qu'il soit correctement traqué
+            //Si surrogate on notifis le changement de map de ce dernier pour qu'il soit correctement traquÃ©
             if (isSurrogate)
             {
@@ -950,8 +965,4 @@
             }
         }
-
-
-
-
 
         public override void PostDestroy(DestroyMode mode, Map previousMap)
@@ -996,5 +1007,5 @@
         private bool isRegularM7()
         {
-            //Les M7Mech standard ne sont pas controlables
+            //Os M7Mech padrão não são controláveis
             return (!isSurrogate && isM7());
         }
@@ -1002,5 +1013,5 @@
         private bool isM7()
         {
-            //Les M7Mech standard ne sont pas controlables
+            // Verifica se o pawn é um M7Mech
             return parent.def.defName == "M7Mech";
         }
@@ -1008,9 +1019,13 @@
         public override IEnumerable<Gizmo> CompGetGizmosExtra()
         {
+            if (!init)
+                initComp();
+
             Pawn pawn = (Pawn)parent;
+
             bool isPrisoner = pawn.IsPrisoner;
             bool transfertAllowed = Utils.mindTransfertsAllowed((Pawn)parent);
 
-            //Si androide virusé (hacking) ajout boutton permettant de le shutdown
+            // Se o androide estiver infectado (hacking), adicione um botão para desligá-lo
             if(csm != null && csm.Hacked == 1)
             {
@@ -1029,8 +1044,8 @@
             }
 
-            //Prevent battery overload on organic, only player's pawn allowed but disabled for temp hacked androids
+            // Prevenção de sobrecarga da bateria em orgânicos, apenas para pawns do jogador, mas desabilitado para androides hackeados temporariamente
             if (!isOrganic && pawn.Faction == Faction.OfPlayer && (csm == null || csm.hacked != 3))
             {
-                //Ajout possibilité de lancer l'explosion d'un androide a distance
+                //Adiciona a possibilidade de lançar a explosão de um androide à distância
 
                 if (Utils.ResearchAndroidBatteryOverload.IsFinished)
@@ -1059,5 +1074,5 @@
                 }
 
-                //Si POWER++ chargé ajout possibilité de rattaché android à un LWPN
+                //Se POWER++ carregado adiciona a possibilidade de anexar o android a um LWPN
                 if (Utils.POWERPP_LOADED && useBattery)
                 {
@@ -1115,9 +1130,9 @@
                             }
 
-                            //SI pas choix affichage de la raison 
+                            //Se não houver escolha, exiba a razão
                             if (opts.Count == 0)
                                 opts.Add(new FloatMenuOption("ATPP_NoAvailableLWPN".Translate(), null, MenuOptionPriority.Default, null, null, 0f, null, null));
 
-                            //Si le recepteur est configuré pour se connecter a un LWPN définis on ajoute une option de deconnexion
+                            //Se o receptor estiver configurado para se conectar a um LWPN definido, adicione uma opção de desconexão
                             if (connectedLWPN != null)
                             {
@@ -1200,5 +1215,5 @@
             }
 
-            //Permet de deconnecter l'utilisateur connecté sur le robot
+            // Permite desconectar o usuário conectado ao robô
             if(isSurrogate )
             {
@@ -1222,5 +1237,5 @@
                     if (lastController != null)
                     { 
-                        //Permet au surrogate de se relier au dernier controller
+                        // Permite ao surrogate se reconectar ao último controlador
                         yield return new Command_Action
                         {
@@ -1242,5 +1257,5 @@
                                 {
                                     bool isMind = false;
-                                    //Check so lastController est un mind dans ce cas check qu'il ne fait pas deja autre chose
+                                    //Verifica se o último controlador é um mind, nesse caso verifica se ele não está fazendo outra coisa
                                     if (cso.skyCloudHost != null)
                                     {
@@ -1254,19 +1269,19 @@
                                     }
 
-                                    //Si controller deconnecté tenttive reconnection au SkyMind
+                                    //Se o controlador estiver desconectado, tente se reconectar ao SkyMind
                                     bool isConnected = true;
                                     if (!Utils.GCATPP.isConnectedToSkyMind(lastController, true))
                                         isConnected = false;
 
-                                    //If surrogate disconnected try to reconnect
+                                    //Se o surrogate estiver desconectado, tente se reconectar
                                     if (!Utils.GCATPP.isConnectedToSkyMind(cSurrogate, true))
                                         isConnected = false;
 
-                                    //If regular pawn check the controlMode BUT if stored mind no check (senseless) just set as if the controlmode is enabled
+                                    //Se o pawn regular verificar o controlMode, mas se a mente estiver armazenada não verificar (sem sentido) apenas definir como se o controlmode estivesse habilitado
                                     bool genControlMode = cso.controlMode;
                                     if (isMind)
                                         genControlMode = true;
 
-                                    //Deja en session le lastUser on jerte
+                                    //Deixa em sessão o último usuário
                                     if ( !isConnected || ((!VX3Owner && cso.isThereSX()) || (VX3Owner && cso.availableSX.Count+1 > Settings.VX3MaxSurrogateControllableAtOnce) ) || !genControlMode)
                                     {
@@ -1299,8 +1314,8 @@
                                     bool m8Mind = (cso.skyCloudHost != null);
 
-                                    //OK only if controller can be connected OR reside in a M8 (no check for connection on SkyMind)
+                                    //OK apenas se o controlador puder ser conectado OU residir em um M8 (sem verificação de conexão no SkyMind)
                                     if (cso != null && (m8Mind || Utils.GCATPP.isConnectedToSkyMind(controller, true)))
                                     {
-                                        //If not a hosted mind then we try to enable the controlMode if not already enabled
+                                        //Se não for uma mente hospedada, tentamos habilitar o controlMode se ainda não estiver habilitado
                                         if (!m8Mind && !cso.controlMode)
                                         {
@@ -1500,5 +1515,5 @@
                     return;
 
-                //Surrogate en cours on check si clones toujours connecté
+                //Surrogate en cours on check si clones toujours connectÃ©
                 if (cso.isThereSX() && cso.availableSX != null)
                 {
@@ -1512,5 +1527,5 @@
                         surrogateControllerLastSkymindDisconnectIsManual = surrogateControllerCAS.lastSkymindDisconnectIsManual;
 
-                    //Si surrogateController stoclé dans le skyCloud
+                    //Si surrogateController stoclÃ© dans le skyCloud
                     if (cso.skyCloudHost != null)
                         hostBadConn = !Utils.getCachedCSC(cso.skyCloudHost).isRunning();
@@ -1536,5 +1551,5 @@
                             Messages.Message("ATPP_SurrogateUnexpectedDisconnection".Translate(invertedPawn.LabelShortCap), disconnectedPawn, MessageTypeDefOf.NegativeEvent);
 
-                        //un ou les deux des composantes sont déconnectés ===> on lance la deconnection du SX
+                        //un ou les deux des composantes sont dÃ©connectÃ©s ===> on lance la deconnection du SX
                         cso.stopControlledSurrogate(currentPawn);
                     }
@@ -1645,5 +1660,5 @@
             get
             {
-                //SI M7 surrogate forcé à utilsier la recharge en directe
+                //SI M7 surrogate forcÃ© Ã  utilsier la recharge en directe
                 if (parent.def.defName == Utils.M7 && isSurrogate)
                     return true;
@@ -1655,5 +1670,5 @@
         
         Pawn currentPawn = null;
-        //Stock le signal indiquant si le pawn à été attribué par le systeme de job pour faire du guarding ou non
+        //Stock le signal indiquant si le pawn Ã  Ã©tÃ© attribuÃ© par le systeme de job pour faire du guarding ou non
         public bool useBattery = false;
         public int uploadEndingGT = -1;
@@ -1673,5 +1688,5 @@
         public bool showUploadProgress = false;
 
-        //Stocke le pawn externe (n'appartenant pas au joueur) controllant le surrogate (le cas des groupes de factions alliés/neutre/ennemis)
+        //Stocke le pawn externe (n'appartenant pas au joueur) controllant le surrogate (le cas des groupes de factions alliÃ©s/neutre/ennemis)
         public Pawn externalController;
         public int externalControllerConvertedJoinGT = 0;
@@ -1717,3 +1732,3 @@
         public Thing droppedWeapon;
     }
-}+}
```

### Components/CompAutoDoor.cs
```diff
--- v1.3/Components/CompAutoDoor.cs
+++ v1.6/Components/CompAutoDoor.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using System.Collections.Generic;
 using HarmonyLib;
```

### Components/CompBlankAndroidSpawner.cs
```diff
--- v1.3/Components/CompBlankAndroidSpawner.cs
+++ v1.6/Components/CompBlankAndroidSpawner.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using RimWorld;
 using Verse;
@@ -27,5 +27,5 @@
                 Utils.forceGeneratedAndroidToBeDefaultPainted = true;
 
-                PawnGenerationRequest request = new PawnGenerationRequest(Spawnprops.Pawnkind, Faction.OfPlayer, PawnGenerationContext.NonPlayer, -1, false, false, false, false, true, true, 1f, false, true, false, false, false, false, false, false, 0f, 0f, null, 0f, null, null, null, null);
+                PawnGenerationRequest request = Utils.NewPawnGenerationRequest(Spawnprops.Pawnkind, Faction.OfPlayer, PawnGenerationContext.NonPlayer, -1, false, false, false, false, true, true, 1f, false, true, false, false, false, false, false, false, 0f, 0f, null, 0f, null, null, null, null);
                 Pawn blankAndroid = PawnGenerator.GeneratePawn(request);
                 GenSpawn.Spawn(blankAndroid, this.parent.Position, this.parent.Map, WipeMode.Vanish);
```

### Components/CompBuildingSkyMindLAN.cs
```diff
--- v1.3/Components/CompBuildingSkyMindLAN.cs
+++ v1.6/Components/CompBuildingSkyMindLAN.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using Verse;
 using Verse.AI;
@@ -16,7 +16,7 @@
     public class CompBuildingSkyMindLAN : ThingComp
     {
-        public override void PostDeSpawn(Map map)
+        public override void PostDeSpawn(Map map, DestroyMode mode)
         {
-            base.PostDeSpawn(map);
+            base.PostDeSpawn(map, mode);
 
             Utils.GCATPP.popSkyMindServer(this.parent);
@@ -129,3 +129,3 @@
         private bool init = false;
     }
-}+}
```

### Components/CompBuildingSkyMindRelay.cs
```diff
--- v1.3/Components/CompBuildingSkyMindRelay.cs
+++ v1.6/Components/CompBuildingSkyMindRelay.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using Verse;
 using Verse.AI;
@@ -15,7 +15,7 @@
     public class CompBuildingSkyMindRelay : ThingComp
     {
-        public override void PostDeSpawn(Map map)
+        public override void PostDeSpawn(Map map, DestroyMode mode)
         {
-            base.PostDeSpawn(map);
+            base.PostDeSpawn(map, mode);
 
             
@@ -55,3 +55,3 @@
         }
     }
-}+}
```

### Components/CompBuildingSkyMindWAN.cs
```diff
--- v1.3/Components/CompBuildingSkyMindWAN.cs
+++ v1.6/Components/CompBuildingSkyMindWAN.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using Verse;
 using Verse.AI;
@@ -15,7 +15,7 @@
     public class CompBuildingSkyMindWAN : ThingComp
     {
-        public override void PostDeSpawn(Map map)
+        public override void PostDeSpawn(Map map, DestroyMode mode)
         {
-            base.PostDeSpawn(map);
+            base.PostDeSpawn(map, mode);
 
             Building build = (Building)this.parent;
@@ -70,3 +70,3 @@
         }
     }
-}+}
```

### Components/CompComputer.cs
```diff
--- v1.3/Components/CompComputer.cs
+++ v1.6/Components/CompComputer.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using System.Text;
 using Verse;
@@ -122,5 +122,5 @@
             canVirus = canVirusExplosive = canHack = canTempHack = false;
 
-            bool powered = !Find.World.gameConditionManager.ConditionIsActive(GameConditionDefOf.SolarFlare) && !build.IsBrokenDown() && cpt.PowerOn;
+            bool powered = !Find.World.gameConditionManager.ConditionIsActive(Utils.SolarFlare) && !build.IsBrokenDown() && cpt.PowerOn;
             
             Texture2D tex;
@@ -289,7 +289,7 @@
         }
 
-        public override void PostDeSpawn(Map map)
-        {
-            base.PostDeSpawn(map);
+        public override void PostDeSpawn(Map map, DestroyMode mode)
+        {
+            base.PostDeSpawn(map, mode);
             this.StopSustainer();
 
```

### Components/CompGSTXSpawner.cs
```diff
--- v1.3/Components/CompGSTXSpawner.cs
+++ v1.6/Components/CompGSTXSpawner.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using HarmonyLib;
 using RimWorld;
```

### Components/CompHeatSensitive.cs
```diff
--- v1.3/Components/CompHeatSensitive.cs
+++ v1.6/Components/CompHeatSensitive.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using System.Text;
 using Verse;
@@ -192,13 +192,14 @@
                 if (isSkyCloudCore)
                 {
-                    GenExplosion.DoExplosion(this.parent.Position, this.parent.Map, 8, DamageDefOf.Flame, null, -1, -1f, null, null, null, null, null, 0f, 1, false, null, 0f, 1, 0f, false);
+                    GenExplosion.DoExplosion(this.parent.Position, this.parent.Map, 8, DamageDefOf.Flame, null);
                 }
                 else
-                    GenExplosion.DoExplosion(this.parent.Position, this.parent.Map, 2, DamageDefOf.Flame, null, -1, -1f, null, null, null, null, null, 0f, 1, false, null, 0f, 1, 0f, false);
-            }
-        }
-
-        public override void PostDeSpawn(Map map)
-        {
+                    GenExplosion.DoExplosion(this.parent.Position, this.parent.Map, 2, DamageDefOf.Flame, null);
+            }
+        }
+
+        public override void PostDeSpawn(Map map, DestroyMode mode)
+        {
+            base.PostDeSpawn(map, mode);
             this.StopSustainerHot();
 
```

### Components/CompProperties_BlankAndroidSpawner.cs
```diff
--- v1.3/Components/CompProperties_BlankAndroidSpawner.cs
+++ v1.6/Components/CompProperties_BlankAndroidSpawner.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using Verse;
 
```

### Components/CompProperties_Computer.cs
```diff
--- v1.3/Components/CompProperties_Computer.cs
+++ v1.6/Components/CompProperties_Computer.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using Verse;
 using RimWorld;
```

### Components/CompProperties_GSTXSpawner.cs
```diff
--- v1.3/Components/CompProperties_GSTXSpawner.cs
+++ v1.6/Components/CompProperties_GSTXSpawner.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using Verse;
 
```

### Components/CompProperties_HeatSensitive.cs
```diff
--- v1.3/Components/CompProperties_HeatSensitive.cs
+++ v1.6/Components/CompProperties_HeatSensitive.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using Verse;
 using RimWorld;
```

### Components/CompProperties_ReloadStation.cs
```diff
--- v1.3/Components/CompProperties_ReloadStation.cs
+++ v1.6/Components/CompProperties_ReloadStation.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using Verse;
 using RimWorld;
```

### Components/CompProperties_SurrogateSpawner.cs
```diff
--- v1.3/Components/CompProperties_SurrogateSpawner.cs
+++ v1.6/Components/CompProperties_SurrogateSpawner.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using Verse;
 
```

### Components/CompReloadStation.cs
```diff
--- v1.3/Components/CompReloadStation.cs
+++ v1.6/Components/CompReloadStation.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using Verse;
 using RimWorld;
@@ -30,7 +30,7 @@
         }
 
-        public override void PostDeSpawn(Map map)
-        {
-            base.PostDeSpawn(map);
+        public override void PostDeSpawn(Map map, DestroyMode mode)
+        {
+            base.PostDeSpawn(map, mode);
 
             //Retire de la liste des emetteurs de la map
@@ -94,5 +94,5 @@
         {
             CompPowerTrader cpt = Utils.getCachedCPT(this.parent);
-            return getNbAndroidReloading() + cpt.Props.basePowerConsumption;
+            return getNbAndroidReloading() + cpt.Props.PowerConsumption;
         }
 
@@ -209,3 +209,3 @@
         }
     }
-}+}
```

### Components/CompRemotelyControlledTurret.cs
```diff
--- v1.3/Components/CompRemotelyControlledTurret.cs
+++ v1.6/Components/CompRemotelyControlledTurret.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using System.Text;
 using Verse;
@@ -151,7 +151,7 @@
         }
 
-        public override void PostDeSpawn(Map map)
+        public override void PostDeSpawn(Map map, DestroyMode mode)
         {
-            base.PostDeSpawn(map);
+            base.PostDeSpawn(map, mode);
             
 
```

### Components/CompSkyCloudCore.cs
```diff
--- v1.3/Components/CompSkyCloudCore.cs
+++ v1.6/Components/CompSkyCloudCore.cs
@@ -23,8 +23,8 @@
             Scribe_Values.Look<int>(ref KidnappedPendingDisconnectionGT, "ATPP_KidnappedPendingDisconnectionGT", -1);
             
-            Scribe_Collections.Look(ref this.storedMinds, false, "ATPP_storedMinds", LookMode.Deep);
-            Scribe_Collections.Look(ref this.assistingMinds, false, "ATPP_assistingMinds", LookMode.Reference);
-            Scribe_Collections.Look(ref this.replicatingMinds, false, "ATPP_replicatingMinds", LookMode.Reference);
-            Scribe_Collections.Look(ref this.pendingUploads, false, "ATPP_pendingUploads", LookMode.Reference);
+            Scribe_Collections.Look(ref this.storedMinds, "ATPP_storedMinds", false, LookMode.Deep);
+            Scribe_Collections.Look(ref this.assistingMinds, "ATPP_assistingMinds", false, LookMode.Reference);
+            Scribe_Collections.Look(ref this.replicatingMinds, "ATPP_replicatingMinds", false, LookMode.Reference);
+            Scribe_Collections.Look(ref this.pendingUploads, "ATPP_pendingUploads", false, LookMode.Reference);
 
             Scribe_Collections.Look<Pawn, int>(ref this.inMentalBreak, "ATPP_inMentalBreak", LookMode.Reference, LookMode.Value, ref inMentalBreakKeys, ref inMentalBreakValues);
@@ -45,4 +45,6 @@
 
                 storedMinds.RemoveAll(item => item == null);
+                foreach (var mind in storedMinds)
+                    Utils.PrepareSkyCloudStoredMind(mind, false);
             }
         }
@@ -53,8 +55,8 @@
             base.PostDrawExtraSelectionOverlays();
 
-            //Affichage minds connectés
+            //Affichage minds connectÃ©s
             foreach (var p in storedMinds)
             {
-                // Colono digitalizado conectado a um surrogate traça-se o link
+                //Colon digitalisÃ© connectÃ© Ã  un surrogate on trace le lien
                 CompSurrogateOwner cso = Utils.getCachedCSO(p);
 
@@ -69,5 +71,5 @@
             }
 
-            // Controle de torretas
+            //Affichage turets connectÃ©s
             foreach(var p in controlledTurrets)
             {
@@ -83,5 +85,5 @@
             base.PostSpawnSetup(respawningAfterLoad);
 
-            // Permite redefinir o estado de sequestrado se o M8 voltar (spawn com isKinapped habilitado mas não sequestrado de fato)
+            //Allow to reset kidnapped state if the M8 come back (spawn with isKinapped enabled but not Kidnapped infact)
             if (isKidnapped)
             {
@@ -105,9 +107,9 @@
         }
 
-        public override void PostDeSpawn(Map map)
-        {
-            base.PostDeSpawn(map);
-
-            // Se o M8 for despawnado mas estiver vivo, as mentes podem continuar suas atividades
+        public override void PostDeSpawn(Map map, DestroyMode mode)
+        {
+            base.PostDeSpawn(map, mode);
+
+            //If despawn but it's an M8Mech host and he is alive then minds can continue their activities 
             if (parentPawn == null || parentPawn.Dead)
             {
@@ -122,5 +124,5 @@
             base.PostDestroy(mode, previousMap);
 
-            // Mata todos os hospedeiros armazenados
+            //Kill de tous les hotes stockÃ©s
             if (storedMinds.Count != 0)
             {
@@ -144,9 +146,9 @@
             {
                 case "PowerTurnedOn":
-                    // Definição de segundos para o core realmente ligar
+                    //Definition sec ou le core dÃ©marrera vraiment
                     bootGT = Find.TickManager.TicksGame + (Settings.secToBootSkyCloudCore * 60);
                     break;
                 case "PowerTurnedOff":
-                    // Se o sistema estiver ligado, o servidor diz que houve falha de energia
+                    //Su systeme bootÃ© le serveur dit le power Failure
                     if (bootGT == -1)
                         Utils.playVocal("soundDefSkyCloudPowerFailure");
@@ -157,5 +159,4 @@
                     break;
                 case "AndroidTiers_CaravanInit":
-                    // Se o M8 for despawnado mas estiver vivo, as mentes podem continuar suas atividades
                     if (parent is Pawn)
                     {
@@ -170,9 +171,9 @@
         public void generateInitialSurvivorsMinds()
         {
-            // Se o cenário for apocalipse, gera 3 consciências humanas
-            if (Current.Game.tickManager.TicksGame == 0 && Current.Game.Scenario.name == "Androids apocalypse")
+            //If scenario apocalypse then generate 3 human conscioussness
+            if (Current.Game.tickManager.TicksGame == 0 && Utils.IsAndroidApocalypseScenario())
             {
                 Pawn cp = (Pawn)parent;
-                // Define o dano inicial do M8
+                //Set the initial M8 damage
                 Hediff he = cp.health.hediffSet.GetFirstHediffOfDef(HediffDefOf.DecayedFrame);
                 if(he == null)
@@ -181,11 +182,11 @@
                 Pawn mind;
                 CompSurrogateOwner cso;
-                PawnGenerationRequest pgr = new PawnGenerationRequest(PawnKindDefOf.AncientSoldier, Faction.OfPlayer, PawnGenerationContext.NonPlayer, -1, forceGenerateNewPawn: true, newborn: false, allowDead: false, allowDowned: false, canGeneratePawnRelations: true, mustBeCapableOfViolence: false, colonistRelationChanceFactor:1f, forceAddFreeWarmLayerIfNeeded: true, allowGay: true, allowFood: false, allowAddictions: false, inhabitant: false, certainlyBeenInCryptosleep: false, forceRedressWorldPawnIfFormerColonist: false, worldPawnFactionDoesntMatter: false, biocodeWeaponChance: 0f, forceNoBackstory:false);
-                // Gera as 3 consciências humanas
+                PawnGenerationRequest pgr = Utils.NewPawnGenerationRequest(PawnKindDefOf.AncientSoldier, Faction.OfPlayer, PawnGenerationContext.NonPlayer, -1, forceGenerateNewPawn: true, newborn: false, allowDead: false, allowDowned: false, canGeneratePawnRelations: true, mustBeCapableOfViolence: false, colonistRelationChanceFactor:1f, forceAddFreeWarmLayerIfNeeded: true, allowGay: true, allowFood: false, allowAddictions: false, inhabitant: false, certainlyBeenInCryptosleep: false, forceRedressWorldPawnIfFormerColonist: false, worldPawnFactionDoesntMatter: false, biocodeWeaponChance: 0f, forceNoBackstory:false);
+                //Generate the 3 humans minds
                 for (int i = 0; i != 3; i++)
                 {
                     mind = PawnGenerator.GeneratePawn(pgr);
                     setInitialChildhood(mind, "ApocalypseSurvivor23");
-                    mind.story.adulthood = null;
+                    mind.story.Adulthood = null;
                     cso = Utils.getCachedCSO(mind);
                     cso.skyCloudHost = parent;
@@ -194,11 +195,12 @@
                     Current.Game.tickManager.DeRegisterAllTickabilityFor(mind);
                     storedMinds.Add(mind);
-                }
-
-                // Gera o robô de defesa
-                pgr = new PawnGenerationRequest(PawnKindDefOf.AndroidT2Colonist, Faction.OfPlayer, PawnGenerationContext.NonPlayer, -1, forceGenerateNewPawn: true, newborn: false, allowDead: false, allowDowned: false, canGeneratePawnRelations: true, mustBeCapableOfViolence: false, colonistRelationChanceFactor: 1f, forceAddFreeWarmLayerIfNeeded: true, allowGay: true, allowFood: false, allowAddictions: false, inhabitant: false, certainlyBeenInCryptosleep: false, forceRedressWorldPawnIfFormerColonist: false, worldPawnFactionDoesntMatter: false, biocodeWeaponChance: 0f, forceNoBackstory: false);
+                    Utils.PrepareSkyCloudStoredMind(mind, false);
+                }
+
+                //Generate the defense Bot
+                pgr = Utils.NewPawnGenerationRequest(PawnKindDefOf.AndroidT2Colonist, Faction.OfPlayer, PawnGenerationContext.NonPlayer, -1, forceGenerateNewPawn: true, newborn: false, allowDead: false, allowDowned: false, canGeneratePawnRelations: true, mustBeCapableOfViolence: false, colonistRelationChanceFactor: 1f, forceAddFreeWarmLayerIfNeeded: true, allowGay: true, allowFood: false, allowAddictions: false, inhabitant: false, certainlyBeenInCryptosleep: false, forceRedressWorldPawnIfFormerColonist: false, worldPawnFactionDoesntMatter: false, biocodeWeaponChance: 0f, forceNoBackstory: false);
                 mind = PawnGenerator.GeneratePawn(pgr);
                 setInitialChildhood(mind,"");
-                mind.story.adulthood = null;
+                mind.story.Adulthood = null;
                 cso = Utils.getCachedCSO(mind);
                 cso.skyCloudHost = parent;
@@ -226,5 +228,5 @@
                     }
                 }
-                // Robô básico com traço de mente simples
+                //Basic robot so simple minded trait
                 if(!mind.story.traits.HasTrait(TraitDefOf.SimpleMindedAndroid))
                     mind.story.traits.GainTrait(new Trait(TraitDefOf.SimpleMindedAndroid, 0, true));
@@ -234,6 +236,7 @@
                 Current.Game.tickManager.DeRegisterAllTickabilityFor(mind);
                 storedMinds.Add(mind);
-
-                // Unidade fala sobre o fato de haver danos físicos
+                Utils.PrepareSkyCloudStoredMind(mind, false);
+
+                //Unit talk about the fact there is physical damages
                 forceIntegrityWarning = 5;
             }
@@ -242,8 +245,8 @@
         private void setInitialChildhood(Pawn mind, string id)
         {
-            Backstory bs = null;
-            BackstoryDatabase.TryGetWithIdentifier(id, out bs);
+            BackstoryDef bs = null;
+            bs = Utils.GetBackstoryByIdentifier(id, BackstorySlot.Childhood);
             if (bs != null)
-                mind.story.childhood = bs;
+                mind.story.Childhood = bs;
         }
 
@@ -275,5 +278,5 @@
 
 
-            // Aplicação retroativa da remoção de traços banidos para as mentes
+            //Application retroactive de la surppression de traits blacklistÃ©s pour les minds
             foreach (var m in storedMinds)
             {
@@ -317,5 +320,5 @@
             else
             {
-                // PowerOn se M8 não estiver morto E não estiver sequestrado OU sequestrado mas dentro do tempo de exceção
+                //PowerOn if M8 not dead And not kidnapped Or kidnapped but within the exception time
                 return !parentPawn.Dead && (!isKidnapped || (KidnappedPendingDisconnectionGT != -1));
             }
@@ -324,4 +327,6 @@
         public override IEnumerable<Gizmo> CompGetGizmosExtra()
         {
+            initSelfReference();
+
             //If no minds stored
             if (storedMinds.Count() == 0 || !isOnline() || !Booted())
@@ -414,10 +419,10 @@
                 {
                     List<FloatMenuOption> opts = new List<FloatMenuOption>();
-                    //Affichage des minds affectés à l'assistement
+                    //Affichage des minds affectÃ©s Ã  l'assistement
                     opts.Add(new FloatMenuOption("ATPP_ProcessAssistAssignedMinds".Translate(), delegate
                     {
                         List<FloatMenuOption> optsAdd = null;
 
-                        //Check s'il y a lieu d'jaouter l'option (il y a au moin 1+ minds assigné à supprimer
+                        //Check s'il y a lieu d'jaouter l'option (il y a au moin 1+ minds assignÃ© Ã  supprimer
                         if (assistingMinds.Count > 0)
                         {
@@ -451,10 +456,10 @@
                     }, MenuOptionPriority.Default, null, null, 0f, null, null));
 
-                    //Affichage des minds non affectés à l'assistement
+                    //Affichage des minds non affectÃ©s Ã  l'assistement
                     opts.Add(new FloatMenuOption("ATPP_ProcessAssistUnassignedMinds".Translate(), delegate
                     {
                         List<FloatMenuOption> optsAdd = null;
 
-                        //Check s'il y a lieu d'jaouter l'option (il y a des minds et des minds non ajoutés)
+                        //Check s'il y a lieu d'jaouter l'option (il y a des minds et des minds non ajoutÃ©s)
                         if (storedMinds.Count > 0 && getNbUnassistingMinds() > 0)
                         {
@@ -580,5 +585,5 @@
             if (Utils.isThereNotControlledSurrogateInCaravan())
             {
-                //Si drones SX no controllés dans une caravane
+                //Si drones SX no controllÃ©s dans une caravane
                 yield return new Command_Action
                 {
@@ -755,5 +760,5 @@
             if(CGT % 120 == 0)
             {
-                //Rafraichissement qt de courant consommé
+                //Rafraichissement qt de courant consommÃ©
                 refreshPowerConsumed();
 
@@ -879,5 +884,5 @@
 
             //Arret du mental state
-            mind.mindState.Reset();
+            mind.mindState.Reset(clearInspiration: false, clearMentalState: true, wasDowned: false);
 
             //Si surrogate founris resolution du controleur
@@ -891,5 +896,5 @@
             }
 
-            //Arret des activitées
+            //Arret des activitÃ©es
             stopMindActivities(mind);
 
@@ -958,5 +963,5 @@
         {
             CompPowerTrader cpt = Utils.getCachedCPT((Building)this.parent);
-            return (storedMinds.Count()*Settings.powerConsumedByStoredMind) + cpt.Props.basePowerConsumption;
+            return (storedMinds.Count()*Settings.powerConsumedByStoredMind) + cpt.Props.PowerConsumption;
         }
 
@@ -1103,5 +1108,5 @@
                 if (isSurrogateController)
                 {
-                    //On affiche le nom du colon numérisé car il est permuté avec le surrogate
+                    //On affiche le nom du colon numÃ©risÃ© car il est permutÃ© avec le surrogate
                     if (!cso.isThereSX())
                     {
@@ -1187,3 +1192,3 @@
         public int KidnappedPendingDisconnectionGT = -1;
     }
-}+}
```

### Components/CompSkyMind.cs
```diff
--- v1.3/Components/CompSkyMind.cs
+++ v1.6/Components/CompSkyMind.cs
@@ -45,7 +45,7 @@
         }
 
-        public override void PostDeSpawn(Map map)
-        {
-            base.PostDeSpawn(map);
+        public override void PostDeSpawn(Map map, DestroyMode mode)
+        {
+            base.PostDeSpawn(map, mode);
 
             Utils.GCATPP.popSkyMindable(parent);
@@ -55,27 +55,54 @@
         {
             base.PostSpawnSetup(respawningAfterLoad);
-            if (connected)
-            {
-                if (!Utils.GCATPP.connectUser(parent))
+
+            if (Utils.GCATPP == null)
+                return;
+
+            try
+            {
+                if (Utils.IsDeadPawnOrCorpse(parent))
+                {
                     connected = false;
-            }
-
-            if(infected != -1 || hacked != -1)
-            {
-                Utils.GCATPP.pushVirusedThing(parent);
-            }
-
-            if (parent is Pawn)
-            {
-                parentPawn = (Pawn)parent;
-                isSurrogate = parentPawn.IsSurrogateAndroid();
-                parentCAS = Utils.getCachedCAS((Pawn)parent);
-            }
-            else
-            {
-                parentCPT = Utils.getCachedCPT((Building)parent);
-            }
-
-            Utils.GCATPP.pushSkyMindable(parent);
+                    autoconn = false;
+                    Utils.GCATPP.disconnectUser(parent, false, false);
+                    Utils.GCATPP.popSkyMindable(parent);
+                    return;
+                }
+
+                if (!(parent is Pawn) && !(parent is Building))
+                    return;
+
+                if (connected)
+                {
+                    if (!Utils.GCATPP.connectUser(parent))
+                        connected = false;
+                }
+
+                if (infected != -1 || hacked != -1)
+                {
+                    Utils.GCATPP.pushVirusedThing(parent);
+                }
+
+                if (parent is Pawn pawn)
+                {
+                    parentPawn = pawn;
+                    isSurrogate = parentPawn.IsSurrogateAndroid();
+                    parentCAS = Utils.getCachedCAS(pawn);
+                }
+                else if (parent is Building building)
+                {
+                    parentCPT = Utils.getCachedCPT(building);
+                }
+                else
+                {
+                    return;
+                }
+
+                Utils.GCATPP.pushSkyMindable(parent);
+            }
+            catch (Exception e)
+            {
+                Log.Warning("[ATPP] CompSkyMind.PostSpawnSetup: " + e.Message);
+            }
         }
 
@@ -83,4 +110,7 @@
         public override void PostDraw()
         {
+            if (Utils.IsDeadPawnOrCorpse(parent))
+                return;
+
             Material avatar = null;
             Vector3 vector;
@@ -121,8 +151,11 @@
         public bool canBeConnectedToSkyMind()
         {
+            if (Utils.IsDeadPawnOrCorpse(parent))
+                return false;
+
             if (parent is Pawn)
             {
                 Pawn pawn = (Pawn)parent;
-                return pawn.VXChipPresent() || pawn.RaceProps.FleshType == FleshTypeDefOfAT.AndroidTier;
+                return pawn.VXChipPresent() || pawn.IsAndroidTier();
             }
             else
@@ -134,5 +167,8 @@
         public override IEnumerable<Gizmo> CompGetGizmosExtra()
         {
-            //Si infecté ou un surrogate ennemis alors pas de possibilité de le connecté/déconnecté du réseau du joueur
+            if (Utils.IsDeadPawnOrCorpse(parent))
+                yield break;
+
+            //Si infectÃ© ou un surrogate ennemis alors pas de possibilitÃ© de le connectÃ©/dÃ©connectÃ© du rÃ©seau du joueur
             if (infected != -1 || (parent.Faction != Faction.OfPlayer && parentCAS != null && parentCAS.isSurrogate))
                 yield break;
@@ -143,16 +179,14 @@
 
                 //Si ni un humain ou robot pucé ET pas un android Tier alors pas de possibilité de connection au SkyMind
-                if (!pawn.VXChipPresent() && !pawn.VX0ChipPresent() && !(pawn.RaceProps.FleshType == FleshTypeDefOfAT.AndroidTier))
+                if (!pawn.VXChipPresent() && !pawn.VX0ChipPresent() && !pawn.IsAndroidTier())
                 {
                     yield break;
                 }
 
-                //Les M7Mech standard ne sont pas controlables
-                if (parentCAS != null && !parentCAS.isSurrogate && parent.def.defName == "M7Mech")
-                    yield break;
-
-            }
-
-            //Si batiment et il n'y a pas de skyCloud placé on masque les controles sur les batiments
+                // M7Mech units can connect as SkyMind users. Surrogate control is handled separately by CompSurrogateOwner.
+
+            }
+
+            //Si batiment et il n'y a pas de skyCloud placÃ© on masque les controles sur les batiments
             if(parent is Building && !Utils.GCATPP.isThereSkyCloudCore())
             {
@@ -213,5 +247,5 @@
                 case "SkyMindNetworkUserConnected":
                     //Log.Message(parent.LabelCap + " => SkyMindConnectedUser");
-                    connected = true;
+                    connected = !Utils.IsDeadPawnOrCorpse(parent);
                     break;
                 case "SkyMindNetworkUserDisconnectedManually":
@@ -347,5 +381,5 @@
                         else
                         {
-                            //Sinon le truc enmerdant ces que le dispositif est desactivé
+                            //Sinon le truc enmerdant ces que le dispositif est desactivÃ©
                             CompFlickable cf = parent.TryGetComp<CompFlickable>();
                             if (cf != null)
@@ -396,5 +430,5 @@
 
             cp.SetFaction(hackOrigFaction, null);
-            //Si le surrogate été un prisonnier on le restaure en tant que tel
+            //Si le surrogate Ã©tÃ© un prisonnier on le restaure en tant que tel
             if (hackWasPrisoned)
             {
@@ -418,5 +452,5 @@
             }
             if(cp.mindState != null)
-                cp.mindState.Reset(true);
+                cp.mindState.Reset(clearInspiration: true, clearMentalState: true, wasDowned: false);
 
             PawnComponentsUtility.AddAndRemoveDynamicComponents(cp, false);
@@ -523,5 +557,5 @@
         private int infected = -1; // -1 : pas d'infection, 1: infection virus std, 2: virus explosif, 3: virus cryptolocker => android inutilisable
         public int infectedExplodeGT = -1;
-        //Stocke le state precedent des composants piraté (du casting de type a prevoir)
+        //Stocke le state precedent des composants piratÃ© (du casting de type a prevoir)
         private string infectedPreviousState = "";
         public int lastRemoteFlickGT = 0;
@@ -532,3 +566,3 @@
         private bool isSurrogate = false;
     }
-}+}
```

### Components/CompSurrogateOwner.cs
```diff
--- v1.3/Components/CompSurrogateOwner.cs
+++ v1.6/Components/CompSurrogateOwner.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using Verse;
 using Verse.AI;
@@ -62,5 +62,5 @@
             Scribe_Collections.Look(ref savedSkillsBecauseM7Control, "ATPP_savedSkillsBecauseM7Control", LookMode.Value, LookMode.Value);
             Scribe_Collections.Look(ref savedWorkAffectationBecauseM7Control, "ATPP_savedWorkAffectationBecauseM7Control", LookMode.Value, LookMode.Value);
-            Scribe_Collections.Look(ref this.extraSX, false, "ATPP_extraSX", LookMode.Reference);
+            Scribe_Collections.Look(ref this.extraSX, "ATPP_extraSX", false, LookMode.Reference);
             Scribe_Values.Look<bool>(ref this.lastSkymindDisconnectIsManual, "ATPP_lastSkymindDisconnectIsManualCSO", false);
 
@@ -84,5 +84,11 @@
             base.PostSpawnSetup(respawningAfterLoad);
 
-            currentPawn = (Pawn)parent;
+            currentPawn = parent as Pawn;
+            if (currentPawn == null)
+            {
+                currentCAS = null;
+                return;
+            }
+
             currentCAS = Utils.getCachedCAS(currentPawn);
         }
@@ -91,4 +97,7 @@
         {
             base.CompTick();
+
+            if (currentPawn == null)
+                return;
 
             if (parent.Map == null || !parent.Spawned)
@@ -197,4 +206,5 @@
                     //Stockage pawn actuel
                     csc.storedMinds.Add(currentPawn);
+                    skyCloudHost = skyCloudRecipient;
                     Current.Game.tickManager.DeRegisterAllTickabilityFor(currentPawn);
 
@@ -231,15 +241,12 @@
                     }
 
-
-                    //Deconnection de skymind le cas echeant
+                    // Desconecta o usuário do SkyMind, se for o caso
                     Utils.GCATPP.disconnectUser(currentPawn);
 
-                    //Despawn du pawn numérisé
+                    // Prepara o pawn para ser armazenado no SkyCloud
                     currentPawn.DeSpawn();
-
-                    skyCloudHost = skyCloudRecipient;
-
-                    //Simulation mort du corp en générant un corp identique
-
+                    Utils.PrepareSkyCloudStoredMind(currentPawn);
+
+                    // Simulação de morte do corpo gerando um corpo idêntico
                     Utils.playVocal("soundDefSkyCloudMindDownloadCompleted");
 
@@ -247,5 +254,5 @@
                 }
 
-                //Atteinte d'un chargement de download depuis SkyCloud
+                // Atingiu o carregamento de download do SkyCloud
                 if (downloadFromSkyCloudEndingGT != -1 && downloadFromSkyCloudEndingGT < GT)
                 {
@@ -262,35 +269,32 @@
                     CompSkyCloudCore csc = Utils.getCachedCSC(cso.skyCloudHost);
 
-                    //Arret des jobs d'un esprit
+                    // Para os jobs de um espírito
                     csc.setMindInReplicationModeOff(skyCloudDownloadRecipient);
 
 
                     Find.LetterStack.ReceiveLetter("ATPP_LetterSkyCloudDownloadOK".Translate(), "ATPP_LetterSkyCloudDownloadOKDesc".Translate(skyCloudDownloadRecipient.LabelShortCap, currentPawn.LabelShortCap), LetterDefOf.PositiveEvent, parent);
-                    //On realise effectivement le download du core vers le cerveau
-                    //Permutation
+                    // Permuta os pawns
                     Utils.PermutePawn(skyCloudDownloadRecipient, currentPawn);
 
-                    //Report du blankAndroid pour le flagger dans la routine de kill
+                    // Reporta o android vazio para o flagger na rotina de kill
                     CompAndroidState cas = Utils.getCachedCAS(skyCloudDownloadRecipient);
                     if(cas != null)
                         cas.isBlankAndroid = true;
 
-                    //Clear du status de blank andorid si destinataire blank android
+                    // Limpa o status de android vazio se o destinatário for um android vazio
                     Utils.clearBlankAndroid(currentPawn);
 
-                    //Si cpawn un T1 on lui ajoute le trait SimpleMinded
+                    // Se o pawn for um T1, adicione o traço SimpleMinded
                     Utils.addSimpleMindedTraitForT1(currentPawn);
 
-                    
-
-                    //Suppression de la memoire du core de l'esprit téléchargé
+                    // Remove a memória do núcleo do espírito baixado
                     csc.RemoveMind(skyCloudDownloadRecipient);
 
-                    //Annulation status de prisonnier de l'esprit downloader
+                    // Annulação do status de prisioneiro do espírito baixado
                     dealWithPrisonerRecipientPermute(currentPawn, skyCloudDownloadRecipient);
 
                     Utils.playVocal("soundDefSkyCloudMindUploadCompleted");
 
-                    //On kill le destinataire permuté
+                    // Mata o destinatário permutado
                     skyCloudDownloadRecipient.Kill(null,null);
 
@@ -300,5 +304,5 @@
                 if(mindAbsorptionEndingGT != -1 && mindAbsorptionEndingGT < GT)
                 {
-                    //Calcul moyenne point de skill du prisonnier
+                    // Calculo da média de pontos de habilidade do prisioneiro
                     int sum = 0;
                     int average = 0;
@@ -324,5 +328,5 @@
         public void dealWithPrisonerRecipient(Pawn cpawn, Pawn recipient)
         {
-            //Si destinataire de la duplication prisonnier Et emetteur pas prisonier on enleve la condition 
+            // Se o destinatário da duplicação for prisioneiro e o emissor não for prisioneiro, remove a condição
             if (!cpawn.IsPrisoner && recipient.IsPrisoner)
             {
@@ -338,5 +342,5 @@
             }
 
-            //SI destinataire de la duplication colon regular et  prisonnier 
+            // Se o destinatário da duplicação for um colono regular e o emissor for prisioneiro
             if (cpawn.IsPrisoner && !recipient.IsPrisoner)
             {
@@ -383,5 +387,5 @@
             }
             else
-            // Prisonner <=> COLON
+            // Prisioneiro <=> COLONO
             {
                 Faction tmp = cpawn.Faction;
@@ -418,5 +422,5 @@
             CompSkyCloudCore csc = Utils.getCachedCSC(skyCloudHost);
 
-            PawnGenerationRequest request = new PawnGenerationRequest(cpawn.kindDef, Faction.OfPlayer, PawnGenerationContext.NonPlayer, -1, true, false, false, false, true, false, 1f, false, true, true, false, false, false, false, fixedBiologicalAge: cpawn.ageTracker.AgeBiologicalYearsFloat, fixedChronologicalAge: cpawn.ageTracker.AgeChronologicalYearsFloat, fixedGender: cpawn.gender, fixedMelanin: cpawn.story.melanin);
+            PawnGenerationRequest request = Utils.NewPawnGenerationRequest(cpawn.kindDef, Faction.OfPlayer, PawnGenerationContext.NonPlayer, -1, true, false, false, false, true, false, 1f, false, true, true, false, false, false, false, fixedBiologicalAge: cpawn.ageTracker.AgeBiologicalYearsFloat, fixedChronologicalAge: cpawn.ageTracker.AgeChronologicalYearsFloat, fixedGender: cpawn.gender, fixedMelanin: cpawn.story.SkinColorBase);
             Pawn clone = PawnGenerator.GeneratePawn(request);
 
@@ -436,5 +440,5 @@
 
 
-            //Définition nouveau nom
+            // Definição do novo nome
             try
             {
@@ -442,5 +446,5 @@
                 int start = 1;
                 int tmp = 0;
-                //Tentative pour touver dernier indice numerique 
+                // Tentativa de encontrar o último índice numérico
                 foreach (var m in csc.storedMinds)
                 {
@@ -463,5 +467,5 @@
                 {
                     start = tmp + 1;
-                    //On garde uniquement la partie sans chiffre terminal
+                    // Remove apenas a parte sem o dígito final
                     int idx = baseName.LastIndexOf(' ');
                     if (idx != -1)
@@ -498,6 +502,7 @@
 
             csc.storedMinds.Add(clone);
-
-            //On enleve le mind de la liste des minds en cours de replication
+            Utils.PrepareSkyCloudStoredMind(clone);
+
+            // Remove o mind da lista de minds em replicação
             csc.replicatingMinds.Remove(cpawn);
 
@@ -529,4 +534,7 @@
         public override void PostDraw()
         {
+            if (currentPawn == null)
+                return;
+
             Material avatar = null;
             Vector3 vector;
@@ -551,4 +559,8 @@
             base.PostDestroy(mode, previousMap);
 
+            Pawn cpawn = parent as Pawn;
+            if (cpawn == null)
+                return;
+
             if (controlMode && SX != null)
             {
@@ -556,6 +568,4 @@
                 controlMode = false;
             }
-
-            Pawn cpawn = (Pawn)parent;
 
             Hediff he = cpawn.health.hediffSet.GetFirstHediffOfDef(HediffDefOf.ATPP_ConsciousnessUpload);
@@ -578,4 +588,7 @@
             base.PostDrawExtraSelectionOverlays();
 
+            if (currentPawn == null)
+                return;
+
             if( (permuteEndingGT != -1 && permuteRecipient != null) || showPermuteProgress)
             {
@@ -588,5 +601,5 @@
             }
 
-            //Dessin liaison trasfert vers SkyCloud
+            // Desenho da ligação de transferência para o SkyCloud
             if(uploadToSkyCloudEndingGT != -1 && skyCloudRecipient.Map == parent.Map)
             {
@@ -594,5 +607,5 @@
             }
 
-            //Dessin liaison entre controlleur et son/Ses SX
+            // Desenho da ligação entre o controlador e seu/Seus SX
             if (controlMode) {
                 if (SX != null && SX.Map == parent.Map)
@@ -617,5 +630,5 @@
             Pawn cpawn = (Pawn)parent;
 
-            //Si dupication ou permutation en cours on empeche le mode control
+            // Se duplicação ou permutação em curso, impede o modo de controle
             if (duplicateEndingGT != -1 || permuteEndingGT != -1)
             {
@@ -652,8 +665,11 @@
         public override IEnumerable<Gizmo> CompGetGizmosExtra()
         {
+            if (currentPawn == null)
+                yield break;
+
             bool isPrisonner = currentPawn.IsPrisoner;
             bool isBlankAndroid = (currentCAS != null && currentCAS.isBlankAndroid);
 
-            //Si pas prisonier ET pas un surrogate non controlé && affecté au crafting
+            // Se não for prisioneiro E não for um surrogate não controlado && afetado ao crafting
             if (!isPrisonner && !(currentCAS != null && currentCAS.isSurrogate && currentCAS.surrogateController == null) && currentPawn.workSettings != null && currentPawn.workSettings.WorkIsActive(Utils.WorkTypeDefSmithing) && Settings.androidsCanOnlyBeHealedByCrafter)
             {
@@ -962,4 +978,7 @@
             try
             {
+                if (currentPawn == null)
+                    return base.CompInspectStringExtra();
+
                 if (parent.Map == null)
                     return base.CompInspectStringExtra();
@@ -1055,4 +1074,7 @@
         {
             base.ReceiveCompSignal(signal);
+
+            if (currentPawn == null)
+                return;
 
             switch (signal)
@@ -1497,5 +1519,5 @@
                 if (csurrogate.playerSettings != null)
                 {
-                    csurrogate.playerSettings.AreaRestriction = null;
+                    csurrogate.playerSettings.AreaRestrictionInPawnCurrentMap = null;
                     csurrogate.playerSettings.hostilityResponse = HostilityResponseMode.Flee;
                 }
@@ -1588,5 +1610,5 @@
         }
 
-        private void OnMoveConsciousnessToSkyCloudCore(Pawn source, Thing dest)
+        public void OnMoveConsciousnessToSkyCloudCore(Pawn source, Thing dest)
         {
             int CGT = Find.TickManager.TicksGame;
@@ -1608,5 +1630,5 @@
         }
 
-        private void OnMoveConsciousnessFromSkyCloudCore(Pawn source)
+        public void OnMoveConsciousnessFromSkyCloudCore(Pawn source)
         {
             Pawn dest = (Pawn)parent;
@@ -1918,3 +1940,3 @@
         public bool lastSkymindDisconnectIsManual = false;
     }
-}+}
```

### Components/CompSurrogateSpawner.cs
```diff
--- v1.3/Components/CompSurrogateSpawner.cs
+++ v1.6/Components/CompSurrogateSpawner.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using RimWorld;
 using Verse;
```

### Components/CompUseEffect_SpawnAndroid.cs
```diff
--- v1.3/Components/CompUseEffect_SpawnAndroid.cs
+++ v1.6/Components/CompUseEffect_SpawnAndroid.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using RimWorld;
 using RimWorld.Planet;
```

### Components/SpawnerCompProperties_GenericSpawner.cs
```diff
--- v1.3/Components/SpawnerCompProperties_GenericSpawner.cs
+++ v1.6/Components/SpawnerCompProperties_GenericSpawner.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using Verse;
 
```

### Components/Spawner_Generic.cs
```diff
--- v1.3/Components/Spawner_Generic.cs
+++ v1.6/Components/Spawner_Generic.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using System.Collections.Generic;
 using System.Diagnostics;
@@ -47,5 +47,5 @@
             }
 
-            PawnGenerationRequest request = new PawnGenerationRequest(this.Spawnprops.Pawnkind, Faction.OfPlayer, PawnGenerationContext.NonPlayer, fixedGender : gender);
+            PawnGenerationRequest request = Utils.NewPawnGenerationRequest(this.Spawnprops.Pawnkind, Faction.OfPlayer, PawnGenerationContext.NonPlayer, fixedGender : gender);
             Pawn pawn = PawnGenerator.GeneratePawn(request);
 
```

### DefsOf/BodyPartTagDefOf.cs
```diff
--- v1.3/DefsOf/BodyPartTagDefOf.cs
+++ v1.6/DefsOf/BodyPartTagDefOf.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using Verse;
 using RimWorld;
```

### DefsOf/FactionDefOf.cs
```diff
--- v1.3/DefsOf/FactionDefOf.cs
+++ v1.6/DefsOf/FactionDefOf.cs
@@ -1,3 +1,3 @@
-﻿using Verse;
+using Verse;
 using RimWorld;
 
```

### DefsOf/FleshTypeDefOfAT.cs
```diff
--- v1.3/DefsOf/FleshTypeDefOfAT.cs
+++ v1.6/DefsOf/FleshTypeDefOfAT.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using Verse;
 using RimWorld;
```

### DefsOf/HediffDefOf.cs
```diff
--- v1.3/DefsOf/HediffDefOf.cs
+++ v1.6/DefsOf/HediffDefOf.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using Verse;
 using RimWorld;
```

### DefsOf/JobDefOfAT.cs
```diff
--- v1.3/DefsOf/JobDefOfAT.cs
+++ v1.6/DefsOf/JobDefOfAT.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using Verse;
 using RimWorld;
```

### DefsOf/MentalStateDefOf.cs
```diff
--- v1.3/DefsOf/MentalStateDefOf.cs
+++ v1.6/DefsOf/MentalStateDefOf.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using RimWorld;
 using Verse;
```

### DefsOf/PawnKindDef.cs
```diff
--- v1.3/DefsOf/PawnKindDef.cs
+++ v1.6/DefsOf/PawnKindDef.cs
@@ -1,3 +1,3 @@
-﻿using Verse;
+using Verse;
 using RimWorld;
 
```

### DefsOf/SiteCoreDefOf.cs
```diff
--- v1.3/DefsOf/SiteCoreDefOf.cs
+++ v1.6/DefsOf/SiteCoreDefOf.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using RimWorld;
 
```

### DefsOf/SoundDefOfAT.cs
```diff
--- v1.3/DefsOf/SoundDefOfAT.cs
+++ v1.6/DefsOf/SoundDefOfAT.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using RimWorld;
 using Verse;
```

### DefsOf/StatDefOf.cs
```diff
--- v1.3/DefsOf/StatDefOf.cs
+++ v1.6/DefsOf/StatDefOf.cs
@@ -1,3 +1,3 @@
-﻿using RimWorld;
+using RimWorld;
 
 namespace MOARANDROIDS
```

### DefsOf/ThingDefOfAT.cs
```diff
--- v1.3/DefsOf/ThingDefOfAT.cs
+++ v1.6/DefsOf/ThingDefOfAT.cs
@@ -1,3 +1,3 @@
-﻿using Verse;
+using Verse;
 using RimWorld;
 
```

### DefsOf/TraitDefOf.cs
```diff
--- v1.3/DefsOf/TraitDefOf.cs
+++ v1.6/DefsOf/TraitDefOf.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using RimWorld;
 
```

### Designators/Designator_AndroidToControl.cs
```diff
--- v1.3/Designators/Designator_AndroidToControl.cs
+++ v1.6/Designators/Designator_AndroidToControl.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using System.Collections.Generic;
 using System.Diagnostics;
@@ -71,5 +71,5 @@
                 CompAndroidState cas = Utils.getCachedCAS(cp);
 
-                //Si pas clone ou clone deja utilisé on degage
+                // Se não for clone ou clone já usado, remova
                 if (cas == null || !cas.isSurrogate || cas.surrogateController != null || csm.Infected != -1)
                     return false;
@@ -77,5 +77,5 @@
                 if (!Utils.GCATPP.isConnectedToSkyMind(cp))
                 {
-                    //Tentative connection au skymind 
+                    // Tenta conectar ao skymind
                     if (!Utils.GCATPP.connectUser(cp))
                         return false;
@@ -109,12 +109,4 @@
         }
 
-        public override int DraggableDimensions
-        {
-            get
-            {
-                return 0;
-            }
-        }
-
         public override bool DragDrawMeasurements
         {
@@ -142,5 +134,5 @@
             CompSurrogateOwner cso = Utils.getCachedCSO(controller);
 
-            //Prevent some situations where the control mode is disabled and the pawn conscious but the designator is always selected (not concern minds, as there is no controlMode processus)
+            // Previne algumas situações em que o modo de controle está desabilitado e o pawn está consciente, mas o designador está sempre selecionado (não se preocupe com mentes, pois não há processo de controle)
             if (!cso.controlMode && controller.Spawned)
                 return;
```

### Designators/Designator_SurrogateToHack.cs
```diff
--- v1.3/Designators/Designator_SurrogateToHack.cs
+++ v1.6/Designators/Designator_SurrogateToHack.cs
@@ -85,5 +85,5 @@
             CompAndroidState cas = Utils.getCachedCAS(cp);
 
-            //Si pas clone ou clone deja utilisé on degage
+            // Se não for clone ou clone já usado, remova
             if (cas == null || !cas.isSurrogate || cp.Faction == Faction.OfPlayer)
                 return false;
@@ -92,12 +92,4 @@
 
             return true;
-        }
-
-        public override int DraggableDimensions
-        {
-            get
-            {
-                return 0;
-            }
         }
 
@@ -163,5 +155,5 @@
             }
 
-            //Si faction alliée ou neutre ==> pénalitée
+            //Si faction alliÃ©e ou neutre ==> pÃ©nalitÃ©e
             if (target.Faction.RelationKindWith(Faction.OfPlayer) != FactionRelationKind.Hostile)
             {
@@ -184,5 +176,5 @@
                     RCellFinder.TryFindRandomSpotJustOutsideColony(target.PositionHeld, target.Map, out fallbackLocation);
 
-                    target.mindState.Reset();
+                    target.mindState.Reset(clearInspiration: false, clearMentalState: true, wasDowned: false);
                     target.mindState.duty = null;
                     target.jobs.StopAll();
@@ -199,10 +191,10 @@
                     {
                         if(clord.ownedPawns.Contains(target))
-                            clord.Notify_PawnLost(target, PawnLostCondition.IncappedOrKilled, null);
+                            clord.Notify_PawnLost(target, PawnLostCondition.Incapped, null);
                     }
 
                     lord.AddPawn(target);
 
-                    //Si virus explosive enclenchement de la détonnation
+                    //Si virus explosive enclenchement de la dÃ©tonnation
                     if(hackType == 2)
                         csm.infectedExplodeGT = Find.TickManager.TicksGame + (Settings.nbSecExplosiveVirusTakeToExplode * 60);
@@ -252,5 +244,5 @@
                     else
                     {
-                        //Si le surrogate quon veux controlé est infecté alors on enleve l'infection et on reset ses stats
+                        //Si le surrogate quon veux controlÃ© est infectÃ© alors on enleve l'infection et on reset ses stats
                         if (csm.Infected != -1)
                         {
```

### Dialogs/Dialog_Msg.cs
```diff
--- v1.3/Dialogs/Dialog_Msg.cs
+++ v1.6/Dialogs/Dialog_Msg.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using UnityEngine;
 using Verse;
```

### Dialogs/Dialog_SkillUp.cs
```diff
--- v1.3/Dialogs/Dialog_SkillUp.cs
+++ v1.6/Dialogs/Dialog_SkillUp.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using Verse;
 using RimWorld;
```

### Enum/AndroidPaintColor.cs
```diff
--- v1.3/Enum/AndroidPaintColor.cs
+++ v1.6/Enum/AndroidPaintColor.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using System.Collections.Generic;
 using System.Linq;
```

### Extensions/ArrayExtensions.cs
```diff
--- v1.3/Extensions/ArrayExtensions.cs
+++ v1.6/Extensions/ArrayExtensions.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using System.Linq;
 
```

### Extensions/CollectionExtensions.cs
```diff
--- v1.3/Extensions/CollectionExtensions.cs
+++ v1.6/Extensions/CollectionExtensions.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using System.Collections.Generic;
 using System.Linq;
```

### Extensions/PawnExt.cs
```diff
--- v1.3/Extensions/PawnExt.cs
+++ v1.6/Extensions/PawnExt.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using Verse;
 using RimWorld;
```

### Extensions/StringBuilderExtensions.cs
```diff
--- v1.3/Extensions/StringBuilderExtensions.cs
+++ v1.6/Extensions/StringBuilderExtensions.cs
@@ -1,3 +1,3 @@
-﻿using System.Text;
+using System.Text;
 
 namespace MOARANDROIDS
```

### GenStep_DownedRefugee.cs
```diff
--- v1.3/GenStep_DownedRefugee.cs
+++ v1.6/GenStep_DownedRefugee.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using RimWorld.Planet;
 using Verse;
```

### Harmony/Alert_ColonistLeftUnburied_Patch.cs
```diff
--- v1.3/Harmony/Alert_ColonistLeftUnburied_Patch.cs
+++ v1.6/Harmony/Alert_ColonistLeftUnburied_Patch.cs
@@ -1,3 +1,3 @@
-﻿using Verse;
+using Verse;
 using Verse.AI;
 using Verse.AI.Group;
```

### Harmony/Alert_ColonistNeedsRescuing_Patch.cs
```diff
--- v1.3/Harmony/Alert_ColonistNeedsRescuing_Patch.cs
+++ v1.6/Harmony/Alert_ColonistNeedsRescuing_Patch.cs
@@ -1,3 +1,3 @@
-﻿using Verse;
+using Verse;
 using Verse.AI;
 using Verse.AI.Group;
```

### Harmony/Alert_NeedColonistBeds_Patch.cs
```diff
--- v1.3/Harmony/Alert_NeedColonistBeds_Patch.cs
+++ v1.6/Harmony/Alert_NeedColonistBeds_Patch.cs
@@ -1,3 +1,3 @@
-﻿/*using Verse;
+/*using Verse;
 using Verse.AI;
 using Verse.AI.Group;
```

### Harmony/Alert_RoyalNoAcceptableFood_Patch.cs
```diff
--- v1.3/Harmony/Alert_RoyalNoAcceptableFood_Patch.cs
+++ v1.6/Harmony/Alert_RoyalNoAcceptableFood_Patch.cs
@@ -1,3 +1,3 @@
-﻿using Verse;
+using Verse;
 using Verse.AI;
 using Verse.AI.Group;
```

### Harmony/ApparelGraphicRecordGetter_Patch.cs
```diff
--- v1.3/Harmony/ApparelGraphicRecordGetter_Patch.cs
+++ v1.6/Harmony/ApparelGraphicRecordGetter_Patch.cs
@@ -1,3 +1,3 @@
-﻿/*using Verse;
+/*using Verse;
 using Verse.AI;
 using Verse.AI.Group;
```

### Harmony/ApparelUtility_Patch.cs
```diff
--- v1.3/Harmony/ApparelUtility_Patch.cs
+++ v1.6/Harmony/ApparelUtility_Patch.cs
@@ -1,3 +1,3 @@
-﻿using Verse;
+using Verse;
 using Verse.AI;
 using Verse.AI.Group;
```

### Harmony/Apparel_Patch.cs
```diff
--- v1.3/Harmony/Apparel_Patch.cs
+++ v1.6/Harmony/Apparel_Patch.cs
@@ -1,3 +1,3 @@
-﻿using Verse;
+using Verse;
 using Verse.AI;
 using Verse.AI.Group;
```

### Harmony/Building_Bed_Patch.cs
```diff
--- v1.3/Harmony/Building_Bed_Patch.cs
+++ v1.6/Harmony/Building_Bed_Patch.cs
@@ -1,3 +1,3 @@
-﻿using Verse;
+using Verse;
 using Verse.AI;
 using Verse.AI.Group;
@@ -133,5 +133,5 @@
                     return new FloatMenuOption("CannotUseNoPath".Translate(), null, MenuOptionPriority.Default, null, null, 0f, null, null);
                 }
-                if (bed.Spawned && Find.World.gameConditionManager.ConditionIsActive(GameConditionDefOf.SolarFlare))
+                if (bed.Spawned && Find.World.gameConditionManager.ConditionIsActive(Utils.SolarFlare))
                 {
                     return new FloatMenuOption("CannotUseSolarFlare".Translate(), null, MenuOptionPriority.Default, null, null, 0f, null, null);
```

### Harmony/Building_Patch.cs
```diff
--- v1.3/Harmony/Building_Patch.cs
+++ v1.6/Harmony/Building_Patch.cs
@@ -1,3 +1,3 @@
-﻿using System.Collections.Generic;
+using System.Collections.Generic;
 using System.Linq;
 using HarmonyLib;
@@ -19,7 +19,7 @@
         {
             [HarmonyPostfix]
-            public static void Replacement(Building __instance, ref bool __result, Faction by)
+            public static void Replacement(Building __instance, ref AcceptanceReport __result, Faction by)
             {
-                if (!__result)
+                if (!__result.Accepted)
                     return;
 
@@ -28,5 +28,5 @@
                 if ( (csm != null && csm.Infected != -1))
                 {
-                    __result = false;
+                    __result = "Cannot claim: infected.";
                     return;
                 }
@@ -49,3 +49,3 @@
 
     }
-}+}
```

### Harmony/Building_TurretGun_Patch.cs
```diff
--- v1.3/Harmony/Building_TurretGun_Patch.cs
+++ v1.6/Harmony/Building_TurretGun_Patch.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using System.Collections.Generic;
 using System.Linq;
```

### Harmony/Caravan_Patch.cs
```diff
--- v1.3/Harmony/Caravan_Patch.cs
+++ v1.6/Harmony/Caravan_Patch.cs
@@ -1,3 +1,3 @@
-﻿using Verse;
+using Verse;
 using Verse.AI;
 using Verse.AI.Group;
```

### Harmony/ColonistBar_Patch.cs
```diff
--- v1.3/Harmony/ColonistBar_Patch.cs
+++ v1.6/Harmony/ColonistBar_Patch.cs
@@ -1,58 +1,250 @@
-﻿/*using Verse;
-using Verse.AI;
-using Verse.AI.Group;
 using HarmonyLib;
 using RimWorld;
+using RimWorld.Planet;
+using System;
 using System.Collections.Generic;
 using System.Linq;
-using System;
 using UnityEngine;
+using Verse;
 
 namespace MOARANDROIDS
 {
     internal class ColonistBar_Patch
-
     {
+        private static readonly List<Map> tmpMaps = new List<Map>();
+        private static readonly List<Pawn> tmpPawns = new List<Pawn>();
+        private static readonly List<Caravan> tmpCaravans = new List<Caravan>();
+        private static readonly HashSet<Pawn> tmpStoredMinds = new HashSet<Pawn>();
+
         [HarmonyPatch(typeof(ColonistBar), "CheckRecacheEntries")]
         public class CheckRecacheEntries_Patch
         {
-            [HarmonyPostfix]
-            public static void Listener(ColonistBar __instance, ref List<ColonistBar.Entry> ___cachedEntries, ref ColonistBarDrawLocsFinder ___drawLocsFinder, ref List<Vector2> ___cachedDrawLocs, ref float ___cachedScale)
-            {
+            [HarmonyPrefix]
+            public static bool Prefix(
+                ColonistBar __instance,
+                ref bool ___entriesDirty,
+                List<ColonistBar.Entry> ___cachedEntries,
+                List<Vector2> ___cachedDrawLocs,
+                List<int> ___cachedReorderableGroups,
+                ColonistBarColonistDrawer ___drawer,
+                ColonistBarDrawLocsFinder ___drawLocsFinder,
+                ref float ___cachedScale)
+            {
+                if (!___entriesDirty)
+                    return false;
+
+                ___entriesDirty = false;
+
                 try
                 {
-                    if (!Settings.hideInactiveSurrogates)
-                        return;
-
-                    List<ColonistBar.Entry> toDel = null;
-                    //Suppresssion de la barre du haut des surrogates non actifs
-                    foreach (var e in ___cachedEntries)
-                    {
-                        if (e.pawn.IsSurrogateAndroid(false, true))
-                        {
-                            if (toDel == null)
-                                toDel = new List<ColonistBar.Entry>();
-
-                            toDel.Add(e);
-                        }
-                    }
-                    if (toDel != null)
-                    {
-                        foreach (var e in toDel)
-                        {
-                            ___cachedEntries.Remove(e);
-                        }
-
-                        __instance.drawer.Notify_RecachedEntries();
-
-                        ___drawLocsFinder.CalculateDrawLocs(___cachedDrawLocs, out ___cachedScale);
-                    }
-                }
-                catch(Exception e)
-                {
-                    Log.Message("[ATPP] Colonistbar.CheckRecacheEntries " + e.Message + " " + e.StackTrace);
-                }
+                    RecacheEntries(___cachedEntries, ___cachedDrawLocs, ___cachedReorderableGroups, ___drawer, ___drawLocsFinder, ref ___cachedScale);
+                }
+                catch (Exception e)
+                {
+                    Log.Error("[ATPP] ColonistBar.CheckRecacheEntries recovered from " + e.GetType().Name + ": " + e.Message + "\n" + e.StackTrace);
+                    ___cachedEntries.Clear();
+                    ___cachedDrawLocs.Clear();
+                    ___cachedReorderableGroups.Clear();
+                    ___cachedScale = 1f;
+                    ___drawer.Notify_RecachedEntries();
+                }
+                finally
+                {
+                    tmpMaps.Clear();
+                    tmpPawns.Clear();
+                    tmpCaravans.Clear();
+                    tmpStoredMinds.Clear();
+                }
+
+                return false;
+            }
+
+            private static void RecacheEntries(
+                List<ColonistBar.Entry> cachedEntries,
+                List<Vector2> cachedDrawLocs,
+                List<int> cachedReorderableGroups,
+                ColonistBarColonistDrawer drawer,
+                ColonistBarDrawLocsFinder drawLocsFinder,
+                ref float cachedScale)
+            {
+                cachedEntries.Clear();
+                int groupsCount = 0;
+
+                foreach (Pawn mind in Utils.GetSkyCloudStoredMinds())
+                {
+                    if (mind != null)
+                        tmpStoredMinds.Add(mind);
+                }
+
+                if (Find.PlaySettings != null && Find.PlaySettings.showColonistBar)
+                {
+                    RecacheMapEntries(cachedEntries, ref groupsCount);
+                    RecacheCaravanEntries(cachedEntries, ref groupsCount);
+                }
+
+                cachedReorderableGroups.Clear();
+                for (int i = 0; i < cachedEntries.Count; i++)
+                    cachedReorderableGroups.Add(-1);
+
+                drawer.Notify_RecachedEntries();
+                drawLocsFinder.CalculateDrawLocs(cachedDrawLocs, out cachedScale, groupsCount);
+            }
+
+            private static void RecacheMapEntries(List<ColonistBar.Entry> cachedEntries, ref int groupsCount)
+            {
+                tmpMaps.Clear();
+                if (Find.Maps != null)
+                    tmpMaps.AddRange(Find.Maps.Where(map => map != null));
+
+                tmpMaps.SortBy((Map x) => !x.IsPlayerHome, (Map x) => x.uniqueID);
+
+                for (int i = 0; i < tmpMaps.Count; i++)
+                {
+                    tmpPawns.Clear();
+                    Map map = tmpMaps[i];
+
+                    if (map.mapPawns != null)
+                    {
+                        AddDisplayablePawns(tmpPawns, map.mapPawns.FreeColonists);
+                        AddDisplayablePawns(tmpPawns, map.mapPawns.ColonySubhumansControllable);
+                        AddCarriedColonistCorpses(tmpPawns, map.mapPawns.AllPawnsSpawned);
+                    }
+
+                    AddSpawnedColonistCorpses(tmpPawns, map);
+                    EnsureDisplayOrders(tmpPawns);
+                    PlayerPawnsDisplayOrderUtility.Sort(tmpPawns);
+
+                    foreach (Pawn pawn in tmpPawns)
+                        cachedEntries.Add(new ColonistBar.Entry(pawn, map, groupsCount));
+
+                    if (!tmpPawns.Any())
+                        cachedEntries.Add(new ColonistBar.Entry(null, map, groupsCount));
+
+                    groupsCount++;
+                }
+            }
+
+            private static void RecacheCaravanEntries(List<ColonistBar.Entry> cachedEntries, ref int groupsCount)
+            {
+                tmpCaravans.Clear();
+                if (Find.WorldObjects?.Caravans != null)
+                    tmpCaravans.AddRange(Find.WorldObjects.Caravans.Where(caravan => caravan != null));
+
+                tmpCaravans.SortBy((Caravan x) => x.ID);
+
+                for (int i = 0; i < tmpCaravans.Count; i++)
+                {
+                    Caravan caravan = tmpCaravans[i];
+                    if (!caravan.IsPlayerControlled)
+                        continue;
+
+                    tmpPawns.Clear();
+                    AddDisplayablePawns(tmpPawns, caravan.PawnsListForReading);
+                    PlayerPawnsDisplayOrderUtility.Sort(tmpPawns);
+
+                    foreach (Pawn pawn in tmpPawns)
+                    {
+                        if (pawn.IsColonist || pawn.IsColonySubhumanPlayerControlled)
+                            cachedEntries.Add(new ColonistBar.Entry(pawn, null, groupsCount));
+                    }
+
+                    groupsCount++;
+                }
+            }
+
+            private static void AddSpawnedColonistCorpses(List<Pawn> pawns, Map map)
+            {
+                List<Thing> corpses = map?.listerThings?.ThingsInGroup(ThingRequestGroup.Corpse);
+                if (corpses == null)
+                    return;
+
+                for (int i = 0; i < corpses.Count; i++)
+                {
+                    if (corpses[i] is Corpse corpse && !corpse.IsDessicated())
+                    {
+                        Pawn innerPawn = corpse.InnerPawn;
+                        if (innerPawn != null && innerPawn.IsColonist)
+                            AddDisplayablePawn(pawns, innerPawn);
+                    }
+                }
+            }
+
+            private static void AddCarriedColonistCorpses(List<Pawn> pawns, IReadOnlyList<Pawn> carriers)
+            {
+                if (carriers == null)
+                    return;
+
+                for (int i = 0; i < carriers.Count; i++)
+                {
+                    Pawn carrier = carriers[i];
+                    Corpse corpse = carrier?.carryTracker?.CarriedThing as Corpse;
+                    Pawn innerPawn = corpse?.InnerPawn;
+                    if (corpse != null && !corpse.IsDessicated() && innerPawn != null && innerPawn.IsColonist)
+                        AddDisplayablePawn(pawns, innerPawn);
+                }
+            }
+
+            private static void AddDisplayablePawns(List<Pawn> pawns, IEnumerable<Pawn> candidates)
+            {
+                if (candidates == null)
+                    return;
+
+                foreach (Pawn pawn in candidates)
+                    AddDisplayablePawn(pawns, pawn);
+            }
+
+            private static void AddDisplayablePawn(List<Pawn> pawns, Pawn pawn)
+            {
+                if (!CanDisplayPawn(pawn) || pawns.Contains(pawn))
+                    return;
+
+                pawns.Add(pawn);
+            }
+
+            private static bool CanDisplayPawn(Pawn pawn)
+            {
+                if (pawn == null || pawn.Destroyed)
+                    return false;
+
+                if (tmpStoredMinds.Contains(pawn))
+                    return false;
+
+                if (Settings.hideInactiveSurrogates && pawn.IsSurrogateAndroid(false, true))
+                    return false;
+
+                EnsurePlayerSettings(pawn);
+                return pawn.playerSettings != null;
+            }
+
+            private static void EnsureDisplayOrders(List<Pawn> pawns)
+            {
+                if (pawns.Count == 0)
+                    return;
+
+                int maxDisplayOrder = 0;
+                foreach (Pawn pawn in pawns)
+                {
+                    if (pawn?.playerSettings != null)
+                        maxDisplayOrder = Mathf.Max(maxDisplayOrder, pawn.playerSettings.displayOrder);
+                }
+
+                foreach (Pawn pawn in pawns)
+                {
+                    if (pawn.playerSettings.displayOrder == Pawn_PlayerSettings.UnsetDisplayOrder)
+                    {
+                        maxDisplayOrder++;
+                        pawn.playerSettings.displayOrder = maxDisplayOrder;
+                    }
+                }
+            }
+
+            private static void EnsurePlayerSettings(Pawn pawn)
+            {
+                if (pawn == null || pawn.playerSettings != null || pawn.Faction != Faction.OfPlayer)
+                    return;
+
+                pawn.playerSettings = new Pawn_PlayerSettings(pawn);
             }
         }
     }
-}*/+}
```

### Harmony/CompAbilityEffect_Convert_Patch.cs
```diff
--- v1.3/Harmony/CompAbilityEffect_Convert_Patch.cs
+++ v1.6/Harmony/CompAbilityEffect_Convert_Patch.cs
@@ -1,3 +1,3 @@
-﻿using Verse;
+using Verse;
 using Verse.AI;
 using Verse.AI.Group;
```

### Harmony/CompAbilityEffect_StartRitual_Patch.cs
```diff
--- v1.3/Harmony/CompAbilityEffect_StartRitual_Patch.cs
+++ v1.6/Harmony/CompAbilityEffect_StartRitual_Patch.cs
@@ -1,3 +1,3 @@
-﻿using Verse;
+using Verse;
 using Verse.AI;
 using Verse.AI.Group;
```

### Harmony/CompPowerTrader_Patch.cs
```diff
--- v1.3/Harmony/CompPowerTrader_Patch.cs
+++ v1.6/Harmony/CompPowerTrader_Patch.cs
@@ -1,3 +1,3 @@
-﻿using Verse;
+using Verse;
 using Verse.AI;
 using Verse.AI.Group;
```

### Harmony/Corpse_Patch.cs
```diff
--- v1.3/Harmony/Corpse_Patch.cs
+++ v1.6/Harmony/Corpse_Patch.cs
@@ -1,3 +1,3 @@
-﻿using Verse;
+using Verse;
 using Verse.AI;
 using Verse.AI.Group;
```

### Harmony/FactionGenerator_Patch.cs
```diff
--- v1.3/Harmony/FactionGenerator_Patch.cs
+++ v1.6/Harmony/FactionGenerator_Patch.cs
@@ -1,3 +1,3 @@
-﻿using Verse;
+using Verse;
 using Verse.AI;
 using Verse.AI.Group;
@@ -14,9 +14,9 @@
 
     {
-        [HarmonyPatch(typeof(FactionGenerator), "GenerateFactionsIntoWorld")]
+        [HarmonyPatch(typeof(FactionGenerator), "GenerateFactionsIntoWorldLayer")]
         public class Ingested_Patch
         {
             [HarmonyPostfix]
-            public static void Listener(Dictionary<FactionDef, int> factionCounts)
+            public static void Listener()
             {
                 try
@@ -26,5 +26,5 @@
                 catch(Exception e)
                 {
-                    Log.Message("[ATPP] FactionGenerator.GenerateFactionsIntoWorld : " + e.Message + " - " + e.StackTrace);
+                    Log.Message("[ATPP] FactionGenerator.GenerateFactionsIntoWorldLayer : " + e.Message + " - " + e.StackTrace);
                 }
             }
```

### Harmony/FlickUtility_Patch.cs
```diff
--- v1.3/Harmony/FlickUtility_Patch.cs
+++ v1.6/Harmony/FlickUtility_Patch.cs
@@ -1,3 +1,3 @@
-﻿using System.Collections.Generic;
+using System.Collections.Generic;
 using System.Linq;
 using System;
```

### Harmony/FloatMenuMakerMap_Patch.cs
```diff
--- v1.3/Harmony/FloatMenuMakerMap_Patch.cs
+++ v1.6/Harmony/FloatMenuMakerMap_Patch.cs
@@ -1,3 +1,3 @@
-﻿using Verse;
+using Verse;
 using Verse.AI;
 using Verse.AI.Group;
@@ -14,9 +14,9 @@
 
     {
-        [HarmonyPatch(typeof(FloatMenuMakerMap), "AddHumanlikeOrders")]
+        [HarmonyPatch(typeof(FloatMenuMakerMap), "GetOptions")]
         public class AddHumanlikeOrders_Patch
         {
             [HarmonyPrefix]
-            public static bool ListenerPrefix(Vector3 clickPos, Pawn pawn, List<FloatMenuOption> opts)
+            public static bool ListenerPrefix(List<Pawn> selectedPawns, Vector3 clickPos)
             {
                 Utils.insideAddHumanlikeOrders = true;
@@ -25,5 +25,5 @@
 
             [HarmonyPostfix]
-            public static void ListenerPostfix(Vector3 clickPos, Pawn pawn, List<FloatMenuOption> opts)
+            public static void ListenerPostfix(List<Pawn> selectedPawns, Vector3 clickPos)
             {
                 Utils.insideAddHumanlikeOrders = false;
```

### Harmony/FoodUtility_Patch.cs
```diff
--- v1.3/Harmony/FoodUtility_Patch.cs
+++ v1.6/Harmony/FoodUtility_Patch.cs
@@ -1,3 +1,3 @@
-﻿using Verse;
+using Verse;
 using Verse.AI;
 using Verse.AI.Group;
```

### Harmony/ForbidUtility_Patch.cs
```diff
--- v1.3/Harmony/ForbidUtility_Patch.cs
+++ v1.6/Harmony/ForbidUtility_Patch.cs
@@ -1,3 +1,3 @@
-﻿using Verse;
+using Verse;
 using Verse.AI;
 using Verse.AI.Group;
```

### Harmony/FreeColonists_Patch.cs
```diff
--- v1.3/Harmony/FreeColonists_Patch.cs
+++ v1.6/Harmony/FreeColonists_Patch.cs
@@ -1,3 +1,3 @@
-﻿using Verse;
+using Verse;
 using Verse.AI;
 using Verse.AI.Group;
```

### Harmony/Game_Patch.cs
```diff
--- v1.3/Harmony/Game_Patch.cs
+++ v1.6/Harmony/Game_Patch.cs
@@ -1,3 +1,3 @@
-﻿using Verse;
+using Verse;
 using Verse.AI;
 using Verse.AI.Group;
```

### Harmony/HealthAIUtility_Patch.cs
```diff
--- v1.3/Harmony/HealthAIUtility_Patch.cs
+++ v1.6/Harmony/HealthAIUtility_Patch.cs
@@ -1,3 +1,3 @@
-﻿using Verse;
+using Verse;
 using Verse.AI;
 using Verse.AI.Group;
```

### Harmony/HealthCardUtility_Patch.cs
```diff
--- v1.3/Harmony/HealthCardUtility_Patch.cs
+++ v1.6/Harmony/HealthCardUtility_Patch.cs
@@ -1,3 +1,3 @@
-﻿using Verse;
+using Verse;
 using Verse.AI;
 using Verse.AI.Group;
```

### Harmony/HediffMaker_Patch.cs
```diff
--- v1.3/Harmony/HediffMaker_Patch.cs
+++ v1.6/Harmony/HediffMaker_Patch.cs
@@ -1,3 +1,3 @@
-﻿using Verse;
+using Verse;
 using Verse.AI;
 using Verse.AI.Group;
```

### Harmony/HediffUtility_Patch.cs
```diff
--- v1.3/Harmony/HediffUtility_Patch.cs
+++ v1.6/Harmony/HediffUtility_Patch.cs
@@ -1,3 +1,3 @@
-﻿using Verse;
+using Verse;
 using Verse.AI;
 using Verse.AI.Group;
```

### Harmony/IncidentWorker_DiseaseAnimal_Patch.cs
```diff
--- v1.3/Harmony/IncidentWorker_DiseaseAnimal_Patch.cs
+++ v1.6/Harmony/IncidentWorker_DiseaseAnimal_Patch.cs
@@ -1,3 +1,3 @@
-﻿using Verse;
+using Verse;
 using Verse.AI;
 using Verse.AI.Group;
```

### Harmony/IncidentWorker_DiseaseHuman_Patch.cs
```diff
--- v1.3/Harmony/IncidentWorker_DiseaseHuman_Patch.cs
+++ v1.6/Harmony/IncidentWorker_DiseaseHuman_Patch.cs
@@ -1,3 +1,3 @@
-﻿using Verse;
+using Verse;
 using Verse.AI;
 using Verse.AI.Group;
```

### Harmony/IncidentWorker_WandererJoin_Patch.cs
```diff
--- v1.3/Harmony/IncidentWorker_WandererJoin_Patch.cs
+++ v1.6/Harmony/IncidentWorker_WandererJoin_Patch.cs
@@ -1,3 +1,3 @@
-﻿using Verse;
+using Verse;
 using Verse.AI;
 using Verse.AI.Group;
```

### Harmony/InspirationWorker_Patch.cs
```diff
--- v1.3/Harmony/InspirationWorker_Patch.cs
+++ v1.6/Harmony/InspirationWorker_Patch.cs
@@ -1,3 +1,3 @@
-﻿using Verse;
+using Verse;
 using Verse.AI;
 using Verse.AI.Group;
```

### Harmony/InteractionWorker_ConvertIdeoAttempt_Patch.cs
```diff
--- v1.3/Harmony/InteractionWorker_ConvertIdeoAttempt_Patch.cs
+++ v1.6/Harmony/InteractionWorker_ConvertIdeoAttempt_Patch.cs
@@ -1,3 +1,3 @@
-﻿using Verse;
+using Verse;
 using Verse.AI;
 using Verse.AI.Group;
```

### Harmony/InteractionWorker_EnslaveAttempt_Patch.cs
```diff
--- v1.3/Harmony/InteractionWorker_EnslaveAttempt_Patch.cs
+++ v1.6/Harmony/InteractionWorker_EnslaveAttempt_Patch.cs
@@ -1,3 +1,3 @@
-﻿using Verse;
+using Verse;
 using Verse.AI;
 using Verse.AI.Group;
```

### Harmony/InteractionWorker_RecruitAttempt_Patch.cs
```diff
--- v1.3/Harmony/InteractionWorker_RecruitAttempt_Patch.cs
+++ v1.6/Harmony/InteractionWorker_RecruitAttempt_Patch.cs
@@ -1,3 +1,3 @@
-﻿using Verse;
+using Verse;
 using Verse.AI;
 using Verse.AI.Group;
```

### Harmony/JobGiver_GetFood_Patch.cs
```diff
--- v1.3/Harmony/JobGiver_GetFood_Patch.cs
+++ v1.6/Harmony/JobGiver_GetFood_Patch.cs
@@ -1,3 +1,3 @@
-﻿using Verse;
+using Verse;
 using Verse.AI;
 using Verse.AI.Group;
```

### Harmony/JobGiver_GetJoy_Patch.cs
```diff
--- v1.3/Harmony/JobGiver_GetJoy_Patch.cs
+++ v1.6/Harmony/JobGiver_GetJoy_Patch.cs
@@ -1,3 +1,3 @@
-﻿using Verse;
+using Verse;
 using Verse.AI;
 using Verse.AI.Group;
```

### Harmony/JobGiver_SocialFighting_Patch.cs
```diff
--- v1.3/Harmony/JobGiver_SocialFighting_Patch.cs
+++ v1.6/Harmony/JobGiver_SocialFighting_Patch.cs
@@ -1,3 +1,3 @@
-﻿using Verse;
+using Verse;
 using Verse.AI;
 using Verse.AI.Group;
```

### Harmony/KidnapAIUtility_Patch.cs
```diff
--- v1.3/Harmony/KidnapAIUtility_Patch.cs
+++ v1.6/Harmony/KidnapAIUtility_Patch.cs
@@ -1,3 +1,3 @@
-﻿using Verse;
+using Verse;
 using Verse.AI;
 using Verse.AI.Group;
```

### Harmony/ListerThings_Patch.cs
```diff
--- v1.3/Harmony/ListerThings_Patch.cs
+++ v1.6/Harmony/ListerThings_Patch.cs
@@ -1,3 +1,3 @@
-﻿/*using Verse;
+/*using Verse;
 using Verse.AI;
 using Verse.AI.Group;
```

### Harmony/MapPawns_Patch.cs
```diff
--- v1.3/Harmony/MapPawns_Patch.cs
+++ v1.6/Harmony/MapPawns_Patch.cs
@@ -1,3 +1,3 @@
-﻿using System.Collections.Generic;
+using System.Collections.Generic;
 using System.Linq;
 using System;
```

### Harmony/MedicalCareUtility_Patch.cs
```diff
--- v1.3/Harmony/MedicalCareUtility_Patch.cs
+++ v1.6/Harmony/MedicalCareUtility_Patch.cs
@@ -1,3 +1,3 @@
-﻿using Verse;
+using Verse;
 using Verse.AI;
 using Verse.AI.Group;
```

### Harmony/MemoryThoughtHandler_Patch.cs
```diff
--- v1.3/Harmony/MemoryThoughtHandler_Patch.cs
+++ v1.6/Harmony/MemoryThoughtHandler_Patch.cs
@@ -1,3 +1,3 @@
-﻿using Verse;
+using Verse;
 using Verse.AI;
 using Verse.AI.Group;
@@ -13,7 +13,12 @@
     {
 
-        [HarmonyPatch(typeof(MemoryThoughtHandler), "TryGainMemoryFast")]
+        [HarmonyPatch]
         public class TryGainMemoryFast
         {
+            public static System.Reflection.MethodBase TargetMethod()
+            {
+                return AccessTools.Method(typeof(MemoryThoughtHandler), nameof(MemoryThoughtHandler.TryGainMemoryFast), new Type[] { typeof(ThoughtDef), typeof(Precept) });
+            }
+
             [HarmonyPrefix]
             public static bool Listener(ThoughtDef mem, MemoryThoughtHandler __instance)
@@ -22,7 +27,5 @@
                 {
                     if (shouldSkipCurrentMemory(mem, __instance))
-                    {
                         return false;
-                    }
                     return true;
                 }
@@ -30,4 +33,29 @@
                 {
                     Log.Message("[ATPP] MemoryThoughtHandler.TryGainMemoryFast : " + e.Message + " - " + e.StackTrace);
+                    return true;
+                }
+            }
+        }
+
+        [HarmonyPatch]
+        public class TryGainMemoryFast2
+        {
+            public static System.Reflection.MethodBase TargetMethod()
+            {
+                return AccessTools.Method(typeof(MemoryThoughtHandler), nameof(MemoryThoughtHandler.TryGainMemoryFast), new Type[] { typeof(ThoughtDef), typeof(int), typeof(Precept) });
+            }
+
+            [HarmonyPrefix]
+            public static bool Listener(ThoughtDef mem, MemoryThoughtHandler __instance)
+            {
+                try
+                {
+                    if (shouldSkipCurrentMemory(mem, __instance))
+                        return false;
+                    return true;
+                }
+                catch (Exception e)
+                {
+                    Log.Message("[ATPP] MemoryThoughtHandler.TryGainMemoryFast2 : " + e.Message + " - " + e.StackTrace);
                     return true;
                 }
@@ -66,11 +94,15 @@
         private static bool shouldSkipCurrentMemory(ThoughtDef memDef, MemoryThoughtHandler __instance)
         {
-            CompAndroidState cas = Utils.getCachedCAS(__instance.pawn);
-                return  ( __instance.pawn.IsAndroidTier() && Utils.IgnoredThoughtsByAllAndroids.Contains(memDef.defName))
+            Pawn pawn = __instance?.pawn;
+            if (pawn == null || memDef == null)
+                return false;
+
+            CompAndroidState cas = Utils.getCachedCAS(pawn);
+                return  ( pawn.IsAndroidTier() && Utils.IgnoredThoughtsByAllAndroids.Contains(memDef.defName))
                         || Utils.lastButcheredPawnIsAndroid
                         || (cas != null && cas.isSurrogate && cas.surrogateController == null)
-                        || Utils.pawnCurrentlyControlRemoteSurrogate(__instance.pawn)
-                        || ( (__instance.pawn.IsBasicAndroidTier() || __instance.pawn.story.traits.HasTrait(TraitDefOf.SimpleMindedAndroid)) && Utils.IgnoredThoughtsByBasicAndroids.Contains(memDef.defName));
+                        || Utils.pawnCurrentlyControlRemoteSurrogate(pawn)
+                        || ( (pawn.IsBasicAndroidTier() || pawn.story?.traits?.HasTrait(TraitDefOf.SimpleMindedAndroid) == true) && Utils.IgnoredThoughtsByBasicAndroids.Contains(memDef.defName));
         }
     }
-}+}
```

### Harmony/MentalBreaker_Patch.cs
```diff
--- v1.3/Harmony/MentalBreaker_Patch.cs
+++ v1.6/Harmony/MentalBreaker_Patch.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using HarmonyLib;
 using RimWorld;
```

### Harmony/MentalState_Patch.cs
```diff
--- v1.3/Harmony/MentalState_Patch.cs
+++ v1.6/Harmony/MentalState_Patch.cs
@@ -1,3 +1,3 @@
-﻿using Verse;
+using Verse;
 using Verse.AI;
 using Verse.AI.Group;
```

### Harmony/Need_Food_Patch.cs
```diff
--- v1.3/Harmony/Need_Food_Patch.cs
+++ v1.6/Harmony/Need_Food_Patch.cs
@@ -1,3 +1,3 @@
-﻿using Verse;
+using Verse;
 using Verse.AI;
 using Verse.AI.Group;
@@ -7,4 +7,5 @@
 using System.Linq;
 using System;
+using System.Reflection;
 
 namespace MOARANDROIDS
@@ -17,13 +18,23 @@
          * Mise en place d'un Maxlevel raisonable car avec l'algo de base de RW il st demeusuré de part la taille des M7 et donc la batterie (food) met BC de temps a s'écouler
          */
-        [HarmonyPatch(typeof(Need_Food), "get_HungerRate")]
+        [HarmonyPatch]
         public class MaxLevel_Patch
         {
+            public static bool Prepare()
+            {
+                return TargetMethod() != null;
+            }
+
+            public static MethodBase TargetMethod()
+            {
+                return AccessTools.PropertyGetter(typeof(Need_Food), nameof(Need_Food.FoodFallPerTick));
+            }
+
             [HarmonyPostfix]
             public static void Listener(Pawn ___pawn, ref float __result)
             {
-                if (___pawn.def == Utils.M7Mech && ___pawn.IsSurrogateAndroid())
+                if (___pawn?.def == Utils.M7Mech && ___pawn.IsSurrogateAndroid())
                 {
-                    __result = 1.5f;
+                    __result = 1.5f / GenDate.TicksPerDay;
                 }
             }
@@ -61,3 +72,3 @@
         }*/
     }
-}+}
```

### Harmony/Need_Patch.cs
```diff
--- v1.3/Harmony/Need_Patch.cs
+++ v1.6/Harmony/Need_Patch.cs
@@ -1,3 +1,3 @@
-﻿using Verse;
+using Verse;
 using Verse.AI;
 using Verse.AI.Group;
```

### Harmony/PawnBioAndNameGenerator_Patch.cs
```diff
--- v1.3/Harmony/PawnBioAndNameGenerator_Patch.cs
+++ v1.6/Harmony/PawnBioAndNameGenerator_Patch.cs
@@ -1,3 +1,3 @@
-﻿/*using Verse;
+/*using Verse;
 using Verse.AI;
 using Verse.AI.Group;
```

### Harmony/PawnBreathMoteMaker_Patch.cs
```diff
--- v1.3/Harmony/PawnBreathMoteMaker_Patch.cs
+++ v1.6/Harmony/PawnBreathMoteMaker_Patch.cs
@@ -1,3 +1,3 @@
-﻿using Verse;
+using Verse;
 using Verse.AI;
 using Verse.AI.Group;
```

### Harmony/PawnDiedOrDownedThoughtsUtility_Patch.cs
```diff
--- v1.3/Harmony/PawnDiedOrDownedThoughtsUtility_Patch.cs
+++ v1.6/Harmony/PawnDiedOrDownedThoughtsUtility_Patch.cs
@@ -1,3 +1,3 @@
-﻿using Verse;
+using Verse;
 using Verse.AI;
 using Verse.AI.Group;
```

### Harmony/PawnGenerator_Patch.cs
```diff
--- v1.3/Harmony/PawnGenerator_Patch.cs
+++ v1.6/Harmony/PawnGenerator_Patch.cs
@@ -29,4 +29,5 @@
                         //Vire chance generation android
                         if (Settings.androidsAreRare
+                            && !Utils.IsAndroidPlayerScenario()
                             && __result.IsAndroidTier()
                             && ((Current.ProgramState == ProgramState.Entry) || (Current.ProgramState == ProgramState.Playing && request.Faction != Faction.OfPlayer))
@@ -45,12 +46,21 @@
                             }
 
-                            PawnGenerationRequest r = new PawnGenerationRequest(cpkd, request.Faction, request.Context, request.Tile, request.ForceGenerateNewPawn, request.Newborn,
+                            PawnGenerationRequest r = Utils.NewPawnGenerationRequest(cpkd, request.Faction, request.Context, request.Tile, request.ForceGenerateNewPawn, false,
                                 request.AllowDead, request.AllowDowned, request.CanGeneratePawnRelations, request.MustBeCapableOfViolence, request.ColonistRelationChanceFactor,
                                 request.ForceAddFreeWarmLayerIfNeeded, request.AllowGay, request.AllowFood, request.AllowAddictions,request.Inhabitant, request.CertainlyBeenInCryptosleep,
                                 request.ForceRedressWorldPawnIfFormerColonist, request.WorldPawnFactionDoesntMatter, request.BiocodeWeaponChance, request.BiocodeApparelChance, request.ExtraPawnForExtraRelationChance,
-                                request.RelationWithExtraPawnChanceFactor, request.ValidatorPreGear, request.ValidatorPostGear, request.ForcedTraits, request.ProhibitedTraits, request.MinChanceToRedressWorldPawn, request.FixedBiologicalAge, request.FixedChronologicalAge, request.FixedGender, request.FixedMelanin, request.FixedLastName, request.FixedBirthName, request.FixedTitle);
+                                request.RelationWithExtraPawnChanceFactor, request.ValidatorPreGear, request.ValidatorPostGear, request.ForcedTraits, request.ProhibitedTraits, request.MinChanceToRedressWorldPawn, request.FixedBiologicalAge, request.FixedChronologicalAge, request.FixedGender, null, request.FixedLastName, request.FixedBirthName, request.FixedTitle);
 
                             __result = PawnGenerator.GeneratePawn(r);
                         }
+                    }
+
+                    // Force adult age: androids are manufactured, not born.
+                    if (isAndroidTier && __result.ageTracker != null && __result.ageTracker.AgeBiologicalYearsFloat < 18f)
+                    {
+                        long adultTicks = (long)(20f * 3600000f);
+                        __result.ageTracker.AgeBiologicalTicks = adultTicks;
+                        if (__result.ageTracker.AgeChronologicalTicks < adultTicks)
+                            __result.ageTracker.AgeChronologicalTicks = adultTicks;
                     }
 
@@ -118,11 +128,11 @@
                     if(Settings.preventM7T5AppearingInCharacterScreen &&  Current.ProgramState == ProgramState.Entry )
                     {
-                        if(__result.def.defName == Utils.M7 || __result.def.defName == Utils.T5 || (__result.def.defName == Utils.M8 && Current.Game.Scenario != null && Current.Game.Scenario.name != "Androids apocalypse"))
-                        {
-                            PawnGenerationRequest r = new PawnGenerationRequest(Utils.AndroidsPKDNeutral.RandomElement(), request.Faction, request.Context, request.Tile, request.ForceGenerateNewPawn, request.Newborn,
+                        if(__result.def.defName == Utils.M7 || __result.def.defName == Utils.T5 || (__result.def.defName == Utils.M8 && !Utils.IsAndroidApocalypseScenario()))
+                        {
+                            PawnGenerationRequest r = Utils.NewPawnGenerationRequest(Utils.AndroidsPKDNeutral.RandomElement(), request.Faction, request.Context, request.Tile, request.ForceGenerateNewPawn, false,
                                 request.AllowDead, request.AllowDowned, request.CanGeneratePawnRelations, request.MustBeCapableOfViolence, request.ColonistRelationChanceFactor,
                                 request.ForceAddFreeWarmLayerIfNeeded, request.AllowGay, request.AllowFood, request.AllowAddictions, request.Inhabitant, request.CertainlyBeenInCryptosleep,
                                 request.ForceRedressWorldPawnIfFormerColonist, request.WorldPawnFactionDoesntMatter, request.BiocodeWeaponChance, request.BiocodeApparelChance, request.ExtraPawnForExtraRelationChance,
-                                request.RelationWithExtraPawnChanceFactor, request.ValidatorPreGear, request.ValidatorPostGear, request.ForcedTraits, request.ProhibitedTraits, request.MinChanceToRedressWorldPawn, request.FixedBiologicalAge, request.FixedChronologicalAge, request.FixedGender, request.FixedMelanin, request.FixedLastName, request.FixedBirthName, request.FixedTitle);
+                                request.RelationWithExtraPawnChanceFactor, request.ValidatorPreGear, request.ValidatorPostGear, request.ForcedTraits, request.ProhibitedTraits, request.MinChanceToRedressWorldPawn, request.FixedBiologicalAge, request.FixedChronologicalAge, request.FixedGender, null, request.FixedLastName, request.FixedBirthName, request.FixedTitle);
 
                             __result = PawnGenerator.GeneratePawn(r);
@@ -158,24 +168,5 @@
                     }
 
-                    //Si GYNOID chargé changement sex android en fonction chance
-                    if (Utils.ANDROIDTIERSGYNOID_LOADED
-                        && isAndroidTier
-                        && (__result.def.defName == Utils.T1 || __result.def.defName == Utils.T2 || __result.def.defName == Utils.T3 || __result.def.defName == Utils.T4 )
-                        && Current.ProgramState == ProgramState.Playing && __result.Faction == Faction.OfPlayer)
-                    {
-                        if (Rand.Chance(Settings.percentageChanceMaleAndroidModel))
-                        {
-                            __result.gender = Gender.Male;
-                            __result.story.bodyType = BodyTypeDefOf.Male;
-                        }
-                        else
-                        {
-                            __result.gender = Gender.Female;
-                            __result.story.bodyType = BodyTypeDefOf.Female;
-                        }
-
-                    }
-
-                    //Définiton des traits pour les androides générés a destination du player
+                    //DÃ©finiton des traits pour les androides gÃ©nÃ©rÃ©s a destination du player
                     if (Current.ProgramState == ProgramState.Playing && !Settings.basicAndroidsRandomSKills && __result.Faction == Faction.OfPlayer)
                     {
@@ -364,5 +355,5 @@
                         Utils.changeHARCrownType(__result, "Average_Normal");
 
-                        __result.Drawer.renderer.graphics.ResolveAllGraphics();
+                        Utils.ResolvePawnGraphics(__result);
                     }
 
@@ -375,3 +366,3 @@
         }
     }
-}+}
```

### Harmony/PawnGraphicSet_Patch.cs
```diff
--- v1.3/Harmony/PawnGraphicSet_Patch.cs
+++ v1.6/Harmony/PawnGraphicSet_Patch.cs
@@ -1,3 +1,3 @@
-﻿using Verse;
+using Verse;
 using Verse.AI;
 using Verse.AI.Group;
@@ -14,19 +14,25 @@
 
     {
-        [HarmonyPatch(typeof(PawnGraphicSet), "ResolveApparelGraphics")]
-        public class ResolveApparelGraphicsPrefix_Patch
+        [HarmonyPatch(typeof(PawnRenderTree), "SetupDynamicNodes")]
+        public class SetupDynamicNodesPrefix_Patch
         {
             [HarmonyPrefix]
-            public static bool Prefix(Pawn ___pawn)
+            public static bool Prefix(PawnRenderTree __instance)
             {
-                if (Utils.ExceptionBodyTypeDefnameAndroidWithSkinMale.Contains(___pawn.story.bodyType.defName))
+                Pawn pawn = Traverse.Create(__instance).Field("pawn").GetValue<Pawn>();
+                if (pawn?.story?.bodyType == null)
                 {
-                    Utils.insideResolveApparelGraphicsLastBodyTypeDef = ___pawn.story.bodyType;
-                    ___pawn.story.bodyType = BodyTypeDefOf.Male;
+                    return true;
                 }
-                else if (Utils.ExceptionBodyTypeDefnameAndroidWithSkinFemale.Contains(___pawn.story.bodyType.defName))
+
+                if (Utils.ExceptionBodyTypeDefnameAndroidWithSkinMale.Contains(pawn.story.bodyType.defName))
                 {
-                    Utils.insideResolveApparelGraphicsLastBodyTypeDef = ___pawn.story.bodyType;
-                    ___pawn.story.bodyType = BodyTypeDefOf.Female;
+                    Utils.insideResolveApparelGraphicsLastBodyTypeDef = pawn.story.bodyType;
+                    pawn.story.bodyType = BodyTypeDefOf.Male;
+                }
+                else if (Utils.ExceptionBodyTypeDefnameAndroidWithSkinFemale.Contains(pawn.story.bodyType.defName))
+                {
+                    Utils.insideResolveApparelGraphicsLastBodyTypeDef = pawn.story.bodyType;
+                    pawn.story.bodyType = BodyTypeDefOf.Female;
                 }
 
@@ -35,34 +41,21 @@
         }
 
-        [HarmonyPatch(typeof(PawnGraphicSet), "ResolveApparelGraphics")]
-        public class ResolveApparelGraphicsPostfix_Patch
+        [HarmonyPatch(typeof(PawnRenderTree), "SetupDynamicNodes")]
+        public class SetupDynamicNodesPostfix_Patch
         {
             [HarmonyPostfix]
-            public static void Postfix(Pawn ___pawn)
+            public static void Postfix(PawnRenderTree __instance)
             {
                 if(Utils.insideResolveApparelGraphicsLastBodyTypeDef != null)
                 {
-                    ___pawn.story.bodyType = Utils.insideResolveApparelGraphicsLastBodyTypeDef;
+                    Pawn pawn = Traverse.Create(__instance).Field("pawn").GetValue<Pawn>();
+                    if (pawn?.story != null)
+                    {
+                        pawn.story.bodyType = Utils.insideResolveApparelGraphicsLastBodyTypeDef;
+                    }
                     Utils.insideResolveApparelGraphicsLastBodyTypeDef = null;
                 }
             }
         }
-
-        [HarmonyPatch(typeof(PawnGraphicSet), "ResolveAllGraphics")]
-        public class PawnGraphicSetPostfix_Patch
-        {
-            private static Traverse Pawn_StoryTracker_Traverse = Traverse.Create<Pawn_StoryTracker>();
-
-            [HarmonyPostfix]
-            public static void Postfix(PawnGraphicSet __instance)
-            {
-                if (Utils.RIMMSQOL_LOADED && Utils.ExceptionAndroidWithSkinList.Contains(__instance.pawn.def.defName))
-                {
-                    Utils.lastResolveAllGraphicsHeadGraphicPath = __instance.pawn.story.HeadGraphicPath;
-                    Traverse.Create(__instance.pawn.story).Field("headGraphicPath").SetValue(null);
-                    //__instance.pawn.story.GetType().GetField("headGraphicPath", BindingFlags.NonPublic | BindingFlags.Instance).SetValue(__instance.pawn.story,null);
-                }
-            }
-        }
     }
-}+}
```

### Harmony/PawnGroupMakerUtility_Patch.cs
```diff
--- v1.3/Harmony/PawnGroupMakerUtility_Patch.cs
+++ v1.6/Harmony/PawnGroupMakerUtility_Patch.cs
@@ -1,3 +1,3 @@
-﻿using Verse;
+using Verse;
 using HarmonyLib;
 using RimWorld;
@@ -90,5 +90,5 @@
                         for (int i = 0; i != nb; i++)
                         {
-                            //PawnGenerationRequest request = new PawnGenerationRequest(Utils.AndroidsPKD[3], parms.faction, PawnGenerationContext.NonPlayer, parms.tile, false, false, false, false, true, false, 1f, false, true, true, false, false, false, false, null, null, null, null, null, null, null, null);
+                            //PawnGenerationRequest request = Utils.NewPawnGenerationRequest(Utils.AndroidsPKD[3], parms.faction, PawnGenerationContext.NonPlayer, parms.tile, false, false, false, false, true, false, 1f, false, true, true, false, false, false, false, null, null, null, null, null, null, null, null);
                             //Pawn surrogate = PawnGenerator.GeneratePawn(request);
 
```

### Harmony/PawnInventoryGenerator_Patch.cs
```diff
--- v1.3/Harmony/PawnInventoryGenerator_Patch.cs
+++ v1.6/Harmony/PawnInventoryGenerator_Patch.cs
@@ -1,3 +1,3 @@
-﻿using Verse;
+using Verse;
 using Verse.AI;
 using Verse.AI.Group;
```

### Harmony/PawnObserver_Patch.cs
```diff
--- v1.3/Harmony/PawnObserver_Patch.cs
+++ v1.6/Harmony/PawnObserver_Patch.cs
@@ -1,3 +1,3 @@
-﻿using Verse;
+using Verse;
 using Verse.AI;
 using Verse.AI.Group;
```

### Harmony/PawnRenderer_Patch.cs
```diff
--- v1.3/Harmony/PawnRenderer_Patch.cs
+++ v1.6/Harmony/PawnRenderer_Patch.cs
@@ -1,3 +1,3 @@
-﻿using Verse;
+using Verse;
 using Verse.AI;
 using Verse.AI.Group;
@@ -25,108 +25,74 @@
 
 
-        [HarmonyPatch(typeof(PawnRenderer), "DrawHeadHair")]
-        [HarmonyPatch(new Type[] { typeof(Vector3), typeof(Vector3), typeof(float), typeof(Rot4), typeof(Rot4), typeof(RotDrawMode), typeof(PawnRenderFlags) })]
+        [HarmonyPatch(typeof(PawnRenderer), "RenderPawnInternal")]
         public class ATPP_RenderPawnInternal_Patch
         {
             [HarmonyPostfix]
-            public static void Listener(ref PawnRenderer __instance, Vector3 rootLoc, Vector3 headOffset, float angle, Rot4 bodyFacing, Rot4 headFacing, RotDrawMode bodyDrawType, PawnRenderFlags flags, Pawn ___pawn)
+            public static void Listener(PawnRenderer __instance, PawnDrawParms parms)
             {
                 try
                 {
-                    bool flagPortrait = flags.FlagSet(PawnRenderFlags.Portrait);
-                    bool state = false;
-                    CompAndroidState cas = null;
-                    if (___pawn != null)
-                        cas = Utils.getCachedCAS(___pawn);
+                    Pawn pawn = parms.pawn;
+                    if (pawn == null) return;
 
-                    if (___pawn != null
-                        && (___pawn.def.defName == Utils.TX2
-                        || ___pawn.def.defName == Utils.TX2I
-                        || ___pawn.def.defName == Utils.TX2KI
-                        || ___pawn.def.defName == Utils.TX3I
-                        || ___pawn.def.defName == Utils.TX4I
-                        || (___pawn.def.defName == Utils.TX2K && (cas.TXHurtedHeadSet || cas.TXHurtedHeadSet2))
-                        || (___pawn.def.defName == Utils.TX3 && (cas.TXHurtedHeadSet || cas.TXHurtedHeadSet2)) 
-                        || (___pawn.def.defName == Utils.TX4 && (cas.TXHurtedHeadSet || cas.TXHurtedHeadSet2)))
-                        && !___pawn.Dead && !flags.FlagSet(PawnRenderFlags.HeadStump))
-                    {
-                        if (!flagPortrait)
-                        {
-                            if (___pawn != null)
-                            {
-                                Pawn_JobTracker jobs = ___pawn.jobs;
-                                if ((((jobs != null) ? jobs.curDriver : null) != null))
-                                {
-                                    state = !___pawn.jobs.curDriver.asleep;
-                                }
-                            }
-                        }
-                        else
-                            state = flagPortrait;
+                    CompAndroidState cas = Utils.getCachedCAS(pawn);
 
-                        state = true;
-                    }
+                    bool shouldDraw = pawn.def.defName == Utils.TX2
+                        || pawn.def.defName == Utils.TX2I
+                        || pawn.def.defName == Utils.TX2KI
+                        || pawn.def.defName == Utils.TX3I
+                        || pawn.def.defName == Utils.TX4I
+                        || (pawn.def.defName == Utils.TX2K && cas != null && (cas.TXHurtedHeadSet || cas.TXHurtedHeadSet2))
+                        || (pawn.def.defName == Utils.TX3 && cas != null && (cas.TXHurtedHeadSet || cas.TXHurtedHeadSet2))
+                        || (pawn.def.defName == Utils.TX4 && cas != null && (cas.TXHurtedHeadSet || cas.TXHurtedHeadSet2));
 
-                    if (state)
-                    {
-                        if (flagPortrait)
-                            Log.Message("Refresh hair for " + ___pawn.LabelCap + " (PORTRAIT)");
-                        else
-                            Log.Message("Refresh hair for " + ___pawn.LabelCap + " (NO_PORTRAIT)");
+                    if (!shouldDraw || parms.dead || parms.flags.FlagSet(PawnRenderFlags.HeadStump))
+                        return;
 
-                        Quaternion quaternion = Quaternion.AngleAxis(angle, Vector3.up);
-                        Vector3 a = rootLoc;
-                        if (bodyFacing != Rot4.North)
-                        {
-                            a.y += 0.0281250011f;
-                            rootLoc.y += 0.0234375f;
-                        }
-                        else
-                        {
-                            a.y += 0.0234375f;
-                            rootLoc.y += 0.0281250011f;
-                        }
-                        Vector3 b = quaternion * __instance.BaseHeadOffsetAt(headFacing);
-                        Vector3 loc = a + b + new Vector3(0f, 0.01f, 0f);
-                        if (headFacing != Rot4.North)
-                        {
-                            Mesh mesh = MeshPool.humanlikeHeadSet.MeshAt(headFacing);
-                            bool isHorizontal = headFacing.IsHorizontal;
-                            int type = 1;
-                            if (cas.TXHurtedHeadSet)
-                                type = 2;
-                            else if(cas.TXHurtedHeadSet2 || ___pawn.def.defName == Utils.TX2I || ___pawn.def.defName == Utils.TX2KI || ___pawn.def.defName == Utils.TX3I || ___pawn.def.defName == Utils.TX4I)
-                                type = 3;
+                    Rot4 facing = parms.facing;
+                    if (facing == Rot4.North) return;
 
-                            //Couleur yeux standard TX2
-                            Color color = new Color(0.9450f, 0.76862f, 0.05882f);
+                    Vector3 rootLoc = new Vector3(parms.matrix.m03, parms.matrix.m13, parms.matrix.m23);
+                    Quaternion quaternion = Quaternion.identity;
 
+                    Vector3 a = rootLoc;
+                    a.y += 0.0281250011f;
 
-                            //Couleur yeux TX3/TX4 standard (bleu cyan)
-                            if(___pawn.def.defName == Utils.TX3 || ___pawn.def.defName == Utils.TX4 || ___pawn.def.defName == Utils.TX3I || ___pawn.def.defName == Utils.TX4I)
-                            {
-                                color = new Color(0f, 0.972549f, 0.972549f);
-                            }
+                    Vector3 b = quaternion * __instance.BaseHeadOffsetAt(facing);
+                    Vector3 loc = a + b + new Vector3(0f, 0.01f, 0f);
 
-                            // yeux rouges si drafté OU ennemis OU TX2K
-                            if (___pawn.Drafted || (___pawn.Faction != null && ___pawn.Faction.HostileTo(Faction.OfPlayer)) || ___pawn.def.defName == Utils.TX2K || ___pawn.def.defName == Utils.TX2KI)
-                                color = new Color(0.75f, 0f, 0f, 1f);
+                    Mesh mesh = facing == Rot4.West ? MeshPool.plane10Flip : MeshPool.plane10;
+                    bool isHorizontal = facing.IsHorizontal;
 
-                            string gender = "M";
-                            if (___pawn.gender == Gender.Female)
-                                gender = "F";
+                    int type = 1;
+                    if (cas != null && cas.TXHurtedHeadSet)
+                        type = 2;
+                    else if (cas != null && (cas.TXHurtedHeadSet2
+                        || pawn.def.defName == Utils.TX2I
+                        || pawn.def.defName == Utils.TX2KI
+                        || pawn.def.defName == Utils.TX3I
+                        || pawn.def.defName == Utils.TX4I))
+                        type = 3;
 
-                            if (isHorizontal)
-                            {
-                                GenDraw.DrawMeshNowOrLater(mesh, loc, quaternion, Tex.getEyeGlowEffect(color, gender, type, 0).MatSingle, true);
-                            }
-                            else
-                            {
-                                GenDraw.DrawMeshNowOrLater(mesh, loc, quaternion, Tex.getEyeGlowEffect(color, gender, type, 1).MatSingle, true);
-                            }
-                        }
-                    }
+                    Color color = new Color(0.9450f, 0.76862f, 0.05882f);
+
+                    if (pawn.def.defName == Utils.TX3 || pawn.def.defName == Utils.TX4
+                        || pawn.def.defName == Utils.TX3I || pawn.def.defName == Utils.TX4I)
+                        color = new Color(0f, 0.972549f, 0.972549f);
+
+                    if (pawn.Drafted
+                        || (pawn.Faction != null && pawn.Faction.HostileTo(Faction.OfPlayer))
+                        || pawn.def.defName == Utils.TX2K
+                        || pawn.def.defName == Utils.TX2KI)
+                        color = new Color(0.75f, 0f, 0f, 1f);
+
+                    string gender = pawn.gender == Gender.Female ? "F" : "M";
+
+                    if (isHorizontal)
+                        GenDraw.DrawMeshNowOrLater(mesh, loc, quaternion, Tex.getEyeGlowEffect(color, gender, type, 0).MatSingle, true);
+                    else
+                        GenDraw.DrawMeshNowOrLater(mesh, loc, quaternion, Tex.getEyeGlowEffect(color, gender, type, 1).MatSingle, true);
                 }
-                catch(Exception e)
+                catch (Exception e)
                 {
                     Log.Message("[ATPP] PawnRenderer.RenderPawnInternal " + e.Message + " " + e.StackTrace);
```

### Harmony/PawnUtility_Patch.cs
```diff
--- v1.3/Harmony/PawnUtility_Patch.cs
+++ v1.6/Harmony/PawnUtility_Patch.cs
@@ -1,3 +1,3 @@
-﻿using Verse;
+using Verse;
 using Verse.AI;
 using Verse.AI.Group;
```

### Harmony/PawnWoundDrawer_Patch.cs
```diff
--- v1.3/Harmony/PawnWoundDrawer_Patch.cs
+++ v1.6/Harmony/PawnWoundDrawer_Patch.cs
@@ -1,3 +1,3 @@
-﻿/*using Verse;
+/*using Verse;
 using Verse.AI;
 using Verse.AI.Group;
```

### Harmony/Pawn_DraftController_Patch.cs
```diff
--- v1.3/Harmony/Pawn_DraftController_Patch.cs
+++ v1.6/Harmony/Pawn_DraftController_Patch.cs
@@ -1,3 +1,3 @@
-﻿using Verse;
+using Verse;
 using Verse.AI;
 using Verse.AI.Group;
@@ -29,5 +29,5 @@
                         || (___pawn.def.defName == Utils.TX4 && (cas.TXHurtedHeadSet || cas.TXHurtedHeadSet2)))
                 {
-                    ___pawn.Drawer.renderer.graphics.ResolveAllGraphics();
+                    Utils.ResolvePawnGraphics(___pawn);
                 }
             }
```

### Harmony/Pawn_HealthTracker_Patch.cs
```diff
--- v1.3/Harmony/Pawn_HealthTracker_Patch.cs
+++ v1.6/Harmony/Pawn_HealthTracker_Patch.cs
@@ -1,3 +1,3 @@
-﻿using Verse;
+using Verse;
 using Verse.AI;
 using Verse.AI.Group;
@@ -78,14 +78,14 @@
                         {
                             //Reset child and adulthood
-                            if (!Settings.keepPuppetBackstory && ___pawn.story.childhood != null)
-                            {
-                                Backstory bs = null;
-
-                                BackstoryDatabase.TryGetWithIdentifier("MercenaryRecruit", out bs);
+                            if (!Settings.keepPuppetBackstory && ___pawn.story.Childhood != null)
+                            {
+                                BackstoryDef bs = null;
+
+                                bs = Utils.GetBackstoryByIdentifier("MercenaryRecruit", BackstorySlot.Childhood);
                                 if (bs != null)
-                                    ___pawn.story.childhood = bs;
-                            }
-
-                            ___pawn.story.adulthood = null;
+                                    ___pawn.story.Childhood = bs;
+                            }
+
+                            ___pawn.story.Adulthood = null;
                         }
 
@@ -101,5 +101,5 @@
                         {
                             //Addition of the thought of PUPPET
-                            foreach (Pawn current in PawnsFinder.AllMapsCaravansAndTravelingTransportPods_Alive_FreeColonistsAndPrisoners)
+                            foreach (Pawn current in PawnsFinder.AllMapsCaravansAndTravellingTransporters_Alive_FreeColonistsAndPrisoners)
                             {
                                 current.needs.mood.thoughts.memories.TryGainMemory(ThoughtMaker.MakeThought(Utils.thoughtDefVX0Puppet, 0), null);
@@ -364,3 +364,3 @@
         }*/
     }
-}+}
```

### Harmony/Pawn_InteractionsTracker_Patch.cs
```diff
--- v1.3/Harmony/Pawn_InteractionsTracker_Patch.cs
+++ v1.6/Harmony/Pawn_InteractionsTracker_Patch.cs
@@ -1,3 +1,3 @@
-﻿using Verse;
+using Verse;
 using Verse.AI;
 using Verse.AI.Group;
```

### Harmony/Pawn_NeedsTracker_Patch.cs
```diff
--- v1.3/Harmony/Pawn_NeedsTracker_Patch.cs
+++ v1.6/Harmony/Pawn_NeedsTracker_Patch.cs
@@ -1,3 +1,3 @@
-﻿using Verse;
+using Verse;
 using HarmonyLib;
 using RimWorld;
@@ -9,9 +9,32 @@
     {
         /*
-         * PostFix évitant d'attribuer de need comfort et outdoor aux T1 et T2 et l'hygiene a l'ensemble des robots
+         * PostFix evitando a atribuição de need comfort e outdoor aos T1 e T2 e a higiene a todos os robôs
          */
         [HarmonyPatch(typeof(Pawn_NeedsTracker), "ShouldHaveNeed")]
         public class ShouldHaveNeed_Patch
         {
+            [HarmonyPrefix]
+            public static bool Prefix(NeedDef nd, ref bool __result, Pawn ___pawn)
+            {
+                try
+                {
+                    if (___pawn != null
+                        && nd != null
+                        && ___pawn.IsAndroidTier()
+                        && nd.defName != null
+                        && nd.defName.StartsWith("Chemical_", StringComparison.Ordinal))
+                    {
+                        __result = false;
+                        return false;
+                    }
+                }
+                catch (Exception e)
+                {
+                    Log.Message("[ATPP] Pawn_StoryTracker.ShouldHaveNeed Prefix : " + e.Message + " - " + e.StackTrace);
+                }
+
+                return true;
+            }
+
             [HarmonyPostfix]
             public static void Listener(NeedDef nd, ref bool __result, Pawn ___pawn)
@@ -21,5 +44,5 @@
                     bool isAndroid = ___pawn.IsAndroidTier();
 
-                    //SI pas un androide on jerte
+                    //Se não for um androide, retorna
                     if (!isAndroid)
                         return;
@@ -62,3 +85,3 @@
         }*/
     }
-}+}
```

### Harmony/Pawn_Patch.cs
```diff
--- v1.3/Harmony/Pawn_Patch.cs
+++ v1.6/Harmony/Pawn_Patch.cs
@@ -1,3 +1,3 @@
-﻿using Verse;
+using Verse;
 using Verse.AI;
 using Verse.AI.Group;
@@ -26,5 +26,5 @@
                         Utils.insideKillFuncSurrogate = true;
 
-                        //Si c'est un surrogate controllé temporaire alors on le restitue a sa faction
+                        // Se for um surrogate controlado temporariamente, então ele é devolvido à sua facção
                         CompSkyMind csm = Utils.getCachedCSM(__instance);
                         if(csm != null)
@@ -34,20 +34,20 @@
                         }
                     }
-                    //disconnect killed user and dont broadcast the message
+                    // Desconecta o usuário morto e não transmite a mensagem
                     Utils.GCATPP.disconnectUser(__instance, false, false);
                     //Log.Message("YOU KILLED "+__instance.LabelCap);
-                    //Is surrogate android used ?
+                    // Se for um surrogate android usado
                     if (__instance.IsSurrogateAndroid(true))
                     {
-                        //Obtention controlleur
+                        // Obtenção do controlador
                         CompAndroidState cas = Utils.getCachedCAS(__instance);
                         if (cas == null)
                             return true;
 
-                        //Arret du mode de control chez le controller
+                        // Fim do modo de controle no controlador
                         CompSurrogateOwner cso = Utils.getCachedCSO(cas.surrogateController);
                         cso.stopControlledSurrogate(__instance,false, false, true);
 
-                        //On reset les données pour une potentiel futur resurection
+                        // Reset das variáveis para uma potencial ressurreição futura
                         cas.resetInternalState();
 
@@ -89,5 +89,5 @@
                             if (!activeConn)
                             {
-                                //Check if there are active minds/surrogate connections 
+                                // Verifica se há conexões ativas de mentes/surrogates
                                 foreach (var m in csc.storedMinds)
                                 {
@@ -101,5 +101,5 @@
                             }
 
-                            //Active connections then program a random disconnection
+                            // Se houver conexões ativas, então programe um desligamento aleatório
                             if (activeConn)
                             {
@@ -110,5 +110,5 @@
                     else if ((__instance.IsAndroidTier() || __instance.VXChipPresent() || __instance.IsSurrogateAndroid()))
                     {
-                        //On deconnecte l'user de force le cas echeant
+                        // Desconecta o usuário de força, se for o caso
                         Utils.GCATPP.disconnectUser(__instance);
                     }
@@ -134,5 +134,5 @@
         }
 
-        // Patch used to deregister from the mapPawns surrogates (only if the related setting is enabled) And register surrogate in the listerSurrogates
+        // Patch usado para remover surrogates da lista mapPawns (somente se a configuração relacionada estiver habilitada) E registrar surrogate na lista listerSurrogates
         [HarmonyPatch(typeof(Pawn), "SpawnSetup")]
         public class SpawnSetup_Patch
@@ -151,8 +151,8 @@
                         if (Settings.hideInactiveSurrogates)
                         {
-                            //Remove surrogate from main lists only if inactive surrogate
+                            // Remove surrogate da lista principal somente se for um surrogate inativo
                             if (cas.surrogateController == null)
                             {
-                                //hide only surrogate on player's map
+                                // Esconde somente surrogate no mapa do jogador
                                 if (map != null && map.IsPlayerHome)
                                     map.mapPawns.DeRegisterPawn(__instance);
@@ -161,8 +161,8 @@
                     }
                 }
-                //Set a fake rest need to prevent errors
+                // Define uma necessidade de descanso falsa para prevenir erros
                 if (__instance.IsAndroidTier() && __instance.needs != null)
                 {
-                    __instance.needs.rest = new Need_Rest_Fake(null);
+                    __instance.needs.rest = new Need_Rest_Fake(__instance);
                 }
             }
@@ -180,5 +180,5 @@
             public static void Listener(Pawn __instance, ref IEnumerable<Gizmo> __result)
             {
-                //Caching to increase performance on selected pawns
+                // Caching para aumentar o desempenho em pawns selecionados
                 if(__instance != Pawn_GetGizmosPrevPawn)
                 {
@@ -188,10 +188,17 @@
                 }
 
-                //Si prisonnier et possede une VX2 on va obtenir les GIZMOS associés OU virusé
+                // M7/M8 não expõem botões de habilidade do RimWorld, mas ainda precisam dos
+                // gizmos do Android Tiers anexados abaixo.
+                if (Utils.IsM7OrM8(__instance))
+                {
+                    __result = __result.Where(gizmo => gizmo == null || !(gizmo is Command_Ability));
+                }
+
+                // Se for prisioneiro e possuir um VX2, obteremos os GIZMOS associados OU infectados
                 if ((__instance.IsPrisoner) || (Pawn_GetGizmosPrevCSM != null && Pawn_GetGizmosPrevCSM.Hacked == 1))
                 {
                     IEnumerable<Gizmo> tmp;
-                    //Si posseseur d'une VX2
-
+
+                    // Se possuir uma VX2
                     if (__instance.VXChipPresent())
                     {
@@ -205,5 +212,5 @@
                     }
 
-                    //Si android prisonier ou virusé
+                    // Se for um android prisioneiro ou infectado
                     if (__instance.IsAndroidTier())
                     {
@@ -226,5 +233,5 @@
                 }
 
-                //Si animal posséder par player
+                // Se for um animal possuído pelo jogador
                 if (Pawn_GetGizmosPrevIsPoweredAnimalAndroids)
                 {
@@ -238,6 +245,62 @@
                     }
                 }
+
+                if (__instance.Faction == Faction.OfPlayer && !__instance.Dead && !__instance.Destroyed)
+                {
+                    CompSurrogateOwner cso = Utils.getCachedCSO(__instance);
+                    if (cso != null)
+                        __result = AppendUniqueGizmos(__result, cso.CompGetGizmosExtra());
+
+                    CompSkyMind csm = Utils.getCachedCSM(__instance);
+                    if (csm != null && csm.Hacked == -1)
+                        __result = AppendUniqueGizmos(__result, csm.CompGetGizmosExtra());
+
+                    CompAndroidState cas = Utils.getCachedCAS(__instance);
+                    if (cas != null)
+                        __result = AppendUniqueGizmos(__result, cas.CompGetGizmosExtra());
+
+                    CompSkyCloudCore csc = Utils.getCachedCSC(__instance);
+                    if (csc != null)
+                        __result = AppendUniqueGizmos(__result, csc.CompGetGizmosExtra());
+                }
+            }
+
+            private static IEnumerable<Gizmo> AppendUniqueGizmos(IEnumerable<Gizmo> baseGizmos, IEnumerable<Gizmo> extraGizmos)
+            {
+                if (extraGizmos == null)
+                    return baseGizmos;
+
+                List<Gizmo> gizmos = baseGizmos?.ToList() ?? new List<Gizmo>();
+
+                foreach (Gizmo gizmo in extraGizmos)
+                {
+                    if (gizmo == null || ContainsEquivalentGizmo(gizmos, gizmo))
+                        continue;
+
+                    gizmos.Add(gizmo);
+                }
+
+                return gizmos;
+            }
+
+            private static bool ContainsEquivalentGizmo(List<Gizmo> gizmos, Gizmo candidate)
+            {
+                Command candidateCommand = candidate as Command;
+                if (candidateCommand == null)
+                    return gizmos.Contains(candidate);
+
+                foreach (Gizmo gizmo in gizmos)
+                {
+                    Command command = gizmo as Command;
+                    if (command == null)
+                        continue;
+
+                    if (command.GetType() == candidateCommand.GetType() && command.defaultLabel == candidateCommand.defaultLabel)
+                        return true;
+                }
+
+                return false;
             }
         }
     }
-}+}
```

### Harmony/Pawn_StoryTracker_Patch.cs
```diff
--- v1.3/Harmony/Pawn_StoryTracker_Patch.cs
+++ v1.6/Harmony/Pawn_StoryTracker_Patch.cs
@@ -1,3 +1,3 @@
-﻿using Verse;
+using Verse;
 using Verse.AI;
 using Verse.AI.Group;
```

### Harmony/Pawn_StyleTracker_Patch.cs
```diff
--- v1.3/Harmony/Pawn_StyleTracker_Patch.cs
+++ v1.6/Harmony/Pawn_StyleTracker_Patch.cs
@@ -1,3 +1,3 @@
-﻿using Verse;
+using Verse;
 using HarmonyLib;
 using RimWorld;
```

### Harmony/Precept_Ritual_Patch.cs
```diff
--- v1.3/Harmony/Precept_Ritual_Patch.cs
+++ v1.6/Harmony/Precept_Ritual_Patch.cs
@@ -1,3 +1,3 @@
-﻿using Verse;
+using Verse;
 using Verse.AI;
 using Verse.AI.Group;
```

### Harmony/Pregnancy_ChildGrowth_Patch.cs
- **Novo arquivo na versão 1.6**

### Harmony/RaceProperties_Patch.cs
```diff
--- v1.3/Harmony/RaceProperties_Patch.cs
+++ v1.6/Harmony/RaceProperties_Patch.cs
@@ -1,3 +1,3 @@
-﻿using Verse;
+using Verse;
 using Verse.AI;
 using Verse.AI.Group;
```

### Harmony/Recipe_InstallImplant_Patch.cs
```diff
--- v1.3/Harmony/Recipe_InstallImplant_Patch.cs
+++ v1.6/Harmony/Recipe_InstallImplant_Patch.cs
@@ -1,3 +1,3 @@
-﻿using Verse;
+using Verse;
 using Verse.AI;
 using Verse.AI.Group;
```

### Harmony/RestUtility_Patch.cs
```diff
--- v1.3/Harmony/RestUtility_Patch.cs
+++ v1.6/Harmony/RestUtility_Patch.cs
@@ -1,3 +1,3 @@
-﻿using Verse;
+using Verse;
 using Verse.AI;
 using Verse.AI.Group;
```

### Harmony/RitualRoleConvertee_Patch.cs
```diff
--- v1.3/Harmony/RitualRoleConvertee_Patch.cs
+++ v1.6/Harmony/RitualRoleConvertee_Patch.cs
@@ -1,3 +1,3 @@
-﻿using Verse;
+using Verse;
 using Verse.AI;
 using Verse.AI.Group;
```

### Harmony/SickPawnVisitUtility_Patch.cs
```diff
--- v1.3/Harmony/SickPawnVisitUtility_Patch.cs
+++ v1.6/Harmony/SickPawnVisitUtility_Patch.cs
@@ -1,3 +1,3 @@
-﻿using Verse;
+using Verse;
 using Verse.AI;
 using Verse.AI.Group;
```

### Harmony/SkillRecord_Patch.cs
```diff
--- v1.3/Harmony/SkillRecord_Patch.cs
+++ v1.6/Harmony/SkillRecord_Patch.cs
@@ -1,3 +1,3 @@
-﻿using Verse;
+using Verse;
 using Verse.AI;
 using Verse.AI.Group;
```

### Harmony/StartingPawnUtility_Patch.cs
```diff
--- v1.3/Harmony/StartingPawnUtility_Patch.cs
+++ v1.6/Harmony/StartingPawnUtility_Patch.cs
@@ -1,3 +1,3 @@
-﻿using Verse;
+using Verse;
 using Verse.AI;
 using Verse.AI.Group;
@@ -13,7 +13,127 @@
 
     {
+        [HarmonyPatch(typeof(ScenPart_ConfigPage_ConfigureStartingPawns), "GenerateStartingPawns")]
+        public class GenerateAndroidStartingPawnRequests_Patch
+        {
+            [HarmonyPostfix]
+            public static void Listener(ScenPart_ConfigPage_ConfigureStartingPawns __instance)
+            {
+                try
+                {
+                    if (!Utils.IsAndroidPlayerScenario())
+                        return;
+
+                    FactionDef factionDef = Utils.CurrentScenarioPlayerFactionDef();
+                    if (factionDef == null)
+                        return;
+
+                    int pawnCount = Traverse.Create(__instance).Field("pawnCount").GetValue<int>();
+                    int pawnChoiceCount = Traverse.Create(__instance).Field("pawnChoiceCount").GetValue<int>();
+                    if (pawnChoiceCount < pawnCount)
+                        pawnChoiceCount = pawnCount;
+
+                    List<PawnKindDef> selectedKinds = AndroidScenarioSelectedKinds(factionDef.defName, pawnCount);
+                    List<PawnKindDef> choicePool = AndroidScenarioChoicePool(factionDef.defName);
+
+                    if (selectedKinds.Count == 0 || choicePool.Count == 0)
+                        return;
+
+                    List<PawnGenerationRequest> requests = new List<PawnGenerationRequest>();
+                    foreach (PawnKindDef kind in selectedKinds)
+                        requests.Add(AndroidStarterRequest(kind));
+
+                    while (requests.Count < pawnChoiceCount)
+                        requests.Add(AndroidStarterRequest(choicePool.RandomElement()));
+
+                    Traverse.Create(typeof(StartingPawnUtility)).Field("StartingAndOptionalPawnGenerationRequests").SetValue(requests);
+                }
+                catch (Exception e)
+                {
+                    Log.Error("[ATPP] ScenPart_ConfigPage_ConfigureStartingPawns.GenerateStartingPawns " + e.Message + " " + e.StackTrace);
+                }
+            }
+
+            private static PawnGenerationRequest AndroidStarterRequest(PawnKindDef kind)
+            {
+                return Utils.NewPawnGenerationRequest(kind, Faction.OfPlayer, PawnGenerationContext.PlayerStarter, -1, true, false, false, false, true, TutorSystem.TutorialMode, 20f, false, true, true, false, false, false, false);
+            }
+
+            private static List<PawnKindDef> AndroidScenarioSelectedKinds(string factionDefName, int pawnCount)
+            {
+                List<PawnKindDef> kinds = new List<PawnKindDef>();
+                if (factionDefName == "PlayerColonyAndroid")
+                {
+                    AddKind(kinds, "AndroidT1ColonistGeneral");
+                    AddKind(kinds, "AndroidT2ColonistGeneral");
+                    AddKind(kinds, "AndroidT3ColonistGeneral");
+                }
+                else if (factionDefName == "AndroidTiers_PlayerColonyROM")
+                {
+                    AddKind(kinds, "AndroidT4ColonistGeneral");
+                }
+                else if (factionDefName == "AndroidTiers_PlayerColonyApocalypse")
+                {
+                    AddKind(kinds, "M8MechPawn");
+                }
+
+                List<PawnKindDef> pool = AndroidScenarioChoicePool(factionDefName);
+                while (kinds.Count < pawnCount && pool.Count != 0)
+                    kinds.Add(pool.RandomElement());
+
+                if (kinds.Count > pawnCount)
+                    kinds.RemoveRange(pawnCount, kinds.Count - pawnCount);
+
+                return kinds;
+            }
+
+            private static List<PawnKindDef> AndroidScenarioChoicePool(string factionDefName)
+            {
+                List<PawnKindDef> kinds = new List<PawnKindDef>();
+                if (factionDefName == "PlayerColonyAndroid")
+                {
+                    AddKind(kinds, "AndroidT1ColonistGeneral");
+                    AddKind(kinds, "AndroidT1ColonistGeneral");
+                    AddKind(kinds, "AndroidT2ColonistGeneral");
+                    AddKind(kinds, "AndroidT2ColonistGeneral");
+                    AddKind(kinds, "AndroidT3ColonistGeneral");
+                    AddKind(kinds, "AndroidT4ColonistGeneral");
+                }
+                else if (factionDefName == "AndroidTiers_PlayerColonyROM")
+                {
+                    AddKind(kinds, "AndroidT2ColonistGeneral");
+                    AddKind(kinds, "AndroidT3ColonistGeneral");
+                    AddKind(kinds, "AndroidT3ColonistGeneral");
+                    AddKind(kinds, "AndroidT4ColonistGeneral");
+                    AddKind(kinds, "AndroidT4ColonistGeneral");
+                }
+                else if (factionDefName == "AndroidTiers_PlayerColonyApocalypse")
+                {
+                    AddKind(kinds, "M8MechPawn");
+                    AddKind(kinds, "M8MechPawn");
+                    AddKind(kinds, "AndroidT1ColonistGeneral");
+                    AddKind(kinds, "AndroidT2ColonistGeneral");
+                    AddKind(kinds, "AndroidT3ColonistGeneral");
+                    AddKind(kinds, "AndroidT4ColonistGeneral");
+                }
+
+                return kinds;
+            }
+
+            private static void AddKind(List<PawnKindDef> kinds, string defName)
+            {
+                PawnKindDef kind = DefDatabase<PawnKindDef>.GetNamedSilentFail(defName);
+                if (kind != null)
+                    kinds.Add(kind);
+            }
+        }
+
         [HarmonyPatch(typeof(StartingPawnUtility), "NewGeneratedStartingPawn")]
         public class NewGeneratedStartingPawn_Patch
         {
+            public static bool Prepare()
+            {
+                return false;
+            }
+
             [HarmonyAfter(new string[] { "rimworld.rwmods.androidtiers" })]
             [HarmonyPostfix]
@@ -69,5 +189,5 @@
                         }
                     }
-                    request = new PawnGenerationRequest(DefDatabase<PawnKindDef>.GetNamed(pkd, false), Faction.OfPlayer, PawnGenerationContext.PlayerStarter, -1, true, false, false, false, true, TutorSystem.TutorialMode, 20f, false, true, true, false, false, false, false);
+                    request = Utils.NewPawnGenerationRequest(DefDatabase<PawnKindDef>.GetNamed(pkd, false), Faction.OfPlayer, PawnGenerationContext.PlayerStarter, -1, true, false, false, false, true, TutorSystem.TutorialMode, 20f, false, true, true, false, false, false, false);
                     __result = null;
                     try
@@ -86,3 +206,3 @@
         }
     }
-}+}
```

### Harmony/StorytellerComp_Triggered_Patch.cs
```diff
--- v1.3/Harmony/StorytellerComp_Triggered_Patch.cs
+++ v1.6/Harmony/StorytellerComp_Triggered_Patch.cs
@@ -1,3 +1,3 @@
-﻿/*using System.Collections.Generic;
+/*using System.Collections.Generic;
 using System.Linq;
 using System;
```

### Harmony/StunHandler_Patch.cs
```diff
--- v1.3/Harmony/StunHandler_Patch.cs
+++ v1.6/Harmony/StunHandler_Patch.cs
@@ -1,3 +1,3 @@
-﻿using Verse;
+using Verse;
 using Verse.AI;
 using Verse.AI.Group;
@@ -7,4 +7,5 @@
 using System.Linq;
 using System;
+using System.Reflection;
 
 namespace MOARANDROIDS
@@ -14,10 +15,18 @@
     {
 
-        [HarmonyPatch(typeof(StunHandler), "get_AffectedByEMP")]
+        [HarmonyPatch]
         public class get_AffectedByEMP_Patch
         {
+            public static MethodBase TargetMethod()
+            {
+                return AccessTools.Method(typeof(StunHandler), "CanBeStunnedByDamage");
+            }
+
             [HarmonyPostfix]
-            public static void Listener(ref bool __result, Thing ___parent)
+            public static void Listener(DamageDef def, ref bool __result, Thing ___parent)
             {
+                if (def != DamageDefOf.EMP)
+                    return;
+
                 if (___parent is Pawn)
                 {
@@ -31,3 +40,3 @@
         }
     }
-}+}
```

### Harmony/TaleRecorder_Patch.cs
```diff
--- v1.3/Harmony/TaleRecorder_Patch.cs
+++ v1.6/Harmony/TaleRecorder_Patch.cs
@@ -1,3 +1,3 @@
-﻿using Verse;
+using Verse;
 using Verse.AI;
 using Verse.AI.Group;
```

### Harmony/TaleUtility_Patch.cs
```diff
--- v1.3/Harmony/TaleUtility_Patch.cs
+++ v1.6/Harmony/TaleUtility_Patch.cs
@@ -1,3 +1,3 @@
-﻿using Verse;
+using Verse;
 using Verse.AI;
 using Verse.AI.Group;
```

### Harmony/TendUtility_Patch.cs
```diff
--- v1.3/Harmony/TendUtility_Patch.cs
+++ v1.6/Harmony/TendUtility_Patch.cs
@@ -1,3 +1,3 @@
-﻿using Verse;
+using Verse;
 using Verse.AI;
 using Verse.AI.Group;
```

### Harmony/ThinkNode_ConditionalNeedPercentageAbove_Patch.cs
```diff
--- v1.3/Harmony/ThinkNode_ConditionalNeedPercentageAbove_Patch.cs
+++ v1.6/Harmony/ThinkNode_ConditionalNeedPercentageAbove_Patch.cs
@@ -1,3 +1,3 @@
-﻿using Verse;
+using Verse;
 using Verse.AI;
 using Verse.AI.Group;
```

### Harmony/ThoughtUtility_Patch.cs
```diff
--- v1.3/Harmony/ThoughtUtility_Patch.cs
+++ v1.6/Harmony/ThoughtUtility_Patch.cs
@@ -1,3 +1,3 @@
-﻿using Verse;
+using Verse;
 using Verse.AI;
 using Verse.AI.Group;
```

### Harmony/ThoughtWorker_AgeReversalDemanded_Patch.cs
```diff
--- v1.3/Harmony/ThoughtWorker_AgeReversalDemanded_Patch.cs
+++ v1.6/Harmony/ThoughtWorker_AgeReversalDemanded_Patch.cs
@@ -1,3 +1,3 @@
-﻿using Verse;
+using Verse;
 using Verse.AI;
 using Verse.AI.Group;
```

### Harmony/ThoughtWorker_ApparelDamaged_Patch.cs
```diff
--- v1.3/Harmony/ThoughtWorker_ApparelDamaged_Patch.cs
+++ v1.6/Harmony/ThoughtWorker_ApparelDamaged_Patch.cs
@@ -1,3 +1,3 @@
-﻿using Verse;
+using Verse;
 using Verse.AI;
 using Verse.AI.Group;
```

### Harmony/ThoughtWorker_BondedAnimalMaster_Patch.cs
```diff
--- v1.3/Harmony/ThoughtWorker_BondedAnimalMaster_Patch.cs
+++ v1.6/Harmony/ThoughtWorker_BondedAnimalMaster_Patch.cs
@@ -1,3 +1,3 @@
-﻿using Verse;
+using Verse;
 using Verse.AI;
 using Verse.AI.Group;
```

### Harmony/ThoughtWorker_Cold_Patch.cs
```diff
--- v1.3/Harmony/ThoughtWorker_Cold_Patch.cs
+++ v1.6/Harmony/ThoughtWorker_Cold_Patch.cs
@@ -1,3 +1,3 @@
-﻿/*using Verse;
+/*using Verse;
 using Verse.AI;
 using Verse.AI.Group;
```

### Harmony/ThoughtWorker_ColonistLeftUnburied_Patch.cs
```diff
--- v1.3/Harmony/ThoughtWorker_ColonistLeftUnburied_Patch.cs
+++ v1.6/Harmony/ThoughtWorker_ColonistLeftUnburied_Patch.cs
@@ -1,3 +1,3 @@
-﻿using Verse;
+using Verse;
 using Verse.AI;
 using Verse.AI.Group;
```

### Harmony/ThoughtWorker_Dark_Patch.cs
```diff
--- v1.3/Harmony/ThoughtWorker_Dark_Patch.cs
+++ v1.6/Harmony/ThoughtWorker_Dark_Patch.cs
@@ -1,3 +1,3 @@
-﻿using Verse;
+using Verse;
 using Verse.AI;
 using Verse.AI.Group;
```

### Harmony/ThoughtWorker_Expectations.cs
```diff
--- v1.3/Harmony/ThoughtWorker_Expectations.cs
+++ v1.6/Harmony/ThoughtWorker_Expectations.cs
@@ -1,3 +1,3 @@
-﻿using Verse;
+using Verse;
 using Verse.AI;
 using Verse.AI.Group;
```

### Harmony/ThoughtWorker_Greedy_Patch.cs
```diff
--- v1.3/Harmony/ThoughtWorker_Greedy_Patch.cs
+++ v1.6/Harmony/ThoughtWorker_Greedy_Patch.cs
@@ -1,3 +1,3 @@
-﻿using Verse;
+using Verse;
 using Verse.AI;
 using Verse.AI.Group;
```

### Harmony/ThoughtWorker_Hot_Patch.cs
```diff
--- v1.3/Harmony/ThoughtWorker_Hot_Patch.cs
+++ v1.6/Harmony/ThoughtWorker_Hot_Patch.cs
@@ -1,3 +1,3 @@
-﻿/*using Verse;
+/*using Verse;
 using Verse.AI;
 using Verse.AI.Group;
```

### Harmony/ThoughtWorker_HumanLeatherApparel_Patch.cs
```diff
--- v1.3/Harmony/ThoughtWorker_HumanLeatherApparel_Patch.cs
+++ v1.6/Harmony/ThoughtWorker_HumanLeatherApparel_Patch.cs
@@ -1,3 +1,3 @@
-﻿using Verse;
+using Verse;
 using Verse.AI;
 using Verse.AI.Group;
```

### Harmony/ThoughtWorker_LookChangeDesired_Patch.cs
```diff
--- v1.3/Harmony/ThoughtWorker_LookChangeDesired_Patch.cs
+++ v1.6/Harmony/ThoughtWorker_LookChangeDesired_Patch.cs
@@ -1,3 +1,3 @@
-﻿using Verse;
+using Verse;
 using Verse.AI;
 using Verse.AI.Group;
```

### Harmony/ThoughtWorker_MasochistWearingBodyStrap_Patch.cs
```diff
--- v1.3/Harmony/ThoughtWorker_MasochistWearingBodyStrap_Patch.cs
+++ v1.6/Harmony/ThoughtWorker_MasochistWearingBodyStrap_Patch.cs
@@ -1,3 +1,3 @@
-﻿using Verse;
+using Verse;
 using Verse.AI;
 using Verse.AI.Group;
```

### Harmony/ThoughtWorker_MasochistWearingCollar_Patch.cs
```diff
--- v1.3/Harmony/ThoughtWorker_MasochistWearingCollar_Patch.cs
+++ v1.6/Harmony/ThoughtWorker_MasochistWearingCollar_Patch.cs
@@ -1,3 +1,3 @@
-﻿using Verse;
+using Verse;
 using Verse.AI;
 using Verse.AI.Group;
```

### Harmony/ThoughtWorker_NeedFood_Patch.cs
```diff
--- v1.3/Harmony/ThoughtWorker_NeedFood_Patch.cs
+++ v1.6/Harmony/ThoughtWorker_NeedFood_Patch.cs
@@ -1,3 +1,3 @@
-﻿using Verse;
+using Verse;
 using Verse.AI;
 using Verse.AI.Group;
```

### Harmony/ThoughtWorker_NeedJoy_Patch.cs
```diff
--- v1.3/Harmony/ThoughtWorker_NeedJoy_Patch.cs
+++ v1.6/Harmony/ThoughtWorker_NeedJoy_Patch.cs
@@ -1,3 +1,3 @@
-﻿using Verse;
+using Verse;
 using Verse.AI;
 using Verse.AI.Group;
```

### Harmony/ThoughtWorker_NeedNeuralSupercharge_Patch.cs
```diff
--- v1.3/Harmony/ThoughtWorker_NeedNeuralSupercharge_Patch.cs
+++ v1.6/Harmony/ThoughtWorker_NeedNeuralSupercharge_Patch.cs
@@ -1,3 +1,3 @@
-﻿using Verse;
+using Verse;
 using Verse.AI;
 using Verse.AI.Group;
```

### Harmony/ThoughtWorker_NeedRest_Patch.cs
```diff
--- v1.3/Harmony/ThoughtWorker_NeedRest_Patch.cs
+++ v1.6/Harmony/ThoughtWorker_NeedRest_Patch.cs
@@ -1,3 +1,3 @@
-﻿using Verse;
+using Verse;
 using Verse.AI;
 using Verse.AI.Group;
```

### Harmony/ThoughtWorker_Precept_GroinOrChestUncovered_Patch.cs
```diff
--- v1.3/Harmony/ThoughtWorker_Precept_GroinOrChestUncovered_Patch.cs
+++ v1.6/Harmony/ThoughtWorker_Precept_GroinOrChestUncovered_Patch.cs
@@ -1,3 +1,3 @@
-﻿using Verse;
+using Verse;
 using Verse.AI;
 using Verse.AI.Group;
```

### Harmony/ThoughtWorker_Precept_GroinUncovered_Patch.cs
```diff
--- v1.3/Harmony/ThoughtWorker_Precept_GroinUncovered_Patch.cs
+++ v1.6/Harmony/ThoughtWorker_Precept_GroinUncovered_Patch.cs
@@ -1,3 +1,3 @@
-﻿using Verse;
+using Verse;
 using Verse.AI;
 using Verse.AI.Group;
```

### Harmony/ThoughtWorker_Precept_HasNoProsthetic_Patch.cs
```diff
--- v1.3/Harmony/ThoughtWorker_Precept_HasNoProsthetic_Patch.cs
+++ v1.6/Harmony/ThoughtWorker_Precept_HasNoProsthetic_Patch.cs
@@ -1,3 +1,3 @@
-﻿using Verse;
+using Verse;
 using Verse.AI;
 using Verse.AI.Group;
```

### Harmony/ThoughtWorker_Precept_IdeoDiversity_Patch.cs
```diff
--- v1.3/Harmony/ThoughtWorker_Precept_IdeoDiversity_Patch.cs
+++ v1.6/Harmony/ThoughtWorker_Precept_IdeoDiversity_Patch.cs
@@ -1,3 +1,3 @@
-﻿using Verse;
+using Verse;
 using Verse.AI;
 using Verse.AI.Group;
```

### Harmony/ThoughtWorker_Precept_IdeoDiversity_Uniform_Patch.cs
```diff
--- v1.3/Harmony/ThoughtWorker_Precept_IdeoDiversity_Uniform_Patch.cs
+++ v1.6/Harmony/ThoughtWorker_Precept_IdeoDiversity_Uniform_Patch.cs
@@ -1,3 +1,3 @@
-﻿using Verse;
+using Verse;
 using Verse.AI;
 using Verse.AI.Group;
```

### Harmony/ThoughtWorker_Precept_Patch.cs
```diff
--- v1.3/Harmony/ThoughtWorker_Precept_Patch.cs
+++ v1.6/Harmony/ThoughtWorker_Precept_Patch.cs
@@ -1,3 +1,3 @@
-﻿using Verse;
+using Verse;
 using Verse.AI;
 using Verse.AI.Group;
```

### Harmony/ThoughtWorker_Precept_Social_Patch.cs
```diff
--- v1.3/Harmony/ThoughtWorker_Precept_Social_Patch.cs
+++ v1.6/Harmony/ThoughtWorker_Precept_Social_Patch.cs
@@ -1,3 +1,3 @@
-﻿using Verse;
+using Verse;
 using Verse.AI;
 using Verse.AI.Group;
```

### Harmony/ThoughtWorker_PsychicArchotechEmanator_Patch.cs
```diff
--- v1.3/Harmony/ThoughtWorker_PsychicArchotechEmanator_Patch.cs
+++ v1.6/Harmony/ThoughtWorker_PsychicArchotechEmanator_Patch.cs
@@ -1,3 +1,3 @@
-﻿using Verse;
+using Verse;
 using Verse.AI;
 using Verse.AI.Group;
```

### Harmony/ThoughtWorker_PsychicDrone_Patch.cs
```diff
--- v1.3/Harmony/ThoughtWorker_PsychicDrone_Patch.cs
+++ v1.6/Harmony/ThoughtWorker_PsychicDrone_Patch.cs
@@ -1,3 +1,3 @@
-﻿using Verse;
+using Verse;
 using Verse.AI;
 using Verse.AI.Group;
```

### Harmony/ThoughtWorker_PsychicEmanatorSoothe_Patch.cs
```diff
--- v1.3/Harmony/ThoughtWorker_PsychicEmanatorSoothe_Patch.cs
+++ v1.6/Harmony/ThoughtWorker_PsychicEmanatorSoothe_Patch.cs
@@ -1,3 +1,3 @@
-﻿using Verse;
+using Verse;
 using Verse.AI;
 using Verse.AI.Group;
```

### Harmony/ThoughtWorker_SharedBed_Patch.cs
```diff
--- v1.3/Harmony/ThoughtWorker_SharedBed_Patch.cs
+++ v1.6/Harmony/ThoughtWorker_SharedBed_Patch.cs
@@ -1,3 +1,3 @@
-﻿using Verse;
+using Verse;
 using Verse.AI;
 using Verse.AI.Group;
```

### Harmony/ThoughtWorker_WantToSleepWithSpouseOrLover_Patch.cs
```diff
--- v1.3/Harmony/ThoughtWorker_WantToSleepWithSpouseOrLover_Patch.cs
+++ v1.6/Harmony/ThoughtWorker_WantToSleepWithSpouseOrLover_Patch.cs
@@ -1,3 +1,3 @@
-﻿using Verse;
+using Verse;
 using Verse.AI;
 using Verse.AI.Group;
```

### Harmony/ThoughtWorker_WearingColor_Patch.cs
```diff
--- v1.3/Harmony/ThoughtWorker_WearingColor_Patch.cs
+++ v1.6/Harmony/ThoughtWorker_WearingColor_Patch.cs
@@ -1,3 +1,3 @@
-﻿using Verse;
+using Verse;
 using Verse.AI;
 using Verse.AI.Group;
```

### Harmony/Thought_IdeoDisrespectedBuilding_Patch.cs
```diff
--- v1.3/Harmony/Thought_IdeoDisrespectedBuilding_Patch.cs
+++ v1.6/Harmony/Thought_IdeoDisrespectedBuilding_Patch.cs
@@ -1,3 +1,3 @@
-﻿using Verse;
+using Verse;
 using Verse.AI;
 using Verse.AI.Group;
```

### Harmony/Thought_IdeoMissingBuilding_Patch.cs
```diff
--- v1.3/Harmony/Thought_IdeoMissingBuilding_Patch.cs
+++ v1.6/Harmony/Thought_IdeoMissingBuilding_Patch.cs
@@ -1,3 +1,3 @@
-﻿using Verse;
+using Verse;
 using Verse.AI;
 using Verse.AI.Group;
```

### Harmony/Thought_IdeoRoleApparelRequirementNotMet_Patch.cs
```diff
--- v1.3/Harmony/Thought_IdeoRoleApparelRequirementNotMet_Patch.cs
+++ v1.6/Harmony/Thought_IdeoRoleApparelRequirementNotMet_Patch.cs
@@ -1,3 +1,3 @@
-﻿using Verse;
+using Verse;
 using Verse.AI;
 using Verse.AI.Group;
```

### Harmony/Thought_IdeoRoleEmpty_Patch.cs
```diff
--- v1.3/Harmony/Thought_IdeoRoleEmpty_Patch.cs
+++ v1.6/Harmony/Thought_IdeoRoleEmpty_Patch.cs
@@ -1,3 +1,3 @@
-﻿using Verse;
+using Verse;
 using Verse.AI;
 using Verse.AI.Group;
```

### Harmony/ToilEffects_Patch.cs
```diff
--- v1.3/Harmony/ToilEffects_Patch.cs
+++ v1.6/Harmony/ToilEffects_Patch.cs
@@ -1,3 +1,3 @@
-﻿using Verse;
+using Verse;
 using Verse.AI;
 using Verse.AI.Group;
```

### Harmony/Toils_Tend_Patch.cs
```diff
--- v1.3/Harmony/Toils_Tend_Patch.cs
+++ v1.6/Harmony/Toils_Tend_Patch.cs
@@ -1,3 +1,3 @@
-﻿using Verse;
+using Verse;
 using Verse.AI;
 using Verse.AI.Group;
```

### Harmony/WorkGiver_DoBill_Patch.cs
```diff
--- v1.3/Harmony/WorkGiver_DoBill_Patch.cs
+++ v1.6/Harmony/WorkGiver_DoBill_Patch.cs
@@ -1,3 +1,3 @@
-﻿using Verse;
+using Verse;
 using Verse.AI;
 using Verse.AI.Group;
```

### Harmony/WorkGiver_FeedPatient_Patch.cs
```diff
--- v1.3/Harmony/WorkGiver_FeedPatient_Patch.cs
+++ v1.6/Harmony/WorkGiver_FeedPatient_Patch.cs
@@ -1,3 +1,3 @@
-﻿using Verse;
+using Verse;
 using Verse.AI;
 using Verse.AI.Group;
```

### Harmony/WorkGiver_RescueDowned_Patch.cs
```diff
--- v1.3/Harmony/WorkGiver_RescueDowned_Patch.cs
+++ v1.6/Harmony/WorkGiver_RescueDowned_Patch.cs
@@ -1,3 +1,3 @@
-﻿using Verse;
+using Verse;
 using Verse.AI;
 using Verse.AI.Group;
```

### Harmony/WorkGiver_TakeToBedToOperate_Patch.cs
```diff
--- v1.3/Harmony/WorkGiver_TakeToBedToOperate_Patch.cs
+++ v1.6/Harmony/WorkGiver_TakeToBedToOperate_Patch.cs
@@ -1,3 +1,3 @@
-﻿using Verse;
+using Verse;
 using Verse.AI;
 using Verse.AI.Group;
```

### Harmony/WorkGiver_TendOtherUrgent_Patch.cs
```diff
--- v1.3/Harmony/WorkGiver_TendOtherUrgent_Patch.cs
+++ v1.6/Harmony/WorkGiver_TendOtherUrgent_Patch.cs
@@ -1,3 +1,3 @@
-﻿using Verse;
+using Verse;
 using Verse.AI;
 using Verse.AI.Group;
```

### Harmony/WorkGiver_TendOther_Patch.cs
```diff
--- v1.3/Harmony/WorkGiver_TendOther_Patch.cs
+++ v1.6/Harmony/WorkGiver_TendOther_Patch.cs
@@ -1,3 +1,3 @@
-﻿using Verse;
+using Verse;
 using Verse.AI;
 using Verse.AI.Group;
```

### Harmony/WorkGiver_TendSelf_Patch.cs
```diff
--- v1.3/Harmony/WorkGiver_TendSelf_Patch.cs
+++ v1.6/Harmony/WorkGiver_TendSelf_Patch.cs
@@ -1,3 +1,3 @@
-﻿using Verse;
+using Verse;
 using Verse.AI;
 using Verse.AI.Group;
```

### Harmony/WorkGiver_VisitSickPawn_Patch.cs
```diff
--- v1.3/Harmony/WorkGiver_VisitSickPawn_Patch.cs
+++ v1.6/Harmony/WorkGiver_VisitSickPawn_Patch.cs
@@ -1,3 +1,3 @@
-﻿using Verse;
+using Verse;
 using Verse.AI;
 using Verse.AI.Group;
```

### Hediffs/HealOldWoundsAdv.cs
```diff
--- v1.3/Hediffs/HealOldWoundsAdv.cs
+++ v1.6/Hediffs/HealOldWoundsAdv.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using System.Collections.Generic;
 using System.Linq;
```

### Hediffs/HediffCompProperties_HealOldWoundsAdv.cs
```diff
--- v1.3/Hediffs/HediffCompProperties_HealOldWoundsAdv.cs
+++ v1.6/Hediffs/HediffCompProperties_HealOldWoundsAdv.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using Verse;
 
```

### Hediffs/HediffGiver_Android.cs
```diff
--- v1.3/Hediffs/HediffGiver_Android.cs
+++ v1.6/Hediffs/HediffGiver_Android.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using System.Collections.Generic;
 using UnityEngine;
```

### Hediffs/Hediff_AssistingMinds.cs
```diff
--- v1.3/Hediffs/Hediff_AssistingMinds.cs
+++ v1.6/Hediffs/Hediff_AssistingMinds.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using System.Collections.Generic;
 using System.Text;
```

### Hediffs/Hediff_Fractal.cs
```diff
--- v1.3/Hediffs/Hediff_Fractal.cs
+++ v1.6/Hediffs/Hediff_Fractal.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using System.Collections.Generic;
 using System.Text;
@@ -184,10 +184,10 @@
             }
 
-            public override void Notify_PawnDied()
-            {
-                base.Notify_PawnDied();
+            public override void Notify_PawnDied(DamageInfo? dinfo, Hediff culprit)
+            {
+                base.Notify_PawnDied(dinfo, culprit);
                 for (int i = 0; i < this.comps.Count; i++)
                 {
-                    this.comps[i].Notify_PawnDied();
+                    this.comps[i].Notify_PawnDied(dinfo, culprit);
                 }
             }
@@ -299,5 +299,5 @@
                 Find.LetterStack.ReceiveLetter(label, text, LetterDefOf.NegativeEvent, premutant, null);
 
-            PawnGenerationRequest request = new PawnGenerationRequest(PawnKindDefOf.AbominationAtlas, Faction.OfMechanoids, PawnGenerationContext.NonPlayer, -1, false, true, false, false, true, false, 1f, false, true, true, false, false, false, false);
+            PawnGenerationRequest request = Utils.NewPawnGenerationRequest(PawnKindDefOf.AbominationAtlas, Faction.OfMechanoids, PawnGenerationContext.NonPlayer, -1, false, true, false, false, true, false, 1f, false, true, true, false, false, false, false);
             Pawn pawn = PawnGenerator.GeneratePawn(request);
             FilthMaker.TryMakeFilth(premutant.Position, premutant.Map, RimWorld.ThingDefOf.Filth_AmnioticFluid, premutant.LabelIndefinite(), 10);
@@ -305,5 +305,5 @@
 
             GenSpawn.Spawn(pawn, premutant.Position, premutant.Map);
-            pawn.mindState.mentalStateHandler.TryStartMentalState(RimWorld.MentalStateDefOf.ManhunterPermanent, null, true, false, null);
+            pawn.mindState.mentalStateHandler.TryStartMentalState(RimWorld.MentalStateDefOf.ManhunterPermanent, forced: true, forceWake: false);
         }
     }
```

### Hediffs/Hediff_LowNetworkSignal.cs
```diff
--- v1.3/Hediffs/Hediff_LowNetworkSignal.cs
+++ v1.6/Hediffs/Hediff_LowNetworkSignal.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using System.Collections.Generic;
 using System.Text;
```

### Hediffs/Hediff_SolarFlare.cs
```diff
--- v1.3/Hediffs/Hediff_SolarFlare.cs
+++ v1.6/Hediffs/Hediff_SolarFlare.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using System.Collections.Generic;
 using System.Text;
@@ -60,5 +60,5 @@
                     executorGT = curGT + Rand.Range(360, 900);
 
-                    if (Find.World.gameConditionManager.ConditionIsActive(GameConditionDefOf.SolarFlare) || (pawn.Map != null && pawn.Map.GameConditionManager.ConditionIsActive(GameConditionDefOf.EMIField))
+                    if (Find.World.gameConditionManager.ConditionIsActive(Utils.SolarFlare) || (pawn.Map != null && pawn.Map.GameConditionManager.ConditionIsActive(GameConditionDefOf.EMIField))
                     && ((isAndroid && !isTXWithSKin) || (isOrganic && withVXChip)))
                     {
```

### ImportantPawnComp/DownedT5AndroidComp.cs
```diff
--- v1.3/ImportantPawnComp/DownedT5AndroidComp.cs
+++ v1.6/ImportantPawnComp/DownedT5AndroidComp.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using Verse;
 using RimWorld.Planet;
```

### Incidents/IncidentWorker_DownedT5Android.cs
```diff
--- v1.3/Incidents/IncidentWorker_DownedT5Android.cs
+++ v1.6/Incidents/IncidentWorker_DownedT5Android.cs
@@ -14,10 +14,10 @@
             List<SitePartDef> x = new List<SitePartDef>();
             x.Add(SitePartDefOf.DownedT5Android);
-            return base.CanFireNowSub(parms) && this.TryFindTile(out int num) && SiteMakerHelper.TryFindRandomFactionFor( x, out Faction faction, true, null);
+            return base.CanFireNowSub(parms) && this.TryFindTile(out PlanetTile num) && SiteMakerHelper.TryFindRandomFactionFor( x, out Faction faction, true, null);
         }
 
-        private bool TryFindTile(out int tile)
+        private bool TryFindTile(out PlanetTile tile)
         {
-            return TileFinder.TryFindNewSiteTile(out tile, 7, 15, true, TileFinderMode.Near, -1);
+            return TileFinder.TryFindNewSiteTile(out tile, 7, 15, true, tileFinderMode: TileFinderMode.Near);
         }
 
@@ -28,5 +28,5 @@
                 return false;
             }
-            if (!TileFinder.TryFindNewSiteTile(out int tile, 8, 30, false, TileFinderMode.Near, -1))
+            if (!TileFinder.TryFindNewSiteTile(out PlanetTile tile, 8, 30, false, tileFinderMode: TileFinderMode.Near))
             {
                 return false;
@@ -92,3 +92,3 @@
         private static readonly IntRange TimeoutDaysRange = new IntRange(12, 20);
     }
-}+}
```

### Incidents/Incident_DeviceHacking.cs
```diff
--- v1.3/Incidents/Incident_DeviceHacking.cs
+++ v1.6/Incidents/Incident_DeviceHacking.cs
@@ -38,5 +38,5 @@
             int fee = 0;
 
-            //Check si sur lensemble des clients connecté il y a quand meme des devices
+            //Check si sur lensemble des clients connectÃ© il y a quand meme des devices
             if (nbDevices <= 0)
                 return false;
@@ -67,10 +67,10 @@
                 }
 
-                foreach (var v in victims)
+                foreach (var victime in victims)
                 {
-                    CompSkyMind csm = Utils.getCachedCSM(v);
-                    if (v is Pawn)
+                    CompSkyMind csm = Utils.getCachedCSM(victime);
+                    if (victime is Pawn)
                     {
-                        CompAndroidState cas = Utils.getCachedCAS((Pawn)v);
+                        CompAndroidState cas = Utils.getCachedCAS((Pawn)victime);
                         if (cas == null)
                             continue;
@@ -166,10 +166,10 @@
             if (attackType == 3)
             {
-                //Déduction faction ennemis au hasard
+                //DÃ©duction faction ennemis au hasard
                 Faction faction = Find.FactionManager.RandomEnemyFaction();
 
                 ChoiceLetter_RansomDemand ransom = (ChoiceLetter_RansomDemand) LetterMaker.MakeLetter(DefDatabase<LetterDef>.GetNamed("ATPP_CLPayCryptoRansom"));
-                ransom.label = "ATPP_CryptolockerNeedPayRansomTitle".Translate();
-                ransom.text = "ATPP_CryptolockerNeedPayRansom".Translate(faction.Name, fee);
+                ransom.Label = "ATPP_CryptolockerNeedPayRansomTitle".Translate();
+                ransom.Text = "ATPP_CryptolockerNeedPayRansom".Translate(faction.Name, fee);
                 ransom.faction = faction;
                 ransom.radioMode = true;
```

### Incidents/Incident_RansomWare.cs
```diff
--- v1.3/Incidents/Incident_RansomWare.cs
+++ v1.6/Incidents/Incident_RansomWare.cs
@@ -30,5 +30,5 @@
             int nbConnectedClients = Utils.GCATPP.getNbThingsConnected();
             int nbUnsecurisedClients = nbConnectedClients - Utils.GCATPP.getNbSlotSecurisedAvailable();
-            //Déduction faction ennemis au hasard
+            //DÃ©duction faction ennemis au hasard
             Faction faction = Find.FactionManager.RandomEnemyFaction();
 
@@ -36,5 +36,5 @@
             int fee = 0;
 
-            //Si pas de config insécurisé alors on dégage
+            //Si pas de config insÃ©curisÃ© alors on dÃ©gage
             if (nbUnsecurisedClients < 0)
                 return false;
@@ -60,5 +60,5 @@
 
 
-                //Purge des traits deja possédé par la victime ET incompatibles avec ceux present
+                //Purge des traits deja possÃ©dÃ© par la victime ET incompatibles avec ceux present
                 foreach (var t in Utils.RansomAddedBadTraits)
                 {
@@ -74,5 +74,5 @@
                 }
 
-                //Selection trait aleatoire ajouté
+                //Selection trait aleatoire ajoutÃ©
                 cso.ransomwareTraitAdded = tr.RandomElement();
                 victim.story.traits.GainTrait(new Trait(cso.ransomwareTraitAdded, 0, true));
@@ -99,5 +99,5 @@
             else
             {
-                //Skill enlevé
+                //Skill enlevÃ©
 
                 SkillDef find = null;
@@ -115,5 +115,5 @@
                 }
 
-                //APplication effet négatif
+                //APplication effet nÃ©gatif
                 sel.levelInt = 0;
 
@@ -133,6 +133,6 @@
 
             ChoiceLetter_RansomwareDemand ransom = (ChoiceLetter_RansomwareDemand) LetterMaker.MakeLetter(DefDatabase<LetterDef>.GetNamed("ATPP_CLPayRansomwareRansom"));
-            ransom.label = "ATPP_RansomNeedPayRansomTitle".Translate();
-            ransom.text = ransomMsg;
+            ransom.Label = "ATPP_RansomNeedPayRansomTitle".Translate();
+            ransom.Text = ransomMsg;
             ransom.faction = faction;
             ransom.victim = victim;
```

### Incidents/Incident_SurrogateHacking.cs
```diff
--- v1.3/Incidents/Incident_SurrogateHacking.cs
+++ v1.6/Incidents/Incident_SurrogateHacking.cs
@@ -38,5 +38,5 @@
             int fee = 0;
 
-            //Check si sur lensemble des clients connecté il y a quand meme des surrogates
+            //Check si sur lensemble des clients connectÃ© il y a quand meme des surrogates
             if (nbSurrogates <= 0)
                 return false;
@@ -162,5 +162,5 @@
                     }
                     if (v.mindState != null)
-                        v.mindState.Reset(true);
+                        v.mindState.Reset(clearInspiration: true, clearMentalState: true, wasDowned: false);
 
 
@@ -233,10 +233,10 @@
             if (attackType == 3)
             {
-                //Déduction faction ennemis au hasard
+                //DÃ©duction faction ennemis au hasard
                 Faction faction = Find.FactionManager.RandomEnemyFaction();
 
                 ChoiceLetter_RansomDemand ransom = (ChoiceLetter_RansomDemand) LetterMaker.MakeLetter(DefDatabase<LetterDef>.GetNamed("ATPP_CLPayCryptoRansom"));
-                ransom.label = "ATPP_CryptolockerNeedPayRansomTitle".Translate();
-                ransom.text = "ATPP_CryptolockerNeedPayRansom".Translate(faction.Name, fee);
+                ransom.Label = "ATPP_CryptolockerNeedPayRansomTitle".Translate();
+                ransom.Text = "ATPP_CryptolockerNeedPayRansom".Translate(faction.Name, fee);
                 ransom.faction = faction;
                 ransom.radioMode = true;
```

### IngestionOutcomeDoer_GiveTwoHediffs.cs
```diff
--- v1.3/IngestionOutcomeDoer_GiveTwoHediffs.cs
+++ v1.6/IngestionOutcomeDoer_GiveTwoHediffs.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using System.Collections.Generic;
 using RimWorld;
@@ -8,5 +8,5 @@
     class IngestionOutcomeDoer_GiveTwoHediffs : IngestionOutcomeDoer
     {
-        protected override void DoIngestionOutcomeSpecial(Pawn pawn, Thing ingested)
+        protected override void DoIngestionOutcomeSpecial(Pawn pawn, Thing ingested, int ingestedCount)
         {
             if (pawn.IsAndroid() == false)
```

### JobDrivers/JobDriver_GoReloadBattery.cs
```diff
--- v1.3/JobDrivers/JobDriver_GoReloadBattery.cs
+++ v1.6/JobDrivers/JobDriver_GoReloadBattery.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using System.Collections.Generic;
 using System.Diagnostics;
```

### JobGiver_Targetenemies.cs
```diff
--- v1.3/JobGiver_Targetenemies.cs
+++ v1.6/JobGiver_Targetenemies.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using RimWorld;
 using Verse;
@@ -32,5 +32,5 @@
                     if (flag6)
                     {
-                        using (PawnPath pawnPath = pawn.Map.pathFinder.FindPath(pawn.Position, pawn2.Position, TraverseParms.For(pawn, Danger.None, TraverseMode.PassDoors, false), PathEndMode.OnCell))
+                        using (PawnPath pawnPath = pawn.Map.pathFinder.FindPathNow(pawn.Position, pawn2.Position, TraverseParms.For(pawn, Danger.None, TraverseMode.PassDoors, false), peMode: PathEndMode.OnCell))
                         {
                             bool flag7 = !pawnPath.Found;
```

### MechFallStuff/MechFallClass.cs
```diff
--- v1.3/MechFallStuff/MechFallClass.cs
+++ v1.6/MechFallStuff/MechFallClass.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using System.Collections.Generic;
 using System.Linq;
@@ -16,5 +16,5 @@
         }
 
-        public override void Tick()
+        protected override void Tick()
         {
             if (base.TicksPassed >= this.duration)
@@ -46,12 +46,11 @@
             Thing instigator = this.instigator;
             ThingDef def = this.def;
-            ThingDef weaponDef = this.weaponDef;
-            GenExplosion.DoExplosion(base.Position, base.Map, 1, DamageDefOf.Bomb, instigator, -1, -1f, null, weaponDef, def, null, null, 0f, 1, false, null, 0f, 1, 0f, false);
-            GenExplosion.DoExplosion(base.Position, base.Map, 1, DamageDefOf.Bomb, instigator, -1, -1f, null, weaponDef, def, null, null, 0f, 1, false, null, 0f, 1, 0f, false);
+            ThingDef weaponDef = this.weaponDef; 
+            GenExplosion.DoExplosion(base.Position, base.Map, 1, DamageDefOf.Bomb, instigator, weapon: weaponDef, projectile: def);
         }
 
         private void CreatePod()
         {
-            ActiveDropPodInfo info = new ActiveDropPodInfo
+            ActiveTransporterInfo info = new ActiveTransporterInfo
             {
                 openDelay = 10,
@@ -63,5 +62,5 @@
         public void SpawnDude()
         {
-            PawnGenerationRequest request = new PawnGenerationRequest(PawnKindDefOf.M7MechPawn, Faction.OfPlayer, PawnGenerationContext.NonPlayer);
+            PawnGenerationRequest request = Utils.NewPawnGenerationRequest(PawnKindDefOf.M7MechPawn, Faction.OfPlayer, PawnGenerationContext.NonPlayer);
             Pawn pawn = PawnGenerator.GeneratePawn(request);
             FilthMaker.TryMakeFilth(base.Position, base.Map, RimWorld.ThingDefOf.Filth_RubbleBuilding, 30);
```

### MechFallStuff/MechFallMote.cs
```diff
--- v1.3/MechFallStuff/MechFallMote.cs
+++ v1.6/MechFallStuff/MechFallMote.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using System.Collections.Generic;
 using UnityEngine;
```

### MechFallStuff/Verb_MechFall.cs
```diff
--- v1.3/MechFallStuff/Verb_MechFall.cs
+++ v1.6/MechFallStuff/Verb_MechFall.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using Verse;
 using RimWorld;
```

### MentalState_TargetEnemies.cs
```diff
--- v1.3/MentalState_TargetEnemies.cs
+++ v1.6/MentalState_TargetEnemies.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using RimWorld;
 using Verse.AI;
```

### ModExtensionATweaks.cs
```diff
--- v1.3/ModExtensionATweaks.cs
+++ v1.6/ModExtensionATweaks.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using System.Collections.Generic;
 using System.Linq;
```

### Nanites Effects/CompUseEffect_HealCPUSerum.cs
```diff
--- v1.3/Nanites Effects/CompUseEffect_HealCPUSerum.cs
+++ v1.6/Nanites Effects/CompUseEffect_HealCPUSerum.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using Verse;
 using RimWorld;
@@ -43,19 +43,17 @@
         }
 
-        public override bool CanBeUsedBy(Pawn p, out string failReason)
+        public override AcceptanceReport CanBeUsedBy(Pawn p)
         {
             if ( !p.IsAndroidTier())
             {
-                failReason = "ATPP_CanOnlyBeUsedByAndroid".Translate();
-                return false;
+                return "ATPP_CanOnlyBeUsedByAndroid".Translate();
             }
             else if (!p.haveAndroidOldAgeHediff(Utils.AndroidOldAgeHediffCPU))
             {
-                failReason = "ATPP_CannotBeUsedBecauseNoOldAgeIssues".Translate();
-                return false;
+                return "ATPP_CannotBeUsedBecauseNoOldAgeIssues".Translate();
             }
 
-            return base.CanBeUsedBy(p, out failReason);
+            return base.CanBeUsedBy(p);
         }
     }
-}+}
```

### Nanites Effects/CompUseEffect_HealCoolingSystem.cs
```diff
--- v1.3/Nanites Effects/CompUseEffect_HealCoolingSystem.cs
+++ v1.6/Nanites Effects/CompUseEffect_HealCoolingSystem.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using Verse;
 using RimWorld;
@@ -40,18 +40,16 @@
         }
 
-        public override bool CanBeUsedBy(Pawn p, out string failReason)
+        public override AcceptanceReport CanBeUsedBy(Pawn p)
         {
             if ( !p.IsAndroidTier())
             {
-                failReason = "ATPP_CanOnlyBeUsedByAndroid".Translate();
-                return false;
+                return "ATPP_CanOnlyBeUsedByAndroid".Translate();
             }
             else if (!p.haveAndroidOldAgeHediff(Utils.AndroidOldAgeHediffCooling))
             {
-                failReason = "ATPP_CannotBeUsedBecauseNoOldAgeIssues".Translate();
-                return false;
+                return "ATPP_CannotBeUsedBecauseNoOldAgeIssues".Translate();
             }
-            return base.CanBeUsedBy(p, out failReason);
+            return base.CanBeUsedBy(p);
         }
     }
-}+}
```

### Nanites Effects/CompUseEffect_HealFrameworkSystem.cs
```diff
--- v1.3/Nanites Effects/CompUseEffect_HealFrameworkSystem.cs
+++ v1.6/Nanites Effects/CompUseEffect_HealFrameworkSystem.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using Verse;
 using RimWorld;
@@ -26,20 +26,18 @@
         }
 
-        public override bool CanBeUsedBy(Pawn p, out string failReason)
+        public override AcceptanceReport CanBeUsedBy(Pawn p)
         {
             if ( !p.IsAndroidTier())
             {
-                failReason = "ATPP_CanOnlyBeUsedByAndroid".Translate();
-                return false;
+                return "ATPP_CanOnlyBeUsedByAndroid".Translate();
             }
             CompAndroidState cas = Utils.getCachedCAS(p);
             if (cas != null && cas.frameworkNaniteEffectGTEnd != -1)
             {
-                failReason = "";
                 return false;
             }
 
-            return base.CanBeUsedBy(p, out failReason);
+            return base.CanBeUsedBy(p);
         }
     }
-}+}
```

### Nanites Effects/CompUseEffect_HealHydraulicSystem.cs
```diff
--- v1.3/Nanites Effects/CompUseEffect_HealHydraulicSystem.cs
+++ v1.6/Nanites Effects/CompUseEffect_HealHydraulicSystem.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using Verse;
 using RimWorld;
@@ -40,18 +40,16 @@
         }
 
-        public override bool CanBeUsedBy(Pawn p, out string failReason)
+        public override AcceptanceReport CanBeUsedBy(Pawn p)
         {
             if ( !p.IsAndroidTier())
             {
-                failReason = "ATPP_CanOnlyBeUsedByAndroid".Translate();
-                return false;
+                return "ATPP_CanOnlyBeUsedByAndroid".Translate();
             }
             else if (!p.haveAndroidOldAgeHediff(Utils.AndroidOldAgeHediffHydraulic))
             {
-                failReason = "ATPP_CannotBeUsedBecauseNoOldAgeIssues".Translate();
-                return false;
+                return "ATPP_CannotBeUsedBecauseNoOldAgeIssues".Translate();
             }
-            return base.CanBeUsedBy(p, out failReason);
+            return base.CanBeUsedBy(p);
         }
     }
-}+}
```

### Nanites Effects/Operations/Recipe_ApplyHealCPUSerum.cs
```diff
--- v1.3/Nanites Effects/Operations/Recipe_ApplyHealCPUSerum.cs
+++ v1.6/Nanites Effects/Operations/Recipe_ApplyHealCPUSerum.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using System.Collections.Generic;
 using System.Linq;
```

### Nanites Effects/Operations/Recipe_ApplyHealCoolingSystem.cs
```diff
--- v1.3/Nanites Effects/Operations/Recipe_ApplyHealCoolingSystem.cs
+++ v1.6/Nanites Effects/Operations/Recipe_ApplyHealCoolingSystem.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using System.Collections.Generic;
 using System.Linq;
```

### Nanites Effects/Operations/Recipe_ApplyHealFrameworkSystem.cs
```diff
--- v1.3/Nanites Effects/Operations/Recipe_ApplyHealFrameworkSystem.cs
+++ v1.6/Nanites Effects/Operations/Recipe_ApplyHealFrameworkSystem.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using System.Collections.Generic;
 using System.Linq;
```

### Nanites Effects/Operations/Recipe_ApplyHydraulicNaniteBank.cs
```diff
--- v1.3/Nanites Effects/Operations/Recipe_ApplyHydraulicNaniteBank.cs
+++ v1.6/Nanites Effects/Operations/Recipe_ApplyHydraulicNaniteBank.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using System.Collections.Generic;
 using System.Linq;
```

### Need_Rest_Fake.cs
```diff
--- v1.3/Need_Rest_Fake.cs
+++ v1.6/Need_Rest_Fake.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using System.Collections.Generic;
 using Verse;
```

### Other/AndroidCapacityLabel.cs
```diff
--- v1.3/Other/AndroidCapacityLabel.cs
+++ v1.6/Other/AndroidCapacityLabel.cs
@@ -1,3 +1,3 @@
-﻿using RimWorld;
+using RimWorld;
 using System;
 using System.Collections.Generic;
```

### Other/Need_DummyRest.cs
```diff
--- v1.3/Other/Need_DummyRest.cs
+++ v1.6/Other/Need_DummyRest.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using System.Collections.Generic;
 using Verse;
```

### Other/RestOverride.cs
```diff
--- v1.3/Other/RestOverride.cs
+++ v1.6/Other/RestOverride.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using Verse;
 using RimWorld;
```

### PaintAndroidFramework/Recipe_PaintAndroidFrameworkBlack.cs
```diff
--- v1.3/PaintAndroidFramework/Recipe_PaintAndroidFrameworkBlack.cs
+++ v1.6/PaintAndroidFramework/Recipe_PaintAndroidFrameworkBlack.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using System.Collections.Generic;
 using System.Linq;
```

### PaintAndroidFramework/Recipe_PaintAndroidFrameworkBlue.cs
```diff
--- v1.3/PaintAndroidFramework/Recipe_PaintAndroidFrameworkBlue.cs
+++ v1.6/PaintAndroidFramework/Recipe_PaintAndroidFrameworkBlue.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using System.Collections.Generic;
 using System.Linq;
```

### PaintAndroidFramework/Recipe_PaintAndroidFrameworkCyan.cs
```diff
--- v1.3/PaintAndroidFramework/Recipe_PaintAndroidFrameworkCyan.cs
+++ v1.6/PaintAndroidFramework/Recipe_PaintAndroidFrameworkCyan.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using System.Collections.Generic;
 using System.Linq;
```

### PaintAndroidFramework/Recipe_PaintAndroidFrameworkDefault.cs
```diff
--- v1.3/PaintAndroidFramework/Recipe_PaintAndroidFrameworkDefault.cs
+++ v1.6/PaintAndroidFramework/Recipe_PaintAndroidFrameworkDefault.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using System.Collections.Generic;
 using System.Linq;
```

### PaintAndroidFramework/Recipe_PaintAndroidFrameworkGray.cs
```diff
--- v1.3/PaintAndroidFramework/Recipe_PaintAndroidFrameworkGray.cs
+++ v1.6/PaintAndroidFramework/Recipe_PaintAndroidFrameworkGray.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using System.Collections.Generic;
 using System.Linq;
```

### PaintAndroidFramework/Recipe_PaintAndroidFrameworkGreen.cs
```diff
--- v1.3/PaintAndroidFramework/Recipe_PaintAndroidFrameworkGreen.cs
+++ v1.6/PaintAndroidFramework/Recipe_PaintAndroidFrameworkGreen.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using System.Collections.Generic;
 using System.Linq;
```

### PaintAndroidFramework/Recipe_PaintAndroidFrameworkKhaki.cs
```diff
--- v1.3/PaintAndroidFramework/Recipe_PaintAndroidFrameworkKhaki.cs
+++ v1.6/PaintAndroidFramework/Recipe_PaintAndroidFrameworkKhaki.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using System.Collections.Generic;
 using System.Linq;
```

### PaintAndroidFramework/Recipe_PaintAndroidFrameworkOrange.cs
```diff
--- v1.3/PaintAndroidFramework/Recipe_PaintAndroidFrameworkOrange.cs
+++ v1.6/PaintAndroidFramework/Recipe_PaintAndroidFrameworkOrange.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using System.Collections.Generic;
 using System.Linq;
```

### PaintAndroidFramework/Recipe_PaintAndroidFrameworkPink.cs
```diff
--- v1.3/PaintAndroidFramework/Recipe_PaintAndroidFrameworkPink.cs
+++ v1.6/PaintAndroidFramework/Recipe_PaintAndroidFrameworkPink.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using System.Collections.Generic;
 using System.Linq;
```

### PaintAndroidFramework/Recipe_PaintAndroidFrameworkPurple.cs
```diff
--- v1.3/PaintAndroidFramework/Recipe_PaintAndroidFrameworkPurple.cs
+++ v1.6/PaintAndroidFramework/Recipe_PaintAndroidFrameworkPurple.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using System.Collections.Generic;
 using System.Linq;
```

### PaintAndroidFramework/Recipe_PaintAndroidFrameworkRed.cs
```diff
--- v1.3/PaintAndroidFramework/Recipe_PaintAndroidFrameworkRed.cs
+++ v1.6/PaintAndroidFramework/Recipe_PaintAndroidFrameworkRed.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using System.Collections.Generic;
 using System.Linq;
```

### PaintAndroidFramework/Recipe_PaintAndroidFrameworkWhite.cs
```diff
--- v1.3/PaintAndroidFramework/Recipe_PaintAndroidFrameworkWhite.cs
+++ v1.6/PaintAndroidFramework/Recipe_PaintAndroidFrameworkWhite.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using System.Collections.Generic;
 using System.Linq;
```

### PaintAndroidFramework/Recipe_PaintAndroidFrameworkYellow.cs
```diff
--- v1.3/PaintAndroidFramework/Recipe_PaintAndroidFrameworkYellow.cs
+++ v1.6/PaintAndroidFramework/Recipe_PaintAndroidFrameworkYellow.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using System.Collections.Generic;
 using System.Linq;
```

### Patches/AndroidLabelOverwrite.cs
```diff
--- v1.3/Patches/AndroidLabelOverwrite.cs
+++ v1.6/Patches/AndroidLabelOverwrite.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using System.Collections.Generic;
 using System.Linq;
```

### Patches/HarmonyPatches.cs
```diff
--- v1.3/Patches/HarmonyPatches.cs
+++ v1.6/Patches/HarmonyPatches.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using System.Collections.Generic;
 using System.Linq;
@@ -72,5 +72,5 @@
         }
     }*/
-        [HarmonyPatch(typeof(JobDriver_Vomit))]
+    [HarmonyPatch(typeof(JobDriver_Vomit))]
     [HarmonyPatch("MakeNewToils")]
     internal static class DeclineVomitJob
@@ -245,4 +245,9 @@
     internal static class MultiplePawnRacesAtStart
     {
+        private static bool Prepare()
+        {
+            return false;
+        }
+
         private static void Postfix(ref Pawn __result)
         {
@@ -262,11 +267,11 @@
                 {
                     case 1:
-                        request = new PawnGenerationRequest(MOARANDROIDS.PawnKindDefOf.AndroidT2ColonistGeneral, Faction.OfPlayer, PawnGenerationContext.PlayerStarter, -1, true, false, false, false, true, TutorSystem.TutorialMode, 20f, false, true, true, false, false, false, false);
+                        request = Utils.NewPawnGenerationRequest(MOARANDROIDS.PawnKindDefOf.AndroidT2ColonistGeneral, Faction.OfPlayer, PawnGenerationContext.PlayerStarter, -1, true, false, false, false, true, TutorSystem.TutorialMode, 20f, false, true, true, false, false, false, false);
                         break;
                     case 2:
-                        request = new PawnGenerationRequest(MOARANDROIDS.PawnKindDefOf.AndroidT1ColonistGeneral, Faction.OfPlayer, PawnGenerationContext.PlayerStarter, -1, true, false, false, false, true, TutorSystem.TutorialMode, 20f, false, true, true, false, false, false, false);
+                        request = Utils.NewPawnGenerationRequest(MOARANDROIDS.PawnKindDefOf.AndroidT1ColonistGeneral, Faction.OfPlayer, PawnGenerationContext.PlayerStarter, -1, true, false, false, false, true, TutorSystem.TutorialMode, 20f, false, true, true, false, false, false, false);
                         break;
                     default:
-                        request = new PawnGenerationRequest(Faction.OfPlayer.def.basicMemberKind, Faction.OfPlayer, PawnGenerationContext.PlayerStarter, -1, true, false, false, false, true, TutorSystem.TutorialMode, 20f, false, true, true, false, false, false, false);
+                        request = Utils.NewPawnGenerationRequest(Faction.OfPlayer.def.basicMemberKind, Faction.OfPlayer, PawnGenerationContext.PlayerStarter, -1, true, false, false, false, true, TutorSystem.TutorialMode, 20f, false, true, true, false, false, false, false);
                         break;
                 }
```

### Patches/HealthCardUtility_DrawHediffRow.cs
```diff
--- v1.3/Patches/HealthCardUtility_DrawHediffRow.cs
+++ v1.6/Patches/HealthCardUtility_DrawHediffRow.cs
@@ -1,3 +1,3 @@
-﻿/*using System;
+/*using System;
 using System.Linq;
 using System.Collections.Generic;
```

### Patches/HealthCardUtility_GetTooltip.cs
```diff
--- v1.3/Patches/HealthCardUtility_GetTooltip.cs
+++ v1.6/Patches/HealthCardUtility_GetTooltip.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using System.Linq;
 using System.Collections.Generic;
```

### Patches/PawnGatheringPatch.cs
```diff
--- v1.3/Patches/PawnGatheringPatch.cs
+++ v1.6/Patches/PawnGatheringPatch.cs
@@ -1,3 +1,3 @@
-﻿using HarmonyLib;
+using HarmonyLib;
 using RimWorld;
 using Verse;
```

### PawnRelationWorker_Creation.cs
```diff
--- v1.3/PawnRelationWorker_Creation.cs
+++ v1.6/PawnRelationWorker_Creation.cs
@@ -1,3 +1,3 @@
-﻿using System.Linq;
+using System.Linq;
 using RimWorld;
 using Verse;
```

### PostInitTweaks.cs
```diff
--- v1.3/PostInitTweaks.cs
+++ v1.6/PostInitTweaks.cs
@@ -1,3 +1,3 @@
-﻿using HarmonyLib;
+using HarmonyLib;
 using RimWorld;
 using System;
```

### Properties/AssemblyInfo.cs
```diff
--- v1.3/Properties/AssemblyInfo.cs
+++ v1.6/Properties/AssemblyInfo.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using System.Diagnostics;
 using System.Reflection;
```

### Recipes/Recipe_CorruptionChance.cs
```diff
--- v1.3/Recipes/Recipe_CorruptionChance.cs
+++ v1.6/Recipes/Recipe_CorruptionChance.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using System.Collections.Generic;
 using RimWorld;
```

### Recipes/Recipe_Disassemble.cs
```diff
--- v1.3/Recipes/Recipe_Disassemble.cs
+++ v1.6/Recipes/Recipe_Disassemble.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using System.Collections.Generic;
 using RimWorld;
```

### Recipes/Recipe_InstallAndroidPart.cs
```diff
--- v1.3/Recipes/Recipe_InstallAndroidPart.cs
+++ v1.6/Recipes/Recipe_InstallAndroidPart.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using System.Collections.Generic;
 using System.Linq;
```

### Recipes/Recipe_InstallArtificialBrain.cs
```diff
--- v1.3/Recipes/Recipe_InstallArtificialBrain.cs
+++ v1.6/Recipes/Recipe_InstallArtificialBrain.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using System.Collections.Generic;
 using System.Linq;
```

### Recipes/Recipe_InstallNaturalAndroidPart.cs
```diff
--- v1.3/Recipes/Recipe_InstallNaturalAndroidPart.cs
+++ v1.6/Recipes/Recipe_InstallNaturalAndroidPart.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using System.Collections.Generic;
 using System.Linq;
```

### Recipes/Recipe_InstallimplantAndroid.cs
```diff
--- v1.3/Recipes/Recipe_InstallimplantAndroid.cs
+++ v1.6/Recipes/Recipe_InstallimplantAndroid.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using System.Collections.Generic;
 using System.Linq;
```

### Recipes/Recipe_PrisonerConversionReprogram.cs
```diff
--- v1.3/Recipes/Recipe_PrisonerConversionReprogram.cs
+++ v1.6/Recipes/Recipe_PrisonerConversionReprogram.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using System.Collections.Generic;
 using RimWorld;
```

### Recipes/Recipe_RemoveSentience.cs
```diff
--- v1.3/Recipes/Recipe_RemoveSentience.cs
+++ v1.6/Recipes/Recipe_RemoveSentience.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using System.Collections.Generic;
 using RimWorld;
```

### Recipes/Recipe_RerollTraits.cs
```diff
--- v1.3/Recipes/Recipe_RerollTraits.cs
+++ v1.6/Recipes/Recipe_RerollTraits.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using System.Collections.Generic;
 using RimWorld;
```

### Recipes/Recipe_SurgeryAndroids.cs
```diff
--- v1.3/Recipes/Recipe_SurgeryAndroids.cs
+++ v1.6/Recipes/Recipe_SurgeryAndroids.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using System.Collections.Generic;
 using Verse;
@@ -20,5 +20,5 @@
             }
             num *= this.recipe.surgerySuccessChanceFactor;
-            if (surgeon.InspirationDef == InspirationDefOf.Inspired_Surgery && !patient.RaceProps.IsMechanoid)
+            if (Utils.InspiredSurgery != null && surgeon.InspirationDef == Utils.InspiredSurgery && !patient.RaceProps.IsMechanoid)
             {
                 if (num < 1f)
@@ -26,5 +26,5 @@
                     num = 1f - (1f - num) * 0.1f;
                 }
-                surgeon.mindState.inspirationHandler.EndInspiration(InspirationDefOf.Inspired_Surgery);
+                surgeon.mindState.inspirationHandler.EndInspiration(Utils.InspiredSurgery);
             }
             if (!Rand.Chance(num))
@@ -32,5 +32,5 @@
                 if (Rand.Chance(this.recipe.deathOnFailedSurgeryChance))
                 {
-                    HealthUtility.GiveInjuriesOperationFailureCatastrophic(patient, part);
+                    HealthUtility.GiveRandomSurgeryInjuries(patient, 65, part);
                     if (!patient.Dead)
                     {
@@ -44,10 +44,10 @@
                     {
                         Messages.Message("MessageMedicalOperationFailureRidiculousAndroid".Translate(surgeon.LabelShort, patient.LabelShort), patient, MessageTypeDefOf.NegativeHealthEvent);
-                        HealthUtility.GiveInjuriesOperationFailureRidiculous(patient);
+                        HealthUtility.GiveRandomSurgeryInjuries(patient, 999, null);
                     }
                     else
                     {
                         Messages.Message("MessageMedicalOperationFailureCatastrophicAndroid".Translate(surgeon.LabelShort, patient.LabelShort), patient, MessageTypeDefOf.NegativeHealthEvent);
-                        HealthUtility.GiveInjuriesOperationFailureCatastrophic(patient, part);
+                        HealthUtility.GiveRandomSurgeryInjuries(patient, 65, part);
                     }
                 }
@@ -55,5 +55,5 @@
                 {
                     Messages.Message("MessageMedicalOperationFailureMinorAndroid".Translate(surgeon.LabelShort, patient.LabelShort), patient, MessageTypeDefOf.NegativeHealthEvent);
-                    HealthUtility.GiveInjuriesOperationFailureMinor(patient, part);
+                    HealthUtility.GiveRandomSurgeryInjuries(patient, 20, part);
                 }
                 if (!patient.Dead)
```

### Settings.cs
```diff
--- v1.3/Settings.cs
+++ v1.6/Settings.cs
@@ -1,3 +1,3 @@
-﻿using UnityEngine;
+using UnityEngine;
 using Verse;
 using RimWorld;
@@ -23,5 +23,4 @@
         public static bool allowSurrogateConnectionInitMalus = true;
         public static bool keepPuppetBackstory = false;
-        public static float percentageChanceMaleAndroidModel = 0.5f;
         public static bool allowT5ToWearClothes = false;
         public static int maxAndroidByPortableLWPN = 5;
@@ -228,11 +227,4 @@
 
 
-            if (Utils.ANDROIDTIERSGYNOID_LOADED)
-            {
-                list.Label("ATPP_SettingsChanceCreatedAndroidsAreMale".Translate((int)(percentageChanceMaleAndroidModel * 100)));
-                percentageChanceMaleAndroidModel = list.Slider(percentageChanceMaleAndroidModel, 0.0f, 1.0f);
-            }
-
-
             bool prevAllowT5ToWearClothes = allowT5ToWearClothes;
             bool prevSetT1ResearchToIndustrialTechLevel = setT1ResearchToIndustrialTechLevel;
@@ -1032,7 +1024,4 @@
             Scribe_Values.Look<bool>(ref allowAutoRepaintForPrisoners, "allowAutoRepaintForPrisoners", true);
 
-            Scribe_Values.Look<float>(ref percentageChanceMaleAndroidModel, "percentageChanceMaleAndroidModel", 0.5f);
-            
-
             Scribe_Values.Look<bool>(ref allowT5ToWearClothes, "allowT5ToWearClothes", true);
             Scribe_Values.Look<int>(ref maxAndroidByPortableLWPN, "maxAndroidByPortableLWPN", 5);
@@ -1071,3 +1060,3 @@
         }
     }
-}+}
```

### Spawners/DoggoSpawner.cs
```diff
--- v1.3/Spawners/DoggoSpawner.cs
+++ v1.6/Spawners/DoggoSpawner.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using System.Collections.Generic;
 using System.Diagnostics;
@@ -30,5 +30,5 @@
                 PawnKindDefOf.AndroidDog
             }.RandomElement<PawnKindDef>();
-            PawnGenerationRequest request = new PawnGenerationRequest(pawnKindDef, Faction.OfPlayer, PawnGenerationContext.NonPlayer);
+            PawnGenerationRequest request = Utils.NewPawnGenerationRequest(pawnKindDef, Faction.OfPlayer, PawnGenerationContext.NonPlayer);
             Pawn pawn = PawnGenerator.GeneratePawn(request);
 
```

### Spawners/Spawner_LightSwarmSpawner.cs
```diff
--- v1.3/Spawners/Spawner_LightSwarmSpawner.cs
+++ v1.6/Spawners/Spawner_LightSwarmSpawner.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using System.Collections.Generic;
 using System.Diagnostics;
@@ -30,8 +30,8 @@
                 PawnKindDefOf.MicroScyther
             }.RandomElement<PawnKindDef>();
-            PawnGenerationRequest request = new PawnGenerationRequest(pawnKindDef, Faction.OfPlayer, PawnGenerationContext.NonPlayer);
+            PawnGenerationRequest request = Utils.NewPawnGenerationRequest(pawnKindDef, Faction.OfPlayer, PawnGenerationContext.NonPlayer);
             Pawn pawn = PawnGenerator.GeneratePawn(request);
             GenSpawn.Spawn(pawn, parent.Position, parent.Map);
-            pawn.mindState.mentalStateHandler.TryStartMentalState(MentalStateDefOf.ManhunterNotColony, null, true, false, null);
+            pawn.mindState.mentalStateHandler.TryStartMentalState(MentalStateDefOf.ManhunterNotColony, forced: true, forceWake: false);
 
             Hediff hediff = HediffMaker.MakeHediff(MOARANDROIDS.HediffDefOf.BatteryChargeMech, pawn, null);
@@ -40,3 +40,3 @@
         }
     }
-}+}
```

### Spawners/Spawner_MuffSpawner.cs
```diff
--- v1.3/Spawners/Spawner_MuffSpawner.cs
+++ v1.6/Spawners/Spawner_MuffSpawner.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using System.Collections.Generic;
 using System.Diagnostics;
@@ -30,5 +30,5 @@
                 PawnKindDefOf.AndroidMuff
             }.RandomElement<PawnKindDef>();
-            PawnGenerationRequest request = new PawnGenerationRequest(pawnKindDef, Faction.OfPlayer, PawnGenerationContext.NonPlayer);
+            PawnGenerationRequest request = Utils.NewPawnGenerationRequest(pawnKindDef, Faction.OfPlayer, PawnGenerationContext.NonPlayer);
             Pawn pawn = PawnGenerator.GeneratePawn(request);
 
```

### Spawners/Spawner_PhytoSheep.cs
```diff
--- v1.3/Spawners/Spawner_PhytoSheep.cs
+++ v1.6/Spawners/Spawner_PhytoSheep.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using System.Collections.Generic;
 using System.Diagnostics;
@@ -30,5 +30,5 @@
                 PawnKindDefOf.AndroidSheep
             }.RandomElement<PawnKindDef>();
-            PawnGenerationRequest request = new PawnGenerationRequest(pawnKindDef, Faction.OfPlayer, PawnGenerationContext.NonPlayer);
+            PawnGenerationRequest request = Utils.NewPawnGenerationRequest(pawnKindDef, Faction.OfPlayer, PawnGenerationContext.NonPlayer);
             Pawn pawn = PawnGenerator.GeneratePawn(request);
 
```

### Spawners/Spawner_T1Spawner.cs
```diff
--- v1.3/Spawners/Spawner_T1Spawner.cs
+++ v1.6/Spawners/Spawner_T1Spawner.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using System.Collections.Generic;
 using System.Diagnostics;
@@ -30,5 +30,5 @@
                 PawnKindDefOf.AndroidT1Colonist
             }.RandomElement<PawnKindDef>();
-            PawnGenerationRequest request = new PawnGenerationRequest(pawnKindDef, Faction.OfPlayer, PawnGenerationContext.NonPlayer);
+            PawnGenerationRequest request = Utils.NewPawnGenerationRequest(pawnKindDef, Faction.OfPlayer, PawnGenerationContext.NonPlayer);
             Pawn pawn = PawnGenerator.GeneratePawn(request);
             
```

### Spawners/Spawner_T2Spawner.cs
```diff
--- v1.3/Spawners/Spawner_T2Spawner.cs
+++ v1.6/Spawners/Spawner_T2Spawner.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using System.Collections.Generic;
 using System.Diagnostics;
@@ -30,5 +30,5 @@
                 PawnKindDefOf.AndroidT2Colonist
             }.RandomElement<PawnKindDef>();
-            PawnGenerationRequest request = new PawnGenerationRequest(pawnKindDef, Faction.OfPlayer, PawnGenerationContext.NonPlayer);
+            PawnGenerationRequest request = Utils.NewPawnGenerationRequest(pawnKindDef, Faction.OfPlayer, PawnGenerationContext.NonPlayer);
             Pawn pawn = PawnGenerator.GeneratePawn(request);
 
```

### Spawners/Spawner_T3Spawner.cs
```diff
--- v1.3/Spawners/Spawner_T3Spawner.cs
+++ v1.6/Spawners/Spawner_T3Spawner.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using System.Collections.Generic;
 using System.Diagnostics;
@@ -30,5 +30,5 @@
                 PawnKindDefOf.AndroidT3Colonist
             }.RandomElement<PawnKindDef>();
-            PawnGenerationRequest request = new PawnGenerationRequest(pawnKindDef, Faction.OfPlayer, PawnGenerationContext.NonPlayer);
+            PawnGenerationRequest request = Utils.NewPawnGenerationRequest(pawnKindDef, Faction.OfPlayer, PawnGenerationContext.NonPlayer);
             Pawn pawn = PawnGenerator.GeneratePawn(request);
 
```

### Spawners/Spawner_T4Spawner.cs
```diff
--- v1.3/Spawners/Spawner_T4Spawner.cs
+++ v1.6/Spawners/Spawner_T4Spawner.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using System.Collections.Generic;
 using System.Diagnostics;
@@ -30,5 +30,5 @@
                 PawnKindDefOf.AndroidT4Colonist
             }.RandomElement<PawnKindDef>();
-            PawnGenerationRequest request = new PawnGenerationRequest(pawnKindDef, Faction.OfPlayer, PawnGenerationContext.NonPlayer);
+            PawnGenerationRequest request = Utils.NewPawnGenerationRequest(pawnKindDef, Faction.OfPlayer, PawnGenerationContext.NonPlayer);
             Pawn pawn = PawnGenerator.GeneratePawn(request);
 
```

### StockGenerator_SlaveAndroids.cs
```diff
--- v1.3/StockGenerator_SlaveAndroids.cs
+++ v1.6/StockGenerator_SlaveAndroids.cs
@@ -1,5 +1,6 @@
-﻿using System.Collections.Generic;
+using System.Collections.Generic;
 using System.Linq;
 using RimWorld;
+using RimWorld.Planet;
 using Verse;
 using System;
@@ -9,5 +10,5 @@
         public class StockGenerator_SlaveAndroids : StockGenerator
         {
-            public override IEnumerable<Thing> GenerateThings(int forTile, Faction faction = null)
+            public override IEnumerable<Thing> GenerateThings(PlanetTile forTile, Faction faction = null)
             {
                 if (this.respectPopulationIntent && Rand.Value > StorytellerUtilityPopulation.PopulationIntent)
@@ -54,5 +55,5 @@
                     
                     Faction fac1 = androidFaction;
-                PawnGenerationRequest request = new PawnGenerationRequest(android, fac1, PawnGenerationContext.NonPlayer, forTile, false, false, false, false, true, false, 1f, !this.trader.orbital, true, true, false, false, false, false);
+                PawnGenerationRequest request = Utils.NewPawnGenerationRequest(android, fac1, PawnGenerationContext.NonPlayer, forTile, false, false, false, false, true, false, 1f, !this.trader.orbital, true, true, false, false, false, false);
                     yield return PawnGenerator.GeneratePawn(request);
                 }
@@ -69,3 +70,3 @@
             private bool randomisePawnKind;
     }
-}+}
```

### ThinkNodes/ThinkNode_ConditionalM7Charging.cs
```diff
--- v1.3/ThinkNodes/ThinkNode_ConditionalM7Charging.cs
+++ v1.6/ThinkNodes/ThinkNode_ConditionalM7Charging.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using Verse;
 using Verse.AI;
@@ -10,8 +10,8 @@
         protected override bool Satisfied(Pawn pawn)
         { 
-            //QUe les SM7 controlés peuvent se recharger
+            // Que os SM7 controlados podem se recarregar
             if ((!pawn.Downed && pawn.def.defName == Utils.M7 && pawn.IsSurrogateAndroid(true) ))
             {
-                //Min 30% pour aller se recharger en auto
+                // Min 30% para ir se recarregar em auto
                 if (pawn.needs.food != null && pawn.needs.food.CurLevelPercentage < 0.3f)
                     return true;
```

### ThinkNodes/ThinkNode_ConditionalMustKeepLyingDownM7Surrogate.cs
```diff
--- v1.3/ThinkNodes/ThinkNode_ConditionalMustKeepLyingDownM7Surrogate.cs
+++ v1.6/ThinkNodes/ThinkNode_ConditionalMustKeepLyingDownM7Surrogate.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using Verse;
 using Verse.AI;
```

### ThoughtWorker/ThoughtWorker_AssistingMinds.cs
```diff
--- v1.3/ThoughtWorker/ThoughtWorker_AssistingMinds.cs
+++ v1.6/ThoughtWorker/ThoughtWorker_AssistingMinds.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using RimWorld;
 using Verse;
```

### ThoughtWorker/ThoughtWorker_FeelingsTowardHumanity.cs
```diff
--- v1.3/ThoughtWorker/ThoughtWorker_FeelingsTowardHumanity.cs
+++ v1.6/ThoughtWorker/ThoughtWorker_FeelingsTowardHumanity.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using RimWorld;
 using Verse;
```

### ThoughtWorker/ThoughtWorker_UncomfortableClothing.cs
```diff
--- v1.3/ThoughtWorker/ThoughtWorker_UncomfortableClothing.cs
+++ v1.6/ThoughtWorker/ThoughtWorker_UncomfortableClothing.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using System.Collections.Generic;
 using Verse;
```

### Thoughts/Thought_AssistedByMinds.cs
```diff
--- v1.3/Thoughts/Thought_AssistedByMinds.cs
+++ v1.6/Thoughts/Thought_AssistedByMinds.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using UnityEngine;
 using Verse;
```

### Toils/Toils_LayDownPower.cs
```diff
--- v1.3/Toils/Toils_LayDownPower.cs
+++ v1.6/Toils/Toils_LayDownPower.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using System.Linq;
 using Verse;
@@ -56,5 +56,5 @@
                 JobDriver curDriver = actor.jobs.curDriver;
                 Building_Bed building_Bed = (Building_Bed)curJob.GetTarget(bedOrRestSpotIndex).Thing;
-                actor.GainComfortFromCellIfPossible();
+                actor.GainComfortFromCellIfPossible(1);
 
                 if (actor.IsHashIntervalTick(100) && !actor.Position.Fogged(actor.Map))
```

### Utils/CPatchs.cs
```diff
--- v1.3/Utils/CPatchs.cs
+++ v1.6/Utils/CPatchs.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using System.Collections.Generic;
 using System.Linq;
```

### Utils/DownedT5Utility.cs
```diff
--- v1.3/Utils/DownedT5Utility.cs
+++ v1.6/Utils/DownedT5Utility.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using Verse;
 using RimWorld;
@@ -11,5 +11,5 @@
             PawnKindDef AndroidT5Colonist = PawnKindDefOf.AndroidT5Colonist;
             Faction ofplayer = Faction.OfAncients;
-            PawnGenerationRequest request = new PawnGenerationRequest(AndroidT5Colonist, ofplayer, PawnGenerationContext.NonPlayer, tile, false, false, false, false, true, false, 20f, true, true, true, false, false, false, false, false, 0f, 0f, null, 0f, null, null, null, null);
+            PawnGenerationRequest request = Utils.NewPawnGenerationRequest(AndroidT5Colonist, ofplayer, PawnGenerationContext.NonPlayer, tile, false, false, false, false, true, false, 20f, true, true, true, false, false, false, false, false, 0f, 0f, null, 0f, null, null, null, null);
             Pawn pawn = PawnGenerator.GeneratePawn(request);
             HealthUtility.DamageUntilDowned(pawn);
```

### Utils/GC_ATPP.cs
```diff
--- v1.3/Utils/GC_ATPP.cs
+++ v1.6/Utils/GC_ATPP.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using System.Collections.Generic;
 using System.Linq;
@@ -248,6 +248,9 @@
                                 {
                                     CompProperties cp;
-                                    //SkyMind
-                                    if (td.defName != "M8Mech")
+                                    if (td.comps == null)
+                                        td.comps = new List<CompProperties>();
+
+                                    //SkyMind. M8 already exposes SkyMind capacity through its SkyCloud/LAN comps.
+                                    if (td.defName != "M8Mech" && !td.comps.Any(c => c != null && c.compClass == typeof(CompSkyMind)))
                                     {
                                         cp = new CompProperties();
@@ -257,5 +260,5 @@
 
                                     //CompSurrogate
-                                    if (td.defName != "M7Mech")
+                                    if (td.defName != "M7Mech" && !td.comps.Any(c => c != null && c.compClass == typeof(CompSurrogateOwner)))
                                     {
                                         cp = new CompProperties();
@@ -264,7 +267,10 @@
                                     }
 
-                                    cp = new CompProperties();
-                                    cp.compClass = typeof(CompAndroidState);
-                                    td.comps.Add(cp);
+                                    if (!td.comps.Any(c => c != null && c.compClass == typeof(CompAndroidState)))
+                                    {
+                                        cp = new CompProperties();
+                                        cp.compClass = typeof(CompAndroidState);
+                                        td.comps.Add(cp);
+                                    }
 
                                     //Si androide on va venir stocké dans la Raceprops s'il sagit d'un androide evolué ou non
@@ -335,5 +341,5 @@
                                         cp2.compClass = typeof(CompPowerTrader);
                                         cp2.shortCircuitInRain = true;
-                                        cp2.basePowerConsumption = 80;
+                                        Traverse.Create(cp2).Field("basePowerConsumption").SetValue(80f);
                                         td.comps.Add(cp2);
                                     }
@@ -902,4 +908,5 @@
             checkRemoveAndroidFactions();
             Utils.resetCachedComps();
+            refreshSkyMindNetworkState();
         }
 
@@ -931,9 +938,12 @@
             Scribe_Values.Look<int>(ref this.nbSkillPoints, "ATPP_nbSkillPoints", 0);
 
+            if (Scribe.mode == LoadSaveMode.LoadingVars)
+                nbSlot = 0;
+
             Scribe_Collections.Look(ref QEEAndroidHairColor, "ATPP_QEEAndroidHairColor", LookMode.Value, LookMode.Value);
             Scribe_Collections.Look(ref QEESkinColor, "ATPP_QEESkinColor", LookMode.Value, LookMode.Value);
             Scribe_Collections.Look(ref QEEAndroidHair, "ATPP_QEEAndroidHair", LookMode.Value, LookMode.Value);
             Scribe_Collections.Look(ref VatGrowerLastPawnIsTX, "ATPP_VatGrowerLastPawnIsTX", LookMode.Value, LookMode.Value);
-            Scribe_Collections.Look(ref this.externalSurrogateCJoiner, false, "ATPP_externalSurrogateCJoiner", LookMode.Deep);
+            Scribe_Collections.Look(ref this.externalSurrogateCJoiner, "ATPP_externalSurrogateCJoiner", false, LookMode.Deep);
 
             if (Scribe.mode == LoadSaveMode.PostLoadInit)
@@ -1151,5 +1161,5 @@
                     else
                     {
-                        GenExplosion.DoExplosion(t.Position, t.Map, 3, DamageDefOf.Flame, null, -1, -1f, null, null, null, null, null, 0f, 1, false, null, 0f, 1, 0f, false);
+                        GenExplosion.DoExplosion(t.Position, t.Map, 3, DamageDefOf.Flame, null);
                         
                         Building build = (Building)t;
@@ -1195,10 +1205,14 @@
         public void checkSkyMindAutoReconnect()
         {
-            foreach(var el in listerSkyMindable)
-            {
-                Pawn cp=null;
-                if (el is Pawn)
-                    cp = (Pawn)el;
-                CompSkyMind csm = Utils.getCachedCSM(cp);
+            foreach(var el in listerSkyMindable.ToList())
+            {
+                if (Utils.IsDeadPawnOrCorpse(el))
+                {
+                    disconnectUser(el, false, false);
+                    popSkyMindable(el);
+                    continue;
+                }
+
+                CompSkyMind csm = Utils.getCachedCSM(el);
 
                 if (csm == null)
@@ -1239,5 +1253,5 @@
                 {
                     CompBuildingSkyMindLAN csml = Utils.getCachedCML(el2);
-                    if (csml.isPowerOn())
+                    if (el2 != null && !el2.Destroyed && csml != null && csml.isPowerOn())
                     {
                         nbSlot += 3;
@@ -1268,5 +1282,5 @@
                 {
                     CompPowerTrader cpt = Utils.getCachedCPT(el2);
-                    if (el2 != null && cpt.PowerOn && !el2.IsBrokenDown())
+                    if (el2 != null && !el2.Destroyed && cpt != null && cpt.PowerOn && !el2.IsBrokenDown())
                         nbSlot += 15;
                     else
@@ -1294,4 +1308,10 @@
         }
 
+        private void refreshSkyMindNetworkState()
+        {
+            reProcessNbSlot();
+            checkNeedRandomlyDisconnectUsers();
+        }
+
 
         public void reProcessNbSecuritySlot()
@@ -1390,4 +1410,5 @@
         public int getNbSlotAvailable()
         {
+            refreshSkyMindNetworkState();
             return nbSlot;
         }
@@ -1458,4 +1479,12 @@
         public bool isConnectedToSkyMind(Thing colonist, bool tryAutoConnect=false, bool broadcastEvent=true)
         {
+            if (Utils.IsDeadPawnOrCorpse(colonist))
+            {
+                disconnectUser(colonist, false, false);
+                return false;
+            }
+
+            refreshSkyMindNetworkState();
+
             if (connectedThing.Contains(colonist))
                 return true;
@@ -1469,5 +1498,5 @@
                     {
                         CompSkyCloudCore csc = Utils.getCachedCSC(cso.skyCloudHost);
-                        if (csc != null && csc.Booted())
+                        if (csc != null && csc.isOnline() && csc.Booted())
                             return true;
                     }
@@ -1485,4 +1514,12 @@
         public bool connectUser(Thing thing, bool broadcastEvent=true)
         {
+            if (Utils.IsDeadPawnOrCorpse(thing))
+            {
+                disconnectUser(thing, false, false);
+                return false;
+            }
+
+            refreshSkyMindNetworkState();
+
             bool containsThing = connectedThing.Contains(thing);
             //Si déjà connecté return TRUE
@@ -1492,6 +1529,10 @@
             }
 
+            CompSkyMind csm = Utils.getCachedCSM(thing);
+            if (csm != null && !csm.canBeConnectedToSkyMind())
+                return false;
+
             //Nbslot available exceeded ? ==> no Skymind connection
-            if(connectedThing.Count() >= nbSlot)
+            if(nbSlot <= 0 || connectedThing.Count() >= nbSlot)
             {
                 return false;
@@ -1917,5 +1958,5 @@
         public void checkRemoveAndroidFactions()
         {
-            if (!Settings.androidsAreRare)
+            if (!Settings.androidsAreRare || Utils.IsAndroidPlayerScenario())
                 return;
 
@@ -2142,4 +2183,9 @@
         }
 
+        public HashSet<Thing> getAllSkyCloudCores()
+        {
+            return listerSkyCloudCoresAbs;
+        }
+
         public bool isThereSkyCloudCore()
         {
@@ -2212,4 +2258,7 @@
         public void pushSkyMindable(Thing thing)
         {
+            if (Utils.IsDeadPawnOrCorpse(thing))
+                return;
+
             if (listerSkyMindable.Contains(thing))
                 return;
@@ -2445,3 +2494,3 @@
 
     }
-}+}
```

### Utils/ReflectionUtility.cs
```diff
--- v1.3/Utils/ReflectionUtility.cs
+++ v1.6/Utils/ReflectionUtility.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using System.Reflection;
 
```

### Utils/Tex.cs
```diff
--- v1.3/Utils/Tex.cs
+++ v1.6/Utils/Tex.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using System.Collections.Generic;
 using System.Linq;
```

### Utils/Utils.cs
```diff
--- v1.3/Utils/Utils.cs
+++ v1.6/Utils/Utils.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using System.Collections.Generic;
 using System.Linq;
@@ -11,4 +11,5 @@
 using Verse.Sound;
 using Verse.AI;
+using RimWorld.Planet;
 
 namespace MOARANDROIDS
@@ -19,4 +20,212 @@
         public static bool init = false;
         public static Harmony harmonyInstance;
+
+        public static GameConditionDef SolarFlare => DefDatabase<GameConditionDef>.GetNamedSilentFail("SolarFlare");
+
+        public static InspirationDef InspiredSurgery => DefDatabase<InspirationDef>.GetNamedSilentFail("Inspired_Surgery");
+
+        public static bool IsDeadPawnOrCorpse(Thing thing)
+        {
+            if (thing is Corpse)
+                return true;
+
+            Pawn pawn = thing as Pawn;
+            return pawn != null && pawn.Dead;
+        }
+
+        public static bool IsM7OrM8(Thing thing)
+        {
+            Pawn pawn = thing as Pawn;
+            return pawn != null && pawn.def != null && (pawn.def.defName == M7 || pawn.def.defName == M8);
+        }
+
+        public static bool IsAndroidPlayerFactionDef(FactionDef factionDef)
+        {
+            if (factionDef == null)
+                return false;
+
+            return factionDef.defName == "PlayerColonyAndroid"
+                || factionDef.defName == "AndroidTiers_PlayerColonyROM"
+                || factionDef.defName == "AndroidTiers_PlayerColonyApocalypse";
+        }
+
+        public static bool IsAndroidPlayerScenario()
+        {
+            return IsAndroidPlayerFactionDef(CurrentScenarioPlayerFactionDef());
+        }
+
+        public static bool IsAndroidApocalypseScenario()
+        {
+            FactionDef factionDef = CurrentScenarioPlayerFactionDef();
+            return factionDef != null && factionDef.defName == "AndroidTiers_PlayerColonyApocalypse";
+        }
+
+        public static FactionDef CurrentScenarioPlayerFactionDef()
+        {
+            Scenario scenario = Current.Game?.Scenario;
+            if (scenario == null)
+                return null;
+
+            ScenPart_PlayerFaction playerFaction = scenario.AllParts?.OfType<ScenPart_PlayerFaction>().FirstOrDefault();
+            if (playerFaction == null)
+                return null;
+
+            return Traverse.Create(playerFaction).Field("factionDef").GetValue<FactionDef>();
+        }
+
+        public static PawnGenerationRequest NewPawnGenerationRequest(PawnKindDef kind, Faction faction = null, PawnGenerationContext context = PawnGenerationContext.NonPlayer, PlanetTile? tile = null, bool forceGenerateNewPawn = false, bool newborn = false, bool allowDead = false, bool allowDowned = false, bool canGeneratePawnRelations = true, bool mustBeCapableOfViolence = false, float colonistRelationChanceFactor = 1f, bool forceAddFreeWarmLayerIfNeeded = false, bool allowGay = true, bool allowFood = true, bool allowAddictions = true, bool inhabitant = false, bool certainlyBeenInCryptosleep = false, bool forceRedressWorldPawnIfFormerColonist = false, bool worldPawnFactionDoesntMatter = false, float biocodeWeaponChance = 0f, float biocodeApparelChance = 0f, Pawn extraPawnForExtraRelationChance = null, float relationWithExtraPawnChanceFactor = 1f, Predicate<Pawn> validatorPreGear = null, Predicate<Pawn> validatorPostGear = null, IEnumerable<TraitDef> forcedTraits = null, IEnumerable<TraitDef> prohibitedTraits = null, float? minChanceToRedressWorldPawn = null, float? fixedBiologicalAge = null, float? fixedChronologicalAge = null, Gender? fixedGender = null, object fixedMelanin = null, string fixedLastName = null, string fixedBirthName = null, RoyalTitleDef fixedTitle = null, Ideo fixedIdeo = null, bool forceNoIdeo = false, bool forceNoBackstory = false, bool forbidAnyTitle = false, bool forceDead = false)
+        {
+            return new PawnGenerationRequest(
+                kind: kind,
+                faction: faction,
+                context: context,
+                tile: tile,
+                forceGenerateNewPawn: forceGenerateNewPawn,
+                allowDead: allowDead,
+                allowDowned: allowDowned,
+                canGeneratePawnRelations: canGeneratePawnRelations,
+                mustBeCapableOfViolence: mustBeCapableOfViolence,
+                colonistRelationChanceFactor: colonistRelationChanceFactor,
+                forceAddFreeWarmLayerIfNeeded: forceAddFreeWarmLayerIfNeeded,
+                allowGay: allowGay,
+                allowPregnant: false,
+                allowFood: allowFood,
+                allowAddictions: allowAddictions,
+                inhabitant: inhabitant,
+                certainlyBeenInCryptosleep: certainlyBeenInCryptosleep,
+                forceRedressWorldPawnIfFormerColonist: forceRedressWorldPawnIfFormerColonist,
+                worldPawnFactionDoesntMatter: worldPawnFactionDoesntMatter,
+                biocodeWeaponChance: biocodeWeaponChance,
+                biocodeApparelChance: biocodeApparelChance,
+                extraPawnForExtraRelationChance: extraPawnForExtraRelationChance,
+                relationWithExtraPawnChanceFactor: relationWithExtraPawnChanceFactor,
+                validatorPreGear: validatorPreGear,
+                validatorPostGear: validatorPostGear,
+                forcedTraits: forcedTraits,
+                prohibitedTraits: prohibitedTraits,
+                minChanceToRedressWorldPawn: minChanceToRedressWorldPawn,
+                fixedBiologicalAge: fixedBiologicalAge,
+                fixedChronologicalAge: fixedChronologicalAge,
+                fixedGender: fixedGender,
+                fixedLastName: fixedLastName,
+                fixedBirthName: fixedBirthName,
+                fixedTitle: fixedTitle,
+                fixedIdeo: fixedIdeo,
+                forceNoIdeo: forceNoIdeo,
+                forceNoBackstory: forceNoBackstory,
+                forbidAnyTitle: forbidAnyTitle,
+                forceDead: forceDead,
+                developmentalStages: newborn ? DevelopmentalStage.Baby : DevelopmentalStage.Adult);
+        }
+
+        public static BackstoryDef GetBackstoryByIdentifier(string identifier, BackstorySlot? slot = null)
+        {
+            if (identifier.NullOrEmpty())
+                return null;
+
+            return DefDatabase<BackstoryDef>.AllDefsListForReading.FirstOrDefault((BackstoryDef b) =>
+            {
+                if (b == null)
+                    return false;
+
+                if (slot.HasValue && b.slot != slot.Value)
+                    return false;
+
+                bool identifierMatch = !b.identifier.NullOrEmpty()
+                    && (b.identifier == identifier || b.identifier.StartsWith(identifier));
+
+                bool defNameMatch = !b.defName.NullOrEmpty()
+                    && (b.defName == identifier || b.defName.StartsWith(identifier));
+
+                return identifierMatch || defNameMatch;
+            });
+        }
+
+        public static BackstoryDef BackstoryForCopy(BackstoryDef source, BackstoryDef fallback, BackstorySlot slot, bool required = false)
+        {
+            BackstoryDef backstory = ResolveBackstoryForSlot(source, slot)
+                ?? ResolveBackstoryForSlot(fallback, slot);
+
+            if (backstory != null || !required)
+                return backstory;
+
+            if (slot == BackstorySlot.Childhood)
+            {
+                backstory = DefDatabase<BackstoryDef>.GetNamedSilentFail("AndroidBackstory")
+                    ?? DefDatabase<BackstoryDef>.GetNamedSilentFail("CreationBlankSlate");
+            }
+
+            return backstory ?? DefDatabase<BackstoryDef>.AllDefsListForReading.FirstOrDefault(b => b != null && b.slot == slot);
+        }
+
+        private static BackstoryDef ResolveBackstoryForSlot(BackstoryDef backstory, BackstorySlot slot)
+        {
+            if (backstory == null || backstory.slot != slot)
+                return null;
+
+            return GetBackstoryByIdentifier(backstory.identifier, slot)
+                ?? GetBackstoryByIdentifier(backstory.defName, slot)
+                ?? backstory;
+        }
+
+        public static void ResolvePawnGraphics(Pawn pawn)
+        {
+            pawn?.Drawer?.renderer?.SetAllGraphicsDirty();
+            if (pawn != null)
+                PortraitsCache.SetDirty(pawn);
+        }
+
+        public static void PrepareSkyCloudStoredMind(Pawn mind, bool markColonistBarDirty = true)
+        {
+            if (mind == null)
+                return;
+
+            try
+            {
+                if (Find.Selector != null && Find.Selector.IsSelected(mind))
+                    Find.Selector.Deselect(mind);
+            }
+            catch (Exception)
+            {
+            }
+
+            if (!mind.Spawned && mind.Faction == null && Faction.OfPlayer != null)
+                mind.SetFactionDirect(Faction.OfPlayer);
+
+            if (markColonistBarDirty && Find.ColonistBar != null)
+                Find.ColonistBar.MarkColonistsDirty();
+        }
+
+        public static IEnumerable<Pawn> GetSkyCloudStoredMinds()
+        {
+            HashSet<Pawn> minds = new HashSet<Pawn>();
+
+            if (GCATPP == null)
+                return minds;
+
+            AddSkyCloudStoredMindsFromCores(GCATPP.getAvailableSkyCloudCores(), minds);
+            AddSkyCloudStoredMindsFromCores(GCATPP.getAllSkyCloudCores(), minds);
+
+            return minds;
+        }
+
+        private static void AddSkyCloudStoredMindsFromCores(IEnumerable<Thing> cores, HashSet<Pawn> minds)
+        {
+            if (cores == null || minds == null)
+                return;
+
+            foreach (Thing core in cores)
+            {
+                CompSkyCloudCore csc = getCachedCSC(core);
+                if (csc == null || csc.storedMinds == null)
+                    continue;
+
+                foreach (Pawn mind in csc.storedMinds)
+                {
+                    if (mind != null)
+                        minds.Add(mind);
+                }
+            }
+        }
 
         public static HashSet<WorkGiverDef> CrafterDoctorJob;
@@ -33,5 +242,4 @@
         static public bool SEARCHANDDESTROY_LOADED = false;
         static public bool POWERPP_LOADED = false;
-        static public bool ANDROIDTIERSGYNOID_LOADED = false;
         static public bool QEE_LOADED = false;
         static public bool RIMMSQOL_LOADED = false;
@@ -216,5 +424,5 @@
         public static string[] ExceptionBionicHaveHand = new string[] { "MiningArm", "HydraulicArm", "MakeshiftRArm", "BRArm", "ARArm", "AR2Arm" }.GetSortedArray();
 
-        public static HashSet<string> ExceptionPlayerStartingAndroidPawnKindList = new HashSet<string> { "AndroidT1ColonistGeneral", "AndroidT2ColonistGeneral", "AndroidT3ColonistGeneral", "AndroidT4ColonistGeneral", "AndroidT5ColonistGeneral", "ATPP_Android2TXKind", "ATPP_Android3TXKind", "ATPP_Android4TXKind", "ATPP_Android2KTXKind", "ATPP_Android2KITXKind", "ATPP_Android2ITXKind", "ATPP_Android3ITXKind", "ATPP_Android4ITXKind" };
+        public static HashSet<string> ExceptionPlayerStartingAndroidPawnKindList = new HashSet<string> { "AndroidT1ColonistGeneral", "AndroidT2ColonistGeneral", "AndroidT3ColonistGeneral", "AndroidT4ColonistGeneral", "AndroidT5ColonistGeneral", "M7MechPawn", "M8MechPawn", "ATPP_Android2TXKind", "ATPP_Android3TXKind", "ATPP_Android4TXKind", "ATPP_Android2KTXKind", "ATPP_Android2KITXKind", "ATPP_Android2ITXKind", "ATPP_Android3ITXKind", "ATPP_Android4ITXKind" };
 
         public static HashSet<string> ExceptionAndroidsDontRust = new HashSet<string> { "ATPP_Android2TX", "ATPP_Android3TX", "ATPP_Android4TX", "ATPP_Android2KTX", "ATPP_Android2ITX", "ATPP_Android3ITX", "ATPP_Android4ITX", "ATPP_Android2KITX" };
@@ -235,5 +443,5 @@
         public static HashSet<string> ExceptionAndroidListAll = new HashSet<string>();
 
-        public static HashSet<string> BlacklistAndroidHediff = new HashSet<string> { "VacuumDamageHediff", "ZeroGSickness", "SpaceHypoxia", "ClinicalDeathAsphyxiation", "ClinicalDeathNoHeartbeat", "FatalRad", "RimatomicsRadiation", "RadiationIncurable" };
+        public static HashSet<string> BlacklistAndroidHediff = new HashSet<string> { "VacuumDamageHediff", "VacuumBurn", "ZeroGSickness", "SpaceHypoxia", "ClinicalDeathAsphyxiation", "ClinicalDeathNoHeartbeat", "FatalRad", "RimatomicsRadiation", "RadiationIncurable" };
         public static string[] BlacklistMindTraits = new string[] { "NightOwl", "Insomniac", "Codependent", "HeavySleeper", "Polygamous", "Beauty", "Immunity" }.GetSortedArray();
         public static HashSet<string> BlacklistAndroidFood = new HashSet<string> { "SmokeleafJoint", "Yayo", "PsychiteTea", "Flake", "Penoxycyline", "Luciferium", "GoJuice", "Ambrosia", "Beer", "RC2_Coffee", "" };
@@ -1076,5 +1284,5 @@
             }
 
-            PawnGenerationRequest request = new PawnGenerationRequest(kindDef, faction, PawnGenerationContext.NonPlayer, tile, false, false, false, false, true, true, 1f, false, true, allowFood, false,inhabitant, false, false, fixedGender : gender);
+            PawnGenerationRequest request = Utils.NewPawnGenerationRequest(kindDef, faction, PawnGenerationContext.NonPlayer, tile, false, false, false, false, true, true, 1f, false, true, allowFood, false,inhabitant, false, false, fixedGender : gender);
             Pawn surrogate = PawnGenerator.GeneratePawn(request);
             initBodyAsSurrogate(surrogate);
@@ -1161,5 +1369,5 @@
         public static bool isThereSolarFlare()
         {
-            return Find.World.gameConditionManager.ConditionIsActive(GameConditionDefOf.SolarFlare);
+            return Find.World.gameConditionManager.ConditionIsActive(Utils.SolarFlare);
         }
 
@@ -1496,24 +1704,23 @@
                 Pawn_StoryTracker st = new Pawn_StoryTracker(dest);
                 //Recopie atraits physique de la destination
-                st.melanin = dest.story.melanin;
+                st.SkinColorBase = dest.story.SkinColorBase;
                 UnityEngine.Color hair = new UnityEngine.Color();
-                hair.a = dest.story.hairColor.a;
-                hair.r = dest.story.hairColor.r;
-                hair.g = dest.story.hairColor.g;
-                hair.b = dest.story.hairColor.b;
-                st.hairColor = hair;
-                st.crownType = dest.story.crownType;
+                hair.a = dest.story.HairColor.a;
+                hair.r = dest.story.HairColor.r;
+                hair.g = dest.story.HairColor.g;
+                hair.b = dest.story.HairColor.b;
+                st.HairColor = hair;
+                st.headType = dest.story.headType;
                 st.hairDef = dest.story.hairDef;
                 //duplication adultHood de la source
-                if (source.story != null && source.story.adulthood != null)
-                {
-                    Backstory ah = new Backstory();
-                    BackstoryDatabase.TryGetWithIdentifier(source.story.adulthood.identifier, out ah);
-                    st.adulthood = ah;
+                if (source.story != null && source.story.Adulthood != null)
+                {
+                    BackstoryDef ah = Utils.BackstoryForCopy(source.story.Adulthood, dest.story?.Adulthood, BackstorySlot.Adulthood);
+                    st.Adulthood = ah;
                 }
                 //duplication childHood de la source
-                Backstory ch = new Backstory();
-                BackstoryDatabase.TryGetWithIdentifier(source.story.childhood.identifier, out ch);
-                st.childhood = ch;
+                BackstoryDef ch = Utils.BackstoryForCopy(source.story?.Childhood, dest.story?.Childhood, BackstorySlot.Childhood, true);
+                if (ch != null)
+                    st.Childhood = ch;
                 //Recopie attraits du corp de la destination
                 st.bodyType = dest.story.bodyType;
@@ -1593,5 +1800,5 @@
                 dest.Name = new NameTriple(nam.First, nam.Nick, nam.Last);
 
-                dest.Drawer.renderer.graphics.ResolveAllGraphics();
+                Utils.ResolvePawnGraphics(dest);
 
                 //-----------Report agenda worksettings and policies
@@ -1618,5 +1825,5 @@
                         }
                     }
-                    dest.playerSettings.AreaRestriction = source.playerSettings.AreaRestriction;
+                    dest.playerSettings.AreaRestrictionInPawnCurrentMap = source.playerSettings.AreaRestrictionInPawnCurrentMap;
                     dest.playerSettings.hostilityResponse = source.playerSettings.hostilityResponse;
 
@@ -1626,7 +1833,7 @@
                     }
 
-                    dest.foodRestriction.CurrentFoodRestriction = source.foodRestriction.CurrentFoodRestriction;
+                    dest.foodRestriction.CurrentFoodPolicy = source.foodRestriction.CurrentFoodPolicy;
                     dest.drugs.CurrentPolicy = source.drugs.CurrentPolicy;
-                    dest.outfits.CurrentOutfit = source.outfits.CurrentOutfit;
+                    dest.outfits.CurrentApparelPolicy = source.outfits.CurrentApparelPolicy;
                 }
                 catch (Exception)
@@ -1684,26 +1891,26 @@
                 Pawn_StoryTracker st1 = new Pawn_StoryTracker(p2);
                 //Recopie atraits physique de la destination
-                st1.melanin = p2.story.melanin;
+                st1.SkinColorBase = p2.story.SkinColorBase;
                 
                 UnityEngine.Color hair1 = new UnityEngine.Color();
-                hair1.a = p2.story.hairColor.a;
-                hair1.r = p2.story.hairColor.r;
-                hair1.g = p2.story.hairColor.g;
-                hair1.b = p2.story.hairColor.b;
+                hair1.a = p2.story.HairColor.a;
+                hair1.r = p2.story.HairColor.r;
+                hair1.g = p2.story.HairColor.g;
+                hair1.b = p2.story.HairColor.b;
                 //Log.Message("L1");
-                st1.hairColor = hair1;
-                st1.crownType = p2.story.crownType;
+                st1.HairColor = hair1;
+                st1.headType = p2.story.headType;
                 st1.hairDef = p2.story.hairDef;
                 //duplication adultHood de la source
-                Backstory ah = new Backstory();
-                if (p1.story != null && p1.story.adulthood != null)
-                {
-                    BackstoryDatabase.TryGetWithIdentifier(p1.story.adulthood.identifier, out ah);
-                    st1.adulthood = ah;
+                BackstoryDef ah = null;
+                if (p1.story != null && p1.story.Adulthood != null)
+                {
+                    ah = Utils.BackstoryForCopy(p1.story.Adulthood, p2.story?.Adulthood, BackstorySlot.Adulthood);
+                    st1.Adulthood = ah;
                     //duplication childHood de la source
                 }
-                Backstory ch = new Backstory();
-                BackstoryDatabase.TryGetWithIdentifier(p1.story.childhood.identifier, out ch);
-                st1.childhood = ch;
+                BackstoryDef ch = Utils.BackstoryForCopy(p1.story?.Childhood, p2.story?.Childhood, BackstorySlot.Childhood, true);
+                if (ch != null)
+                    st1.Childhood = ch;
                 //Log.Message("L2");
                 //Recopie attraits du corp de la destination
@@ -1724,25 +1931,24 @@
                 Pawn_StoryTracker st2 = new Pawn_StoryTracker(p1);
                 //Recopie atraits physique de la destination
-                st2.melanin = p1.story.melanin;
+                st2.SkinColorBase = p1.story.SkinColorBase;
                 UnityEngine.Color hair2 = new UnityEngine.Color();
-                hair2.a = p1.story.hairColor.a;
-                hair2.r = p1.story.hairColor.r;
-                hair2.g = p1.story.hairColor.g;
-                hair2.b = p1.story.hairColor.b;
-                st2.hairColor = hair2;
+                hair2.a = p1.story.HairColor.a;
+                hair2.r = p1.story.HairColor.r;
+                hair2.g = p1.story.HairColor.g;
+                hair2.b = p1.story.HairColor.b;
+                st2.HairColor = hair2;
                 //Log.Message("L4");
-                st2.crownType = p1.story.crownType;
+                st2.headType = p1.story.headType;
                 st2.hairDef = p1.story.hairDef;
                 //duplication adultHood de la source
-                if (p2.story != null && p2.story.adulthood != null)
-                {
-                    Backstory ah2 = new Backstory();
-                    BackstoryDatabase.TryGetWithIdentifier(p2.story.adulthood.identifier, out ah2);
-                    st2.adulthood = ah2;
+                if (p2.story != null && p2.story.Adulthood != null)
+                {
+                    BackstoryDef ah2 = Utils.BackstoryForCopy(p2.story.Adulthood, p1.story?.Adulthood, BackstorySlot.Adulthood);
+                    st2.Adulthood = ah2;
                 }
                 //duplication childHood de la source
-                Backstory ch2 = new Backstory();
-                BackstoryDatabase.TryGetWithIdentifier(p2.story.childhood.identifier, out ch2);
-                st2.childhood = ch2;
+                BackstoryDef ch2 = Utils.BackstoryForCopy(p2.story?.Childhood, p1.story?.Childhood, BackstorySlot.Childhood, true);
+                if (ch2 != null)
+                    st2.Childhood = ch2;
                 //Log.Message("L5");
                 //Recopie attraits du corp de la destination
@@ -2023,6 +2229,6 @@
                 p2.Name = nam;
 
-                p1.Drawer.renderer.graphics.ResolveAllGraphics();
-                p2.Drawer.renderer.graphics.ResolveAllGraphics();
+                Utils.ResolvePawnGraphics(p1);
+                Utils.ResolvePawnGraphics(p2);
 
                 if (p1.workSettings == null)
@@ -2052,5 +2258,5 @@
                         }
                         Pawn_PlayerSettings p1PS = new Pawn_PlayerSettings(p1);
-                        p1PS.AreaRestriction = p1.playerSettings.AreaRestriction;
+                        p1PS.AreaRestrictionInPawnCurrentMap = p1.playerSettings.AreaRestrictionInPawnCurrentMap;
                         p1PS.hostilityResponse = p1.playerSettings.hostilityResponse;
                         Pawn_TimetableTracker p1TT = new Pawn_TimetableTracker(p1);
@@ -2059,10 +2265,10 @@
                             p1TT.SetAssignment(i, p1.timetable.GetAssignment(i));
                         }
-                        FoodRestriction p1FR;
-                        p1FR = p1.foodRestriction.CurrentFoodRestriction;
+                        FoodPolicy p1FR;
+                        p1FR = p1.foodRestriction.CurrentFoodPolicy;
                         DrugPolicy p1DR;
                         p1DR = p1.drugs.CurrentPolicy;
-                        Outfit p1O;
-                        p1O = p1.outfits.CurrentOutfit;
+                        ApparelPolicy p1O;
+                        p1O = p1.outfits.CurrentApparelPolicy;
 
                         //-----------Report agenda worksettings and policies from P2 to P1
@@ -2072,5 +2278,5 @@
                                 p1.workSettings.SetPriority(el, p2.workSettings.GetPriority(el));
                         }
-                        p1.playerSettings.AreaRestriction = p2.playerSettings.AreaRestriction;
+                        p1.playerSettings.AreaRestrictionInPawnCurrentMap = p2.playerSettings.AreaRestrictionInPawnCurrentMap;
                         p1.playerSettings.hostilityResponse = p2.playerSettings.hostilityResponse;
 
@@ -2080,7 +2286,7 @@
                         }
 
-                        p1.foodRestriction.CurrentFoodRestriction = p2.foodRestriction.CurrentFoodRestriction;
+                        p1.foodRestriction.CurrentFoodPolicy = p2.foodRestriction.CurrentFoodPolicy;
                         p1.drugs.CurrentPolicy = p2.drugs.CurrentPolicy;
-                        p1.outfits.CurrentOutfit = p2.outfits.CurrentOutfit;
+                        p1.outfits.CurrentApparelPolicy = p2.outfits.CurrentApparelPolicy;
 
                         //-----------Report agenda worksettings and policies from P1 to P2
@@ -2090,5 +2296,5 @@
                                 p2.workSettings.SetPriority(el, p1WS.GetPriority(el));
                         }
-                        p2.playerSettings.AreaRestriction = p1PS.AreaRestriction;
+                        p2.playerSettings.AreaRestrictionInPawnCurrentMap = p1PS.AreaRestrictionInPawnCurrentMap;
                         p2.playerSettings.hostilityResponse = p1PS.hostilityResponse;
 
@@ -2098,7 +2304,7 @@
                         }
 
-                        p2.foodRestriction.CurrentFoodRestriction = p1FR;
+                        p2.foodRestriction.CurrentFoodPolicy = p1FR;
                         p2.drugs.CurrentPolicy = p1DR;
-                        p2.outfits.CurrentOutfit = p1O;
+                        p2.outfits.CurrentApparelPolicy = p1O;
                     }
                     catch(Exception)
@@ -2417,5 +2623,5 @@
             }
 
-            return true && !Find.World.gameConditionManager.ConditionIsActive(GameConditionDefOf.SolarFlare);
+            return true && !Find.World.gameConditionManager.ConditionIsActive(Utils.SolarFlare);
         }
 
@@ -2571,5 +2777,5 @@
                 pgc = PawnGenerationContext.PlayerStarter;*/
 
-            PawnGenerationRequest request = new PawnGenerationRequest(kind: pawn.kindDef, faction: Faction.OfAncients, context: PawnGenerationContext.NonPlayer, fixedBiologicalAge: pawn.ageTracker.AgeBiologicalYearsFloat, fixedChronologicalAge: pawn.ageTracker.AgeChronologicalYearsFloat, fixedGender: pawn.gender, fixedMelanin: pawn.story.melanin);
+            PawnGenerationRequest request = Utils.NewPawnGenerationRequest(kind: pawn.kindDef, faction: Faction.OfAncients, context: PawnGenerationContext.NonPlayer, fixedBiologicalAge: pawn.ageTracker.AgeBiologicalYearsFloat, fixedChronologicalAge: pawn.ageTracker.AgeChronologicalYearsFloat, fixedGender: pawn.gender, fixedMelanin: pawn.story.SkinColorBase);
             Pawn p = PawnGenerator.GeneratePawn(request);
 
@@ -2582,13 +2788,13 @@
             //duplication apparence physique
             //p.gender = pawn.gender;
-            p.story.melanin = pawn.story.melanin;
+            p.story.SkinColorBase = pawn.story.SkinColorBase;
             p.story.bodyType = pawn.story.bodyType;
             UnityEngine.Color hair = new UnityEngine.Color();
-            hair.a = pawn.story.hairColor.a;
-            hair.r = pawn.story.hairColor.r;
-            hair.g = pawn.story.hairColor.g;
-            hair.b = pawn.story.hairColor.b;
-            p.story.hairColor = hair;
-            p.story.crownType = pawn.story.crownType;
+            hair.a = pawn.story.HairColor.a;
+            hair.r = pawn.story.HairColor.r;
+            hair.g = pawn.story.HairColor.g;
+            hair.b = pawn.story.HairColor.b;
+            p.story.HairColor = hair;
+            p.story.headType = pawn.story.headType;
             p.story.hairDef = pawn.story.hairDef;
 
@@ -2673,5 +2879,5 @@
 
             //headGraphicPathToUse = pawn.story.HeadGraphicPath;
-            p.Drawer.renderer.graphics.ResolveAllGraphics();
+            Utils.ResolvePawnGraphics(p);
             //headGraphicPathToUse = "";
 
@@ -2984,5 +3190,5 @@
                 ddf = DamageDefOf.Flame;
 
-            GenExplosion.DoExplosion(android.Position, android.Map, radius, ddf, android, -1, -1f, null, null, null, null, null, 0f, 1, false, null, 0f, 1, 0f, false);
+            GenExplosion.DoExplosion(android.Position, android.Map, radius, ddf, android);
 
             if (!android.Dead)
```

### WorkGivers/WorkGiver_RescueSurrogates.cs
```diff
--- v1.3/WorkGivers/WorkGiver_RescueSurrogates.cs
+++ v1.6/WorkGivers/WorkGiver_RescueSurrogates.cs
@@ -1,3 +1,3 @@
-﻿using RimWorld;
+using RimWorld;
 using System;
 using System.Collections.Generic;
```

### WorldObjectDef_DownedT5Android.cs
```diff
--- v1.3/WorldObjectDef_DownedT5Android.cs
+++ v1.6/WorldObjectDef_DownedT5Android.cs
@@ -1,3 +1,3 @@
-﻿using System;
+using System;
 using RimWorld.Planet;
 using RimWorld;
```

