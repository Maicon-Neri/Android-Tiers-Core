Command line arguments: -disable-compute-shaders
UnityEngine.StackTraceUtility:ExtractStackTrace ()
Verse.Log:Message (string)
Verse.Root:CheckGlobalInit ()
Verse.Root:Start ()
Verse.Root_Entry:Start ()

RimWorld 1.6.4633 rev1261
UnityEngine.StackTraceUtility:ExtractStackTrace ()
Verse.Log:Message (string)
RimWorld.VersionControl:LogVersionNumber ()
Verse.Root:CheckGlobalInit ()
Verse.Root:Start ()
Verse.Root_Entry:Start ()

--- Main thread ---
 126.430ms StaticConstructorOnStartupUtility.CallAll()


Hotspot analysis
----------------------------------------
1x StaticConstructorOnStartupUtility.CallAll() -> 126.430 ms (total (w/children): 126.430 ms)

UnityEngine.StackTraceUtility:ExtractStackTrace ()
Verse.Log:Message (string)
Verse.ThreadLocalDeepProfiler:Output (Verse.ThreadLocalDeepProfiler/Watcher)
Verse.ThreadLocalDeepProfiler:End ()
Verse.DeepProfiler:End ()
Verse.StaticConstructorOnStartupUtility:CallAll ()
Verse.LongEventHandler:UpdateCurrentSynchronousEvent (bool&)
Verse.LongEventHandler:LongEventsUpdate (bool&)
Verse.Root:Update ()
Verse.Root_Entry:Update ()

Rebuilding mods list
Adding official mods from content folder:
  Adding Ludeon.RimWorld.Anomaly(E:\SteamLibrary\steamapps\common\RimWorld\Data\Anomaly)
  Adding Ludeon.RimWorld.Biotech(E:\SteamLibrary\steamapps\common\RimWorld\Data\Biotech)
  Adding Ludeon.RimWorld(E:\SteamLibrary\steamapps\common\RimWorld\Data\Core)
  Adding Ludeon.RimWorld.Ideology(E:\SteamLibrary\steamapps\common\RimWorld\Data\Ideology)
  Adding Ludeon.RimWorld.Odyssey(E:\SteamLibrary\steamapps\common\RimWorld\Data\Odyssey)
  Adding Ludeon.RimWorld.Royalty(E:\SteamLibrary\steamapps\common\RimWorld\Data\Royalty)
Adding mods from mods folder:
  Adding Atlas.AndroidTiers(E:\SteamLibrary\steamapps\common\RimWorld\Mods\Android-Tiers-Core)
Adding mods from Steam:
  Adding Atlas.AndroidTiers(E:\SteamLibrary\steamapps\workshop\content\294100\3546710219)
  Adding CarnySenpai.EnableOversizedWeapons(E:\SteamLibrary\steamapps\workshop\content\294100\2543371889)
  Adding erdelf.HumanoidAlienRaces(E:\SteamLibrary\steamapps\workshop\content\294100\839005762)
  Adding brrainz.harmony(E:\SteamLibrary\steamapps\workshop\content\294100\2009463077)
Deactivating not-installed mods:
UnityEngine.StackTraceUtility:ExtractStackTrace ()
Verse.Log:Message (string)
Verse.ModLister:RebuildModList ()
Verse.ModLister:.cctor ()
Verse.ModsConfig:.cctor ()
Verse.LoadedModManager:InitializeMods ()
Verse.LoadedModManager:LoadAllActiveMods (bool)
Verse.PlayDataLoader:DoPlayLoad ()
Verse.PlayDataLoader:LoadAllPlayData (bool)
Verse.Root/<>c:<Start>b__10_1 ()
Verse.LongEventHandler:RunEventFromAnotherThread (System.Action)
Verse.LongEventHandler/<>c:<UpdateCurrentAsynchronousEvent>b__28_0 ()
System.Threading.ThreadHelper:ThreadStart_Context (object)
System.Threading.ExecutionContext:RunInternal (System.Threading.ExecutionContext,System.Threading.ContextCallback,object,bool)
System.Threading.ExecutionContext:Run (System.Threading.ExecutionContext,System.Threading.ContextCallback,object,bool)
System.Threading.ExecutionContext:Run (System.Threading.ExecutionContext,System.Threading.ContextCallback,object)
System.Threading.ThreadHelper:ThreadStart ()

--- Thread 18 ---
 5237.563ms (self: 1.770 ms) LoadAllPlayData
 - 2011.749ms (38%) (self: 0.627 ms) Load all active mods.
 - - 984.390ms (49%) (self: 5.265 ms) ParseAndProcessXML()
 - - - 849.671ms (86%) (self: 49.331 ms) Loading defs for 14809 nodes
 - - - - 234.048ms (28%) (self: 200.510 ms) 1962x ParseValueAndReturnDef (for Verse.ThingDef)
 - - - - - 14.653ms (6.3%) (self: 14.653 ms) 89x CreateFieldSetterForType
 - - - - - 8.838ms (3.8%) (self: 8.838 ms) 12188x RegisterObjectWantsCrossRef (object,string,string)
 - - - - - 5.019ms (2.1%) (self: 5.019 ms) 12208x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - - 2.929ms (1.3%) (self: 2.929 ms) 6080x RegisterListWantsCrossRef
 - - - - - 2.039ms (0.87%) (self: 2.039 ms) 17x CreateListItemAdderForType
 - - - - - 0.051ms (0.02%) (self: 0.051 ms) 11x Search for field alias
 - - - - - 0.006ms (0%) (self: 0.006 ms) RegisterDictionaryWantsCrossRef
 - - - - - 0.004ms (0%) (self: 0.004 ms) 6x RegisterObjectWantsCrossRef (object,string,XmlNode)
 - - - - 43.849ms (5.2%) (self: 36.354 ms) 313x ParseValueAndReturnDef (for Verse.PawnKindDef)
 - - - - - 3.055ms (7%) (self: 3.055 ms) 218x RegisterListWantsCrossRef
 - - - - - 2.821ms (6.4%) (self: 2.821 ms) 12x CreateFieldSetterForType
 - - - - - 1.157ms (2.6%) (self: 1.157 ms) 960x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - - 0.389ms (0.89%) (self: 0.389 ms) 2x CreateListItemAdderForType
 - - - - - 0.074ms (0.17%) (self: 0.074 ms) 143x RegisterObjectWantsCrossRef (object,string,string)
 - - - - 40.082ms (4.7%) (self: 32.205 ms) 964x ParseValueAndReturnDef (for RimWorld.BackstoryDef)
 - - - - - 6.474ms (16%) (self: 6.474 ms) 3118x RegisterObjectWantsCrossRef (object,string,string)
 - - - - - 1.124ms (2.8%) (self: 1.124 ms) 1358x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - - 0.236ms (0.59%) (self: 0.236 ms) CreateFieldSetterForType
 - - - - - 0.043ms (0.11%) (self: 0.043 ms) CreateListItemAdderForType
 - - - - 36.379ms (4.3%) (self: 30.169 ms) 151x ParseValueAndReturnDef (for RimWorld.QuestScriptDef)
 - - - - - 5.794ms (16%) (self: 5.794 ms) 93x CreateFieldSetterForType
 - - - - - 0.383ms (1.1%) (self: 0.383 ms) 3x CreateListItemAdderForType
 - - - - - 0.019ms (0.05%) (self: 0.019 ms) 54x RegisterListWantsCrossRef
 - - - - - 0.014ms (0.04%) (self: 0.014 ms) 61x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - 32.127ms (3.8%) (self: 18.227 ms) 427x ParseValueAndReturnDef (for Verse.HediffDef)
 - - - - - 10.339ms (32%) (self: 10.339 ms) 66x CreateListItemAdderForType
 - - - - - 3.092ms (9.6%) (self: 3.092 ms) 20x CreateFieldSetterForType
 - - - - - 0.246ms (0.77%) (self: 0.246 ms) 498x RegisterObjectWantsCrossRef (object,string,string)
 - - - - - 0.162ms (0.5%) (self: 0.162 ms) 872x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - - 0.062ms (0.19%) (self: 0.062 ms) 91x RegisterListWantsCrossRef
 - - - - 22.169ms (2.6%) (self: 19.780 ms) 1282x ParseValueAndReturnDef (for Verse.SoundDef)
 - - - - - 1.282ms (5.8%) (self: 1.282 ms) 12x CreateFieldSetterForType
 - - - - - 1.096ms (4.9%) (self: 1.096 ms) 25x Search for field alias
 - - - - - 0.011ms (0.05%) (self: 0.011 ms) 54x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - 20.645ms (2.4%) (self: 19.775 ms) 66x ParseValueAndReturnDef (for Verse.ThinkTreeDef)
 - - - - - 0.773ms (3.7%) (self: 0.773 ms) 4x CreateFieldSetterForType
 - - - - - 0.082ms (0.4%) (self: 0.082 ms) 214x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - - 0.015ms (0.07%) (self: 0.015 ms) 12x RegisterListWantsCrossRef
 - - - - 19.246ms (2.3%) (self: 16.012 ms) 9x ParseValueAndReturnDef (for AlienRace.ThingDef_AlienRace)
 - - - - - 2.722ms (14%) (self: 2.722 ms) 15x CreateFieldSetterForType
 - - - - - 0.166ms (0.86%) (self: 0.166 ms) 3x CreateListItemAdderForType
 - - - - - 0.165ms (0.86%) (self: 0.165 ms) 328x RegisterObjectWantsCrossRef (object,string,string)
 - - - - - 0.137ms (0.71%) (self: 0.137 ms) 640x RegisterListWantsCrossRef
 - - - - - 0.041ms (0.21%) (self: 0.041 ms) 183x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - - 0.004ms (0.02%) (self: 0.004 ms) 35x TryDoPostLoad
 - - - - 19.128ms (2.3%) (self: 17.569 ms) 990x ParseValueAndReturnDef (for RimWorld.ThoughtDef)
 - - - - - 0.711ms (3.7%) (self: 0.711 ms) 4x CreateFieldSetterForType
 - - - - - 0.646ms (3.4%) (self: 0.646 ms) 582x RegisterListWantsCrossRef
 - - - - - 0.174ms (0.91%) (self: 0.174 ms) CreateListItemAdderForType
 - - - - - 0.018ms (0.1%) (self: 0.018 ms) 94x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - - 0.010ms (0.05%) (self: 0.010 ms) 25x RegisterObjectWantsCrossRef (object,string,string)
 - - - - 15.883ms (1.9%) (self: 14.869 ms) 108x ParseValueAndReturnDef (for Verse.AI.DutyDef)
 - - - - - 1.007ms (6.3%) (self: 1.007 ms) 11x CreateFieldSetterForType
 - - - - - 0.008ms (0.05%) (self: 0.008 ms) 42x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - 15.876ms (1.9%) (self: 13.283 ms) 390x ParseValueAndReturnDef (for Verse.RecipeDef)
 - - - - - 1.091ms (6.9%) (self: 1.091 ms) 7x CreateFieldSetterForType
 - - - - - 0.631ms (4%) (self: 0.631 ms) 1549x RegisterListWantsCrossRef
 - - - - - 0.316ms (2%) (self: 0.316 ms) 1986x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - - 0.297ms (1.9%) (self: 0.297 ms) 659x RegisterObjectWantsCrossRef (object,string,string)
 - - - - - 0.259ms (1.6%) (self: 0.259 ms) 2x CreateListItemAdderForType
 - - - - 12.451ms (1.5%) (self: 8.152 ms) 26x ParseValueAndReturnDef (for RimWorld.TraderKindDef)
 - - - - - 3.829ms (31%) (self: 3.829 ms) 4x CreateFieldSetterForType
 - - - - - 0.339ms (2.7%) (self: 0.339 ms) 2x CreateListItemAdderForType
 - - - - - 0.080ms (0.64%) (self: 0.080 ms) 340x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - - 0.043ms (0.35%) (self: 0.043 ms) 89x RegisterListWantsCrossRef
 - - - - - 0.009ms (0.07%) (self: 0.009 ms) 10x RegisterObjectWantsCrossRef (object,string,string)
 - - - - 11.962ms (1.4%) (self: 8.132 ms) 51x ParseValueAndReturnDef (for RimWorld.ThingSetMakerDef)
 - - - - - 3.651ms (31%) (self: 3.651 ms) 4x CreateFieldSetterForType
 - - - - - 0.170ms (1.4%) (self: 0.170 ms) 626x RegisterListWantsCrossRef
 - - - - - 0.009ms (0.07%) (self: 0.009 ms) 44x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - 11.615ms (1.4%) (self: 9.196 ms) 170x ParseValueAndReturnDef (for Verse.GenStepDef)
 - - - - - 1.992ms (17%) (self: 1.992 ms) 11x CreateFieldSetterForType
 - - - - - 0.304ms (2.6%) (self: 0.304 ms) 6x CreateListItemAdderForType
 - - - - - 0.079ms (0.68%) (self: 0.079 ms) 187x RegisterObjectWantsCrossRef (object,string,string)
 - - - - - 0.037ms (0.32%) (self: 0.037 ms) 203x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - - 0.004ms (0.03%) (self: 0.004 ms) 12x RegisterListWantsCrossRef
 - - - - - 0.003ms (0.02%) (self: 0.003 ms) 3x RegisterObjectWantsCrossRef (object,string,XmlNode)
 - - - - 10.487ms (1.2%) (self: 5.391 ms) 56x ParseValueAndReturnDef (for RimWorld.TraitDef)
 - - - - - 4.508ms (43%) (self: 4.508 ms) 7x CreateFieldSetterForType
 - - - - - 0.431ms (4.1%) (self: 0.431 ms) 3x CreateListItemAdderForType
 - - - - - 0.084ms (0.8%) (self: 0.084 ms) 69x RegisterListWantsCrossRef
 - - - - - 0.072ms (0.68%) (self: 0.072 ms) 80x RegisterObjectWantsCrossRef (object,string,string)
 - - - - - 0.002ms (0.02%) (self: 0.002 ms) 6x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - 9.905ms (1.2%) (self: 6.106 ms) 37x ParseValueAndReturnDef (for RimWorld.FactionDef)
 - - - - - 2.778ms (28%) (self: 2.778 ms) 18x CreateFieldSetterForType
 - - - - - 0.447ms (4.5%) (self: 0.447 ms) 1001x RegisterObjectWantsCrossRef (object,string,string)
 - - - - - 0.320ms (3.2%) (self: 0.320 ms) 4x CreateListItemAdderForType
 - - - - - 0.207ms (2.1%) (self: 0.207 ms) 352x RegisterListWantsCrossRef
 - - - - - 0.047ms (0.48%) (self: 0.047 ms) 281x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - 9.134ms (1.1%) (self: 7.183 ms) 250x ParseValueAndReturnDef (for RimWorld.StatDef)
 - - - - - 1.397ms (15%) (self: 1.397 ms) 9x CreateFieldSetterForType
 - - - - - 0.440ms (4.8%) (self: 0.440 ms) 2x CreateListItemAdderForType
 - - - - - 0.083ms (0.9%) (self: 0.083 ms) 437x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - - 0.031ms (0.34%) (self: 0.031 ms) 33x RegisterListWantsCrossRef
 - - - - 9.123ms (1.1%) (self: 8.872 ms) 348x ParseValueAndReturnDef (for Verse.RulePackDef)
 - - - - - 0.165ms (1.8%) (self: 0.165 ms) CreateFieldSetterForType
 - - - - - 0.087ms (0.95%) (self: 0.087 ms) 255x RegisterListWantsCrossRef
 - - - - 8.911ms (1%) (self: 7.076 ms) 235x ParseValueAndReturnDef (for RimWorld.PreceptDef)
 - - - - - 1.376ms (15%) (self: 1.376 ms) 8x CreateFieldSetterForType
 - - - - - 0.209ms (2.3%) (self: 0.209 ms) 1241x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - - 0.162ms (1.8%) (self: 0.162 ms) 513x RegisterListWantsCrossRef
 - - - - - 0.045ms (0.51%) (self: 0.045 ms) CreateListItemAdderForType
 - - - - - 0.037ms (0.41%) (self: 0.037 ms) 77x RegisterObjectWantsCrossRef (object,string,string)
 - - - - - 0.007ms (0.08%) (self: 0.007 ms) 12x RegisterObjectWantsCrossRef (object,string,XmlNode)
 - - - - 8.512ms (1%) (self: 4.786 ms) 25x ParseValueAndReturnDef (for RimWorld.BiomeDef)
 - - - - - 2.255ms (26%) (self: 2.255 ms) 14x CreateFieldSetterForType
 - - - - - 0.531ms (6.2%) (self: 0.531 ms) 5x CreateListItemAdderForType
 - - - - - 0.498ms (5.8%) (self: 0.498 ms) 902x RegisterObjectWantsCrossRef (object,string,XmlNode)
 - - - - - 0.388ms (4.6%) (self: 0.388 ms) 80x RegisterListWantsCrossRef
 - - - - - 0.054ms (0.64%) (self: 0.054 ms) 336x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - 8.120ms (0.96%) (self: 6.500 ms) 54x ParseValueAndReturnDef (for Verse.BodyDef)
 - - - - - 0.834ms (10%) (self: 0.834 ms) 6x CreateFieldSetterForType
 - - - - - 0.379ms (4.7%) (self: 0.379 ms) 2x CreateListItemAdderForType
 - - - - - 0.207ms (2.5%) (self: 0.207 ms) 1249x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - - 0.200ms (2.5%) (self: 0.200 ms) 638x RegisterListWantsCrossRef
 - - - - 7.930ms (0.93%) (self: 7.435 ms) 283x ParseValueAndReturnDef (for Verse.EffecterDef)
 - - - - - 0.371ms (4.7%) (self: 0.371 ms) 3x CreateFieldSetterForType
 - - - - - 0.124ms (1.6%) (self: 0.124 ms) 713x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - 7.615ms (0.9%) (self: 7.025 ms) 316x ParseValueAndReturnDef (for Verse.FleckDef)
 - - - - - 0.471ms (6.2%) (self: 0.471 ms) 3x CreateFieldSetterForType
 - - - - - 0.080ms (1.1%) (self: 0.080 ms) 407x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - - 0.038ms (0.5%) (self: 0.038 ms) CreateListItemAdderForType
 - - - - 7.059ms (0.83%) (self: 5.673 ms) 99x ParseValueAndReturnDef (for RimWorld.AbilityDef)
 - - - - - 1.002ms (14%) (self: 1.002 ms) 6x CreateFieldSetterForType
 - - - - - 0.242ms (3.4%) (self: 0.242 ms) CreateListItemAdderForType
 - - - - - 0.079ms (1.1%) (self: 0.079 ms) 457x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - - 0.050ms (0.71%) (self: 0.050 ms) 115x RegisterObjectWantsCrossRef (object,string,string)
 - - - - - 0.012ms (0.17%) (self: 0.012 ms) 19x RegisterListWantsCrossRef
 - - - - 6.493ms (0.76%) (self: 4.009 ms) 38x ParseValueAndReturnDef (for RimWorld.MemeDef)
 - - - - - 2.078ms (32%) (self: 2.078 ms) 12x CreateFieldSetterForType
 - - - - - 0.256ms (3.9%) (self: 0.256 ms) 2x CreateListItemAdderForType
 - - - - - 0.123ms (1.9%) (self: 0.123 ms) 165x RegisterListWantsCrossRef
 - - - - - 0.019ms (0.29%) (self: 0.019 ms) 108x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - - 0.008ms (0.12%) (self: 0.008 ms) 18x RegisterObjectWantsCrossRef (object,string,string)
 - - - - 6.439ms (0.76%) (self: 4.948 ms) 169x ParseValueAndReturnDef (for Verse.GeneDef)
 - - - - - 1.352ms (21%) (self: 1.352 ms) 8x CreateFieldSetterForType
 - - - - - 0.044ms (0.68%) (self: 0.044 ms) CreateListItemAdderForType
 - - - - - 0.043ms (0.66%) (self: 0.043 ms) 210x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - - 0.039ms (0.6%) (self: 0.039 ms) 78x RegisterObjectWantsCrossRef (object,string,string)
 - - - - - 0.014ms (0.22%) (self: 0.014 ms) 48x RegisterListWantsCrossRef
 - - - - 6.214ms (0.73%) (self: 4.632 ms) 26x ParseValueAndReturnDef (for RimWorld.RitualBehaviorDef)
 - - - - - 1.540ms (25%) (self: 1.540 ms) 9x CreateFieldSetterForType
 - - - - - 0.040ms (0.65%) (self: 0.040 ms) 216x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - - 0.002ms (0.03%) (self: 0.002 ms) 7x RegisterListWantsCrossRef
 - - - - 5.807ms (0.68%) (self: 4.844 ms) 112x ParseValueAndReturnDef (for Verse.TerrainDef)
 - - - - - 0.579ms (10%) (self: 0.579 ms) 6x CreateFieldSetterForType
 - - - - - 0.176ms (3%) (self: 0.176 ms) 361x RegisterObjectWantsCrossRef (object,string,string)
 - - - - - 0.122ms (2.1%) (self: 0.122 ms) 514x RegisterListWantsCrossRef
 - - - - - 0.086ms (1.5%) (self: 0.086 ms) 530x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - 5.571ms (0.66%) (self: 5.023 ms) 33x ParseValueAndReturnDef (for RimWorld.WorldObjectDef)
 - - - - - 0.536ms (9.6%) (self: 0.536 ms) 2x CreateFieldSetterForType
 - - - - - 0.009ms (0.17%) (self: 0.009 ms) 16x RegisterListWantsCrossRef
 - - - - - 0.003ms (0.06%) (self: 0.003 ms) 16x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - 5.487ms (0.65%) (self: 4.354 ms) 24x ParseValueAndReturnDef (for Verse.WeatherDef)
 - - - - - 0.669ms (12%) (self: 0.669 ms) 24x RegisterListWantsCrossRef
 - - - - - 0.461ms (8.4%) (self: 0.461 ms) 2x CreateFieldSetterForType
 - - - - - 0.003ms (0.05%) (self: 0.003 ms) 12x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - 5.442ms (0.64%) (self: 5.018 ms) 155x ParseValueAndReturnDef (for RimWorld.WorkGiverDef)
 - - - - - 0.232ms (4.3%) (self: 0.232 ms) 175x RegisterListWantsCrossRef
 - - - - - 0.192ms (3.5%) (self: 0.192 ms) 164x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - 5.436ms (0.64%) (self: 4.425 ms) 176x ParseValueAndReturnDef (for RimWorld.PrefabDef)
 - - - - - 0.613ms (11%) (self: 0.613 ms) 4x CreateFieldSetterForType
 - - - - - 0.261ms (4.8%) (self: 0.261 ms) 580x RegisterObjectWantsCrossRef (object,string,string)
 - - - - - 0.138ms (2.5%) (self: 0.138 ms) 3x CreateListItemAdderForType
 - - - - 5.303ms (0.62%) (self: 0.361 ms) 19x ParseValueAndReturnDef (for Verse.MapGeneratorDef)
 - - - - - 4.863ms (92%) (self: 4.863 ms) 2x CreateFieldSetterForType
 - - - - - 0.076ms (1.4%) (self: 0.076 ms) 293x RegisterListWantsCrossRef
 - - - - - 0.003ms (0.06%) (self: 0.003 ms) 15x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - 5.203ms (0.61%) (self: 3.835 ms) 12x ParseValueAndReturnDef (for RimWorld.ScenarioDef)
 - - - - - 1.245ms (24%) (self: 1.245 ms) 9x CreateFieldSetterForType
 - - - - - 0.080ms (1.5%) (self: 0.080 ms) 467x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - - 0.043ms (0.83%) (self: 0.043 ms) CreateListItemAdderForType
 - - - - - 0.001ms (0.01%) (self: 0.001 ms) RegisterListWantsCrossRef
 - - - - 5.165ms (0.61%) (self: 3.611 ms) 145x ParseValueAndReturnDef (for RimWorld.LayoutRoomDef)
 - - - - - 1.038ms (20%) (self: 1.038 ms) 6x CreateFieldSetterForType
 - - - - - 0.266ms (5.2%) (self: 0.266 ms) 637x RegisterObjectWantsCrossRef (object,string,string)
 - - - - - 0.200ms (3.9%) (self: 0.200 ms) 5x CreateListItemAdderForType
 - - - - - 0.045ms (0.87%) (self: 0.045 ms) 97x RegisterListWantsCrossRef
 - - - - - 0.004ms (0.08%) (self: 0.004 ms) 22x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - 4.442ms (0.52%) (self: 3.185 ms) 27x ParseValueAndReturnDef (for RimWorld.RitualOutcomeEffectDef)
 - - - - - 1.131ms (25%) (self: 1.131 ms) 6x CreateFieldSetterForType
 - - - - - 0.051ms (1.1%) (self: 0.051 ms) CreateListItemAdderForType
 - - - - - 0.050ms (1.1%) (self: 0.050 ms) 3x RegisterDictionaryWantsCrossRef
 - - - - - 0.019ms (0.43%) (self: 0.019 ms) 108x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - - 0.006ms (0.13%) (self: 0.006 ms) 10x RegisterObjectWantsCrossRef (object,string,string)
 - - - - - 0.001ms (0.02%) (self: 0.001 ms) 3x RegisterListWantsCrossRef
 - - - - 4.237ms (0.5%) (self: 3.899 ms) 202x ParseValueAndReturnDef (for Verse.ResearchProjectDef)
 - - - - - 0.166ms (3.9%) (self: 0.166 ms) CreateFieldSetterForType
 - - - - - 0.137ms (3.2%) (self: 0.137 ms) 313x RegisterListWantsCrossRef
 - - - - - 0.035ms (0.84%) (self: 0.035 ms) 189x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - 4.177ms (0.49%) (self: 4.033 ms) 112x ParseValueAndReturnDef (for RimWorld.RuleDef)
 - - - - - 0.144ms (3.4%) (self: 0.144 ms) CreateFieldSetterForType
 - - - - 3.862ms (0.45%) (self: 1.636 ms) 41x ParseValueAndReturnDef (for RimWorld.BeardDef)
 - - - - - 1.955ms (51%) (self: 1.955 ms) 5x CreateFieldSetterForType
 - - - - - 0.155ms (4%) (self: 0.155 ms) CreateListItemAdderForType
 - - - - - 0.116ms (3%) (self: 0.116 ms) 51x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - 3.471ms (0.41%) (self: 2.299 ms) 196x ParseValueAndReturnDef (for Verse.BodyPartDef)
 - - - - - 1.002ms (29%) (self: 1.002 ms) 2x CreateFieldSetterForType
 - - - - - 0.095ms (2.7%) (self: 0.095 ms) RegisterDictionaryWantsCrossRef
 - - - - - 0.075ms (2.2%) (self: 0.075 ms) 225x RegisterListWantsCrossRef
 - - - - - 0.001ms (0.03%) (self: 0.001 ms) 4x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - 3.376ms (0.4%) (self: 1.949 ms) 45x ParseValueAndReturnDef (for RimWorld.LandmarkDef)
 - - - - - 0.936ms (28%) (self: 0.936 ms) 878x RegisterObjectWantsCrossRef (object,string,string)
 - - - - - 0.426ms (13%) (self: 0.426 ms) 3x CreateFieldSetterForType
 - - - - - 0.055ms (1.6%) (self: 0.055 ms) CreateListItemAdderForType
 - - - - - 0.010ms (0.29%) (self: 0.010 ms) 45x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - 2.955ms (0.35%) (self: 2.112 ms) 135x ParseValueAndReturnDef (for RimWorld.IncidentDef)
 - - - - - 0.629ms (21%) (self: 0.629 ms) 4x CreateFieldSetterForType
 - - - - - 0.094ms (3.2%) (self: 0.094 ms) 231x RegisterListWantsCrossRef
 - - - - - 0.053ms (1.8%) (self: 0.053 ms) 306x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - - 0.038ms (1.3%) (self: 0.038 ms) CreateListItemAdderForType
 - - - - - 0.029ms (0.99%) (self: 0.029 ms) 48x RegisterObjectWantsCrossRef (object,string,string)
 - - - - 2.916ms (0.34%) (self: 1.840 ms) 27x ParseValueAndReturnDef (for RimWorld.StructureLayoutDef)
 - - - - - 0.765ms (26%) (self: 0.765 ms) 5x CreateFieldSetterForType
 - - - - - 0.162ms (5.5%) (self: 0.162 ms) 384x RegisterObjectWantsCrossRef (object,string,string)
 - - - - - 0.131ms (4.5%) (self: 0.131 ms) 3x CreateListItemAdderForType
 - - - - - 0.019ms (0.65%) (self: 0.019 ms) 117x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - 2.905ms (0.34%) (self: 1.937 ms) 11x ParseValueAndReturnDef (for RimWorld.RoyalTitleDef)
 - - - - - 0.885ms (30%) (self: 0.885 ms) 5x CreateFieldSetterForType
 - - - - - 0.071ms (2.5%) (self: 0.071 ms) 193x RegisterListWantsCrossRef
 - - - - - 0.012ms (0.4%) (self: 0.012 ms) 69x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - 2.885ms (0.34%) (self: 2.781 ms) 103x ParseValueAndReturnDef (for RimWorld.TaleDef)
 - - - - - 0.104ms (3.6%) (self: 0.104 ms) CreateFieldSetterForType
 - - - - - 0.001ms (0.03%) (self: 0.001 ms) 2x RegisterListWantsCrossRef
 - - - - 2.787ms (0.33%) (self: 2.040 ms) 4x ParseValueAndReturnDef (for RimWorld.StorytellerDef)
 - - - - - 0.638ms (23%) (self: 0.638 ms) 5x CreateFieldSetterForType
 - - - - - 0.053ms (1.9%) (self: 0.053 ms) 116x RegisterListWantsCrossRef
 - - - - - 0.033ms (1.2%) (self: 0.033 ms) CreateListItemAdderForType
 - - - - - 0.019ms (0.69%) (self: 0.019 ms) 105x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - - 0.004ms (0.13%) (self: 0.004 ms) 6x RegisterObjectWantsCrossRef (object,string,string)
 - - - - 2.686ms (0.32%) (self: 2.037 ms) 87x ParseValueAndReturnDef (for RimWorld.TileMutatorDef)
 - - - - - 0.430ms (16%) (self: 0.430 ms) 2x CreateFieldSetterForType
 - - - - - 0.113ms (4.2%) (self: 0.113 ms) 469x RegisterListWantsCrossRef
 - - - - - 0.059ms (2.2%) (self: 0.059 ms) CreateListItemAdderForType
 - - - - - 0.036ms (1.4%) (self: 0.036 ms) 72x RegisterObjectWantsCrossRef (object,string,string)
 - - - - - 0.005ms (0.19%) (self: 0.005 ms) 32x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - - 0.005ms (0.18%) (self: 0.005 ms) 5x RegisterObjectWantsCrossRef (object,string,XmlNode)
 - - - - 2.628ms (0.31%) (self: 1.778 ms) 23x ParseValueAndReturnDef (for RimWorld.BodyTypeDef)
 - - - - - 0.845ms (32%) (self: 0.845 ms) 4x CreateFieldSetterForType
 - - - - - 0.006ms (0.22%) (self: 0.006 ms) 28x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - 2.343ms (0.28%) (self: 1.910 ms) 71x ParseValueAndReturnDef (for RimWorld.InteractionDef)
 - - - - - 0.404ms (17%) (self: 0.404 ms) 3x CreateFieldSetterForType
 - - - - - 0.023ms (0.98%) (self: 0.023 ms) 66x RegisterListWantsCrossRef
 - - - - - 0.006ms (0.26%) (self: 0.006 ms) 34x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - 2.253ms (0.27%) (self: 1.953 ms) 11x ParseValueAndReturnDef (for Verse.PawnRenderTreeDef)
 - - - - - 0.288ms (13%) (self: 0.288 ms) 3x CreateFieldSetterForType
 - - - - - 0.012ms (0.53%) (self: 0.012 ms) 54x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - 2.053ms (0.24%) (self: 1.966 ms) 327x ParseValueAndReturnDef (for Verse.JobDef)
 - - - - - 0.079ms (3.8%) (self: 0.079 ms) CreateFieldSetterForType
 - - - - - 0.008ms (0.38%) (self: 0.008 ms) 46x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - 1.748ms (0.21%) (self: 1.002 ms) 8x ParseValueAndReturnDef (for Verse.CreepJoinerFormKindDef)
 - - - - - 0.688ms (39%) (self: 0.688 ms) 4x CreateFieldSetterForType
 - - - - - 0.036ms (2%) (self: 0.036 ms) 55x RegisterListWantsCrossRef
 - - - - - 0.018ms (1%) (self: 0.018 ms) 41x RegisterObjectWantsCrossRef (object,string,string)
 - - - - - 0.004ms (0.25%) (self: 0.004 ms) 23x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - 1.631ms (0.19%) (self: 1.498 ms) 8x ParseValueAndReturnDef (for RimWorld.PsychicRitualRoleDef)
 - - - - - 0.133ms (8.2%) (self: 0.133 ms) CreateFieldSetterForType
 - - - - 1.597ms (0.19%) (self: 0.260 ms) 8x ParseValueAndReturnDef (for RimWorld.InspirationDef)
 - - - - - 1.289ms (81%) (self: 1.289 ms) 4x CreateFieldSetterForType
 - - - - - 0.040ms (2.5%) (self: 0.040 ms) 23x RegisterListWantsCrossRef
 - - - - - 0.007ms (0.41%) (self: 0.007 ms) 11x RegisterObjectWantsCrossRef (object,string,string)
 - - - - - 0.002ms (0.1%) (self: 0.002 ms) 8x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - 1.521ms (0.18%) (self: 0.672 ms) 9x ParseValueAndReturnDef (for RimWorld.ComplexThreatDef)
 - - - - - 0.432ms (28%) (self: 0.432 ms) 3x CreateFieldSetterForType
 - - - - - 0.417ms (27%) (self: 0.417 ms) 2x CreateListItemAdderForType
 - - - - - 0.001ms (0.04%) (self: 0.001 ms) 2x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - 1.459ms (0.17%) (self: 1.249 ms) 58x ParseValueAndReturnDef (for RimWorld.SitePartDef)
 - - - - - 0.203ms (14%) (self: 0.203 ms) CreateFieldSetterForType
 - - - - - 0.006ms (0.39%) (self: 0.006 ms) 31x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - - 0.002ms (0.1%) (self: 0.002 ms) 2x RegisterListWantsCrossRef
 - - - - 1.395ms (0.16%) (self: 1.154 ms) 47x ParseValueAndReturnDef (for Verse.MentalStateDef)
 - - - - - 0.206ms (15%) (self: 0.206 ms) 2x CreateFieldSetterForType
 - - - - - 0.022ms (1.6%) (self: 0.022 ms) 30x RegisterListWantsCrossRef
 - - - - - 0.013ms (0.94%) (self: 0.013 ms) 73x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - 1.380ms (0.16%) (self: 1.086 ms) 135x ParseValueAndReturnDef (for RimWorld.ColorDef)
 - - - - - 0.294ms (21%) (self: 0.294 ms) 2x CreateFieldSetterForType
 - - - - 1.340ms (0.16%) (self: 1.340 ms) 33x ParseValueAndReturnDef (for RimWorld.SketchResolverDef)
 - - - - 1.281ms (0.15%) (self: 1.113 ms) 52x ParseValueAndReturnDef (for Verse.DamageDef)
 - - - - - 0.133ms (10%) (self: 0.133 ms) CreateFieldSetterForType
 - - - - - 0.034ms (2.6%) (self: 0.034 ms) 201x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - - 0.001ms (0.09%) (self: 0.001 ms) 2x RegisterListWantsCrossRef
 - - - - 1.239ms (0.15%) (self: 1.100 ms) 85x ParseValueAndReturnDef (for RimWorld.ConceptDef)
 - - - - - 0.139ms (11%) (self: 0.139 ms) CreateFieldSetterForType
 - - - - 1.127ms (0.13%) (self: 1.126 ms) 123x ParseValueAndReturnDef (for Verse.ThingStyleDef)
 - - - - - 0.001ms (0.05%) (self: 0.001 ms) 2x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - 1.126ms (0.13%) (self: 0.851 ms) 18x ParseValueAndReturnDef (for RimWorld.RitualVisualEffectDef)
 - - - - - 0.270ms (24%) (self: 0.270 ms) CreateFieldSetterForType
 - - - - - 0.005ms (0.43%) (self: 0.005 ms) 27x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - - 0.001ms (0.08%) (self: 0.001 ms) 3x RegisterListWantsCrossRef
 - - - - 1.059ms (0.12%) (self: 0.594 ms) 3x ParseValueAndReturnDef (for RimWorld.ComplexLayoutDef)
 - - - - - 0.365ms (35%) (self: 0.365 ms) 2x CreateFieldSetterForType
 - - - - - 0.082ms (7.7%) (self: 0.082 ms) 2x CreateListItemAdderForType
 - - - - - 0.016ms (1.5%) (self: 0.016 ms) 36x RegisterObjectWantsCrossRef (object,string,string)
 - - - - - 0.001ms (0.1%) (self: 0.001 ms) 5x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - 1.058ms (0.12%) (self: 0.581 ms) 11x ParseValueAndReturnDef (for RimWorld.RaidStrategyDef)
 - - - - - 0.451ms (43%) (self: 0.451 ms) 2x CreateFieldSetterForType
 - - - - - 0.025ms (2.4%) (self: 0.025 ms) 36x RegisterListWantsCrossRef
 - - - - - 0.002ms (0.17%) (self: 0.002 ms) 6x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - 1.056ms (0.12%) (self: 1.053 ms) 37x ParseValueAndReturnDef (for RimWorld.InstructionDef)
 - - - - - 0.004ms (0.35%) (self: 0.004 ms) 15x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - 1.056ms (0.12%) (self: 0.604 ms) 3x ParseValueAndReturnDef (for RimWorld.SurgeryOutcomeEffectDef)
 - - - - - 0.443ms (42%) (self: 0.443 ms) 3x CreateFieldSetterForType
 - - - - - 0.008ms (0.71%) (self: 0.008 ms) 4x RegisterListWantsCrossRef
 - - - - - 0.001ms (0.13%) (self: 0.001 ms) 6x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - 1.045ms (0.12%) (self: 0.579 ms) 77x ParseValueAndReturnDef (for Verse.SongDef)
 - - - - - 0.267ms (26%) (self: 0.267 ms) 2x CreateFieldSetterForType
 - - - - - 0.199ms (19%) (self: 0.199 ms) CreateListItemAdderForType
 - - - - - 0.000ms (0.02%) (self: 0.000 ms) RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - 1.020ms (0.12%) (self: 0.668 ms) 39x ParseValueAndReturnDef (for Verse.HeadTypeDef)
 - - - - - 0.346ms (34%) (self: 0.346 ms) 2x CreateFieldSetterForType
 - - - - - 0.006ms (0.62%) (self: 0.006 ms) 21x RegisterListWantsCrossRef
 - - - - 1.019ms (0.12%) (self: 0.595 ms) 3x ParseValueAndReturnDef (for RimWorld.BossgroupDef)
 - - - - - 0.335ms (33%) (self: 0.335 ms) 2x CreateFieldSetterForType
 - - - - - 0.047ms (4.6%) (self: 0.047 ms) CreateListItemAdderForType
 - - - - - 0.034ms (3.3%) (self: 0.034 ms) 78x RegisterObjectWantsCrossRef (object,string,string)
 - - - - - 0.007ms (0.73%) (self: 0.007 ms) 21x RegisterListWantsCrossRef
 - - - - - 0.001ms (0.14%) (self: 0.001 ms) 9x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - 1.005ms (0.12%) (self: 0.486 ms) 7x ParseValueAndReturnDef (for RimWorld.MonolithLevelDef)
 - - - - - 0.510ms (51%) (self: 0.510 ms) 2x CreateFieldSetterForType
 - - - - - 0.006ms (0.6%) (self: 0.006 ms) 37x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - - 0.002ms (0.18%) (self: 0.002 ms) 3x RegisterListWantsCrossRef
 - - - - 1.004ms (0.12%) (self: 0.971 ms) 23x ParseValueAndReturnDef (for Verse.WorkTypeDef)
 - - - - - 0.034ms (3.3%) (self: 0.034 ms) 18x RegisterListWantsCrossRef
 - - - - 0.990ms (0.12%) (self: 0.456 ms) 27x ParseValueAndReturnDef (for RimWorld.EntityCodexEntryDef)
 - - - - - 0.487ms (49%) (self: 0.487 ms) 3x CreateFieldSetterForType
 - - - - - 0.038ms (3.8%) (self: 0.038 ms) 77x RegisterListWantsCrossRef
 - - - - - 0.008ms (0.84%) (self: 0.008 ms) 48x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - 0.895ms (0.11%) (self: 0.833 ms) 61x ParseValueAndReturnDef (for RimWorld.WeaponTraitDef)
 - - - - - 0.044ms (5%) (self: 0.044 ms) 105x RegisterObjectWantsCrossRef (object,string,string)
 - - - - - 0.016ms (1.8%) (self: 0.016 ms) 96x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - - 0.002ms (0.2%) (self: 0.002 ms) 4x RegisterListWantsCrossRef
 - - - - 0.838ms (0.1%) (self: 0.608 ms) 27x ParseValueAndReturnDef (for RimWorld.RitualPatternDef)
 - - - - - 0.213ms (25%) (self: 0.213 ms) CreateFieldSetterForType
 - - - - - 0.016ms (1.9%) (self: 0.016 ms) 99x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - - 0.001ms (0.11%) (self: 0.001 ms) RegisterListWantsCrossRef
 - - - - 0.814ms (0.1%) (self: 0.814 ms) 12x ParseValueAndReturnDef (for Verse.WorldGenStepDef)
 - - - - 0.807ms (0.1%) (self: 0.451 ms) 2x ParseValueAndReturnDef (for AlienRace.RaceSettings)
 - - - - - 0.346ms (43%) (self: 0.346 ms) 2x CreateFieldSetterForType
 - - - - - 0.010ms (1.2%) (self: 0.010 ms) 27x RegisterListWantsCrossRef
 - - - - 0.798ms (0.09%) (self: 0.469 ms) 8x ParseValueAndReturnDef (for RimWorld.FleshTypeDef)
 - - - - - 0.325ms (41%) (self: 0.325 ms) 2x CreateFieldSetterForType
 - - - - - 0.004ms (0.45%) (self: 0.004 ms) 20x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - 0.777ms (0.09%) (self: 0.527 ms) 38x ParseValueAndReturnDef (for Verse.GameConditionDef)
 - - - - - 0.233ms (30%) (self: 0.233 ms) 2x CreateFieldSetterForType
 - - - - - 0.013ms (1.7%) (self: 0.013 ms) 14x RegisterListWantsCrossRef
 - - - - - 0.004ms (0.48%) (self: 0.004 ms) 25x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - 0.772ms (0.09%) (self: 0.607 ms) 2x ParseValueAndReturnDef (for RimWorld.PlanetLayerDef)
 - - - - - 0.154ms (20%) (self: 0.154 ms) CreateFieldSetterForType
 - - - - - 0.010ms (1.3%) (self: 0.010 ms) 13x RegisterListWantsCrossRef
 - - - - - 0.002ms (0.21%) (self: 0.002 ms) 5x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - 0.768ms (0.09%) (self: 0.486 ms) 59x ParseValueAndReturnDef (for Verse.KeyBindingDef)
 - - - - - 0.264ms (34%) (self: 0.264 ms) 2x CreateFieldSetterForType
 - - - - - 0.010ms (1.3%) (self: 0.010 ms) 59x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - - 0.008ms (1%) (self: 0.008 ms) 8x RegisterListWantsCrossRef
 - - - - 0.754ms (0.09%) (self: 0.263 ms) ParseValueAndReturnDef (for AlienRace.PawnBioDef)
 - - - - - 0.328ms (44%) (self: 0.328 ms) 2x CreateFieldSetterForType
 - - - - - 0.161ms (21%) (self: 0.161 ms) 3x Search for field alias
 - - - - - 0.001ms (0.17%) (self: 0.001 ms) 2x RegisterListWantsCrossRef
 - - - - - 0.000ms (0.05%) (self: 0.000 ms) 2x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - 0.735ms (0.09%) (self: 0.379 ms) 13x ParseValueAndReturnDef (for Verse.RoomStatDef)
 - - - - - 0.226ms (31%) (self: 0.226 ms) CreateListItemAdderForType
 - - - - - 0.129ms (18%) (self: 0.129 ms) CreateFieldSetterForType
 - - - - - 0.001ms (0.14%) (self: 0.001 ms) 7x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - 0.734ms (0.09%) (self: 0.462 ms) 5x ParseValueAndReturnDef (for RimWorld.RoadDef)
 - - - - - 0.266ms (36%) (self: 0.266 ms) 2x CreateFieldSetterForType
 - - - - - 0.006ms (0.75%) (self: 0.006 ms) 33x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - 0.726ms (0.09%) (self: 0.446 ms) 5x ParseValueAndReturnDef (for RimWorld.CultureDef)
 - - - - - 0.274ms (38%) (self: 0.274 ms) 2x CreateFieldSetterForType
 - - - - - 0.006ms (0.84%) (self: 0.006 ms) 35x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - 0.720ms (0.08%) (self: 0.297 ms) 10x ParseValueAndReturnDef (for Verse.CreepJoinerBenefitDef)
 - - - - - 0.362ms (50%) (self: 0.362 ms) 2x CreateFieldSetterForType
 - - - - - 0.041ms (5.7%) (self: 0.041 ms) CreateListItemAdderForType
 - - - - - 0.010ms (1.4%) (self: 0.010 ms) 7x RegisterListWantsCrossRef
 - - - - - 0.009ms (1.3%) (self: 0.009 ms) 17x RegisterObjectWantsCrossRef (object,string,string)
 - - - - 0.716ms (0.08%) (self: 0.455 ms) 71x ParseValueAndReturnDef (for RimWorld.RecordDef)
 - - - - - 0.247ms (34%) (self: 0.247 ms) 2x CreateFieldSetterForType
 - - - - - 0.014ms (2%) (self: 0.014 ms) 30x RegisterListWantsCrossRef
 - - - - 0.710ms (0.08%) (self: 0.679 ms) 3x ParseValueAndReturnDef (for RimWorld.MutantDef)
 - - - - - 0.021ms (3%) (self: 0.021 ms) 96x RegisterListWantsCrossRef
 - - - - - 0.008ms (1.1%) (self: 0.008 ms) 45x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - - 0.002ms (0.32%) (self: 0.002 ms) 5x RegisterObjectWantsCrossRef (object,string,string)
 - - - - 0.694ms (0.08%) (self: 0.303 ms) 7x ParseValueAndReturnDef (for RimWorld.GeneTemplateDef)
 - - - - - 0.389ms (56%) (self: 0.389 ms) 3x CreateFieldSetterForType
 - - - - - 0.003ms (0.4%) (self: 0.003 ms) 13x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - 0.686ms (0.08%) (self: 0.463 ms) 11x ParseValueAndReturnDef (for Verse.StyleCategoryDef)
 - - - - - 0.176ms (26%) (self: 0.176 ms) CreateFieldSetterForType
 - - - - - 0.040ms (5.9%) (self: 0.040 ms) 252x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - - 0.006ms (0.93%) (self: 0.006 ms) 18x RegisterListWantsCrossRef
 - - - - 0.684ms (0.08%) (self: 0.674 ms) 5x ParseValueAndReturnDef (for RimWorld.HediffGiverSetDef)
 - - - - - 0.006ms (0.83%) (self: 0.006 ms) 16x RegisterListWantsCrossRef
 - - - - - 0.005ms (0.72%) (self: 0.005 ms) 30x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - 0.644ms (0.08%) (self: 0.630 ms) 80x ParseValueAndReturnDef (for RimWorld.HairDef)
 - - - - - 0.014ms (2.2%) (self: 0.014 ms) 80x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - 0.643ms (0.08%) (self: 0.333 ms) 13x ParseValueAndReturnDef (for Verse.AnimationDef)
 - - - - - 0.243ms (38%) (self: 0.243 ms) CreateFieldSetterForType
 - - - - - 0.067ms (10%) (self: 0.067 ms) 13x RegisterDictionaryWantsCrossRef
 - - - - 0.608ms (0.07%) (self: 0.602 ms) 18x ParseValueAndReturnDef (for RimWorld.LifeStageDef)
 - - - - - 0.006ms (0.92%) (self: 0.006 ms) 11x RegisterObjectWantsCrossRef (object,string,string)
 - - - - - 0.000ms (0.07%) (self: 0.000 ms) 2x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - 0.569ms (0.07%) (self: 0.568 ms) 17x ParseValueAndReturnDef (for Verse.DesignationCategoryDef)
 - - - - - 0.002ms (0.3%) (self: 0.002 ms) 3x RegisterListWantsCrossRef
 - - - - 0.565ms (0.07%) (self: 0.398 ms) 28x ParseValueAndReturnDef (for RimWorld.PawnRelationDef)
 - - - - - 0.140ms (25%) (self: 0.140 ms) CreateFieldSetterForType
 - - - - - 0.014ms (2.5%) (self: 0.014 ms) 15x RegisterListWantsCrossRef
 - - - - - 0.013ms (2.2%) (self: 0.013 ms) 81x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - 0.553ms (0.07%) (self: 0.241 ms) 12x ParseValueAndReturnDef (for Verse.ManeuverDef)
 - - - - - 0.299ms (54%) (self: 0.299 ms) 2x CreateFieldSetterForType
 - - - - - 0.013ms (2.4%) (self: 0.013 ms) 86x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - 0.544ms (0.06%) (self: 0.434 ms) 41x ParseValueAndReturnDef (for RimWorld.ScenPartDef)
 - - - - - 0.109ms (20%) (self: 0.109 ms) CreateFieldSetterForType
 - - - - - 0.001ms (0.17%) (self: 0.001 ms) 4x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - 0.502ms (0.06%) (self: 0.494 ms) 20x ParseValueAndReturnDef (for Verse.PlaceDef)
 - - - - - 0.008ms (1.6%) (self: 0.008 ms) 20x RegisterListWantsCrossRef
 - - - - 0.485ms (0.06%) (self: 0.485 ms) 181x ParseValueAndReturnDef (for RimWorld.HistoryEventDef)
 - - - - 0.422ms (0.05%) (self: 0.375 ms) 94x ParseValueAndReturnDef (for RimWorld.IdeoIconDef)
 - - - - - 0.046ms (11%) (self: 0.046 ms) 159x RegisterListWantsCrossRef
 - - - - 0.412ms (0.05%) (self: 0.399 ms) 80x ParseValueAndReturnDef (for Verse.ThingCategoryDef)
 - - - - - 0.013ms (3.1%) (self: 0.013 ms) 78x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - 0.400ms (0.05%) (self: 0.240 ms) 3x ParseValueAndReturnDef (for Verse.OrbitalDebrisDef)
 - - - - - 0.159ms (40%) (self: 0.159 ms) CreateFieldSetterForType
 - - - - - 0.001ms (0.35%) (self: 0.001 ms) 9x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - 0.395ms (0.05%) (self: 0.184 ms) 8x ParseValueAndReturnDef (for RimWorld.MusicSequenceDef)
 - - - - - 0.197ms (50%) (self: 0.197 ms) CreateFieldSetterForType
 - - - - - 0.013ms (3.3%) (self: 0.013 ms) 19x RegisterListWantsCrossRef
 - - - - - 0.001ms (0.13%) (self: 0.001 ms) 2x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - 0.394ms (0.05%) (self: 0.302 ms) 28x ParseValueAndReturnDef (for Verse.LetterDef)
 - - - - - 0.089ms (23%) (self: 0.089 ms) CreateFieldSetterForType
 - - - - - 0.003ms (0.81%) (self: 0.003 ms) 17x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - 0.392ms (0.05%) (self: 0.172 ms) 7x ParseValueAndReturnDef (for RimWorld.MeditationFocusDef)
 - - - - - 0.220ms (56%) (self: 0.220 ms) 2x CreateFieldSetterForType
 - - - - 0.392ms (0.05%) (self: 0.377 ms) 47x ParseValueAndReturnDef (for Verse.SpecialThingFilterDef)
 - - - - - 0.015ms (3.7%) (self: 0.015 ms) 47x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - 0.383ms (0.05%) (self: 0.155 ms) ParseValueAndReturnDef (for RimWorld.FurDef)
 - - - - - 0.178ms (46%) (self: 0.178 ms) CreateFieldSetterForType
 - - - - - 0.046ms (12%) (self: 0.046 ms) CreateListItemAdderForType
 - - - - - 0.004ms (1.1%) (self: 0.004 ms) 7x RegisterObjectWantsCrossRef (object,string,string)
 - - - - 0.367ms (0.04%) (self: 0.273 ms) 31x ParseValueAndReturnDef (for RimWorld.TattooDef)
 - - - - - 0.089ms (24%) (self: 0.089 ms) CreateFieldSetterForType
 - - - - - 0.005ms (1.5%) (self: 0.005 ms) 31x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - 0.365ms (0.04%) (self: 0.137 ms) ParseValueAndReturnDef (for RimWorld.RoomPart_GestationTankDef)
 - - - - - 0.183ms (50%) (self: 0.183 ms) CreateFieldSetterForType
 - - - - - 0.045ms (12%) (self: 0.045 ms) CreateListItemAdderForType
 - - - - 0.363ms (0.04%) (self: 0.280 ms) 33x ParseValueAndReturnDef (for Verse.MentalBreakDef)
 - - - - - 0.072ms (20%) (self: 0.072 ms) CreateFieldSetterForType
 - - - - - 0.010ms (2.8%) (self: 0.010 ms) 34x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - - 0.000ms (0.08%) (self: 0.000 ms) RegisterListWantsCrossRef
 - - - - 0.357ms (0.04%) (self: 0.355 ms) ParseValueAndReturnDef (for RimWorld.PsychicRitualDef_VoidProvocation)
 - - - - - 0.001ms (0.34%) (self: 0.001 ms) RegisterListWantsCrossRef
 - - - - - 0.000ms (0.08%) (self: 0.000 ms) RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - 0.354ms (0.04%) (self: 0.317 ms) 12x ParseValueAndReturnDef (for RimWorld.XenotypeDef)
 - - - - - 0.033ms (9.2%) (self: 0.033 ms) 181x RegisterListWantsCrossRef
 - - - - - 0.003ms (0.82%) (self: 0.003 ms) 6x RegisterObjectWantsCrossRef (object,string,string)
 - - - - - 0.002ms (0.45%) (self: 0.002 ms) 7x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - 0.346ms (0.04%) (self: 0.109 ms) 6x ParseValueAndReturnDef (for RimWorld.PawnTableDef)
 - - - - - 0.213ms (62%) (self: 0.213 ms) CreateFieldSetterForType
 - - - - - 0.024ms (7%) (self: 0.024 ms) 78x RegisterListWantsCrossRef
 - - - - 0.343ms (0.04%) (self: 0.343 ms) 52x ParseValueAndReturnDef (for RimWorld.PawnColumnDef)
 - - - - 0.334ms (0.04%) (self: 0.168 ms) 23x ParseValueAndReturnDef (for Verse.RoomRoleDef)
 - - - - - 0.151ms (45%) (self: 0.151 ms) CreateFieldSetterForType
 - - - - - 0.015ms (4.6%) (self: 0.015 ms) 36x RegisterListWantsCrossRef
 - - - - 0.333ms (0.04%) (self: 0.333 ms) 123x ParseValueAndReturnDef (for Verse.ShaderTypeDef)
 - - - - 0.328ms (0.04%) (self: 0.189 ms) 8x ParseValueAndReturnDef (for RimWorld.ChemicalDef)
 - - - - - 0.135ms (41%) (self: 0.135 ms) CreateFieldSetterForType
 - - - - - 0.003ms (0.95%) (self: 0.003 ms) 14x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - - 0.001ms (0.31%) (self: 0.001 ms) 2x RegisterListWantsCrossRef
 - - - - 0.325ms (0.04%) (self: 0.325 ms) 24x ParseValueAndReturnDef (for RimWorld.NeedDef)
 - - - - - 0.001ms (0.15%) (self: 0.001 ms) RegisterListWantsCrossRef
 - - - - 0.318ms (0.04%) (self: 0.315 ms) 12x ParseValueAndReturnDef (for RimWorld.SkillDef)
 - - - - - 0.003ms (0.91%) (self: 0.003 ms) 12x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - 0.313ms (0.04%) (self: 0.313 ms) 76x ParseValueAndReturnDef (for RimWorld.IssueDef)
 - - - - 0.302ms (0.04%) (self: 0.107 ms) 4x ParseValueAndReturnDef (for RimWorld.HistoryAutoRecorderGroupDef)
 - - - - - 0.182ms (60%) (self: 0.182 ms) CreateFieldSetterForType
 - - - - - 0.013ms (4.4%) (self: 0.013 ms) 11x RegisterListWantsCrossRef
 - - - - 0.302ms (0.04%) (self: 0.291 ms) 15x ParseValueAndReturnDef (for RimWorld.RoyalTitlePermitDef)
 - - - - - 0.005ms (1.8%) (self: 0.005 ms) 32x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - - 0.004ms (1.4%) (self: 0.004 ms) 8x RegisterListWantsCrossRef
 - - - - - 0.002ms (0.63%) (self: 0.002 ms) 4x RegisterObjectWantsCrossRef (object,string,string)
 - - - - 0.299ms (0.04%) (self: 0.118 ms) 9x ParseValueAndReturnDef (for Verse.KeyBindingCategoryDef)
 - - - - - 0.169ms (57%) (self: 0.169 ms) CreateFieldSetterForType
 - - - - - 0.012ms (4.1%) (self: 0.012 ms) 30x RegisterListWantsCrossRef
 - - - - 0.299ms (0.04%) (self: 0.170 ms) 4x ParseValueAndReturnDef (for RimWorld.RiverDef)
 - - - - - 0.128ms (43%) (self: 0.128 ms) CreateFieldSetterForType
 - - - - - 0.001ms (0.47%) (self: 0.001 ms) 8x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - 0.298ms (0.04%) (self: 0.292 ms) 14x ParseValueAndReturnDef (for RimWorld.TrainableDef)
 - - - - - 0.004ms (1.2%) (self: 0.004 ms) 5x RegisterListWantsCrossRef
 - - - - - 0.002ms (0.74%) (self: 0.002 ms) 10x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - 0.293ms (0.03%) (self: 0.123 ms) 3x ParseValueAndReturnDef (for RimWorld.GatheringDef)
 - - - - - 0.157ms (54%) (self: 0.157 ms) CreateFieldSetterForType
 - - - - - 0.013ms (4.5%) (self: 0.013 ms) 5x RegisterListWantsCrossRef
 - - - - - 0.001ms (0.17%) (self: 0.001 ms) 2x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - 0.290ms (0.03%) (self: 0.134 ms) 19x ParseValueAndReturnDef (for Verse.DrawStyleCategoryDef)
 - - - - - 0.136ms (47%) (self: 0.136 ms) CreateFieldSetterForType
 - - - - - 0.020ms (6.8%) (self: 0.020 ms) 89x RegisterListWantsCrossRef
 - - - - 0.273ms (0.03%) (self: 0.141 ms) 4x ParseValueAndReturnDef (for RimWorld.DrugPolicyDef)
 - - - - - 0.132ms (48%) (self: 0.132 ms) CreateFieldSetterForType
 - - - - - 0.001ms (0.33%) (self: 0.001 ms) 4x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - 0.265ms (0.03%) (self: 0.261 ms) 6x ParseValueAndReturnDef (for Verse.IdeoStoryPatternDef)
 - - - - - 0.003ms (1.2%) (self: 0.003 ms) 6x RegisterListWantsCrossRef
 - - - - 0.263ms (0.03%) (self: 0.241 ms) 25x ParseValueAndReturnDef (for RimWorld.FeatureDef)
 - - - - - 0.017ms (6.3%) (self: 0.017 ms) 55x RegisterListWantsCrossRef
 - - - - - 0.005ms (2%) (self: 0.005 ms) 25x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - 0.260ms (0.03%) (self: 0.249 ms) 39x ParseValueAndReturnDef (for RimWorld.GoodwillSituationDef)
 - - - - - 0.011ms (4.3%) (self: 0.011 ms) 66x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - 0.258ms (0.03%) (self: 0.258 ms) 7x ParseValueAndReturnDef (for RimWorld.DifficultyDef)
 - - - - 0.255ms (0.03%) (self: 0.140 ms) 27x ParseValueAndReturnDef (for Verse.DesignationDef)
 - - - - - 0.115ms (45%) (self: 0.115 ms) CreateFieldSetterForType
 - - - - 0.245ms (0.03%) (self: 0.239 ms) 13x ParseValueAndReturnDef (for RimWorld.PawnsArrivalModeDef)
 - - - - - 0.005ms (2.1%) (self: 0.005 ms) 12x RegisterListWantsCrossRef
 - - - - - 0.000ms (0.16%) (self: 0.000 ms) 2x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - 0.234ms (0.03%) (self: 0.204 ms) 22x ParseValueAndReturnDef (for RimWorld.JoyGiverDef)
 - - - - - 0.023ms (9.7%) (self: 0.023 ms) 34x RegisterListWantsCrossRef
 - - - - - 0.007ms (3%) (self: 0.007 ms) 42x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - 0.233ms (0.03%) (self: 0.216 ms) 25x ParseValueAndReturnDef (for RimWorld.IdeoPresetDef)
 - - - - - 0.012ms (5.3%) (self: 0.012 ms) 51x RegisterListWantsCrossRef
 - - - - - 0.004ms (1.8%) (self: 0.004 ms) 25x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - 0.210ms (0.02%) (self: 0.210 ms) 15x ParseValueAndReturnDef (for RimWorld.MainButtonDef)
 - - - - 0.203ms (0.02%) (self: 0.097 ms) 9x ParseValueAndReturnDef (for RimWorld.MusicTransitionDef)
 - - - - - 0.105ms (52%) (self: 0.105 ms) CreateFieldSetterForType
 - - - - - 0.002ms (0.79%) (self: 0.002 ms) 9x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - 0.196ms (0.02%) (self: 0.196 ms) 50x ParseValueAndReturnDef (for Verse.BodyPartGroupDef)
 - - - - 0.195ms (0.02%) (self: 0.191 ms) 9x ParseValueAndReturnDef (for Verse.CreepJoinerDownsideDef)
 - - - - - 0.002ms (1.1%) (self: 0.002 ms) 4x RegisterListWantsCrossRef
 - - - - - 0.001ms (0.46%) (self: 0.001 ms) 2x RegisterObjectWantsCrossRef (object,string,string)
 - - - - - 0.001ms (0.36%) (self: 0.001 ms) 3x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - 0.192ms (0.02%) (self: 0.192 ms) 40x ParseValueAndReturnDef (for RimWorld.StatCategoryDef)
 - - - - 0.188ms (0.02%) (self: 0.167 ms) 7x ParseValueAndReturnDef (for RimWorld.GauranlenTreeModeDef)
 - - - - - 0.014ms (7.6%) (self: 0.014 ms) 20x RegisterListWantsCrossRef
 - - - - - 0.005ms (2.9%) (self: 0.005 ms) 11x RegisterObjectWantsCrossRef (object,string,string)
 - - - - - 0.001ms (0.75%) (self: 0.001 ms) 7x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - 0.170ms (0.02%) (self: 0.083 ms) 13x ParseValueAndReturnDef (for Verse.DesignatorDropdownGroupDef)
 - - - - - 0.087ms (51%) (self: 0.087 ms) CreateFieldSetterForType
 - - - - 0.167ms (0.02%) (self: 0.167 ms) 6x ParseValueAndReturnDef (for Verse.TipSetDef)
 - - - - 0.165ms (0.02%) (self: 0.165 ms) ParseValueAndReturnDef (for RimWorld.PitGateIncidentDef)
 - - - - 0.160ms (0.02%) (self: 0.074 ms) 2x ParseValueAndReturnDef (for Verse.SubcameraDef)
 - - - - - 0.086ms (54%) (self: 0.086 ms) CreateFieldSetterForType
 - - - - 0.159ms (0.02%) (self: 0.146 ms) 4x ParseValueAndReturnDef (for RimWorld.TerrainTemplateDef)
 - - - - - 0.010ms (6.2%) (self: 0.010 ms) 22x RegisterObjectWantsCrossRef (object,string,string)
 - - - - - 0.002ms (1%) (self: 0.002 ms) 10x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - - 0.001ms (0.88%) (self: 0.001 ms) 4x RegisterListWantsCrossRef
 - - - - 0.142ms (0.02%) (self: 0.142 ms) 6x ParseValueAndReturnDef (for RimWorld.ExpansionDef)
 - - - - 0.142ms (0.02%) (self: 0.142 ms) 11x ParseValueAndReturnDef (for Verse.PawnCapacityDef)
 - - - - 0.141ms (0.02%) (self: 0.141 ms) 11x ParseValueAndReturnDef (for RimWorld.HistoryAutoRecorderDef)
 - - - - 0.141ms (0.02%) (self: 0.141 ms) 9x ParseValueAndReturnDef (for Verse.ScatterableDef)
 - - - - 0.128ms (0.02%) (self: 0.128 ms) 6x ParseValueAndReturnDef (for Verse.DrawStyleDef)
 - - - - 0.123ms (0.01%) (self: 0.123 ms) 12x ParseValueAndReturnDef (for RimWorld.PrisonerInteractionModeDef)
 - - - - 0.118ms (0.01%) (self: 0.118 ms) 4x ParseValueAndReturnDef (for Verse.GameSetupStepDef)
 - - - - 0.116ms (0.01%) (self: 0.115 ms) 3x ParseValueAndReturnDef (for Verse.CreepJoinerAggressiveDef)
 - - - - - 0.000ms (0.35%) (self: 0.000 ms) 2x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - 0.115ms (0.01%) (self: 0.104 ms) 33x ParseValueAndReturnDef (for RimWorld.IdeoColorDef)
 - - - - - 0.006ms (4.9%) (self: 0.006 ms) 16x RegisterListWantsCrossRef
 - - - - - 0.006ms (4.8%) (self: 0.006 ms) 33x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - 0.115ms (0.01%) (self: 0.112 ms) 7x ParseValueAndReturnDef (for RimWorld.RitualAttachableOutcomeEffectDef)
 - - - - - 0.003ms (2.4%) (self: 0.003 ms) 8x RegisterListWantsCrossRef
 - - - - - 0.000ms (0.17%) (self: 0.000 ms) RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - 0.106ms (0.01%) (self: 0.102 ms) 21x ParseValueAndReturnDef (for RimWorld.RitualObligationTargetFilterDef)
 - - - - - 0.004ms (3.8%) (self: 0.004 ms) 11x RegisterListWantsCrossRef
 - - - - 0.104ms (0.01%) (self: 0.104 ms) 10x ParseValueAndReturnDef (for RimWorld.ExpectationDef)
 - - - - 0.098ms (0.01%) (self: 0.098 ms) 4x ParseValueAndReturnDef (for Verse.MechWorkModeDef)
 - - - - 0.090ms (0.01%) (self: 0.090 ms) 21x ParseValueAndReturnDef (for Verse.GeneCategoryDef)
 - - - - 0.088ms (0.01%) (self: 0.083 ms) 11x ParseValueAndReturnDef (for RimWorld.NegativeFishingOutcomeDef)
 - - - - - 0.005ms (5.5%) (self: 0.005 ms) 29x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - 0.087ms (0.01%) (self: 0.087 ms) 12x ParseValueAndReturnDef (for Verse.TerrainAffordanceDef)
 - - - - 0.084ms (0.01%) (self: 0.083 ms) 7x ParseValueAndReturnDef (for RimWorld.LearningDesireDef)
 - - - - - 0.001ms (1.3%) (self: 0.001 ms) 7x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - 0.078ms (0.01%) (self: 0.078 ms) 13x ParseValueAndReturnDef (for Verse.ToolCapacityDef)
 - - - - 0.076ms (0.01%) (self: 0.076 ms) 2x ParseValueAndReturnDef (for RimWorld.KnowledgeCategoryDef)
 - - - - - 0.000ms (0.39%) (self: 0.000 ms) RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - 0.076ms (0.01%) (self: 0.069 ms) ParseValueAndReturnDef (for RimWorld.LayoutDef)
 - - - - - 0.007ms (9.5%) (self: 0.007 ms) 19x RegisterObjectWantsCrossRef (object,string,string)
 - - - - 0.075ms (0.01%) (self: 0.075 ms) 33x ParseValueAndReturnDef (for Verse.BodyPartTagDef)
 - - - - 0.072ms (0.01%) (self: 0.071 ms) ParseValueAndReturnDef (for RimWorld.PsychicRitualDef_ImbueDeathRefusal)
 - - - - - 0.001ms (0.84%) (self: 0.001 ms) 3x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - - 0.001ms (0.84%) (self: 0.001 ms) RegisterListWantsCrossRef
 - - - - 0.072ms (0.01%) (self: 0.072 ms) 20x ParseValueAndReturnDef (for RimWorld.PawnGroupKindDef)
 - - - - 0.071ms (0.01%) (self: 0.071 ms) 5x ParseValueAndReturnDef (for RimWorld.TimeAssignmentDef)
 - - - - 0.071ms (0.01%) (self: 0.071 ms) 8x ParseValueAndReturnDef (for RimWorld.MemeGroupDef)
 - - - - 0.070ms (0.01%) (self: 0.070 ms) 3x ParseValueAndReturnDef (for RimWorld.ResearchTabDef)
 - - - - 0.069ms (0.01%) (self: 0.067 ms) ParseValueAndReturnDef (for RimWorld.PsychicRitualDef_SummonAnimals)
 - - - - - 0.001ms (1.5%) (self: 0.001 ms) 2x RegisterListWantsCrossRef
 - - - - - 0.000ms (0.44%) (self: 0.000 ms) RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - 0.067ms (0.01%) (self: 0.066 ms) ParseValueAndReturnDef (for RimWorld.PsychicRitualDef_Philophagy)
 - - - - - 0.001ms (0.75%) (self: 0.001 ms) 2x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - - 0.000ms (0.6%) (self: 0.000 ms) RegisterListWantsCrossRef
 - - - - 0.066ms (0.01%) (self: 0.064 ms) ParseValueAndReturnDef (for RimWorld.PsychicRitualDef_SummonFleshbeastsPlayer)
 - - - - - 0.001ms (2.1%) (self: 0.001 ms) 2x RegisterListWantsCrossRef
 - - - - - 0.001ms (0.76%) (self: 0.001 ms) 2x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - 0.065ms (0.01%) (self: 0.063 ms) ParseValueAndReturnDef (for RimWorld.PsychicRitualDef_Chronophagy)
 - - - - - 0.001ms (1.4%) (self: 0.001 ms) RegisterListWantsCrossRef
 - - - - - 0.000ms (0.62%) (self: 0.000 ms) 2x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - 0.065ms (0.01%) (self: 0.064 ms) ParseValueAndReturnDef (for RimWorld.PsychicRitualDef_Psychophagy)
 - - - - - 0.001ms (0.78%) (self: 0.001 ms) 2x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - - 0.000ms (0.62%) (self: 0.000 ms) RegisterListWantsCrossRef
 - - - - 0.062ms (0.01%) (self: 0.062 ms) 2x ParseValueAndReturnDef (for RimWorld.PlanetLayerSettingsDef)
 - - - - 0.062ms (0.01%) (self: 0.060 ms) ParseValueAndReturnDef (for RimWorld.GeneratedLocationDef)
 - - - - - 0.002ms (2.4%) (self: 0.002 ms) 8x RegisterListWantsCrossRef
 - - - - - 0.000ms (0.49%) (self: 0.000 ms) RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - 0.061ms (0.01%) (self: 0.059 ms) ParseValueAndReturnDef (for RimWorld.PsychicRitualDef_SummonFleshbeasts)
 - - - - - 0.001ms (1.2%) (self: 0.001 ms) RegisterListWantsCrossRef
 - - - - - 0.000ms (0.66%) (self: 0.000 ms) RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - 0.060ms (0.01%) (self: 0.060 ms) 6x ParseValueAndReturnDef (for RimWorld.IdeoPresetCategoryDef)
 - - - - 0.059ms (0.01%) (self: 0.058 ms) ParseValueAndReturnDef (for RimWorld.PsychicRitualDef_Brainwipe)
 - - - - - 0.001ms (0.85%) (self: 0.001 ms) 3x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - - 0.001ms (0.85%) (self: 0.001 ms) RegisterListWantsCrossRef
 - - - - 0.059ms (0.01%) (self: 0.059 ms) 2x ParseValueAndReturnDef (for Verse.LogEntryDef)
 - - - - 0.058ms (0.01%) (self: 0.057 ms) ParseValueAndReturnDef (for RimWorld.PsychicRitualDef_PleasurePulse)
 - - - - - 0.000ms (0.69%) (self: 0.000 ms) 2x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - - 0.000ms (0.69%) (self: 0.000 ms) RegisterListWantsCrossRef
 - - - - 0.057ms (0.01%) (self: 0.056 ms) 2x ParseValueAndReturnDef (for Verse.MentalFitDef)
 - - - - - 0.000ms (0.71%) (self: 0.000 ms) 2x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - 0.056ms (0.01%) (self: 0.056 ms) 3x ParseValueAndReturnDef (for Verse.PathGridDef)
 - - - - 0.054ms (0.01%) (self: 0.053 ms) ParseValueAndReturnDef (for RimWorld.PsychicRitualDef_SummonPitGate)
 - - - - - 0.001ms (1.8%) (self: 0.001 ms) 2x RegisterListWantsCrossRef
 - - - - - 0.000ms (0.74%) (self: 0.000 ms) 2x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - 0.054ms (0.01%) (self: 0.054 ms) 12x ParseValueAndReturnDef (for RimWorld.RoomPartDef)
 - - - - 0.054ms (0.01%) (self: 0.053 ms) ParseValueAndReturnDef (for RimWorld.PsychicRitualDef_SkipAbductionPlayer)
 - - - - - 0.001ms (0.93%) (self: 0.001 ms) RegisterListWantsCrossRef
 - - - - - 0.000ms (0.56%) (self: 0.000 ms) RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - 0.054ms (0.01%) (self: 0.053 ms) 4x ParseValueAndReturnDef (for Verse.RoofDef)
 - - - - - 0.001ms (2.6%) (self: 0.001 ms) 7x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - 0.054ms (0.01%) (self: 0.054 ms) 3x ParseValueAndReturnDef (for RimWorld.EntityCategoryDef)
 - - - - 0.053ms (0.01%) (self: 0.052 ms) ParseValueAndReturnDef (for RimWorld.PsychicRitualDef_NeurosisPulse)
 - - - - - 0.001ms (0.94%) (self: 0.001 ms) 2x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - - 0.000ms (0.75%) (self: 0.000 ms) RegisterListWantsCrossRef
 - - - - 0.052ms (0.01%) (self: 0.051 ms) ParseValueAndReturnDef (for RimWorld.PsychicRitualDef_BloodRain)
 - - - - - 0.001ms (1.3%) (self: 0.001 ms) 2x RegisterListWantsCrossRef
 - - - - - 0.000ms (0.76%) (self: 0.000 ms) 2x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - 0.052ms (0.01%) (self: 0.052 ms) 3x ParseValueAndReturnDef (for RimWorld.AnomalyPlaystyleDef)
 - - - - 0.049ms (0.01%) (self: 0.049 ms) 4x ParseValueAndReturnDef (for RimWorld.LandingOutcomeDef)
 - - - - - 0.001ms (1.4%) (self: 0.001 ms) 4x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - 0.049ms (0.01%) (self: 0.049 ms) 2x ParseValueAndReturnDef (for Verse.CreepJoinerRejectionDef)
 - - - - - 0.001ms (1%) (self: 0.001 ms) 2x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - 0.049ms (0.01%) (self: 0.048 ms) ParseValueAndReturnDef (for RimWorld.PsychicRitualDef_SummonShamblers)
 - - - - - 0.001ms (1.2%) (self: 0.001 ms) 2x RegisterListWantsCrossRef
 - - - - - 0.000ms (0.41%) (self: 0.000 ms) RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - 0.047ms (0.01%) (self: 0.045 ms) 6x ParseValueAndReturnDef (for RimWorld.StuffCategoryDef)
 - - - - - 0.002ms (5.1%) (self: 0.002 ms) 16x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - 0.047ms (0.01%) (self: 0.045 ms) 4x ParseValueAndReturnDef (for RimWorld.TransportShipDef)
 - - - - - 0.002ms (3.9%) (self: 0.002 ms) 12x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - 0.046ms (0.01%) (self: 0.046 ms) 6x ParseValueAndReturnDef (for Verse.ApparelLayerDef)
 - - - - 0.046ms (0.01%) (self: 0.046 ms) 10x ParseValueAndReturnDef (for WeaponClassDef)
 - - - - 0.046ms (0.01%) (self: 0.046 ms) 11x ParseValueAndReturnDef (for RimWorld.XenotypeIconDef)
 - - - - 0.045ms (0.01%) (self: 0.044 ms) ParseValueAndReturnDef (for RimWorld.PsychicRitualDef_SkipAbduction)
 - - - - - 0.000ms (0.45%) (self: 0.000 ms) RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - 0.043ms (0.01%) (self: 0.043 ms) 7x ParseValueAndReturnDef (for RimWorld.ShipJobDef)
 - - - - 0.043ms (0.01%) (self: 0.043 ms) ParseValueAndReturnDef (for RimWorld.RaidAgeRestrictionDef)
 - - - - 0.043ms (0.01%) (self: 0.043 ms) 7x ParseValueAndReturnDef (for RimWorld.RitualTargetFilterDef)
 - - - - 0.041ms (0%) (self: 0.041 ms) 12x ParseValueAndReturnDef (for RimWorld.StyleItemCategoryDef)
 - - - - 0.040ms (0%) (self: 0.040 ms) 8x ParseValueAndReturnDef (for Verse.OptionCategoryDef)
 - - - - 0.040ms (0%) (self: 0.040 ms) 5x ParseValueAndReturnDef (for RimWorld.GravshipComponentTypeDef)
 - - - - 0.039ms (0%) (self: 0.039 ms) 10x ParseValueAndReturnDef (for RimWorld.JoyKindDef)
 - - - - 0.039ms (0%) (self: 0.037 ms) 12x ParseValueAndReturnDef (for Verse.MessageTypeDef)
 - - - - - 0.002ms (4.6%) (self: 0.002 ms) 10x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - 0.037ms (0%) (self: 0.037 ms) 13x ParseValueAndReturnDef (for RimWorld.IncidentCategoryDef)
 - - - - - 0.000ms (0.54%) (self: 0.000 ms) RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - 0.037ms (0%) (self: 0.036 ms) 3x ParseValueAndReturnDef (for RimWorld.BossDef)
 - - - - - 0.001ms (1.4%) (self: 0.001 ms) 3x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - 0.037ms (0%) (self: 0.037 ms) 7x ParseValueAndReturnDef (for RimWorld.TransferableSorterDef)
 - - - - 0.036ms (0%) (self: 0.036 ms) 15x ParseValueAndReturnDef (for RimWorld.MapMeshFlagDef)
 - - - - 0.035ms (0%) (self: 0.035 ms) 3x ParseValueAndReturnDef (for RimWorld.AbilityGroupDef)
 - - - - 0.035ms (0%) (self: 0.035 ms) 5x ParseValueAndReturnDef (for RimWorld.SlaveInteractionModeDef)
 - - - - 0.035ms (0%) (self: 0.035 ms) 3x ParseValueAndReturnDef (for RimWorld.DebugTabMenuDef)
 - - - - 0.034ms (0%) (self: 0.034 ms) 16x ParseValueAndReturnDef (for RimWorld.WeaponCategoryDef)
 - - - - 0.034ms (0%) (self: 0.033 ms) 7x ParseValueAndReturnDef (for Verse.Sound.ImpactSoundTypeDef)
 - - - - - 0.001ms (1.5%) (self: 0.001 ms) 2x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - 0.034ms (0%) (self: 0.034 ms) 5x ParseValueAndReturnDef (for RimWorld.RoadWorldLayerDef)
 - - - - 0.034ms (0%) (self: 0.034 ms) ParseValueAndReturnDef (for RimWorld.PsychicRitualRoleDef_DeathRefusalTarget)
 - - - - 0.033ms (0%) (self: 0.031 ms) 5x ParseValueAndReturnDef (for WeaponClassPairDef)
 - - - - - 0.002ms (6.3%) (self: 0.002 ms) 10x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - 0.033ms (0%) (self: 0.033 ms) 6x ParseValueAndReturnDef (for RimWorld.RoomPart_ThingDef)
 - - - - - 0.001ms (2.4%) (self: 0.001 ms) 6x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - 0.031ms (0%) (self: 0.031 ms) 6x ParseValueAndReturnDef (for Verse.ClamorDef)
 - - - - 0.030ms (0%) (self: 0.030 ms) 3x ParseValueAndReturnDef (for RimWorld.InfectionPathwayDef)
 - - - - 0.028ms (0%) (self: 0.028 ms) 2x ParseValueAndReturnDef (for RimWorld.GlobalWorldDrawLayerDef)
 - - - - 0.028ms (0%) (self: 0.028 ms) 5x ParseValueAndReturnDef (for Verse.ImplementOwnerTypeDef)
 - - - - 0.027ms (0%) (self: 0.026 ms) 3x ParseValueAndReturnDef (for RimWorld.BabyPlayDef)
 - - - - - 0.001ms (2.6%) (self: 0.001 ms) 3x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - 0.025ms (0%) (self: 0.025 ms) 4x ParseValueAndReturnDef (for RimWorld.AbilityCategoryDef)
 - - - - 0.025ms (0%) (self: 0.025 ms) 3x ParseValueAndReturnDef (for RimWorld.BillStoreModeDef)
 - - - - 0.024ms (0%) (self: 0.024 ms) ParseValueAndReturnDef (for RimWorld.RoomPart_BarricadeDef)
 - - - - - 0.000ms (0.41%) (self: 0.000 ms) RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - 0.024ms (0%) (self: 0.024 ms) 5x ParseValueAndReturnDef (for Verse.PawnRenderNodeTagDef)
 - - - - 0.024ms (0%) (self: 0.024 ms) 3x ParseValueAndReturnDef (for RimWorld.BillRepeatModeDef)
 - - - - 0.023ms (0%) (self: 0.023 ms) 2x ParseValueAndReturnDef (for RimWorld.RoomPart_CrateDef)
 - - - - - 0.001ms (3%) (self: 0.001 ms) 4x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - 0.023ms (0%) (self: 0.023 ms) ParseValueAndReturnDef (for RimWorld.IdeoFoundationDef)
 - - - - 0.023ms (0%) (self: 0.023 ms) 4x ParseValueAndReturnDef (for Verse.MechWeightClassDef)
 - - - - 0.022ms (0%) (self: 0.022 ms) 5x ParseValueAndReturnDef (for Verse.ResearchProjectTagDef)
 - - - - 0.021ms (0%) (self: 0.021 ms) 3x ParseValueAndReturnDef (for Verse.TrainabilityDef)
 - - - - 0.020ms (0%) (self: 0.020 ms) 3x ParseValueAndReturnDef (for Verse.DamageArmorCategoryDef)
 - - - - - 0.001ms (3%) (self: 0.001 ms) 5x RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - 0.019ms (0%) (self: 0.018 ms) ParseValueAndReturnDef (for Verse.InventoryStockGroupDef)
 - - - - - 0.001ms (6.2%) (self: 0.001 ms) 3x RegisterListWantsCrossRef
 - - - - - 0.000ms (1%) (self: 0.000 ms) RegisterObjectWantsCrossRef (object, FieldInfo, string)
 - - - - 0.019ms (0%) (self: 0.019 ms) 7x ParseValueAndReturnDef (for RimWorld.RenderSkipFlagDef)
 - - - - 0.019ms (0%) (self: 0.019 ms) 7x ParseValueAndReturnDef (for RimWorld.IncidentTargetTagDef)
 - - - - 0.018ms (0%) (self: 0.018 ms) 4x ParseValueAndReturnDef (for Verse.StuffAppearanceDef)
 - - - - 0.016ms (0%) (self: 0.016 ms) 2x ParseValueAndReturnDef (for Verse.OrderedTakeGroupDef)
 - - - - 0.015ms (0%) (self: 0.015 ms) 2x ParseValueAndReturnDef (for RimWorld.RoadPathingDef)
 - - - - 0.015ms (0%) (self: 0.015 ms) 3x ParseValueAndReturnDef (for Verse.ReservationLayerDef)
 - - - - 0.013ms (0%) (self: 0.013 ms) 3x ParseValueAndReturnDef (for RimWorld.HibernatableStateDef)
 - - - - 0.012ms (0%) (self: 0.012 ms) 2x ParseValueAndReturnDef (for Verse.GraphicStateDef)
 - - - - 0.012ms (0%) (self: 0.012 ms) 3x ParseValueAndReturnDef (for RimWorld.WorkGiverEquivalenceGroupDef)
 - - - 120.191ms (12%) (self: 67.097 ms) XmlInheritance.Resolve()
 - - - - 53.094ms (44%) (self: 33.135 ms) 4946x RecursiveNodeCopyOverwriteElements
 - - - - - 19.959ms (38%) (self: 13.130 ms) 8947x RecursiveNodeCopyOverwriteElements
 - - - - - - 6.045ms (30%) (self: 5.314 ms) 3265x RecursiveNodeCopyOverwriteElements
 - - - - - - - 0.636ms (11%) (self: 0.636 ms) 2964x RecursiveNodeCopyOverwriteElements - Remove all current nodes
 - - - - - - - 0.095ms (1.6%) (self: 0.067 ms) 137x RecursiveNodeCopyOverwriteElements
 - - - - - - - - 0.027ms (29%) (self: 0.027 ms) 135x RecursiveNodeCopyOverwriteElements - Remove all current nodes
 - - - - - - 0.784ms (3.9%) (self: 0.784 ms) 4004x RecursiveNodeCopyOverwriteElements - Remove all current nodes
 - - - 9.264ms (0.94%) (self: 3.117 ms) Loading asset nodes 14809
 - - - - 4.393ms (47%) (self: 4.393 ms) 14809x XmlInheritance.TryRegister
 - - - - 1.754ms (19%) (self: 1.754 ms) 14809x assetlookup.TryGetValue
 - - 423.667ms (21%) (self: 0.200 ms) LoadModXML()
 - - - 161.168ms (38%) (self: 0.006 ms) Loading Ludeon.RimWorld
 - - - - 161.026ms (100%) (self: 161.026 ms) Load defs via DirectXmlLoader
 - - - - 0.136ms (0.08%) (self: 0.136 ms) Parse loaded defs
 - - - 85.191ms (20%) (self: 0.008 ms) Loading Ludeon.RimWorld.Ideology
 - - - - 85.146ms (100%) (self: 85.146 ms) Load defs via DirectXmlLoader
 - - - - 0.037ms (0.04%) (self: 0.037 ms) Parse loaded defs
 - - - 47.355ms (11%) (self: 0.006 ms) Loading Ludeon.RimWorld.Odyssey
 - - - - 47.308ms (100%) (self: 47.308 ms) Load defs via DirectXmlLoader
 - - - - 0.042ms (0.09%) (self: 0.042 ms) Parse loaded defs
 - - - 42.259ms (10%) (self: 0.006 ms) Loading Ludeon.RimWorld.Anomaly
 - - - - 42.229ms (100%) (self: 42.229 ms) Load defs via DirectXmlLoader
 - - - - 0.024ms (0.06%) (self: 0.024 ms) Parse loaded defs
 - - - 32.340ms (7.6%) (self: 0.007 ms) Loading Ludeon.RimWorld.Biotech
 - - - - 32.308ms (100%) (self: 32.308 ms) Load defs via DirectXmlLoader
 - - - - 0.025ms (0.08%) (self: 0.025 ms) Parse loaded defs
 - - - 32.159ms (7.6%) (self: 0.006 ms) Loading Ludeon.RimWorld.Royalty
 - - - - 32.131ms (100%) (self: 32.131 ms) Load defs via DirectXmlLoader
 - - - - 0.023ms (0.07%) (self: 0.023 ms) Parse loaded defs
 - - - 19.444ms (4.6%) (self: 0.004 ms) Loading Atlas.AndroidTiers
 - - - - 19.426ms (100%) (self: 19.426 ms) Load defs via DirectXmlLoader
 - - - - 0.014ms (0.07%) (self: 0.014 ms) Parse loaded defs
 - - - 2.489ms (0.59%) (self: 0.004 ms) Loading erdelf.HumanoidAlienRaces
 - - - - 2.482ms (100%) (self: 2.482 ms) Load defs via DirectXmlLoader
 - - - - 0.002ms (0.09%) (self: 0.002 ms) Parse loaded defs
 - - - 1.024ms (0.24%) (self: 0.278 ms) Loading brrainz.harmony
 - - - - 0.715ms (70%) (self: 0.715 ms) Load defs via DirectXmlLoader
 - - - - 0.032ms (3.1%) (self: 0.032 ms) Parse loaded defs
 - - - 0.037ms (0.01%) (self: 0.002 ms) Loading CarnySenpai.EnableOversizedWeapons
 - - - - 0.036ms (95%) (self: 0.036 ms) Load defs via DirectXmlLoader
 - - - - 0.000ms (0.53%) (self: 0.000 ms) Parse loaded defs
 - - 273.295ms (14%) (self: 24.364 ms) CreateModClasses()
 - - - 205.035ms (75%) (self: 205.035 ms) Loading HarmonyMod.Main mod class
 - - - 33.363ms (12%) (self: 33.358 ms) Loading AlienRace.AlienRaceMod mod class
 - - - - 0.006ms (0.02%) (self: 0.006 ms) TryDoPostLoad
 - - - 10.180ms (3.7%) (self: 10.180 ms) Loading MOARANDROIDS.AndroidTiersPP mod class
 - - - 0.353ms (0.13%) (self: 0.353 ms) Loading EnableOversizedWeapons.EnableOversizedWeaponsMod mod class
 - - 190.174ms (9.5%) (self: 190.174 ms) CombineIntoUnifiedXML()
 - - 75.535ms (3.8%) (self: 0.342 ms) ApplyPatches()
 - - - 28.066ms (37%) (self: 28.066 ms) 24x Verse.PatchOperationReplace Worker
 - - - 22.075ms (29%) (self: 22.075 ms) 8x Verse.PatchOperationAdd Worker
 - - - 19.615ms (26%) (self: 19.615 ms) 4x Verse.PatchOperationAttributeSet Worker
 - - - 5.436ms (7.2%) (self: 0.124 ms) 3x Verse.PatchOperationSequence Worker
 - - - - 5.312ms (98%) (self: 5.312 ms) 3x Verse.PatchOperationAdd Worker
 - - 29.602ms (1.5%) (self: 26.311 ms) InitializeMods()
 - - - 2.293ms (7.7%) (self: 2.293 ms) Initializing [brrainz.harmony|Harmony]
 - - - 0.229ms (0.77%) (self: 0.229 ms) Initializing [erdelf.HumanoidAlienRaces|Humanoid Alien Races]
 - - - 0.213ms (0.72%) (self: 0.213 ms) Initializing [Ludeon.RimWorld|Core]
 - - - 0.123ms (0.41%) (self: 0.123 ms) Initializing [Atlas.AndroidTiers|Android tiers]
 - - - 0.095ms (0.32%) (self: 0.095 ms) Initializing [Ludeon.RimWorld.Royalty|Royalty]
 - - - 0.083ms (0.28%) (self: 0.083 ms) Initializing [Ludeon.RimWorld.Ideology|Ideology]
 - - - 0.062ms (0.21%) (self: 0.062 ms) Initializing [Ludeon.RimWorld.Odyssey|Odyssey]
 - - - 0.058ms (0.2%) (self: 0.058 ms) Initializing [Ludeon.RimWorld.Biotech|Biotech]
 - - - 0.054ms (0.18%) (self: 0.054 ms) Initializing [Ludeon.RimWorld.Anomaly|Anomaly]
 - - - 0.052ms (0.18%) (self: 0.052 ms) 7x TryDoPostLoad
 - - - 0.017ms (0.06%) (self: 0.017 ms) 2x ResolveAllWantedCrossReferences
 - - - 0.013ms (0.04%) (self: 0.013 ms) Initializing [CarnySenpai.EnableOversizedWeapons|Enable Oversized Weapons]
 - - - 0.000ms (0%) (self: 0.000 ms) Clear
 - - 17.630ms (0.88%) (self: 0.763 ms) ErrorCheckPatches()
 - - - 16.867ms (96%) (self: 16.863 ms) 10x Loading all patches
 - - - - 0.004ms (0.02%) (self: 0.004 ms) 6x TryDoPostLoad
 - - 14.976ms (0.74%) (self: 0.292 ms) LoadModContent()
 - - - 8.187ms (55%) (self: 8.187 ms) Loading brrainz.harmony content
 - - - 3.401ms (23%) (self: 3.401 ms) Loading erdelf.HumanoidAlienRaces content
 - - - 2.140ms (14%) (self: 2.140 ms) Loading Atlas.AndroidTiers content
 - - - 0.885ms (5.9%) (self: 0.885 ms) Loading CarnySenpai.EnableOversizedWeapons content
 - - - 0.027ms (0.18%) (self: 0.027 ms) Loading Ludeon.RimWorld content
 - - - 0.011ms (0.07%) (self: 0.011 ms) Loading Ludeon.RimWorld.Royalty content
 - - - 0.010ms (0.07%) (self: 0.010 ms) Loading Ludeon.RimWorld.Ideology content
 - - - 0.009ms (0.06%) (self: 0.009 ms) Loading Ludeon.RimWorld.Odyssey content
 - - - 0.008ms (0.05%) (self: 0.008 ms) Loading Ludeon.RimWorld.Anomaly content
 - - - 0.007ms (0.05%) (self: 0.007 ms) Loading Ludeon.RimWorld.Biotech content
 - - 1.559ms (0.08%) (self: 1.559 ms) TKeySystem.Parse()
 - - 0.243ms (0.01%) (self: 0.243 ms) ClearCachedPatches()
 - - 0.050ms (0%) (self: 0.050 ms) 2x XmlInheritance.Clear()
 - 1835.127ms (35%) (self: 1835.127 ms) Inject selected language data into game data (early pass).
 - 476.244ms (9.1%) (self: 0.008 ms) Resolve references.
 - - 406.275ms (85%) (self: 3.690 ms) Static resolver calls
 - - - 332.907ms (82%) (self: 0.043 ms) ResolveAllReferences Verse.ThinkTreeDef
 - - - - 332.864ms (100%) (self: 332.864 ms) 65x Resolver call
 - - - 55.098ms (14%) (self: 0.016 ms) ResolveAllReferences AlienRace.ThingDef_AlienRace
 - - - - 55.082ms (100%) (self: 55.082 ms) 9x Resolver call
 - - - 3.333ms (0.82%) (self: 0.019 ms) ResolveAllReferences RimWorld.ThingSetMakerDef
 - - - - 3.314ms (99%) (self: 3.314 ms) 50x Resolver call
 - - - 1.547ms (0.38%) (self: 1.547 ms) 512x SetIndices
 - - - 0.993ms (0.24%) (self: 0.015 ms) ResolveAllReferences Verse.WorkTypeDef
 - - - - 0.978ms (99%) (self: 0.978 ms) 23x Resolver call
 - - - 0.919ms (0.23%) (self: 0.160 ms) ResolveAllReferences Verse.SoundDef
 - - - - 0.759ms (83%) (self: 0.759 ms) 1282x Resolver call
 - - - 0.448ms (0.11%) (self: 0.015 ms) ResolveAllReferences Verse.BodyDef
 - - - - 0.433ms (97%) (self: 0.433 ms) 54x Resolver call
 - - - 0.335ms (0.08%) (self: 0.067 ms) ResolveAllReferences Verse.HediffDef
 - - - - 0.268ms (80%) (self: 0.268 ms) 427x Resolver call
 - - - 0.300ms (0.07%) (self: 0.035 ms) ResolveAllReferences Verse.GeneDef
 - - - - 0.265ms (88%) (self: 0.265 ms) 232x Resolver call
 - - - 0.280ms (0.07%) (self: 0.014 ms) ResolveAllReferences RimWorld.FactionDef
 - - - - 0.266ms (95%) (self: 0.266 ms) 37x Resolver call
 - - - 0.263ms (0.06%) (self: 0.007 ms) ResolveAllReferences AlienRace.PawnBioDef
 - - - - 0.257ms (98%) (self: 0.257 ms) Resolver call
 - - - 0.259ms (0.06%) (self: 0.019 ms) ResolveAllReferences RimWorld.TileMutatorDef
 - - - - 0.240ms (93%) (self: 0.240 ms) 87x Resolver call
 - - - 0.245ms (0.06%) (self: 0.011 ms) ResolveAllReferences RimWorld.EntityCodexEntryDef
 - - - - 0.234ms (95%) (self: 0.234 ms) 27x Resolver call
 - - - 0.233ms (0.06%) (self: 0.011 ms) ResolveAllReferences RimWorld.XenotypeDef
 - - - - 0.222ms (95%) (self: 0.222 ms) 12x Resolver call
 - - - 0.216ms (0.05%) (self: 0.043 ms) ResolveAllReferences Verse.PawnKindDef
 - - - - 0.173ms (80%) (self: 0.173 ms) 313x Resolver call
 - - - 0.195ms (0.05%) (self: 0.126 ms) ResolveAllReferences RimWorld.BackstoryDef
 - - - - 0.069ms (35%) (self: 0.069 ms) 964x Resolver call
 - - - 0.194ms (0.05%) (self: 0.126 ms) ResolveAllReferences RimWorld.ThoughtDef
 - - - - 0.068ms (35%) (self: 0.068 ms) 995x Resolver call
 - - - 0.178ms (0.04%) (self: 0.012 ms) ResolveAllReferences RimWorld.TraderKindDef
 - - - - 0.166ms (93%) (self: 0.166 ms) 26x Resolver call
 - - - 0.118ms (0.03%) (self: 0.015 ms) ResolveAllReferences RimWorld.TraitDef
 - - - - 0.103ms (87%) (self: 0.103 ms) 56x Resolver call
 - - - 0.102ms (0.02%) (self: 0.007 ms) ResolveAllReferences RimWorld.StorytellerDef
 - - - - 0.095ms (93%) (self: 0.095 ms) 4x Resolver call
 - - - 0.095ms (0.02%) (self: 0.061 ms) ResolveAllReferences Verse.GraphicStateDef
 - - - - 0.033ms (35%) (self: 0.033 ms) 449x Resolver call
 - - - 0.094ms (0.02%) (self: 0.013 ms) ResolveAllReferences RimWorld.PsychicRitualDef_BloodRain
 - - - - 0.081ms (87%) (self: 0.081 ms) Resolver call
 - - - 0.093ms (0.02%) (self: 0.013 ms) ResolveAllReferences Verse.CreepJoinerFormKindDef
 - - - - 0.080ms (86%) (self: 0.080 ms) 8x Resolver call
 - - - 0.081ms (0.02%) (self: 0.011 ms) ResolveAllReferences Verse.PawnRenderTreeDef
 - - - - 0.070ms (86%) (self: 0.070 ms) 11x Resolver call
 - - - 0.079ms (0.02%) (self: 0.014 ms) ResolveAllReferences RimWorld.WorldObjectDef
 - - - - 0.065ms (82%) (self: 0.065 ms) 33x Resolver call
 - - - 0.078ms (0.02%) (self: 0.050 ms) ResolveAllReferences Verse.TerrainDef
 - - - - 0.028ms (36%) (self: 0.028 ms) 382x Resolver call
 - - - 0.074ms (0.02%) (self: 0.011 ms) ResolveAllReferences Verse.DesignationCategoryDef
 - - - - 0.064ms (85%) (self: 0.064 ms) 17x Resolver call
 - - - 0.073ms (0.02%) (self: 0.044 ms) ResolveAllReferences Verse.JobDef
 - - - - 0.029ms (39%) (self: 0.029 ms) 327x Resolver call
 - - - 0.073ms (0.02%) (self: 0.046 ms) ResolveAllReferences Verse.RulePackDef
 - - - - 0.027ms (37%) (self: 0.027 ms) 348x Resolver call
 - - - 0.071ms (0.02%) (self: 0.047 ms) ResolveAllReferences Verse.FleckDef
 - - - - 0.024ms (34%) (self: 0.024 ms) 316x Resolver call
 - - - 0.064ms (0.02%) (self: 0.030 ms) ResolveAllReferences Verse.ResearchProjectDef
 - - - - 0.035ms (54%) (self: 0.035 ms) 202x Resolver call
 - - - 0.061ms (0.01%) (self: 0.041 ms) ResolveAllReferences Verse.EffecterDef
 - - - - 0.020ms (33%) (self: 0.020 ms) 283x Resolver call
 - - - 0.058ms (0.01%) (self: 0.017 ms) ResolveAllReferences Verse.SongDef
 - - - - 0.041ms (71%) (self: 0.041 ms) 77x Resolver call
 - - - 0.057ms (0.01%) (self: 0.036 ms) ResolveAllReferences RimWorld.StatDef
 - - - - 0.020ms (36%) (self: 0.020 ms) 247x Resolver call
 - - - 0.054ms (0.01%) (self: 0.009 ms) ResolveAllReferences RimWorld.LifeStageDef
 - - - - 0.045ms (83%) (self: 0.045 ms) 18x Resolver call
 - - - 0.054ms (0.01%) (self: 0.054 ms) ResolveAllReferences Verse.BuildableDef
 - - - 0.054ms (0.01%) (self: 0.036 ms) ResolveAllReferences RimWorld.PreceptDef
 - - - - 0.017ms (33%) (self: 0.017 ms) 235x Resolver call
 - - - 0.051ms (0.01%) (self: 0.032 ms) ResolveAllReferences Verse.BodyPartDef
 - - - - 0.019ms (37%) (self: 0.019 ms) 191x Resolver call
 - - - 0.048ms (0.01%) (self: 0.035 ms) ResolveAllReferences Verse.GenStepDef
 - - - - 0.014ms (28%) (self: 0.014 ms) 170x Resolver call
 - - - 0.048ms (0.01%) (self: 0.033 ms) ResolveAllReferences RimWorld.HistoryEventDef
 - - - - 0.016ms (32%) (self: 0.016 ms) 181x Resolver call
 - - - 0.045ms (0.01%) (self: 0.008 ms) ResolveAllReferences RimWorld.MutantDef
 - - - - 0.037ms (83%) (self: 0.037 ms) 3x Resolver call
 - - - 0.044ms (0.01%) (self: 0.017 ms) ResolveAllReferences RimWorld.InteractionDef
 - - - - 0.028ms (63%) (self: 0.028 ms) 71x Resolver call
 - - - 0.044ms (0.01%) (self: 0.030 ms) ResolveAllReferences RimWorld.PrefabDef
 - - - - 0.014ms (32%) (self: 0.014 ms) 176x Resolver call
 - - - 0.041ms (0.01%) (self: 0.024 ms) ResolveAllReferences RimWorld.IncidentDef
 - - - - 0.016ms (40%) (self: 0.016 ms) 135x Resolver call
 - - - 0.040ms (0.01%) (self: 0.029 ms) ResolveAllReferences RimWorld.WorkGiverDef
 - - - - 0.012ms (29%) (self: 0.012 ms) 155x Resolver call
 - - - 0.039ms (0.01%) (self: 0.026 ms) ResolveAllReferences RimWorld.QuestScriptDef
 - - - - 0.013ms (33%) (self: 0.013 ms) 151x Resolver call
 - - - 0.038ms (0.01%) (self: 0.011 ms) ResolveAllReferences Verse.LetterDef
 - - - - 0.027ms (71%) (self: 0.027 ms) 28x Resolver call
 - - - 0.037ms (0.01%) (self: 0.013 ms) ResolveAllReferences Verse.MentalStateDef
 - - - - 0.024ms (64%) (self: 0.024 ms) 47x Resolver call
 - - - 0.036ms (0.01%) (self: 0.024 ms) ResolveAllReferences RimWorld.LayoutRoomDef
 - - - - 0.012ms (33%) (self: 0.012 ms) 145x Resolver call
 - - - 0.035ms (0.01%) (self: 0.033 ms) ResolveAllReferences WeaponClassDef
 - - - - 0.003ms (7.3%) (self: 0.003 ms) 10x Resolver call
 - - - 0.034ms (0.01%) (self: 0.023 ms) ResolveAllReferences RimWorld.ColorDef
 - - - - 0.011ms (31%) (self: 0.011 ms) 135x Resolver call
 - - - 0.034ms (0.01%) (self: 0.012 ms) ResolveAllReferences Verse.DesignationDef
 - - - - 0.022ms (65%) (self: 0.022 ms) 27x Resolver call
 - - - 0.033ms (0.01%) (self: 0.008 ms) ResolveAllReferences RimWorld.SkillDef
 - - - - 0.025ms (76%) (self: 0.025 ms) 12x Resolver call
 - - - 0.031ms (0.01%) (self: 0.022 ms) ResolveAllReferences Verse.ThingStyleDef
 - - - - 0.010ms (30%) (self: 0.010 ms) 123x Resolver call
 - - - 0.031ms (0.01%) (self: 0.029 ms) ResolveAllReferences RimWorld.CultureDef
 - - - - 0.002ms (7.5%) (self: 0.002 ms) 5x Resolver call
 - - - 0.029ms (0.01%) (self: 0.020 ms) ResolveAllReferences Verse.AI.DutyDef
 - - - - 0.009ms (32%) (self: 0.009 ms) 108x Resolver call
 - - - 0.029ms (0.01%) (self: 0.020 ms) ResolveAllReferences RimWorld.TaleDef
 - - - - 0.009ms (30%) (self: 0.009 ms) 103x Resolver call
 - - - 0.029ms (0.01%) (self: 0.019 ms) ResolveAllReferences Verse.ShaderTypeDef
 - - - - 0.010ms (33%) (self: 0.010 ms) 122x Resolver call
 - - - 0.028ms (0.01%) (self: 0.026 ms) ResolveAllReferences Verse.TipSetDef
 - - - - 0.002ms (8.2%) (self: 0.002 ms) 6x Resolver call
 - - - 0.028ms (0.01%) (self: 0.019 ms) ResolveAllReferences RimWorld.AbilityDef
 - - - - 0.008ms (29%) (self: 0.008 ms) 99x Resolver call
 - - - 0.027ms (0.01%) (self: 0.018 ms) ResolveAllReferences RimWorld.RuleDef
 - - - - 0.009ms (34%) (self: 0.009 ms) 112x Resolver call
 - - - 0.027ms (0.01%) (self: 0.020 ms) ResolveAllReferences RimWorld.PawnColumnDef
 - - - - 0.007ms (26%) (self: 0.007 ms) 80x Resolver call
 - - - 0.025ms (0.01%) (self: 0.018 ms) ResolveAllReferences RimWorld.IdeoIconDef
 - - - - 0.008ms (30%) (self: 0.008 ms) 94x Resolver call
 - - - 0.025ms (0.01%) (self: 0.018 ms) ResolveAllReferences RimWorld.ConceptDef
 - - - - 0.007ms (29%) (self: 0.007 ms) 85x Resolver call
 - - - 0.025ms (0.01%) (self: 0.018 ms) ResolveAllReferences RimWorld.IssueDef
 - - - - 0.007ms (27%) (self: 0.007 ms) 76x Resolver call
 - - - 0.024ms (0.01%) (self: 0.018 ms) ResolveAllReferences RimWorld.RecordDef
 - - - - 0.006ms (26%) (self: 0.006 ms) 70x Resolver call
 - - - 0.024ms (0.01%) (self: 0.017 ms) ResolveAllReferences RimWorld.HairDef
 - - - - 0.007ms (30%) (self: 0.007 ms) 80x Resolver call
 - - - 0.024ms (0.01%) (self: 0.018 ms) ResolveAllReferences Verse.AnimationDef
 - - - - 0.006ms (24%) (self: 0.006 ms) 70x Resolver call
 - - - 0.022ms (0.01%) (self: 0.020 ms) ResolveAllReferences RimWorld.ExpectationDef
 - - - - 0.002ms (10%) (self: 0.002 ms) 10x Resolver call
 - - - 0.021ms (0.01%) (self: 0.016 ms) ResolveAllReferences Verse.SpecialThingFilterDef
 - - - - 0.005ms (22%) (self: 0.005 ms) 47x Resolver call
 - - - 0.020ms (0%) (self: 0.014 ms) ResolveAllReferences Verse.BodyPartGroupDef
 - - - - 0.005ms (26%) (self: 0.005 ms) 50x Resolver call
 - - - 0.020ms (0%) (self: 0.014 ms) ResolveAllReferences Verse.KeyBindingDef
 - - - - 0.006ms (30%) (self: 0.006 ms) 59x Resolver call
 - - - 0.020ms (0%) (self: 0.014 ms) ResolveAllReferences RimWorld.WeaponTraitDef
 - - - - 0.005ms (28%) (self: 0.005 ms) 61x Resolver call
 - - - 0.019ms (0%) (self: 0.014 ms) ResolveAllReferences RimWorld.SitePartDef
 - - - - 0.006ms (30%) (self: 0.006 ms) 58x Resolver call
 - - - 0.019ms (0%) (self: 0.016 ms) ResolveAllReferences Verse.ClamorDef
 - - - - 0.003ms (15%) (self: 0.003 ms) 6x Resolver call
 - - - 0.019ms (0%) (self: 0.013 ms) ResolveAllReferences Verse.DamageDef
 - - - - 0.006ms (29%) (self: 0.006 ms) 52x Resolver call
 - - - 0.019ms (0%) (self: 0.016 ms) ResolveAllReferences Verse.StyleCategoryDef
 - - - - 0.002ms (13%) (self: 0.002 ms) 11x Resolver call
 - - - 0.018ms (0%) (self: 0.014 ms) ResolveAllReferences RimWorld.GoodwillSituationDef
 - - - - 0.005ms (26%) (self: 0.005 ms) 39x Resolver call
 - - - 0.018ms (0%) (self: 0.013 ms) ResolveAllReferences RimWorld.BeardDef
 - - - - 0.005ms (27%) (self: 0.005 ms) 41x Resolver call
 - - - 0.017ms (0%) (self: 0.014 ms) ResolveAllReferences RimWorld.PsychicRitualDef_SkipAbductionPlayer
 - - - - 0.003ms (19%) (self: 0.003 ms) Resolver call
 - - - 0.017ms (0%) (self: 0.013 ms) ResolveAllReferences RimWorld.NeedDef
 - - - - 0.004ms (23%) (self: 0.004 ms) 24x Resolver call
 - - - 0.017ms (0%) (self: 0.014 ms) ResolveAllReferences RimWorld.PawnsArrivalModeDef
 - - - - 0.003ms (16%) (self: 0.003 ms) 13x Resolver call
 - - - 0.017ms (0%) (self: 0.012 ms) ResolveAllReferences Verse.HeadTypeDef
 - - - - 0.004ms (27%) (self: 0.004 ms) 39x Resolver call
 - - - 0.017ms (0%) (self: 0.013 ms) ResolveAllReferences RimWorld.LandmarkDef
 - - - - 0.004ms (24%) (self: 0.004 ms) 45x Resolver call
 - - - 0.016ms (0%) (self: 0.012 ms) ResolveAllReferences RimWorld.ScenPartDef
 - - - - 0.005ms (27%) (self: 0.005 ms) 41x Resolver call
 - - - 0.016ms (0%) (self: 0.012 ms) ResolveAllReferences RimWorld.StatCategoryDef
 - - - - 0.004ms (25%) (self: 0.004 ms) 40x Resolver call
 - - - 0.016ms (0%) (self: 0.012 ms) ResolveAllReferences RimWorld.MemeDef
 - - - - 0.004ms (24%) (self: 0.004 ms) 38x Resolver call
 - - - 0.016ms (0%) (self: 0.014 ms) ResolveAllReferences Verse.ToolCapacityDef
 - - - - 0.002ms (14%) (self: 0.002 ms) 13x Resolver call
 - - - 0.016ms (0%) (self: 0.012 ms) ResolveAllReferences Verse.WeatherDef
 - - - - 0.003ms (21%) (self: 0.003 ms) 24x Resolver call
 - - - 0.016ms (0%) (self: 0.012 ms) ResolveAllReferences RimWorld.InstructionDef
 - - - - 0.004ms (24%) (self: 0.004 ms) 37x Resolver call
 - - - 0.016ms (0%) (self: 0.012 ms) ResolveAllReferences RimWorld.RitualPatternDef
 - - - - 0.004ms (22%) (self: 0.004 ms) 27x Resolver call
 - - - 0.015ms (0%) (self: 0.012 ms) ResolveAllReferences Verse.BodyPartTagDef
 - - - - 0.004ms (23%) (self: 0.004 ms) 30x Resolver call
 - - - 0.015ms (0%) (self: 0.012 ms) ResolveAllReferences RimWorld.StructureLayoutDef
 - - - - 0.004ms (24%) (self: 0.004 ms) 27x Resolver call
 - - - 0.015ms (0%) (self: 0.012 ms) ResolveAllReferences RimWorld.SketchResolverDef
 - - - - 0.004ms (24%) (self: 0.004 ms) 33x Resolver call
 - - - 0.015ms (0%) (self: 0.012 ms) ResolveAllReferences RimWorld.FeatureDef
 - - - - 0.003ms (22%) (self: 0.003 ms) 25x Resolver call
 - - - 0.015ms (0%) (self: 0.012 ms) ResolveAllReferences Verse.GeneCategoryDef
 - - - - 0.003ms (21%) (self: 0.003 ms) 21x Resolver call
 - - - 0.015ms (0%) (self: 0.012 ms) ResolveAllReferences Verse.WorldGenStepDef
 - - - - 0.003ms (19%) (self: 0.003 ms) 12x Resolver call
 - - - 0.015ms (0%) (self: 0.010 ms) ResolveAllReferences Verse.GameConditionDef
 - - - - 0.004ms (29%) (self: 0.004 ms) 38x Resolver call
 - - - 0.015ms (0%) (self: 0.012 ms) ResolveAllReferences RimWorld.BodyTypeDef
 - - - - 0.003ms (21%) (self: 0.003 ms) 23x Resolver call
 - - - 0.015ms (0%) (self: 0.012 ms) ResolveAllReferences RimWorld.PawnGroupKindDef
 - - - - 0.003ms (20%) (self: 0.003 ms) 20x Resolver call
 - - - 0.015ms (0%) (self: 0.013 ms) ResolveAllReferences RimWorld.PlanetLayerDef
 - - - - 0.002ms (14%) (self: 0.002 ms) 2x Resolver call
 - - - 0.014ms (0%) (self: 0.010 ms) ResolveAllReferences RimWorld.IdeoColorDef
 - - - - 0.004ms (28%) (self: 0.004 ms) 33x Resolver call
 - - - 0.014ms (0%) (self: 0.011 ms) ResolveAllReferences RimWorld.JoyGiverDef
 - - - - 0.003ms (24%) (self: 0.003 ms) 22x Resolver call
 - - - 0.014ms (0%) (self: 0.010 ms) ResolveAllReferences RimWorld.PawnRelationDef
 - - - - 0.004ms (27%) (self: 0.004 ms) 28x Resolver call
 - - - 0.014ms (0%) (self: 0.011 ms) ResolveAllReferences RimWorld.RitualOutcomeEffectDef
 - - - - 0.004ms (25%) (self: 0.004 ms) 27x Resolver call
 - - - 0.014ms (0%) (self: 0.010 ms) ResolveAllReferences RimWorld.TattooDef
 - - - - 0.004ms (29%) (self: 0.004 ms) 31x Resolver call
 - - - 0.014ms (0%) (self: 0.011 ms) ResolveAllReferences RimWorld.RitualBehaviorDef
 - - - - 0.003ms (24%) (self: 0.003 ms) 26x Resolver call
 - - - 0.014ms (0%) (self: 0.010 ms) ResolveAllReferences RimWorld.BiomeDef
 - - - - 0.004ms (26%) (self: 0.004 ms) 25x Resolver call
 - - - 0.014ms (0%) (self: 0.011 ms) ResolveAllReferences RimWorld.IdeoPresetDef
 - - - - 0.003ms (23%) (self: 0.003 ms) 25x Resolver call
 - - - 0.014ms (0%) (self: 0.011 ms) ResolveAllReferences Verse.PawnRenderNodeTagDef
 - - - - 0.002ms (18%) (self: 0.002 ms) 5x Resolver call
 - - - 0.013ms (0%) (self: 0.011 ms) ResolveAllReferences Verse.ScatterableDef
 - - - - 0.002ms (16%) (self: 0.002 ms) 9x Resolver call
 - - - 0.013ms (0%) (self: 0.010 ms) ResolveAllReferences RimWorld.PsychicRitualDef_SummonFleshbeastsPlayer
 - - - - 0.003ms (25%) (self: 0.003 ms) Resolver call
 - - - 0.013ms (0%) (self: 0.011 ms) ResolveAllReferences RimWorld.DrugPolicyDef
 - - - - 0.002ms (16%) (self: 0.002 ms) 4x Resolver call
 - - - 0.013ms (0%) (self: 0.011 ms) ResolveAllReferences Verse.CreepJoinerBenefitDef
 - - - - 0.002ms (18%) (self: 0.002 ms) 10x Resolver call
 - - - 0.013ms (0%) (self: 0.010 ms) ResolveAllReferences Verse.MentalBreakDef
 - - - - 0.004ms (28%) (self: 0.004 ms) 33x Resolver call
 - - - 0.013ms (0%) (self: 0.010 ms) ResolveAllReferences Verse.MapGeneratorDef
 - - - - 0.003ms (22%) (self: 0.003 ms) 19x Resolver call
 - - - 0.013ms (0%) (self: 0.013 ms) ResolveAllReferences Verse.CreepJoinerBaseDef
 - - - 0.013ms (0%) (self: 0.010 ms) ResolveAllReferences Verse.DesignatorDropdownGroupDef
 - - - - 0.002ms (18%) (self: 0.002 ms) 13x Resolver call
 - - - 0.013ms (0%) (self: 0.010 ms) ResolveAllReferences RimWorld.RitualVisualEffectDef
 - - - - 0.003ms (24%) (self: 0.003 ms) 18x Resolver call
 - - - 0.013ms (0%) (self: 0.011 ms) ResolveAllReferences Verse.SubcameraDef
 - - - - 0.002ms (14%) (self: 0.002 ms) 2x Resolver call
 - - - 0.013ms (0%) (self: 0.010 ms) ResolveAllReferences RimWorld.MapMeshFlagDef
 - - - - 0.003ms (24%) (self: 0.003 ms) 15x Resolver call
 - - - 0.013ms (0%) (self: 0.010 ms) ResolveAllReferences RimWorld.StyleItemCategoryDef
 - - - - 0.003ms (20%) (self: 0.003 ms) 12x Resolver call
 - - - 0.013ms (0%) (self: 0.010 ms) ResolveAllReferences RimWorld.XenotypeIconDef
 - - - - 0.002ms (17%) (self: 0.002 ms) 11x Resolver call
 - - - 0.012ms (0%) (self: 0.010 ms) ResolveAllReferences Verse.PlaceDef
 - - - - 0.003ms (21%) (self: 0.003 ms) 20x Resolver call
 - - - 0.012ms (0%) (self: 0.010 ms) ResolveAllReferences RimWorld.NegativeFishingOutcomeDef
 - - - - 0.002ms (15%) (self: 0.002 ms) 11x Resolver call
 - - - 0.012ms (0%) (self: 0.009 ms) ResolveAllReferences RimWorld.RitualObligationTargetFilterDef
 - - - - 0.003ms (25%) (self: 0.003 ms) 21x Resolver call
 - - - 0.012ms (0%) (self: 0.012 ms) ResolveAllReferences RimWorld.PsychicRitualDef_InvocationCircle
 - - - 0.012ms (0%) (self: 0.010 ms) ResolveAllReferences WeaponClassPairDef
 - - - - 0.002ms (15%) (self: 0.002 ms) 5x Resolver call
 - - - 0.012ms (0%) (self: 0.009 ms) ResolveAllReferences RimWorld.PsychicRitualDef_Brainwipe
 - - - - 0.003ms (28%) (self: 0.003 ms) Resolver call
 - - - 0.012ms (0%) (self: 0.010 ms) ResolveAllReferences RimWorld.RoomPartDef
 - - - - 0.002ms (15%) (self: 0.002 ms) 12x Resolver call
 - - - 0.012ms (0%) (self: 0.010 ms) ResolveAllReferences RimWorld.PawnTableDef
 - - - - 0.002ms (18%) (self: 0.002 ms) 6x Resolver call
 - - - 0.012ms (0%) (self: 0.009 ms) ResolveAllReferences Verse.OptionCategoryDef
 - - - - 0.002ms (19%) (self: 0.002 ms) 8x Resolver call
 - - - 0.012ms (0%) (self: 0.009 ms) ResolveAllReferences Verse.CreepJoinerDownsideDef
 - - - - 0.002ms (19%) (self: 0.002 ms) 9x Resolver call
 - - - 0.012ms (0%) (self: 0.009 ms) ResolveAllReferences Verse.DrawStyleCategoryDef
 - - - - 0.003ms (27%) (self: 0.003 ms) 19x Resolver call
 - - - 0.012ms (0%) (self: 0.009 ms) ResolveAllReferences RimWorld.WeaponCategoryDef
 - - - - 0.002ms (21%) (self: 0.002 ms) 16x Resolver call
 - - - 0.012ms (0%) (self: 0.010 ms) ResolveAllReferences RimWorld.RitualAttachableOutcomeEffectDef
 - - - - 0.002ms (17%) (self: 0.002 ms) 7x Resolver call
 - - - 0.012ms (0%) (self: 0.010 ms) ResolveAllReferences Verse.TrainabilityDef
 - - - - 0.002ms (14%) (self: 0.002 ms) 3x Resolver call
 - - - 0.011ms (0%) (self: 0.008 ms) ResolveAllReferences Verse.RoomRoleDef
 - - - - 0.003ms (28%) (self: 0.003 ms) 23x Resolver call
 - - - 0.011ms (0%) (self: 0.009 ms) ResolveAllReferences RimWorld.PsychicRitualDef_ImbueDeathRefusal
 - - - - 0.003ms (24%) (self: 0.003 ms) Resolver call
 - - - 0.011ms (0%) (self: 0.009 ms) ResolveAllReferences RimWorld.TimeAssignmentDef
 - - - - 0.002ms (18%) (self: 0.002 ms) 5x Resolver call
 - - - 0.011ms (0%) (self: 0.009 ms) ResolveAllReferences RimWorld.PsychicRitualDef_PleasurePulse
 - - - - 0.003ms (23%) (self: 0.003 ms) Resolver call
 - - - 0.011ms (0%) (self: 0.010 ms) ResolveAllReferences RimWorld.HibernatableStateDef
 - - - - 0.002ms (14%) (self: 0.002 ms) 3x Resolver call
 - - - 0.011ms (0%) (self: 0.009 ms) ResolveAllReferences Verse.ManeuverDef
 - - - - 0.002ms (21%) (self: 0.002 ms) 12x Resolver call
 - - - 0.011ms (0%) (self: 0.009 ms) ResolveAllReferences Verse.Sound.ImpactSoundTypeDef
 - - - - 0.002ms (16%) (self: 0.002 ms) 7x Resolver call
 - - - 0.011ms (0%) (self: 0.009 ms) ResolveAllReferences RimWorld.ChemicalDef
 - - - - 0.003ms (22%) (self: 0.003 ms) 8x Resolver call
 - - - 0.011ms (0%) (self: 0.009 ms) ResolveAllReferences RimWorld.IncidentCategoryDef
 - - - - 0.002ms (21%) (self: 0.002 ms) 13x Resolver call
 - - - 0.011ms (0%) (self: 0.008 ms) ResolveAllReferences RimWorld.RoyalTitlePermitDef
 - - - - 0.003ms (28%) (self: 0.003 ms) 15x Resolver call
 - - - 0.011ms (0%) (self: 0.009 ms) ResolveAllReferences RimWorld.MeditationFocusDef
 - - - - 0.002ms (20%) (self: 0.002 ms) 7x Resolver call
 - - - 0.011ms (0%) (self: 0.009 ms) ResolveAllReferences RimWorld.PlanetLayerSettingsDef
 - - - - 0.002ms (15%) (self: 0.002 ms) 2x Resolver call
 - - - 0.011ms (0%) (self: 0.009 ms) ResolveAllReferences RimWorld.GatheringDef
 - - - - 0.002ms (18%) (self: 0.002 ms) 3x Resolver call
 - - - 0.011ms (0%) (self: 0.009 ms) ResolveAllReferences Verse.TerrainAffordanceDef
 - - - - 0.002ms (20%) (self: 0.002 ms) 12x Resolver call
 - - - 0.011ms (0%) (self: 0.009 ms) ResolveAllReferences RimWorld.ExpansionDef
 - - - - 0.002ms (17%) (self: 0.002 ms) 6x Resolver call
 - - - 0.011ms (0%) (self: 0.009 ms) ResolveAllReferences RimWorld.HistoryAutoRecorderDef
 - - - - 0.002ms (19%) (self: 0.002 ms) 11x Resolver call
 - - - 0.011ms (0%) (self: 0.009 ms) ResolveAllReferences RimWorld.KnowledgeCategoryDef
 - - - - 0.002ms (14%) (self: 0.002 ms) 2x Resolver call
 - - - 0.011ms (0%) (self: 0.009 ms) ResolveAllReferences Verse.CreepJoinerAggressiveDef
 - - - - 0.002ms (15%) (self: 0.002 ms) 3x Resolver call
 - - - 0.011ms (0%) (self: 0.008 ms) ResolveAllReferences RimWorld.MainButtonDef
 - - - - 0.003ms (23%) (self: 0.003 ms) 15x Resolver call
 - - - 0.011ms (0%) (self: 0.009 ms) ResolveAllReferences RimWorld.DifficultyDef
 - - - - 0.002ms (18%) (self: 0.002 ms) 7x Resolver call
 - - - 0.011ms (0%) (self: 0.009 ms) ResolveAllReferences RimWorld.IncidentTargetTagDef
 - - - - 0.002ms (17%) (self: 0.002 ms) 7x Resolver call
 - - - 0.011ms (0%) (self: 0.009 ms) ResolveAllReferences Verse.MessageTypeDef
 - - - - 0.002ms (19%) (self: 0.002 ms) 12x Resolver call
 - - - 0.011ms (0%) (self: 0.008 ms) ResolveAllReferences RimWorld.PrisonerInteractionModeDef
 - - - - 0.002ms (23%) (self: 0.002 ms) 12x Resolver call
 - - - 0.011ms (0%) (self: 0.008 ms) ResolveAllReferences RimWorld.RoyalTitleDef
 - - - - 0.002ms (20%) (self: 0.002 ms) 11x Resolver call
 - - - 0.010ms (0%) (self: 0.008 ms) ResolveAllReferences RimWorld.HediffGiverSetDef
 - - - - 0.002ms (22%) (self: 0.002 ms) 5x Resolver call
 - - - 0.010ms (0%) (self: 0.008 ms) ResolveAllReferences RimWorld.PsychicRitualDef_Psychophagy
 - - - - 0.003ms (25%) (self: 0.003 ms) Resolver call
 - - - 0.010ms (0%) (self: 0.009 ms) ResolveAllReferences RimWorld.BossgroupDef
 - - - - 0.002ms (17%) (self: 0.002 ms) 3x Resolver call
 - - - 0.010ms (0%) (self: 0.009 ms) ResolveAllReferences RimWorld.EntityCategoryDef
 - - - - 0.001ms (14%) (self: 0.001 ms) 3x Resolver call
 - - - 0.010ms (0%) (self: 0.008 ms) ResolveAllReferences RimWorld.RaidStrategyDef
 - - - - 0.002ms (20%) (self: 0.002 ms) 11x Resolver call
 - - - 0.010ms (0%) (self: 0.008 ms) ResolveAllReferences Verse.ApparelLayerDef
 - - - - 0.002ms (19%) (self: 0.002 ms) 6x Resolver call
 - - - 0.010ms (0%) (self: 0.008 ms) ResolveAllReferences Verse.MechWeightClassDef
 - - - - 0.002ms (19%) (self: 0.002 ms) 4x Resolver call
 - - - 0.010ms (0%) (self: 0.008 ms) ResolveAllReferences RimWorld.TrainableDef
 - - - - 0.003ms (26%) (self: 0.003 ms) 14x Resolver call
 - - - 0.010ms (0%) (self: 0.008 ms) ResolveAllReferences Verse.IdeoStoryPatternDef
 - - - - 0.002ms (17%) (self: 0.002 ms) 6x Resolver call
 - - - 0.010ms (0%) (self: 0.009 ms) ResolveAllReferences RimWorld.BabyPlayDef
 - - - - 0.001ms (14%) (self: 0.001 ms) 3x Resolver call
 - - - 0.010ms (0%) (self: 0.008 ms) ResolveAllReferences RimWorld.StuffCategoryDef
 - - - - 0.002ms (18%) (self: 0.002 ms) 6x Resolver call
 - - - 0.010ms (0%) (self: 0.008 ms) ResolveAllReferences Verse.RoomStatDef
 - - - - 0.002ms (23%) (self: 0.002 ms) 13x Resolver call
 - - - 0.010ms (0%) (self: 0.008 ms) ResolveAllReferences RimWorld.PsychicRitualDef_Philophagy
 - - - - 0.002ms (24%) (self: 0.002 ms) Resolver call
 - - - 0.010ms (0%) (self: 0.008 ms) ResolveAllReferences RimWorld.PsychicRitualRoleDef
 - - - - 0.002ms (16%) (self: 0.002 ms) 8x Resolver call
 - - - 0.010ms (0%) (self: 0.008 ms) ResolveAllReferences RimWorld.AbilityCategoryDef
 - - - - 0.002ms (18%) (self: 0.002 ms) 4x Resolver call
 - - - 0.010ms (0%) (self: 0.009 ms) ResolveAllReferences RimWorld.LandingOutcomeDef
 - - - - 0.002ms (15%) (self: 0.002 ms) 4x Resolver call
 - - - 0.010ms (0%) (self: 0.008 ms) ResolveAllReferences RimWorld.ComplexThreatDef
 - - - - 0.002ms (24%) (self: 0.002 ms) 9x Resolver call
 - - - 0.010ms (0%) (self: 0.007 ms) ResolveAllReferences RimWorld.PsychicRitualDef_Chronophagy
 - - - - 0.003ms (25%) (self: 0.003 ms) Resolver call
 - - - 0.010ms (0%) (self: 0.008 ms) ResolveAllReferences RimWorld.ScenarioDef
 - - - - 0.002ms (24%) (self: 0.002 ms) 12x Resolver call
 - - - 0.010ms (0%) (self: 0.008 ms) ResolveAllReferences RimWorld.TransferableSorterDef
 - - - - 0.002ms (21%) (self: 0.002 ms) 7x Resolver call
 - - - 0.010ms (0%) (self: 0.008 ms) ResolveAllReferences Verse.DrawStyleDef
 - - - - 0.002ms (23%) (self: 0.002 ms) 6x Resolver call
 - - - 0.010ms (0%) (self: 0.008 ms) ResolveAllReferences Verse.ImplementOwnerTypeDef
 - - - - 0.002ms (17%) (self: 0.002 ms) 5x Resolver call
 - - - 0.010ms (0%) (self: 0.008 ms) ResolveAllReferences Verse.KeyBindingCategoryDef
 - - - - 0.002ms (20%) (self: 0.002 ms) 9x Resolver call
 - - - 0.010ms (0%) (self: 0.007 ms) ResolveAllReferences RimWorld.PsychicRitualDef_SummonShamblers
 - - - - 0.003ms (28%) (self: 0.003 ms) Resolver call
 - - - 0.010ms (0%) (self: 0.008 ms) ResolveAllReferences RimWorld.MusicSequenceDef
 - - - - 0.002ms (19%) (self: 0.002 ms) 8x Resolver call
 - - - 0.010ms (0%) (self: 0.008 ms) ResolveAllReferences RimWorld.RoadWorldLayerDef
 - - - - 0.002ms (18%) (self: 0.002 ms) 5x Resolver call
 - - - 0.010ms (0%) (self: 0.008 ms) ResolveAllReferences AlienRace.RaceSettings
 - - - - 0.002ms (15%) (self: 0.002 ms) 2x Resolver call
 - - - 0.010ms (0%) (self: 0.007 ms) ResolveAllReferences Verse.PawnCapacityDef
 - - - - 0.002ms (25%) (self: 0.002 ms) 11x Resolver call
 - - - 0.010ms (0%) (self: 0.007 ms) ResolveAllReferences RimWorld.PsychicRitualDef_NeurosisPulse
 - - - - 0.003ms (31%) (self: 0.003 ms) Resolver call
 - - - 0.010ms (0%) (self: 0.007 ms) ResolveAllReferences RimWorld.PsychicRitualDef_SummonAnimals
 - - - - 0.003ms (26%) (self: 0.003 ms) Resolver call
 - - - 0.010ms (0%) (self: 0.008 ms) ResolveAllReferences RimWorld.FleshTypeDef
 - - - - 0.002ms (22%) (self: 0.002 ms) 8x Resolver call
 - - - 0.010ms (0%) (self: 0.008 ms) ResolveAllReferences RimWorld.GauranlenTreeModeDef
 - - - - 0.002ms (19%) (self: 0.002 ms) 7x Resolver call
 - - - 0.010ms (0%) (self: 0.008 ms) ResolveAllReferences RimWorld.JoyKindDef
 - - - - 0.002ms (23%) (self: 0.002 ms) 10x Resolver call
 - - - 0.010ms (0%) (self: 0.008 ms) ResolveAllReferences RimWorld.ShipJobDef
 - - - - 0.002ms (20%) (self: 0.002 ms) 7x Resolver call
 - - - 0.010ms (0%) (self: 0.008 ms) ResolveAllReferences RimWorld.DebugTabMenuDef
 - - - - 0.002ms (20%) (self: 0.002 ms) 3x Resolver call
 - - - 0.010ms (0%) (self: 0.008 ms) ResolveAllReferences RimWorld.InfectionPathwayDef
 - - - - 0.002ms (20%) (self: 0.002 ms) 3x Resolver call
 - - - 0.010ms (0%) (self: 0.008 ms) ResolveAllReferences RimWorld.AbilityGroupDef
 - - - - 0.002ms (17%) (self: 0.002 ms) 3x Resolver call
 - - - 0.010ms (0%) (self: 0.008 ms) ResolveAllReferences RimWorld.LearningDesireDef
 - - - - 0.002ms (18%) (self: 0.002 ms) 7x Resolver call
 - - - 0.009ms (0%) (self: 0.008 ms) ResolveAllReferences RimWorld.BillRepeatModeDef
 - - - - 0.002ms (17%) (self: 0.002 ms) 3x Resolver call
 - - - 0.009ms (0%) (self: 0.007 ms) ResolveAllReferences RimWorld.InspirationDef
 - - - - 0.002ms (22%) (self: 0.002 ms) 8x Resolver call
 - - - 0.009ms (0%) (self: 0.008 ms) ResolveAllReferences RimWorld.RiverDef
 - - - - 0.002ms (20%) (self: 0.002 ms) 4x Resolver call
 - - - 0.009ms (0%) (self: 0.008 ms) ResolveAllReferences RimWorld.RitualTargetFilterDef
 - - - - 0.002ms (19%) (self: 0.002 ms) 7x Resolver call
 - - - 0.009ms (0%) (self: 0.008 ms) ResolveAllReferences Verse.DamageArmorCategoryDef
 - - - - 0.002ms (18%) (self: 0.002 ms) 3x Resolver call
 - - - 0.009ms (0%) (self: 0.008 ms) ResolveAllReferences RimWorld.PsychicRitualDef_VoidProvocation
 - - - - 0.002ms (16%) (self: 0.002 ms) Resolver call
 - - - 0.009ms (0%) (self: 0.008 ms) ResolveAllReferences RimWorld.GeneTemplateDef
 - - - - 0.002ms (17%) (self: 0.002 ms) 7x Resolver call
 - - - 0.009ms (0%) (self: 0.008 ms) ResolveAllReferences RimWorld.AnomalyPlaystyleDef
 - - - - 0.001ms (15%) (self: 0.001 ms) 3x Resolver call
 - - - 0.009ms (0%) (self: 0.007 ms) ResolveAllReferences RimWorld.RenderSkipFlagDef
 - - - - 0.002ms (24%) (self: 0.002 ms) 7x Resolver call
 - - - 0.009ms (0%) (self: 0.007 ms) ResolveAllReferences RimWorld.RoadDef
 - - - - 0.002ms (22%) (self: 0.002 ms) 5x Resolver call
 - - - 0.009ms (0%) (self: 0.008 ms) ResolveAllReferences RimWorld.GeneratedLocationDef
 - - - - 0.001ms (14%) (self: 0.001 ms) Resolver call
 - - - 0.009ms (0%) (self: 0.008 ms) ResolveAllReferences Verse.StuffAppearanceDef
 - - - - 0.002ms (17%) (self: 0.002 ms) 4x Resolver call
 - - - 0.009ms (0%) (self: 0.007 ms) ResolveAllReferences RimWorld.PsychicRitualDef_SummonPitGate
 - - - - 0.003ms (27%) (self: 0.003 ms) Resolver call
 - - - 0.009ms (0%) (self: 0.007 ms) ResolveAllReferences RimWorld.MemeGroupDef
 - - - - 0.002ms (20%) (self: 0.002 ms) 8x Resolver call
 - - - 0.009ms (0%) (self: 0.007 ms) ResolveAllReferences RimWorld.MusicTransitionDef
 - - - - 0.002ms (20%) (self: 0.002 ms) 9x Resolver call
 - - - 0.009ms (0%) (self: 0.008 ms) ResolveAllReferences RimWorld.ResearchTabDef
 - - - - 0.002ms (18%) (self: 0.002 ms) 3x Resolver call
 - - - 0.009ms (0%) (self: 0.008 ms) ResolveAllReferences RimWorld.SlaveInteractionModeDef
 - - - - 0.002ms (18%) (self: 0.002 ms) 5x Resolver call
 - - - 0.009ms (0%) (self: 0.008 ms) ResolveAllReferences RimWorld.BossDef
 - - - - 0.002ms (18%) (self: 0.002 ms) 3x Resolver call
 - - - 0.009ms (0%) (self: 0.007 ms) ResolveAllReferences RimWorld.IdeoPresetCategoryDef
 - - - - 0.002ms (20%) (self: 0.002 ms) 6x Resolver call
 - - - 0.009ms (0%) (self: 0.007 ms) ResolveAllReferences RimWorld.GravshipComponentTypeDef
 - - - - 0.002ms (19%) (self: 0.002 ms) 5x Resolver call
 - - - 0.009ms (0%) (self: 0.007 ms) ResolveAllReferences Verse.CreepJoinerRejectionDef
 - - - - 0.002ms (18%) (self: 0.002 ms) 2x Resolver call
 - - - 0.009ms (0%) (self: 0.007 ms) ResolveAllReferences Verse.InventoryStockGroupDef
 - - - - 0.002ms (17%) (self: 0.002 ms) Resolver call
 - - - 0.009ms (0%) (self: 0.007 ms) ResolveAllReferences RimWorld.FurDef
 - - - - 0.002ms (17%) (self: 0.002 ms) Resolver call
 - - - 0.009ms (0%) (self: 0.007 ms) ResolveAllReferences RimWorld.SurgeryOutcomeEffectDef
 - - - - 0.002ms (21%) (self: 0.002 ms) 3x Resolver call
 - - - 0.009ms (0%) (self: 0.007 ms) ResolveAllReferences Verse.LogEntryDef
 - - - - 0.002ms (17%) (self: 0.002 ms) 2x Resolver call
 - - - 0.009ms (0%) (self: 0.007 ms) ResolveAllReferences Verse.PathGridDef
 - - - - 0.002ms (19%) (self: 0.002 ms) 3x Resolver call
 - - - 0.009ms (0%) (self: 0.007 ms) ResolveAllReferences RimWorld.GlobalWorldDrawLayerDef
 - - - - 0.002ms (20%) (self: 0.002 ms) 2x Resolver call
 - - - 0.009ms (0%) (self: 0.007 ms) ResolveAllReferences Verse.MechWorkModeDef
 - - - - 0.002ms (17%) (self: 0.002 ms) 4x Resolver call
 - - - 0.009ms (0%) (self: 0.007 ms) ResolveAllReferences Verse.ResearchProjectTagDef
 - - - - 0.002ms (21%) (self: 0.002 ms) 5x Resolver call
 - - - 0.009ms (0%) (self: 0.007 ms) ResolveAllReferences Verse.RoofDef
 - - - - 0.002ms (18%) (self: 0.002 ms) 4x Resolver call
 - - - 0.009ms (0%) (self: 0.007 ms) ResolveAllReferences RimWorld.PsychicRitualDef_SkipAbduction
 - - - - 0.001ms (16%) (self: 0.001 ms) Resolver call
 - - - 0.009ms (0%) (self: 0.007 ms) ResolveAllReferences RimWorld.ComplexLayoutDef
 - - - - 0.002ms (17%) (self: 0.002 ms) 3x Resolver call
 - - - 0.009ms (0%) (self: 0.007 ms) ResolveAllReferences RimWorld.HistoryAutoRecorderGroupDef
 - - - - 0.002ms (19%) (self: 0.002 ms) 4x Resolver call
 - - - 0.009ms (0%) (self: 0.007 ms) ResolveAllReferences RimWorld.MonolithLevelDef
 - - - - 0.002ms (20%) (self: 0.002 ms) 7x Resolver call
 - - - 0.009ms (0%) (self: 0.007 ms) ResolveAllReferences RimWorld.RaidAgeRestrictionDef
 - - - - 0.001ms (15%) (self: 0.001 ms) Resolver call
 - - - 0.009ms (0%) (self: 0.007 ms) ResolveAllReferences RimWorld.TransportShipDef
 - - - - 0.002ms (20%) (self: 0.002 ms) 4x Resolver call
 - - - 0.009ms (0%) (self: 0.007 ms) ResolveAllReferences RimWorld.WorkGiverEquivalenceGroupDef
 - - - - 0.002ms (17%) (self: 0.002 ms) 3x Resolver call
 - - - 0.009ms (0%) (self: 0.007 ms) ResolveAllReferences RimWorld.IdeoFoundationDef
 - - - - 0.001ms (16%) (self: 0.001 ms) Resolver call
 - - - 0.009ms (0%) (self: 0.007 ms) ResolveAllReferences RimWorld.RoomPart_CrateDef
 - - - - 0.001ms (16%) (self: 0.001 ms) 2x Resolver call
 - - - 0.009ms (0%) (self: 0.007 ms) ResolveAllReferences RimWorld.RoadPathingDef
 - - - - 0.002ms (20%) (self: 0.002 ms) 2x Resolver call
 - - - 0.008ms (0%) (self: 0.007 ms) ResolveAllReferences Verse.MentalFitDef
 - - - - 0.001ms (17%) (self: 0.001 ms) 2x Resolver call
 - - - 0.008ms (0%) (self: 0.007 ms) ResolveAllReferences Verse.OrbitalDebrisDef
 - - - - 0.001ms (15%) (self: 0.001 ms) 3x Resolver call
 - - - 0.008ms (0%) (self: 0.007 ms) ResolveAllReferences RimWorld.PsychicRitualRoleDef_DeathRefusalTarget
 - - - - 0.001ms (17%) (self: 0.001 ms) Resolver call
 - - - 0.008ms (0%) (self: 0.006 ms) ResolveAllReferences RimWorld.TerrainTemplateDef
 - - - - 0.002ms (24%) (self: 0.002 ms) 4x Resolver call
 - - - 0.008ms (0%) (self: 0.007 ms) ResolveAllReferences RimWorld.RoomPart_GestationTankDef
 - - - - 0.001ms (15%) (self: 0.001 ms) Resolver call
 - - - 0.008ms (0%) (self: 0.007 ms) ResolveAllReferences RimWorld.RoomPart_ThingDef
 - - - - 0.002ms (21%) (self: 0.002 ms) 6x Resolver call
 - - - 0.008ms (0%) (self: 0.007 ms) ResolveAllReferences Verse.GameSetupStepDef
 - - - - 0.002ms (21%) (self: 0.002 ms) 4x Resolver call
 - - - 0.008ms (0%) (self: 0.007 ms) ResolveAllReferences RimWorld.BillStoreModeDef
 - - - - 0.002ms (20%) (self: 0.002 ms) 3x Resolver call
 - - - 0.008ms (0%) (self: 0.007 ms) ResolveAllReferences Verse.ReservationLayerDef
 - - - - 0.002ms (20%) (self: 0.002 ms) 3x Resolver call
 - - - 0.008ms (0%) (self: 0.007 ms) ResolveAllReferences RimWorld.PsychicRitualDef_SummonFleshbeasts
 - - - - 0.001ms (16%) (self: 0.001 ms) Resolver call
 - - - 0.008ms (0%) (self: 0.007 ms) ResolveAllReferences RimWorld.LayoutDef
 - - - - 0.001ms (16%) (self: 0.001 ms) Resolver call
 - - - 0.008ms (0%) (self: 0.008 ms) ResolveAllReferences RimWorld.PsychicRitualDef
 - - - 0.008ms (0%) (self: 0.007 ms) ResolveAllReferences RimWorld.RoomPart_BarricadeDef
 - - - - 0.001ms (16%) (self: 0.001 ms) Resolver call
 - - - 0.008ms (0%) (self: 0.008 ms) ResolveAllReferences RimWorld.StyleItemDef
 - - - 0.008ms (0%) (self: 0.006 ms) ResolveAllReferences Verse.OrderedTakeGroupDef
 - - - - 0.001ms (18%) (self: 0.001 ms) 2x Resolver call
 - - - 0.007ms (0%) (self: 0.007 ms) ResolveAllReferences AlienRace.AlienBackstoryDef
 - - - 0.007ms (0%) (self: 0.006 ms) ResolveAllReferences RimWorld.PitGateIncidentDef
 - - - - 0.001ms (19%) (self: 0.001 ms) Resolver call
 - - - 0.007ms (0%) (self: 0.007 ms) ResolveAllReferences RimWorld.IdeoSymbolPartDef
 - - 40.906ms (8.6%) (self: 40.906 ms) RecipeDef resolver
 - - 26.902ms (5.6%) (self: 0.018 ms) ThingDef resolver
 - - - 26.594ms (99%) (self: 0.497 ms) ResolveAllReferences Verse.ThingDef
 - - - - 26.097ms (98%) (self: 26.097 ms) 3641x Resolver call
 - - - 0.290ms (1.1%) (self: 0.290 ms) 2x SetIndices
 - - 2.153ms (0.45%) (self: 2.153 ms) ThingCategoryDef resolver
 - 427.687ms (8.2%) (self: 427.687 ms) Loading language data: PortugueseBrazilian (Português Brasileiro)
 - 107.140ms (2%) (self: 107.140 ms) Copy all Defs from mods to global databases.
 - 92.447ms (1.8%) (self: 92.447 ms) Error check all defs.
 - 79.603ms (1.5%) (self: 0.006 ms) Resolve cross-references between non-implied Defs.
 - - 79.597ms (100%) (self: 79.597 ms) ResolveAllWantedCrossReferences
 - 49.831ms (0.95%) (self: 49.831 ms) Short hash giving.
 - 43.929ms (0.84%) (self: 42.919 ms) Generate implied Defs (pre-resolve).
 - - 0.686ms (1.6%) (self: 0.686 ms) ResolveAllWantedCrossReferences
 - - 0.213ms (0.49%) (self: 0.213 ms) 280x RegisterObjectWantsCrossRef (object,string,string)
 - - 0.110ms (0.25%) (self: 0.110 ms) 253x RegisterListWantsCrossRef
 - 32.265ms (0.62%) (self: 32.252 ms) Other def binding, resetting and global operations (pre-resolve).
 - - 0.012ms (0.04%) (self: 0.012 ms) 2x ResolveAllWantedCrossReferences
 - - 0.000ms (0%) (self: 0.000 ms) 2x Clear
 - 30.451ms (0.58%) (self: 30.451 ms) Rebind DefOfs (early).
 - 19.428ms (0.37%) (self: 19.425 ms) Load language metadata.
 - - 0.003ms (0.02%) (self: 0.003 ms) 21x TryDoPostLoad
 - 8.443ms (0.16%) (self: 8.443 ms) Other def binding, resetting and global operations (post-resolve).
 - 6.992ms (0.13%) (self: 6.992 ms) TKeySystem.BuildMappings()
 - 6.915ms (0.13%) (self: 6.915 ms) Rebind DefOfs (final).
 - 3.807ms (0.07%) (self: 3.788 ms) Load keyboard preferences.
 - - 0.010ms (0.26%) (self: 0.010 ms) ResolveAllWantedCrossReferences
 - - 0.009ms (0.24%) (self: 0.009 ms) 69x TryDoPostLoad
 - - 0.000ms (0.01%) (self: 0.000 ms) Clear
 - 1.649ms (0.03%) (self: 1.649 ms) Legacy backstory translations.
 - 1.270ms (0.02%) (self: 1.270 ms) Generate implied Defs (post-resolve).
 - 0.678ms (0.01%) (self: 0.678 ms) Global operations (early pass).
 - 0.107ms (0%) (self: 0.006 ms) Resolve cross-references between Defs made by the implied defs.
 - - 0.090ms (84%) (self: 0.090 ms) ResolveAllWantedCrossReferences
 - - 0.012ms (11%) (self: 0.012 ms) Clear
 - 0.033ms (0%) (self: 0.033 ms) GraphicDatabase.Clear()


Hotspot analysis
----------------------------------------
1x Inject selected language data into game data (early pass). -> 1835.127 ms (total (w/children): 1835.127 ms)
1x Loading language data: PortugueseBrazilian (Português Brasileiro) -> 427.687 ms (total (w/children): 427.687 ms)
16240x Resolver call -> 423.462 ms (total (w/children): 423.462 ms)
10x Load defs via DirectXmlLoader -> 422.807 ms (total (w/children): 422.807 ms)
1x Loading HarmonyMod.Main mod class -> 205.035 ms (total (w/children): 205.035 ms)
1962x ParseValueAndReturnDef (for Verse.ThingDef) -> 200.510 ms (total (w/children): 234.048 ms)
1x CombineIntoUnifiedXML() -> 190.174 ms (total (w/children): 190.174 ms)
1x Copy all Defs from mods to global databases. -> 107.140 ms (total (w/children): 107.140 ms)
563x CreateFieldSetterForType -> 97.475 ms (total (w/children): 97.475 ms)
1x Error check all defs. -> 92.447 ms (total (w/children): 92.447 ms)
8x ResolveAllWantedCrossReferences -> 80.412 ms (total (w/children): 80.412 ms)
1x XmlInheritance.Resolve() -> 67.097 ms (total (w/children): 120.191 ms)
17295x RecursiveNodeCopyOverwriteElements -> 51.646 ms (total (w/children): 79.193 ms)
1x Short hash giving. -> 49.831 ms (total (w/children): 49.831 ms)
1x Loading defs for 14809 nodes -> 49.331 ms (total (w/children): 849.671 ms)
1x Generate implied Defs (pre-resolve). -> 42.919 ms (total (w/children): 43.929 ms)
1x RecipeDef resolver -> 40.906 ms (total (w/children): 40.906 ms)
313x ParseValueAndReturnDef (for Verse.PawnKindDef) -> 36.354 ms (total (w/children): 43.849 ms)
1x Loading AlienRace.AlienRaceMod mod class -> 33.358 ms (total (w/children): 33.363 ms)
1x Other def binding, resetting and global operations (pre-resolve). -> 32.252 ms (total (w/children): 32.265 ms)
964x ParseValueAndReturnDef (for RimWorld.BackstoryDef) -> 32.206 ms (total (w/children): 40.082 ms)
1x Rebind DefOfs (early). -> 30.451 ms (total (w/children): 30.451 ms)
151x ParseValueAndReturnDef (for RimWorld.QuestScriptDef) -> 30.169 ms (total (w/children): 36.379 ms)
24x Verse.PatchOperationReplace Worker -> 28.066 ms (total (w/children): 28.066 ms)
11x Verse.PatchOperationAdd Worker -> 27.387 ms (total (w/children): 27.387 ms)
1x InitializeMods() -> 26.311 ms (total (w/children): 29.602 ms)
1x CreateModClasses() -> 24.364 ms (total (w/children): 273.295 ms)
1282x ParseValueAndReturnDef (for Verse.SoundDef) -> 19.780 ms (total (w/children): 22.169 ms)
66x ParseValueAndReturnDef (for Verse.ThinkTreeDef) -> 19.775 ms (total (w/children): 20.645 ms)
4x Verse.PatchOperationAttributeSet Worker -> 19.615 ms (total (w/children): 19.615 ms)
1x Load language metadata. -> 19.425 ms (total (w/children): 19.428 ms)
153x CreateListItemAdderForType -> 19.162 ms (total (w/children): 19.162 ms)
22156x RegisterObjectWantsCrossRef (object,string,string) -> 19.101 ms (total (w/children): 19.101 ms)
427x ParseValueAndReturnDef (for Verse.HediffDef) -> 18.227 ms (total (w/children): 32.127 ms)
990x ParseValueAndReturnDef (for RimWorld.ThoughtDef) -> 17.569 ms (total (w/children): 19.128 ms)
10x Loading all patches -> 16.863 ms (total (w/children): 16.867 ms)
9x ParseValueAndReturnDef (for AlienRace.ThingDef_AlienRace) -> 16.012 ms (total (w/children): 19.246 ms)
108x ParseValueAndReturnDef (for Verse.AI.DutyDef) -> 14.869 ms (total (w/children): 15.883 ms)
390x ParseValueAndReturnDef (for Verse.RecipeDef) -> 13.283 ms (total (w/children): 15.876 ms)
16569x RegisterListWantsCrossRef -> 11.501 ms (total (w/children): 11.501 ms)
1x Loading MOARANDROIDS.AndroidTiersPP mod class -> 10.180 ms (total (w/children): 10.180 ms)
28849x RegisterObjectWantsCrossRef (object, FieldInfo, string) -> 10.138 ms (total (w/children): 10.138 ms)
170x ParseValueAndReturnDef (for Verse.GenStepDef) -> 9.196 ms (total (w/children): 11.615 ms)
348x ParseValueAndReturnDef (for Verse.RulePackDef) -> 8.872 ms (total (w/children): 9.123 ms)
1x Other def binding, resetting and global operations (post-resolve). -> 8.443 ms (total (w/children): 8.443 ms)
1x Loading brrainz.harmony content -> 8.187 ms (total (w/children): 8.187 ms)
26x ParseValueAndReturnDef (for RimWorld.TraderKindDef) -> 8.152 ms (total (w/children): 12.451 ms)
51x ParseValueAndReturnDef (for RimWorld.ThingSetMakerDef) -> 8.132 ms (total (w/children): 11.962 ms)
283x ParseValueAndReturnDef (for Verse.EffecterDef) -> 7.436 ms (total (w/children): 7.930 ms)
250x ParseValueAndReturnDef (for RimWorld.StatDef) -> 7.183 ms (total (w/children): 9.134 ms)
235x ParseValueAndReturnDef (for RimWorld.PreceptDef) -> 7.076 ms (total (w/children): 8.911 ms)
316x ParseValueAndReturnDef (for Verse.FleckDef) -> 7.025 ms (total (w/children): 7.615 ms)
1x TKeySystem.BuildMappings() -> 6.992 ms (total (w/children): 6.992 ms)
1x Rebind DefOfs (final). -> 6.915 ms (total (w/children): 6.915 ms)
54x ParseValueAndReturnDef (for Verse.BodyDef) -> 6.500 ms (total (w/children): 8.120 ms)
37x ParseValueAndReturnDef (for RimWorld.FactionDef) -> 6.106 ms (total (w/children): 9.905 ms)
99x ParseValueAndReturnDef (for RimWorld.AbilityDef) -> 5.674 ms (total (w/children): 7.059 ms)
56x ParseValueAndReturnDef (for RimWorld.TraitDef) -> 5.391 ms (total (w/children): 10.487 ms)
1x ParseAndProcessXML() -> 5.265 ms (total (w/children): 984.390 ms)
33x ParseValueAndReturnDef (for RimWorld.WorldObjectDef) -> 5.023 ms (total (w/children): 5.571 ms)
155x ParseValueAndReturnDef (for RimWorld.WorkGiverDef) -> 5.018 ms (total (w/children): 5.442 ms)
169x ParseValueAndReturnDef (for Verse.GeneDef) -> 4.948 ms (total (w/children): 6.439 ms)
112x ParseValueAndReturnDef (for Verse.TerrainDef) -> 4.844 ms (total (w/children): 5.807 ms)
25x ParseValueAndReturnDef (for RimWorld.BiomeDef) -> 4.786 ms (total (w/children): 8.512 ms)
26x ParseValueAndReturnDef (for RimWorld.RitualBehaviorDef) -> 4.632 ms (total (w/children): 6.214 ms)
176x ParseValueAndReturnDef (for RimWorld.PrefabDef) -> 4.425 ms (total (w/children): 5.436 ms)
14809x XmlInheritance.TryRegister -> 4.393 ms (total (w/children): 4.393 ms)
24x ParseValueAndReturnDef (for Verse.WeatherDef) -> 4.354 ms (total (w/children): 5.487 ms)
112x ParseValueAndReturnDef (for RimWorld.RuleDef) -> 4.033 ms (total (w/children): 4.177 ms)
38x ParseValueAndReturnDef (for RimWorld.MemeDef) -> 4.010 ms (total (w/children): 6.493 ms)
202x ParseValueAndReturnDef (for Verse.ResearchProjectDef) -> 3.899 ms (total (w/children): 4.237 ms)
12x ParseValueAndReturnDef (for RimWorld.ScenarioDef) -> 3.835 ms (total (w/children): 5.203 ms)
1x Load keyboard preferences. -> 3.788 ms (total (w/children): 3.807 ms)
1x Static resolver calls -> 3.690 ms (total (w/children): 406.275 ms)
145x ParseValueAndReturnDef (for RimWorld.LayoutRoomDef) -> 3.611 ms (total (w/children): 5.165 ms)
1x Loading erdelf.HumanoidAlienRaces content -> 3.401 ms (total (w/children): 3.401 ms)
27x ParseValueAndReturnDef (for RimWorld.RitualOutcomeEffectDef) -> 3.185 ms (total (w/children): 4.442 ms)
1x Loading asset nodes 14809 -> 3.117 ms (total (w/children): 9.264 ms)
103x ParseValueAndReturnDef (for RimWorld.TaleDef) -> 2.781 ms (total (w/children): 2.885 ms)
196x ParseValueAndReturnDef (for Verse.BodyPartDef) -> 2.299 ms (total (w/children): 3.471 ms)
1x Initializing [brrainz.harmony|Harmony] -> 2.293 ms (total (w/children): 2.293 ms)
1x ThingCategoryDef resolver -> 2.153 ms (total (w/children): 2.153 ms)
1x Loading Atlas.AndroidTiers content -> 2.140 ms (total (w/children): 2.140 ms)
135x ParseValueAndReturnDef (for RimWorld.IncidentDef) -> 2.112 ms (total (w/children): 2.955 ms)
4x ParseValueAndReturnDef (for RimWorld.StorytellerDef) -> 2.040 ms (total (w/children): 2.787 ms)
87x ParseValueAndReturnDef (for RimWorld.TileMutatorDef) -> 2.037 ms (total (w/children): 2.686 ms)
327x ParseValueAndReturnDef (for Verse.JobDef) -> 1.966 ms (total (w/children): 2.053 ms)
11x ParseValueAndReturnDef (for Verse.PawnRenderTreeDef) -> 1.953 ms (total (w/children): 2.253 ms)
45x ParseValueAndReturnDef (for RimWorld.LandmarkDef) -> 1.949 ms (total (w/children): 3.376 ms)
11x ParseValueAndReturnDef (for RimWorld.RoyalTitleDef) -> 1.937 ms (total (w/children): 2.905 ms)
71x ParseValueAndReturnDef (for RimWorld.InteractionDef) -> 1.910 ms (total (w/children): 2.343 ms)
27x ParseValueAndReturnDef (for RimWorld.StructureLayoutDef) -> 1.840 ms (total (w/children): 2.916 ms)
514x SetIndices -> 1.837 ms (total (w/children): 1.837 ms)
23x ParseValueAndReturnDef (for RimWorld.BodyTypeDef) -> 1.778 ms (total (w/children): 2.628 ms)
1x LoadAllPlayData -> 1.770 ms (total (w/children): 5237.563 ms)
14809x assetlookup.TryGetValue -> 1.754 ms (total (w/children): 1.754 ms)
1x Legacy backstory translations. -> 1.649 ms (total (w/children): 1.649 ms)
41x ParseValueAndReturnDef (for RimWorld.BeardDef) -> 1.636 ms (total (w/children): 3.862 ms)
1x TKeySystem.Parse() -> 1.559 ms (total (w/children): 1.559 ms)
8x ParseValueAndReturnDef (for RimWorld.PsychicRitualRoleDef) -> 1.498 ms (total (w/children): 1.631 ms)
7103x RecursiveNodeCopyOverwriteElements - Remove all current nodes -> 1.448 ms (total (w/children): 1.448 ms)
33x ParseValueAndReturnDef (for RimWorld.SketchResolverDef) -> 1.340 ms (total (w/children): 1.340 ms)
39x Search for field alias -> 1.307 ms (total (w/children): 1.307 ms)
1x Generate implied Defs (post-resolve). -> 1.270 ms (total (w/children): 1.270 ms)
58x ParseValueAndReturnDef (for RimWorld.SitePartDef) -> 1.249 ms (total (w/children): 1.459 ms)
47x ParseValueAndReturnDef (for Verse.MentalStateDef) -> 1.154 ms (total (w/children): 1.395 ms)
123x ParseValueAndReturnDef (for Verse.ThingStyleDef) -> 1.126 ms (total (w/children): 1.127 ms)
52x ParseValueAndReturnDef (for Verse.DamageDef) -> 1.113 ms (total (w/children): 1.281 ms)
85x ParseValueAndReturnDef (for RimWorld.ConceptDef) -> 1.100 ms (total (w/children): 1.239 ms)
135x ParseValueAndReturnDef (for RimWorld.ColorDef) -> 1.086 ms (total (w/children): 1.380 ms)
37x ParseValueAndReturnDef (for RimWorld.InstructionDef) -> 1.053 ms (total (w/children): 1.056 ms)
8x ParseValueAndReturnDef (for Verse.CreepJoinerFormKindDef) -> 1.002 ms (total (w/children): 1.748 ms)
23x ParseValueAndReturnDef (for Verse.WorkTypeDef) -> 0.971 ms (total (w/children): 1.004 ms)
1x Loading CarnySenpai.EnableOversizedWeapons content -> 0.885 ms (total (w/children): 0.885 ms)
18x ParseValueAndReturnDef (for RimWorld.RitualVisualEffectDef) -> 0.851 ms (total (w/children): 1.126 ms)
61x ParseValueAndReturnDef (for RimWorld.WeaponTraitDef) -> 0.833 ms (total (w/children): 0.895 ms)
12x ParseValueAndReturnDef (for Verse.WorldGenStepDef) -> 0.814 ms (total (w/children): 0.814 ms)
1x ErrorCheckPatches() -> 0.763 ms (total (w/children): 17.630 ms)
3x ParseValueAndReturnDef (for RimWorld.MutantDef) -> 0.679 ms (total (w/children): 0.710 ms)
1x Global operations (early pass). -> 0.678 ms (total (w/children): 0.678 ms)
5x ParseValueAndReturnDef (for RimWorld.HediffGiverSetDef) -> 0.674 ms (total (w/children): 0.684 ms)
9x ParseValueAndReturnDef (for RimWorld.ComplexThreatDef) -> 0.672 ms (total (w/children): 1.521 ms)
39x ParseValueAndReturnDef (for Verse.HeadTypeDef) -> 0.668 ms (total (w/children): 1.020 ms)
80x ParseValueAndReturnDef (for RimWorld.HairDef) -> 0.630 ms (total (w/children): 0.644 ms)
1x Load all active mods. -> 0.627 ms (total (w/children): 2011.749 ms)
27x ParseValueAndReturnDef (for RimWorld.RitualPatternDef) -> 0.608 ms (total (w/children): 0.838 ms)
2x ParseValueAndReturnDef (for RimWorld.PlanetLayerDef) -> 0.607 ms (total (w/children): 0.772 ms)
3x ParseValueAndReturnDef (for RimWorld.SurgeryOutcomeEffectDef) -> 0.604 ms (total (w/children): 1.056 ms)
18x ParseValueAndReturnDef (for RimWorld.LifeStageDef) -> 0.602 ms (total (w/children): 0.608 ms)
3x ParseValueAndReturnDef (for RimWorld.BossgroupDef) -> 0.595 ms (total (w/children): 1.019 ms)
3x ParseValueAndReturnDef (for RimWorld.ComplexLayoutDef) -> 0.594 ms (total (w/children): 1.059 ms)
11x ParseValueAndReturnDef (for RimWorld.RaidStrategyDef) -> 0.581 ms (total (w/children): 1.058 ms)
77x ParseValueAndReturnDef (for Verse.SongDef) -> 0.579 ms (total (w/children): 1.045 ms)
17x ParseValueAndReturnDef (for Verse.DesignationCategoryDef) -> 0.568 ms (total (w/children): 0.569 ms)
38x ParseValueAndReturnDef (for Verse.GameConditionDef) -> 0.527 ms (total (w/children): 0.777 ms)
928x RegisterObjectWantsCrossRef (object,string,XmlNode) -> 0.516 ms (total (w/children): 0.516 ms)
1x ResolveAllReferences Verse.ThingDef -> 0.497 ms (total (w/children): 26.594 ms)
20x ParseValueAndReturnDef (for Verse.PlaceDef) -> 0.494 ms (total (w/children): 0.502 ms)
7x ParseValueAndReturnDef (for RimWorld.MonolithLevelDef) -> 0.486 ms (total (w/children): 1.005 ms)
59x ParseValueAndReturnDef (for Verse.KeyBindingDef) -> 0.486 ms (total (w/children): 0.768 ms)
181x ParseValueAndReturnDef (for RimWorld.HistoryEventDef) -> 0.485 ms (total (w/children): 0.485 ms)
8x ParseValueAndReturnDef (for RimWorld.FleshTypeDef) -> 0.469 ms (total (w/children): 0.798 ms)
11x ParseValueAndReturnDef (for Verse.StyleCategoryDef) -> 0.463 ms (total (w/children): 0.686 ms)
5x ParseValueAndReturnDef (for RimWorld.RoadDef) -> 0.462 ms (total (w/children): 0.734 ms)
27x ParseValueAndReturnDef (for RimWorld.EntityCodexEntryDef) -> 0.456 ms (total (w/children): 0.990 ms)
71x ParseValueAndReturnDef (for RimWorld.RecordDef) -> 0.455 ms (total (w/children): 0.716 ms)
2x ParseValueAndReturnDef (for AlienRace.RaceSettings) -> 0.451 ms (total (w/children): 0.807 ms)
5x ParseValueAndReturnDef (for RimWorld.CultureDef) -> 0.446 ms (total (w/children): 0.726 ms)
41x ParseValueAndReturnDef (for RimWorld.ScenPartDef) -> 0.434 ms (total (w/children): 0.544 ms)
80x ParseValueAndReturnDef (for Verse.ThingCategoryDef) -> 0.399 ms (total (w/children): 0.412 ms)
28x ParseValueAndReturnDef (for RimWorld.PawnRelationDef) -> 0.398 ms (total (w/children): 0.565 ms)
13x ParseValueAndReturnDef (for Verse.RoomStatDef) -> 0.379 ms (total (w/children): 0.735 ms)
47x ParseValueAndReturnDef (for Verse.SpecialThingFilterDef) -> 0.377 ms (total (w/children): 0.392 ms)
94x ParseValueAndReturnDef (for RimWorld.IdeoIconDef) -> 0.375 ms (total (w/children): 0.422 ms)
19x ParseValueAndReturnDef (for Verse.MapGeneratorDef) -> 0.361 ms (total (w/children): 5.303 ms)
1x ParseValueAndReturnDef (for RimWorld.PsychicRitualDef_VoidProvocation) -> 0.355 ms (total (w/children): 0.357 ms)
1x Loading EnableOversizedWeapons.EnableOversizedWeaponsMod mod class -> 0.353 ms (total (w/children): 0.353 ms)
52x ParseValueAndReturnDef (for RimWorld.PawnColumnDef) -> 0.343 ms (total (w/children): 0.343 ms)
1x ApplyPatches() -> 0.342 ms (total (w/children): 75.535 ms)
10x Parse loaded defs -> 0.335 ms (total (w/children): 0.335 ms)
123x ParseValueAndReturnDef (for Verse.ShaderTypeDef) -> 0.333 ms (total (w/children): 0.333 ms)
13x ParseValueAndReturnDef (for Verse.AnimationDef) -> 0.333 ms (total (w/children): 0.643 ms)
24x ParseValueAndReturnDef (for RimWorld.NeedDef) -> 0.325 ms (total (w/children): 0.325 ms)
12x ParseValueAndReturnDef (for RimWorld.XenotypeDef) -> 0.317 ms (total (w/children): 0.354 ms)
12x ParseValueAndReturnDef (for RimWorld.SkillDef) -> 0.315 ms (total (w/children): 0.318 ms)
76x ParseValueAndReturnDef (for RimWorld.IssueDef) -> 0.313 ms (total (w/children): 0.313 ms)
7x ParseValueAndReturnDef (for RimWorld.GeneTemplateDef) -> 0.303 ms (total (w/children): 0.694 ms)
28x ParseValueAndReturnDef (for Verse.LetterDef) -> 0.302 ms (total (w/children): 0.394 ms)
10x ParseValueAndReturnDef (for Verse.CreepJoinerBenefitDef) -> 0.297 ms (total (w/children): 0.720 ms)
14x ParseValueAndReturnDef (for RimWorld.TrainableDef) -> 0.292 ms (total (w/children): 0.298 ms)
1x LoadModContent() -> 0.292 ms (total (w/children): 14.976 ms)
15x ParseValueAndReturnDef (for RimWorld.RoyalTitlePermitDef) -> 0.291 ms (total (w/children): 0.302 ms)
33x ParseValueAndReturnDef (for Verse.MentalBreakDef) -> 0.280 ms (total (w/children): 0.363 ms)
1x Loading brrainz.harmony -> 0.278 ms (total (w/children): 1.024 ms)
31x ParseValueAndReturnDef (for RimWorld.TattooDef) -> 0.273 ms (total (w/children): 0.367 ms)
1x ParseValueAndReturnDef (for AlienRace.PawnBioDef) -> 0.263 ms (total (w/children): 0.754 ms)
6x ParseValueAndReturnDef (for Verse.IdeoStoryPatternDef) -> 0.261 ms (total (w/children): 0.265 ms)
8x ParseValueAndReturnDef (for RimWorld.InspirationDef) -> 0.260 ms (total (w/children): 1.597 ms)
7x ParseValueAndReturnDef (for RimWorld.DifficultyDef) -> 0.258 ms (total (w/children): 0.258 ms)
39x ParseValueAndReturnDef (for RimWorld.GoodwillSituationDef) -> 0.249 ms (total (w/children): 0.260 ms)
1x ClearCachedPatches() -> 0.243 ms (total (w/children): 0.243 ms)
25x ParseValueAndReturnDef (for RimWorld.FeatureDef) -> 0.241 ms (total (w/children): 0.263 ms)
12x ParseValueAndReturnDef (for Verse.ManeuverDef) -> 0.241 ms (total (w/children): 0.553 ms)
3x ParseValueAndReturnDef (for Verse.OrbitalDebrisDef) -> 0.240 ms (total (w/children): 0.400 ms)
13x ParseValueAndReturnDef (for RimWorld.PawnsArrivalModeDef) -> 0.239 ms (total (w/children): 0.245 ms)
1x Initializing [erdelf.HumanoidAlienRaces|Humanoid Alien Races] -> 0.229 ms (total (w/children): 0.229 ms)
18x RegisterDictionaryWantsCrossRef -> 0.217 ms (total (w/children): 0.217 ms)
25x ParseValueAndReturnDef (for RimWorld.IdeoPresetDef) -> 0.216 ms (total (w/children): 0.233 ms)
1x Initializing [Ludeon.RimWorld|Core] -> 0.213 ms (total (w/children): 0.213 ms)
15x ParseValueAndReturnDef (for RimWorld.MainButtonDef) -> 0.210 ms (total (w/children): 0.210 ms)
22x ParseValueAndReturnDef (for RimWorld.JoyGiverDef) -> 0.204 ms (total (w/children): 0.234 ms)
1x LoadModXML() -> 0.200 ms (total (w/children): 423.667 ms)
50x ParseValueAndReturnDef (for Verse.BodyPartGroupDef) -> 0.196 ms (total (w/children): 0.196 ms)
40x ParseValueAndReturnDef (for RimWorld.StatCategoryDef) -> 0.192 ms (total (w/children): 0.192 ms)
9x ParseValueAndReturnDef (for Verse.CreepJoinerDownsideDef) -> 0.191 ms (total (w/children): 0.195 ms)
8x ParseValueAndReturnDef (for RimWorld.ChemicalDef) -> 0.189 ms (total (w/children): 0.328 ms)
8x ParseValueAndReturnDef (for RimWorld.MusicSequenceDef) -> 0.184 ms (total (w/children): 0.395 ms)
7x ParseValueAndReturnDef (for RimWorld.MeditationFocusDef) -> 0.172 ms (total (w/children): 0.392 ms)
4x ParseValueAndReturnDef (for RimWorld.RiverDef) -> 0.170 ms (total (w/children): 0.299 ms)
23x ParseValueAndReturnDef (for Verse.RoomRoleDef) -> 0.168 ms (total (w/children): 0.334 ms)
6x ParseValueAndReturnDef (for Verse.TipSetDef) -> 0.167 ms (total (w/children): 0.167 ms)
7x ParseValueAndReturnDef (for RimWorld.GauranlenTreeModeDef) -> 0.167 ms (total (w/children): 0.188 ms)
1x ParseValueAndReturnDef (for RimWorld.PitGateIncidentDef) -> 0.165 ms (total (w/children): 0.165 ms)
1x ResolveAllReferences Verse.SoundDef -> 0.160 ms (total (w/children): 0.919 ms)
1x ParseValueAndReturnDef (for RimWorld.FurDef) -> 0.155 ms (total (w/children): 0.383 ms)
4x ParseValueAndReturnDef (for RimWorld.TerrainTemplateDef) -> 0.146 ms (total (w/children): 0.159 ms)
6x ParseValueAndReturnDef (for RimWorld.ExpansionDef) -> 0.142 ms (total (w/children): 0.142 ms)
11x ParseValueAndReturnDef (for Verse.PawnCapacityDef) -> 0.142 ms (total (w/children): 0.142 ms)
11x ParseValueAndReturnDef (for RimWorld.HistoryAutoRecorderDef) -> 0.141 ms (total (w/children): 0.141 ms)
4x ParseValueAndReturnDef (for RimWorld.DrugPolicyDef) -> 0.141 ms (total (w/children): 0.273 ms)
9x ParseValueAndReturnDef (for Verse.ScatterableDef) -> 0.141 ms (total (w/children): 0.141 ms)
27x ParseValueAndReturnDef (for Verse.DesignationDef) -> 0.140 ms (total (w/children): 0.255 ms)
1x ParseValueAndReturnDef (for RimWorld.RoomPart_GestationTankDef) -> 0.137 ms (total (w/children): 0.365 ms)
19x ParseValueAndReturnDef (for Verse.DrawStyleCategoryDef) -> 0.134 ms (total (w/children): 0.290 ms)
6x ParseValueAndReturnDef (for Verse.DrawStyleDef) -> 0.128 ms (total (w/children): 0.128 ms)
1x ResolveAllReferences RimWorld.BackstoryDef -> 0.126 ms (total (w/children): 0.195 ms)
1x ResolveAllReferences RimWorld.ThoughtDef -> 0.126 ms (total (w/children): 0.194 ms)
3x Verse.PatchOperationSequence Worker -> 0.124 ms (total (w/children): 5.436 ms)
12x ParseValueAndReturnDef (for RimWorld.PrisonerInteractionModeDef) -> 0.123 ms (total (w/children): 0.123 ms)
1x Initializing [Atlas.AndroidTiers|Android tiers] -> 0.123 ms (total (w/children): 0.123 ms)
3x ParseValueAndReturnDef (for RimWorld.GatheringDef) -> 0.123 ms (total (w/children): 0.293 ms)
9x ParseValueAndReturnDef (for Verse.KeyBindingCategoryDef) -> 0.118 ms (total (w/children): 0.299 ms)
4x ParseValueAndReturnDef (for Verse.GameSetupStepDef) -> 0.118 ms (total (w/children): 0.118 ms)
3x ParseValueAndReturnDef (for Verse.CreepJoinerAggressiveDef) -> 0.115 ms (total (w/children): 0.116 ms)
7x ParseValueAndReturnDef (for RimWorld.RitualAttachableOutcomeEffectDef) -> 0.112 ms (total (w/children): 0.115 ms)
6x ParseValueAndReturnDef (for RimWorld.PawnTableDef) -> 0.109 ms (total (w/children): 0.346 ms)
4x ParseValueAndReturnDef (for RimWorld.HistoryAutoRecorderGroupDef) -> 0.107 ms (total (w/children): 0.302 ms)
10x ParseValueAndReturnDef (for RimWorld.ExpectationDef) -> 0.104 ms (total (w/children): 0.104 ms)
33x ParseValueAndReturnDef (for RimWorld.IdeoColorDef) -> 0.104 ms (total (w/children): 0.115 ms)
21x ParseValueAndReturnDef (for RimWorld.RitualObligationTargetFilterDef) -> 0.102 ms (total (w/children): 0.106 ms)
4x ParseValueAndReturnDef (for Verse.MechWorkModeDef) -> 0.098 ms (total (w/children): 0.098 ms)
9x ParseValueAndReturnDef (for RimWorld.MusicTransitionDef) -> 0.097 ms (total (w/children): 0.203 ms)
1x Initializing [Ludeon.RimWorld.Royalty|Royalty] -> 0.095 ms (total (w/children): 0.095 ms)
21x ParseValueAndReturnDef (for Verse.GeneCategoryDef) -> 0.090 ms (total (w/children): 0.090 ms)
12x ParseValueAndReturnDef (for Verse.TerrainAffordanceDef) -> 0.087 ms (total (w/children): 0.087 ms)
1x Initializing [Ludeon.RimWorld.Ideology|Ideology] -> 0.083 ms (total (w/children): 0.083 ms)
11x ParseValueAndReturnDef (for RimWorld.NegativeFishingOutcomeDef) -> 0.083 ms (total (w/children): 0.088 ms)
13x ParseValueAndReturnDef (for Verse.DesignatorDropdownGroupDef) -> 0.083 ms (total (w/children): 0.170 ms)
7x ParseValueAndReturnDef (for RimWorld.LearningDesireDef) -> 0.083 ms (total (w/children): 0.084 ms)
13x ParseValueAndReturnDef (for Verse.ToolCapacityDef) -> 0.078 ms (total (w/children): 0.078 ms)
139x TryDoPostLoad -> 0.078 ms (total (w/children): 0.078 ms)
2x ParseValueAndReturnDef (for RimWorld.KnowledgeCategoryDef) -> 0.076 ms (total (w/children): 0.076 ms)
33x ParseValueAndReturnDef (for Verse.BodyPartTagDef) -> 0.075 ms (total (w/children): 0.075 ms)
2x ParseValueAndReturnDef (for Verse.SubcameraDef) -> 0.074 ms (total (w/children): 0.160 ms)
20x ParseValueAndReturnDef (for RimWorld.PawnGroupKindDef) -> 0.072 ms (total (w/children): 0.072 ms)
5x ParseValueAndReturnDef (for RimWorld.TimeAssignmentDef) -> 0.071 ms (total (w/children): 0.071 ms)
8x ParseValueAndReturnDef (for RimWorld.MemeGroupDef) -> 0.071 ms (total (w/children): 0.071 ms)
1x ParseValueAndReturnDef (for RimWorld.PsychicRitualDef_ImbueDeathRefusal) -> 0.071 ms (total (w/children): 0.072 ms)
3x ParseValueAndReturnDef (for RimWorld.ResearchTabDef) -> 0.070 ms (total (w/children): 0.070 ms)
1x ParseValueAndReturnDef (for RimWorld.LayoutDef) -> 0.069 ms (total (w/children): 0.076 ms)
1x ParseValueAndReturnDef (for RimWorld.PsychicRitualDef_SummonAnimals) -> 0.067 ms (total (w/children): 0.069 ms)
1x ResolveAllReferences Verse.HediffDef -> 0.067 ms (total (w/children): 0.335 ms)
1x ParseValueAndReturnDef (for RimWorld.PsychicRitualDef_Philophagy) -> 0.066 ms (total (w/children): 0.067 ms)
1x ParseValueAndReturnDef (for RimWorld.PsychicRitualDef_SummonFleshbeastsPlayer) -> 0.064 ms (total (w/children): 0.066 ms)
1x ParseValueAndReturnDef (for RimWorld.PsychicRitualDef_Psychophagy) -> 0.064 ms (total (w/children): 0.065 ms)
1x ParseValueAndReturnDef (for RimWorld.PsychicRitualDef_Chronophagy) -> 0.063 ms (total (w/children): 0.065 ms)
2x ParseValueAndReturnDef (for RimWorld.PlanetLayerSettingsDef) -> 0.062 ms (total (w/children): 0.062 ms)
1x Initializing [Ludeon.RimWorld.Odyssey|Odyssey] -> 0.062 ms (total (w/children): 0.062 ms)
1x ResolveAllReferences Verse.GraphicStateDef -> 0.061 ms (total (w/children): 0.095 ms)
1x ParseValueAndReturnDef (for RimWorld.GeneratedLocationDef) -> 0.060 ms (total (w/children): 0.062 ms)
6x ParseValueAndReturnDef (for RimWorld.IdeoPresetCategoryDef) -> 0.060 ms (total (w/children): 0.060 ms)
1x ParseValueAndReturnDef (for RimWorld.PsychicRitualDef_SummonFleshbeasts) -> 0.059 ms (total (w/children): 0.061 ms)
2x ParseValueAndReturnDef (for Verse.LogEntryDef) -> 0.059 ms (total (w/children): 0.059 ms)
1x ParseValueAndReturnDef (for RimWorld.PsychicRitualDef_Brainwipe) -> 0.058 ms (total (w/children): 0.059 ms)
1x Initializing [Ludeon.RimWorld.Biotech|Biotech] -> 0.058 ms (total (w/children): 0.058 ms)
1x ParseValueAndReturnDef (for RimWorld.PsychicRitualDef_PleasurePulse) -> 0.057 ms (total (w/children): 0.058 ms)
2x ParseValueAndReturnDef (for Verse.MentalFitDef) -> 0.056 ms (total (w/children): 0.057 ms)
3x ParseValueAndReturnDef (for Verse.PathGridDef) -> 0.056 ms (total (w/children): 0.056 ms)
12x ParseValueAndReturnDef (for RimWorld.RoomPartDef) -> 0.054 ms (total (w/children): 0.054 ms)
1x Initializing [Ludeon.RimWorld.Anomaly|Anomaly] -> 0.054 ms (total (w/children): 0.054 ms)
3x ParseValueAndReturnDef (for RimWorld.EntityCategoryDef) -> 0.054 ms (total (w/children): 0.054 ms)
1x ResolveAllReferences Verse.BuildableDef -> 0.054 ms (total (w/children): 0.054 ms)
1x ParseValueAndReturnDef (for RimWorld.PsychicRitualDef_SkipAbductionPlayer) -> 0.053 ms (total (w/children): 0.054 ms)
1x ParseValueAndReturnDef (for RimWorld.PsychicRitualDef_SummonPitGate) -> 0.053 ms (total (w/children): 0.054 ms)
4x ParseValueAndReturnDef (for Verse.RoofDef) -> 0.053 ms (total (w/children): 0.054 ms)
3x ParseValueAndReturnDef (for RimWorld.AnomalyPlaystyleDef) -> 0.052 ms (total (w/children): 0.052 ms)
1x ParseValueAndReturnDef (for RimWorld.PsychicRitualDef_NeurosisPulse) -> 0.052 ms (total (w/children): 0.053 ms)
1x ParseValueAndReturnDef (for RimWorld.PsychicRitualDef_BloodRain) -> 0.051 ms (total (w/children): 0.052 ms)
2x XmlInheritance.Clear() -> 0.050 ms (total (w/children): 0.050 ms)
1x ResolveAllReferences Verse.TerrainDef -> 0.050 ms (total (w/children): 0.078 ms)
2x ParseValueAndReturnDef (for Verse.CreepJoinerRejectionDef) -> 0.049 ms (total (w/children): 0.049 ms)
4x ParseValueAndReturnDef (for RimWorld.LandingOutcomeDef) -> 0.049 ms (total (w/children): 0.049 ms)
1x ParseValueAndReturnDef (for RimWorld.PsychicRitualDef_SummonShamblers) -> 0.048 ms (total (w/children): 0.049 ms)
1x ResolveAllReferences Verse.FleckDef -> 0.047 ms (total (w/children): 0.071 ms)
6x ParseValueAndReturnDef (for Verse.ApparelLayerDef) -> 0.046 ms (total (w/children): 0.046 ms)
1x ResolveAllReferences Verse.RulePackDef -> 0.046 ms (total (w/children): 0.073 ms)
10x ParseValueAndReturnDef (for WeaponClassDef) -> 0.046 ms (total (w/children): 0.046 ms)
11x ParseValueAndReturnDef (for RimWorld.XenotypeIconDef) -> 0.046 ms (total (w/children): 0.046 ms)
4x ParseValueAndReturnDef (for RimWorld.TransportShipDef) -> 0.045 ms (total (w/children): 0.047 ms)
6x ParseValueAndReturnDef (for RimWorld.StuffCategoryDef) -> 0.045 ms (total (w/children): 0.047 ms)
1x ParseValueAndReturnDef (for RimWorld.PsychicRitualDef_SkipAbduction) -> 0.044 ms (total (w/children): 0.045 ms)
1x ResolveAllReferences Verse.JobDef -> 0.044 ms (total (w/children): 0.073 ms)
7x ParseValueAndReturnDef (for RimWorld.ShipJobDef) -> 0.043 ms (total (w/children): 0.043 ms)
1x ResolveAllReferences Verse.PawnKindDef -> 0.043 ms (total (w/children): 0.216 ms)
1x ParseValueAndReturnDef (for RimWorld.RaidAgeRestrictionDef) -> 0.043 ms (total (w/children): 0.043 ms)
7x ParseValueAndReturnDef (for RimWorld.RitualTargetFilterDef) -> 0.043 ms (total (w/children): 0.043 ms)
1x ResolveAllReferences Verse.ThinkTreeDef -> 0.043 ms (total (w/children): 332.907 ms)
12x ParseValueAndReturnDef (for RimWorld.StyleItemCategoryDef) -> 0.041 ms (total (w/children): 0.041 ms)
1x ResolveAllReferences Verse.EffecterDef -> 0.041 ms (total (w/children): 0.061 ms)
8x ParseValueAndReturnDef (for Verse.OptionCategoryDef) -> 0.040 ms (total (w/children): 0.040 ms)
5x ParseValueAndReturnDef (for RimWorld.GravshipComponentTypeDef) -> 0.040 ms (total (w/children): 0.040 ms)
10x ParseValueAndReturnDef (for RimWorld.JoyKindDef) -> 0.039 ms (total (w/children): 0.039 ms)
12x ParseValueAndReturnDef (for Verse.MessageTypeDef) -> 0.037 ms (total (w/children): 0.039 ms)
13x ParseValueAndReturnDef (for RimWorld.IncidentCategoryDef) -> 0.037 ms (total (w/children): 0.037 ms)
1x ResolveAllReferences RimWorld.StatDef -> 0.037 ms (total (w/children): 0.057 ms)
7x ParseValueAndReturnDef (for RimWorld.TransferableSorterDef) -> 0.037 ms (total (w/children): 0.037 ms)
15x ParseValueAndReturnDef (for RimWorld.MapMeshFlagDef) -> 0.036 ms (total (w/children): 0.036 ms)
3x ParseValueAndReturnDef (for RimWorld.BossDef) -> 0.036 ms (total (w/children): 0.037 ms)
1x ResolveAllReferences RimWorld.PreceptDef -> 0.036 ms (total (w/children): 0.054 ms)
3x ParseValueAndReturnDef (for RimWorld.AbilityGroupDef) -> 0.035 ms (total (w/children): 0.035 ms)
1x ResolveAllReferences Verse.GeneDef -> 0.035 ms (total (w/children): 0.300 ms)
5x ParseValueAndReturnDef (for RimWorld.SlaveInteractionModeDef) -> 0.035 ms (total (w/children): 0.035 ms)
1x ResolveAllReferences Verse.GenStepDef -> 0.035 ms (total (w/children): 0.048 ms)
3x ParseValueAndReturnDef (for RimWorld.DebugTabMenuDef) -> 0.035 ms (total (w/children): 0.035 ms)
16x ParseValueAndReturnDef (for RimWorld.WeaponCategoryDef) -> 0.034 ms (total (w/children): 0.034 ms)
5x ParseValueAndReturnDef (for RimWorld.RoadWorldLayerDef) -> 0.034 ms (total (w/children): 0.034 ms)
1x ParseValueAndReturnDef (for RimWorld.PsychicRitualRoleDef_DeathRefusalTarget) -> 0.034 ms (total (w/children): 0.034 ms)
1x GraphicDatabase.Clear() -> 0.033 ms (total (w/children): 0.033 ms)
7x ParseValueAndReturnDef (for Verse.Sound.ImpactSoundTypeDef) -> 0.033 ms (total (w/children): 0.034 ms)
1x ResolveAllReferences WeaponClassDef -> 0.033 ms (total (w/children): 0.035 ms)
1x ResolveAllReferences RimWorld.HistoryEventDef -> 0.033 ms (total (w/children): 0.048 ms)
6x ParseValueAndReturnDef (for RimWorld.RoomPart_ThingDef) -> 0.033 ms (total (w/children): 0.033 ms)
1x ResolveAllReferences Verse.BodyPartDef -> 0.032 ms (total (w/children): 0.051 ms)
5x ParseValueAndReturnDef (for WeaponClassPairDef) -> 0.031 ms (total (w/children): 0.033 ms)
6x ParseValueAndReturnDef (for Verse.ClamorDef) -> 0.031 ms (total (w/children): 0.031 ms)
1x ResolveAllReferences RimWorld.PrefabDef -> 0.030 ms (total (w/children): 0.044 ms)
3x ParseValueAndReturnDef (for RimWorld.InfectionPathwayDef) -> 0.030 ms (total (w/children): 0.030 ms)
1x ResolveAllReferences Verse.ResearchProjectDef -> 0.030 ms (total (w/children): 0.064 ms)
1x ResolveAllReferences RimWorld.WorkGiverDef -> 0.029 ms (total (w/children): 0.040 ms)
1x ResolveAllReferences RimWorld.CultureDef -> 0.029 ms (total (w/children): 0.031 ms)
2x ParseValueAndReturnDef (for RimWorld.GlobalWorldDrawLayerDef) -> 0.028 ms (total (w/children): 0.028 ms)
5x ParseValueAndReturnDef (for Verse.ImplementOwnerTypeDef) -> 0.028 ms (total (w/children): 0.028 ms)
1x Loading Ludeon.RimWorld content -> 0.027 ms (total (w/children): 0.027 ms)
3x ParseValueAndReturnDef (for RimWorld.BabyPlayDef) -> 0.026 ms (total (w/children): 0.027 ms)
1x ResolveAllReferences RimWorld.QuestScriptDef -> 0.026 ms (total (w/children): 0.039 ms)
1x ResolveAllReferences Verse.TipSetDef -> 0.026 ms (total (w/children): 0.028 ms)
4x ParseValueAndReturnDef (for RimWorld.AbilityCategoryDef) -> 0.025 ms (total (w/children): 0.025 ms)
1x ResolveAllReferences RimWorld.IncidentDef -> 0.025 ms (total (w/children): 0.041 ms)
3x ParseValueAndReturnDef (for RimWorld.BillStoreModeDef) -> 0.025 ms (total (w/children): 0.025 ms)
1x ResolveAllReferences RimWorld.LayoutRoomDef -> 0.024 ms (total (w/children): 0.036 ms)
1x ParseValueAndReturnDef (for RimWorld.RoomPart_BarricadeDef) -> 0.024 ms (total (w/children): 0.024 ms)
5x ParseValueAndReturnDef (for Verse.PawnRenderNodeTagDef) -> 0.024 ms (total (w/children): 0.024 ms)
3x ParseValueAndReturnDef (for RimWorld.BillRepeatModeDef) -> 0.024 ms (total (w/children): 0.024 ms)
1x ResolveAllReferences RimWorld.ColorDef -> 0.023 ms (total (w/children): 0.034 ms)
2x ParseValueAndReturnDef (for RimWorld.RoomPart_CrateDef) -> 0.023 ms (total (w/children): 0.023 ms)
1x ParseValueAndReturnDef (for RimWorld.IdeoFoundationDef) -> 0.023 ms (total (w/children): 0.023 ms)
4x ParseValueAndReturnDef (for Verse.MechWeightClassDef) -> 0.023 ms (total (w/children): 0.023 ms)
1x ResolveAllReferences Verse.ThingStyleDef -> 0.022 ms (total (w/children): 0.031 ms)
5x ParseValueAndReturnDef (for Verse.ResearchProjectTagDef) -> 0.022 ms (total (w/children): 0.022 ms)
3x ParseValueAndReturnDef (for Verse.TrainabilityDef) -> 0.021 ms (total (w/children): 0.021 ms)
1x ResolveAllReferences RimWorld.TaleDef -> 0.020 ms (total (w/children): 0.029 ms)
1x ResolveAllReferences Verse.AI.DutyDef -> 0.020 ms (total (w/children): 0.029 ms)
1x ResolveAllReferences RimWorld.ExpectationDef -> 0.020 ms (total (w/children): 0.022 ms)
1x ResolveAllReferences RimWorld.PawnColumnDef -> 0.020 ms (total (w/children): 0.027 ms)
3x ParseValueAndReturnDef (for Verse.DamageArmorCategoryDef) -> 0.020 ms (total (w/children): 0.020 ms)
1x ResolveAllReferences RimWorld.ThingSetMakerDef -> 0.019 ms (total (w/children): 3.333 ms)
1x ResolveAllReferences RimWorld.AbilityDef -> 0.019 ms (total (w/children): 0.028 ms)
1x ResolveAllReferences Verse.ShaderTypeDef -> 0.019 ms (total (w/children): 0.029 ms)
7x ParseValueAndReturnDef (for RimWorld.RenderSkipFlagDef) -> 0.019 ms (total (w/children): 0.019 ms)
1x ResolveAllReferences RimWorld.TileMutatorDef -> 0.019 ms (total (w/children): 0.259 ms)
7x ParseValueAndReturnDef (for RimWorld.IncidentTargetTagDef) -> 0.019 ms (total (w/children): 0.019 ms)
1x ThingDef resolver -> 0.018 ms (total (w/children): 26.902 ms)
1x ResolveAllReferences Verse.AnimationDef -> 0.018 ms (total (w/children): 0.024 ms)
4x ParseValueAndReturnDef (for Verse.StuffAppearanceDef) -> 0.018 ms (total (w/children): 0.018 ms)
1x ResolveAllReferences RimWorld.RecordDef -> 0.018 ms (total (w/children): 0.024 ms)
1x ParseValueAndReturnDef (for Verse.InventoryStockGroupDef) -> 0.018 ms (total (w/children): 0.019 ms)
1x ResolveAllReferences RimWorld.IssueDef -> 0.018 ms (total (w/children): 0.025 ms)
1x ResolveAllReferences RimWorld.IdeoIconDef -> 0.018 ms (total (w/children): 0.025 ms)
1x ResolveAllReferences RimWorld.ConceptDef -> 0.018 ms (total (w/children): 0.025 ms)
1x ResolveAllReferences RimWorld.RuleDef -> 0.018 ms (total (w/children): 0.027 ms)
1x ResolveAllReferences RimWorld.HairDef -> 0.017 ms (total (w/children): 0.024 ms)
1x ResolveAllReferences Verse.SongDef -> 0.017 ms (total (w/children): 0.058 ms)
1x ResolveAllReferences RimWorld.InteractionDef -> 0.017 ms (total (w/children): 0.044 ms)
2x ParseValueAndReturnDef (for Verse.OrderedTakeGroupDef) -> 0.016 ms (total (w/children): 0.016 ms)
1x ResolveAllReferences Verse.StyleCategoryDef -> 0.016 ms (total (w/children): 0.019 ms)
1x ResolveAllReferences Verse.SpecialThingFilterDef -> 0.016 ms (total (w/children): 0.021 ms)
1x ResolveAllReferences Verse.ClamorDef -> 0.016 ms (total (w/children): 0.019 ms)
1x ResolveAllReferences AlienRace.ThingDef_AlienRace -> 0.016 ms (total (w/children): 55.098 ms)
1x ResolveAllReferences Verse.BodyDef -> 0.015 ms (total (w/children): 0.448 ms)
2x ParseValueAndReturnDef (for RimWorld.RoadPathingDef) -> 0.015 ms (total (w/children): 0.015 ms)
3x ParseValueAndReturnDef (for Verse.ReservationLayerDef) -> 0.015 ms (total (w/children): 0.015 ms)
1x ResolveAllReferences RimWorld.TraitDef -> 0.015 ms (total (w/children): 0.118 ms)
1x ResolveAllReferences Verse.WorkTypeDef -> 0.015 ms (total (w/children): 0.993 ms)
1x ResolveAllReferences Verse.BodyPartGroupDef -> 0.014 ms (total (w/children): 0.020 ms)
1x ResolveAllReferences RimWorld.PawnsArrivalModeDef -> 0.014 ms (total (w/children): 0.017 ms)
1x ResolveAllReferences RimWorld.WeaponTraitDef -> 0.014 ms (total (w/children): 0.020 ms)
1x ResolveAllReferences RimWorld.WorldObjectDef -> 0.014 ms (total (w/children): 0.079 ms)
1x ResolveAllReferences RimWorld.PsychicRitualDef_SkipAbductionPlayer -> 0.014 ms (total (w/children): 0.017 ms)
1x ResolveAllReferences Verse.KeyBindingDef -> 0.014 ms (total (w/children): 0.020 ms)
1x ResolveAllReferences RimWorld.FactionDef -> 0.014 ms (total (w/children): 0.280 ms)
1x ResolveAllReferences RimWorld.SitePartDef -> 0.014 ms (total (w/children): 0.019 ms)
1x ResolveAllReferences Verse.ToolCapacityDef -> 0.014 ms (total (w/children): 0.016 ms)
1x ResolveAllReferences RimWorld.GoodwillSituationDef -> 0.014 ms (total (w/children): 0.018 ms)
1x ResolveAllReferences Verse.DamageDef -> 0.013 ms (total (w/children): 0.019 ms)
1x ResolveAllReferences Verse.MentalStateDef -> 0.013 ms (total (w/children): 0.037 ms)
1x ResolveAllReferences RimWorld.BeardDef -> 0.013 ms (total (w/children): 0.018 ms)
1x ResolveAllReferences RimWorld.NeedDef -> 0.013 ms (total (w/children): 0.017 ms)
1x ResolveAllReferences Verse.CreepJoinerFormKindDef -> 0.013 ms (total (w/children): 0.093 ms)
1x ResolveAllReferences Verse.CreepJoinerBaseDef -> 0.013 ms (total (w/children): 0.013 ms)
1x Initializing [CarnySenpai.EnableOversizedWeapons|Enable Oversized Weapons] -> 0.013 ms (total (w/children): 0.013 ms)
3x ParseValueAndReturnDef (for RimWorld.HibernatableStateDef) -> 0.013 ms (total (w/children): 0.013 ms)
1x ResolveAllReferences RimWorld.PlanetLayerDef -> 0.013 ms (total (w/children): 0.015 ms)
1x ResolveAllReferences RimWorld.LandmarkDef -> 0.013 ms (total (w/children): 0.017 ms)
5x Clear -> 0.013 ms (total (w/children): 0.013 ms)
1x ResolveAllReferences RimWorld.PsychicRitualDef_BloodRain -> 0.013 ms (total (w/children): 0.094 ms)
1x ResolveAllReferences Verse.WeatherDef -> 0.012 ms (total (w/children): 0.016 ms)
1x ResolveAllReferences RimWorld.TraderKindDef -> 0.012 ms (total (w/children): 0.178 ms)
1x ResolveAllReferences RimWorld.StatCategoryDef -> 0.012 ms (total (w/children): 0.016 ms)
1x ResolveAllReferences Verse.HeadTypeDef -> 0.012 ms (total (w/children): 0.017 ms)
1x ResolveAllReferences RimWorld.MemeDef -> 0.012 ms (total (w/children): 0.016 ms)
1x ResolveAllReferences RimWorld.RitualPatternDef -> 0.012 ms (total (w/children): 0.016 ms)
1x ResolveAllReferences RimWorld.ScenPartDef -> 0.012 ms (total (w/children): 0.016 ms)
1x ResolveAllReferences RimWorld.InstructionDef -> 0.012 ms (total (w/children): 0.016 ms)
1x ResolveAllReferences Verse.GeneCategoryDef -> 0.012 ms (total (w/children): 0.015 ms)
1x ResolveAllReferences Verse.BodyPartTagDef -> 0.012 ms (total (w/children): 0.015 ms)
1x ResolveAllReferences Verse.WorldGenStepDef -> 0.012 ms (total (w/children): 0.015 ms)
1x ResolveAllReferences RimWorld.PsychicRitualDef_InvocationCircle -> 0.012 ms (total (w/children): 0.012 ms)
1x ResolveAllReferences RimWorld.FeatureDef -> 0.012 ms (total (w/children): 0.015 ms)
2x ParseValueAndReturnDef (for Verse.GraphicStateDef) -> 0.012 ms (total (w/children): 0.012 ms)
1x ResolveAllReferences Verse.DesignationDef -> 0.012 ms (total (w/children): 0.034 ms)
1x ResolveAllReferences RimWorld.PawnGroupKindDef -> 0.012 ms (total (w/children): 0.015 ms)
3x ParseValueAndReturnDef (for RimWorld.WorkGiverEquivalenceGroupDef) -> 0.012 ms (total (w/children): 0.012 ms)
1x ResolveAllReferences RimWorld.StructureLayoutDef -> 0.012 ms (total (w/children): 0.015 ms)
1x ResolveAllReferences RimWorld.SketchResolverDef -> 0.012 ms (total (w/children): 0.015 ms)
1x ResolveAllReferences RimWorld.BodyTypeDef -> 0.012 ms (total (w/children): 0.015 ms)
1x ResolveAllReferences Verse.PawnRenderTreeDef -> 0.011 ms (total (w/children): 0.081 ms)
1x ResolveAllReferences RimWorld.DrugPolicyDef -> 0.011 ms (total (w/children): 0.013 ms)
1x ResolveAllReferences Verse.ScatterableDef -> 0.011 ms (total (w/children): 0.013 ms)
1x ResolveAllReferences Verse.PawnRenderNodeTagDef -> 0.011 ms (total (w/children): 0.014 ms)
1x ResolveAllReferences RimWorld.EntityCodexEntryDef -> 0.011 ms (total (w/children): 0.245 ms)
1x ResolveAllReferences RimWorld.JoyGiverDef -> 0.011 ms (total (w/children): 0.014 ms)
1x ResolveAllReferences Verse.LetterDef -> 0.011 ms (total (w/children): 0.038 ms)
1x ResolveAllReferences Verse.CreepJoinerBenefitDef -> 0.011 ms (total (w/children): 0.013 ms)
1x ResolveAllReferences Verse.DesignationCategoryDef -> 0.011 ms (total (w/children): 0.074 ms)
1x ResolveAllReferences Verse.SubcameraDef -> 0.011 ms (total (w/children): 0.013 ms)
1x ResolveAllReferences RimWorld.RitualBehaviorDef -> 0.011 ms (total (w/children): 0.014 ms)
1x ResolveAllReferences RimWorld.RitualOutcomeEffectDef -> 0.011 ms (total (w/children): 0.014 ms)
1x Loading Ludeon.RimWorld.Royalty content -> 0.011 ms (total (w/children): 0.011 ms)
1x ResolveAllReferences RimWorld.IdeoPresetDef -> 0.011 ms (total (w/children): 0.014 ms)
1x ResolveAllReferences RimWorld.XenotypeDef -> 0.011 ms (total (w/children): 0.233 ms)
1x ResolveAllReferences RimWorld.IdeoColorDef -> 0.010 ms (total (w/children): 0.014 ms)
1x ResolveAllReferences Verse.GameConditionDef -> 0.010 ms (total (w/children): 0.015 ms)
1x ResolveAllReferences RimWorld.PawnRelationDef -> 0.010 ms (total (w/children): 0.014 ms)
1x ResolveAllReferences Verse.DesignatorDropdownGroupDef -> 0.010 ms (total (w/children): 0.013 ms)
1x ResolveAllReferences RimWorld.XenotypeIconDef -> 0.010 ms (total (w/children): 0.013 ms)
1x ResolveAllReferences RimWorld.NegativeFishingOutcomeDef -> 0.010 ms (total (w/children): 0.012 ms)
1x ResolveAllReferences RimWorld.BiomeDef -> 0.010 ms (total (w/children): 0.014 ms)
1x Loading Ludeon.RimWorld.Ideology content -> 0.010 ms (total (w/children): 0.010 ms)
1x ResolveAllReferences Verse.MapGeneratorDef -> 0.010 ms (total (w/children): 0.013 ms)
1x ResolveAllReferences RimWorld.PsychicRitualDef_SummonFleshbeastsPlayer -> 0.010 ms (total (w/children): 0.013 ms)
1x ResolveAllReferences RimWorld.TattooDef -> 0.010 ms (total (w/children): 0.014 ms)
1x ResolveAllReferences WeaponClassPairDef -> 0.010 ms (total (w/children): 0.012 ms)
1x ResolveAllReferences RimWorld.StyleItemCategoryDef -> 0.010 ms (total (w/children): 0.013 ms)
1x ResolveAllReferences RimWorld.RoomPartDef -> 0.010 ms (total (w/children): 0.012 ms)
1x ResolveAllReferences Verse.TrainabilityDef -> 0.010 ms (total (w/children): 0.012 ms)
1x ResolveAllReferences Verse.PlaceDef -> 0.010 ms (total (w/children): 0.012 ms)
1x ResolveAllReferences RimWorld.HibernatableStateDef -> 0.010 ms (total (w/children): 0.011 ms)
1x ResolveAllReferences RimWorld.PawnTableDef -> 0.010 ms (total (w/children): 0.012 ms)
1x ResolveAllReferences RimWorld.RitualAttachableOutcomeEffectDef -> 0.010 ms (total (w/children): 0.012 ms)
1x ResolveAllReferences RimWorld.RitualVisualEffectDef -> 0.010 ms (total (w/children): 0.013 ms)
1x ResolveAllReferences Verse.MentalBreakDef -> 0.010 ms (total (w/children): 0.013 ms)
1x ResolveAllReferences RimWorld.MapMeshFlagDef -> 0.010 ms (total (w/children): 0.013 ms)
1x ResolveAllReferences Verse.OptionCategoryDef -> 0.009 ms (total (w/children): 0.012 ms)
1x ResolveAllReferences Verse.CreepJoinerDownsideDef -> 0.009 ms (total (w/children): 0.012 ms)
1x ResolveAllReferences Verse.Sound.ImpactSoundTypeDef -> 0.009 ms (total (w/children): 0.011 ms)
1x ResolveAllReferences RimWorld.TimeAssignmentDef -> 0.009 ms (total (w/children): 0.011 ms)
1x ResolveAllReferences RimWorld.KnowledgeCategoryDef -> 0.009 ms (total (w/children): 0.011 ms)
1x ResolveAllReferences RimWorld.PlanetLayerSettingsDef -> 0.009 ms (total (w/children): 0.011 ms)
1x ResolveAllReferences RimWorld.RitualObligationTargetFilterDef -> 0.009 ms (total (w/children): 0.012 ms)
1x ResolveAllReferences RimWorld.WeaponCategoryDef -> 0.009 ms (total (w/children): 0.012 ms)
1x ResolveAllReferences Verse.CreepJoinerAggressiveDef -> 0.009 ms (total (w/children): 0.011 ms)
1x ResolveAllReferences RimWorld.LifeStageDef -> 0.009 ms (total (w/children): 0.054 ms)
1x ResolveAllReferences RimWorld.ExpansionDef -> 0.009 ms (total (w/children): 0.011 ms)
1x ResolveAllReferences RimWorld.EntityCategoryDef -> 0.009 ms (total (w/children): 0.010 ms)
1x ResolveAllReferences RimWorld.GatheringDef -> 0.009 ms (total (w/children): 0.011 ms)
1x ResolveAllReferences RimWorld.MeditationFocusDef -> 0.009 ms (total (w/children): 0.011 ms)
1x ResolveAllReferences Verse.ManeuverDef -> 0.009 ms (total (w/children): 0.011 ms)
1x ResolveAllReferences RimWorld.IncidentCategoryDef -> 0.009 ms (total (w/children): 0.011 ms)
1x ResolveAllReferences RimWorld.IncidentTargetTagDef -> 0.009 ms (total (w/children): 0.011 ms)
1x ResolveAllReferences RimWorld.PsychicRitualDef_PleasurePulse -> 0.009 ms (total (w/children): 0.011 ms)
1x ResolveAllReferences RimWorld.BabyPlayDef -> 0.009 ms (total (w/children): 0.010 ms)
1x ResolveAllReferences RimWorld.ChemicalDef -> 0.009 ms (total (w/children): 0.011 ms)
1x ResolveAllReferences RimWorld.HistoryAutoRecorderDef -> 0.009 ms (total (w/children): 0.011 ms)
1x ResolveAllReferences RimWorld.PsychicRitualDef_ImbueDeathRefusal -> 0.009 ms (total (w/children): 0.011 ms)
1x ResolveAllReferences RimWorld.DifficultyDef -> 0.009 ms (total (w/children): 0.011 ms)
1x ResolveAllReferences Verse.TerrainAffordanceDef -> 0.009 ms (total (w/children): 0.011 ms)
1x ResolveAllReferences Verse.DrawStyleCategoryDef -> 0.009 ms (total (w/children): 0.012 ms)
1x Loading Ludeon.RimWorld.Odyssey content -> 0.009 ms (total (w/children): 0.009 ms)
1x ResolveAllReferences Verse.MessageTypeDef -> 0.009 ms (total (w/children): 0.011 ms)
1x ResolveAllReferences RimWorld.PsychicRitualDef_Brainwipe -> 0.009 ms (total (w/children): 0.012 ms)
1x ResolveAllReferences RimWorld.BossgroupDef -> 0.009 ms (total (w/children): 0.010 ms)
1x ResolveAllReferences RimWorld.LandingOutcomeDef -> 0.009 ms (total (w/children): 0.010 ms)
1x Loading Ludeon.RimWorld.Ideology -> 0.008 ms (total (w/children): 85.191 ms)
1x ResolveAllReferences Verse.IdeoStoryPatternDef -> 0.008 ms (total (w/children): 0.010 ms)
1x ResolveAllReferences RimWorld.RoyalTitleDef -> 0.008 ms (total (w/children): 0.011 ms)
1x ResolveAllReferences RimWorld.PsychicRitualRoleDef -> 0.008 ms (total (w/children): 0.010 ms)
1x ResolveAllReferences RimWorld.StuffCategoryDef -> 0.008 ms (total (w/children): 0.010 ms)
1x ResolveAllReferences Verse.ApparelLayerDef -> 0.008 ms (total (w/children): 0.010 ms)
1x ResolveAllReferences Verse.MechWeightClassDef -> 0.008 ms (total (w/children): 0.010 ms)
1x ResolveAllReferences AlienRace.RaceSettings -> 0.008 ms (total (w/children): 0.010 ms)
1x ResolveAllReferences Verse.RoomRoleDef -> 0.008 ms (total (w/children): 0.011 ms)
1x ResolveAllReferences RimWorld.MainButtonDef -> 0.008 ms (total (w/children): 0.011 ms)
1x ResolveAllReferences RimWorld.AbilityCategoryDef -> 0.008 ms (total (w/children): 0.010 ms)
1x ResolveAllReferences RimWorld.RaidStrategyDef -> 0.008 ms (total (w/children): 0.010 ms)
1x ResolveAllReferences RimWorld.SkillDef -> 0.008 ms (total (w/children): 0.033 ms)
1x ResolveAllReferences RimWorld.HediffGiverSetDef -> 0.008 ms (total (w/children): 0.010 ms)
1x ResolveAllReferences RimWorld.PrisonerInteractionModeDef -> 0.008 ms (total (w/children): 0.011 ms)
1x ResolveAllReferences Verse.ImplementOwnerTypeDef -> 0.008 ms (total (w/children): 0.010 ms)
1x ResolveAllReferences RimWorld.PsychicRitualDef -> 0.008 ms (total (w/children): 0.008 ms)
1x ResolveAllReferences RimWorld.RoadWorldLayerDef -> 0.008 ms (total (w/children): 0.010 ms)
1x ResolveAllReferences RimWorld.StyleItemDef -> 0.008 ms (total (w/children): 0.008 ms)
1x ResolveAllReferences RimWorld.GeneratedLocationDef -> 0.008 ms (total (w/children): 0.009 ms)
1x ResolveAllReferences RimWorld.RoyalTitlePermitDef -> 0.008 ms (total (w/children): 0.011 ms)
1x ResolveAllReferences RimWorld.AnomalyPlaystyleDef -> 0.008 ms (total (w/children): 0.009 ms)
1x ResolveAllReferences RimWorld.GauranlenTreeModeDef -> 0.008 ms (total (w/children): 0.010 ms)
1x ResolveAllReferences RimWorld.AbilityGroupDef -> 0.008 ms (total (w/children): 0.010 ms)
1x ResolveAllReferences RimWorld.MusicSequenceDef -> 0.008 ms (total (w/children): 0.010 ms)
1x ResolveAllReferences RimWorld.PsychicRitualDef_VoidProvocation -> 0.008 ms (total (w/children): 0.009 ms)
1x ResolveAllReferences RimWorld.MutantDef -> 0.008 ms (total (w/children): 0.045 ms)
1x ResolveAllReferences RimWorld.TransferableSorterDef -> 0.008 ms (total (w/children): 0.010 ms)
1x Loading Ludeon.RimWorld.Anomaly content -> 0.008 ms (total (w/children): 0.008 ms)
1x ResolveAllReferences RimWorld.BillRepeatModeDef -> 0.008 ms (total (w/children): 0.009 ms)
1x ResolveAllReferences Verse.KeyBindingCategoryDef -> 0.008 ms (total (w/children): 0.010 ms)
1x ResolveAllReferences RimWorld.LearningDesireDef -> 0.008 ms (total (w/children): 0.010 ms)
1x ResolveAllReferences RimWorld.ShipJobDef -> 0.008 ms (total (w/children): 0.010 ms)
1x ResolveAllReferences Verse.RoomStatDef -> 0.008 ms (total (w/children): 0.010 ms)
1x ResolveAllReferences RimWorld.PsychicRitualDef_Psychophagy -> 0.008 ms (total (w/children): 0.010 ms)
1x ResolveAllReferences RimWorld.GeneTemplateDef -> 0.008 ms (total (w/children): 0.009 ms)
1x ResolveAllReferences RimWorld.DebugTabMenuDef -> 0.008 ms (total (w/children): 0.010 ms)
1x ResolveAllReferences RimWorld.InfectionPathwayDef -> 0.008 ms (total (w/children): 0.010 ms)
1x Resolve references. -> 0.008 ms (total (w/children): 476.244 ms)
1x ResolveAllReferences Verse.DamageArmorCategoryDef -> 0.008 ms (total (w/children): 0.009 ms)
1x ResolveAllReferences RimWorld.FleshTypeDef -> 0.008 ms (total (w/children): 0.010 ms)
1x ResolveAllReferences RimWorld.ComplexThreatDef -> 0.008 ms (total (w/children): 0.010 ms)
1x ResolveAllReferences Verse.StuffAppearanceDef -> 0.008 ms (total (w/children): 0.009 ms)
1x ResolveAllReferences RimWorld.PsychicRitualDef_Philophagy -> 0.008 ms (total (w/children): 0.010 ms)
1x ResolveAllReferences RimWorld.RitualTargetFilterDef -> 0.008 ms (total (w/children): 0.009 ms)
1x ResolveAllReferences RimWorld.ScenarioDef -> 0.008 ms (total (w/children): 0.010 ms)
1x ResolveAllReferences RimWorld.TrainableDef -> 0.008 ms (total (w/children): 0.010 ms)
1x ResolveAllReferences RimWorld.BossDef -> 0.008 ms (total (w/children): 0.009 ms)
1x ResolveAllReferences RimWorld.JoyKindDef -> 0.008 ms (total (w/children): 0.010 ms)
1x ResolveAllReferences Verse.DrawStyleDef -> 0.008 ms (total (w/children): 0.010 ms)
1x ResolveAllReferences RimWorld.ResearchTabDef -> 0.008 ms (total (w/children): 0.009 ms)
1x ResolveAllReferences RimWorld.RiverDef -> 0.008 ms (total (w/children): 0.009 ms)
1x ResolveAllReferences RimWorld.SlaveInteractionModeDef -> 0.008 ms (total (w/children): 0.009 ms)
1x ResolveAllReferences Verse.CreepJoinerRejectionDef -> 0.007 ms (total (w/children): 0.009 ms)
1x Loading Ludeon.RimWorld.Biotech content -> 0.007 ms (total (w/children): 0.007 ms)
1x ResolveAllReferences Verse.InventoryStockGroupDef -> 0.007 ms (total (w/children): 0.009 ms)
1x ResolveAllReferences RimWorld.PsychicRitualDef_Chronophagy -> 0.007 ms (total (w/children): 0.010 ms)
1x ResolveAllReferences RimWorld.FurDef -> 0.007 ms (total (w/children): 0.009 ms)
1x ResolveAllReferences RimWorld.GravshipComponentTypeDef -> 0.007 ms (total (w/children): 0.009 ms)
1x ResolveAllReferences RimWorld.MemeGroupDef -> 0.007 ms (total (w/children): 0.009 ms)
1x ResolveAllReferences RimWorld.MusicTransitionDef -> 0.007 ms (total (w/children): 0.009 ms)
1x ResolveAllReferences Verse.PawnCapacityDef -> 0.007 ms (total (w/children): 0.010 ms)
1x ResolveAllReferences RimWorld.PsychicRitualDef_SkipAbduction -> 0.007 ms (total (w/children): 0.009 ms)
1x ResolveAllReferences RimWorld.InspirationDef -> 0.007 ms (total (w/children): 0.009 ms)
1x ResolveAllReferences RimWorld.RoadDef -> 0.007 ms (total (w/children): 0.009 ms)
1x ResolveAllReferences Verse.LogEntryDef -> 0.007 ms (total (w/children): 0.009 ms)
1x ResolveAllReferences RimWorld.IdeoPresetCategoryDef -> 0.007 ms (total (w/children): 0.009 ms)
1x ResolveAllReferences RimWorld.RaidAgeRestrictionDef -> 0.007 ms (total (w/children): 0.009 ms)
1x ResolveAllReferences RimWorld.ComplexLayoutDef -> 0.007 ms (total (w/children): 0.009 ms)
1x ResolveAllReferences Verse.MechWorkModeDef -> 0.007 ms (total (w/children): 0.009 ms)
1x ResolveAllReferences RimWorld.PsychicRitualDef_SummonAnimals -> 0.007 ms (total (w/children): 0.010 ms)
1x Loading Ludeon.RimWorld.Biotech -> 0.007 ms (total (w/children): 32.340 ms)
1x ResolveAllReferences Verse.OrbitalDebrisDef -> 0.007 ms (total (w/children): 0.008 ms)
1x ResolveAllReferences Verse.RoofDef -> 0.007 ms (total (w/children): 0.009 ms)
1x ResolveAllReferences RimWorld.RenderSkipFlagDef -> 0.007 ms (total (w/children): 0.009 ms)
1x ResolveAllReferences RimWorld.RoomPart_GestationTankDef -> 0.007 ms (total (w/children): 0.008 ms)
1x ResolveAllReferences Verse.PathGridDef -> 0.007 ms (total (w/children): 0.009 ms)
1x ResolveAllReferences RimWorld.IdeoFoundationDef -> 0.007 ms (total (w/children): 0.009 ms)
1x ResolveAllReferences RimWorld.RoomPart_CrateDef -> 0.007 ms (total (w/children): 0.009 ms)
1x ResolveAllReferences RimWorld.WorkGiverEquivalenceGroupDef -> 0.007 ms (total (w/children): 0.009 ms)
1x ResolveAllReferences AlienRace.AlienBackstoryDef -> 0.007 ms (total (w/children): 0.007 ms)
1x ResolveAllReferences RimWorld.PsychicRitualDef_SummonShamblers -> 0.007 ms (total (w/children): 0.010 ms)
1x ResolveAllReferences Verse.MentalFitDef -> 0.007 ms (total (w/children): 0.008 ms)
1x ResolveAllReferences RimWorld.PsychicRitualRoleDef_DeathRefusalTarget -> 0.007 ms (total (w/children): 0.008 ms)
1x ResolveAllReferences RimWorld.GlobalWorldDrawLayerDef -> 0.007 ms (total (w/children): 0.009 ms)
1x ResolveAllReferences RimWorld.HistoryAutoRecorderGroupDef -> 0.007 ms (total (w/children): 0.009 ms)
1x ResolveAllReferences RimWorld.SurgeryOutcomeEffectDef -> 0.007 ms (total (w/children): 0.009 ms)
1x ResolveAllReferences Verse.ResearchProjectTagDef -> 0.007 ms (total (w/children): 0.009 ms)
1x ResolveAllReferences RimWorld.MonolithLevelDef -> 0.007 ms (total (w/children): 0.009 ms)
1x ResolveAllReferences RimWorld.TransportShipDef -> 0.007 ms (total (w/children): 0.009 ms)
1x ResolveAllReferences RimWorld.RoadPathingDef -> 0.007 ms (total (w/children): 0.009 ms)
1x ResolveAllReferences RimWorld.PsychicRitualDef_SummonFleshbeasts -> 0.007 ms (total (w/children): 0.008 ms)
1x ResolveAllReferences RimWorld.LayoutDef -> 0.007 ms (total (w/children): 0.008 ms)
1x ResolveAllReferences RimWorld.StorytellerDef -> 0.007 ms (total (w/children): 0.102 ms)
1x ResolveAllReferences RimWorld.PsychicRitualDef_NeurosisPulse -> 0.007 ms (total (w/children): 0.010 ms)
1x ResolveAllReferences RimWorld.IdeoSymbolPartDef -> 0.007 ms (total (w/children): 0.007 ms)
1x ResolveAllReferences RimWorld.RoomPart_BarricadeDef -> 0.007 ms (total (w/children): 0.008 ms)
1x ResolveAllReferences RimWorld.PsychicRitualDef_SummonPitGate -> 0.007 ms (total (w/children): 0.009 ms)
1x ResolveAllReferences RimWorld.BillStoreModeDef -> 0.007 ms (total (w/children): 0.008 ms)
1x ResolveAllReferences RimWorld.RoomPart_ThingDef -> 0.007 ms (total (w/children): 0.008 ms)
1x ResolveAllReferences AlienRace.PawnBioDef -> 0.007 ms (total (w/children): 0.263 ms)
1x ResolveAllReferences Verse.GameSetupStepDef -> 0.007 ms (total (w/children): 0.008 ms)
1x ResolveAllReferences Verse.ReservationLayerDef -> 0.007 ms (total (w/children): 0.008 ms)
1x ResolveAllReferences RimWorld.TerrainTemplateDef -> 0.006 ms (total (w/children): 0.008 ms)
1x ResolveAllReferences Verse.OrderedTakeGroupDef -> 0.006 ms (total (w/children): 0.008 ms)
1x Resolve cross-references between non-implied Defs. -> 0.006 ms (total (w/children): 79.603 ms)
1x Loading Ludeon.RimWorld.Anomaly -> 0.006 ms (total (w/children): 42.259 ms)
1x Loading Ludeon.RimWorld.Odyssey -> 0.006 ms (total (w/children): 47.355 ms)
1x ResolveAllReferences RimWorld.PitGateIncidentDef -> 0.006 ms (total (w/children): 0.007 ms)
1x Loading Ludeon.RimWorld -> 0.006 ms (total (w/children): 161.168 ms)
1x Loading Ludeon.RimWorld.Royalty -> 0.006 ms (total (w/children): 32.159 ms)
1x Resolve cross-references between Defs made by the implied defs. -> 0.006 ms (total (w/children): 0.107 ms)
1x Loading erdelf.HumanoidAlienRaces -> 0.004 ms (total (w/children): 2.489 ms)
1x Loading Atlas.AndroidTiers -> 0.004 ms (total (w/children): 19.444 ms)
1x Loading CarnySenpai.EnableOversizedWeapons -> 0.002 ms (total (w/children): 0.037 ms)

UnityEngine.StackTraceUtility:ExtractStackTrace ()
Verse.Log:Message (string)
Verse.ThreadLocalDeepProfiler:Output (Verse.ThreadLocalDeepProfiler/Watcher)
Verse.ThreadLocalDeepProfiler:End ()
Verse.DeepProfiler:End ()
Verse.PlayDataLoader:LoadAllPlayData (bool)
Verse.Root/<>c:<Start>b__10_1 ()
Verse.LongEventHandler:RunEventFromAnotherThread (System.Action)
Verse.LongEventHandler/<>c:<UpdateCurrentAsynchronousEvent>b__28_0 ()
System.Threading.ThreadHelper:ThreadStart_Context (object)
System.Threading.ExecutionContext:RunInternal (System.Threading.ExecutionContext,System.Threading.ContextCallback,object,bool)
System.Threading.ExecutionContext:Run (System.Threading.ExecutionContext,System.Threading.ContextCallback,object,bool)
System.Threading.ExecutionContext:Run (System.Threading.ExecutionContext,System.Threading.ContextCallback,object)
System.Threading.ThreadHelper:ThreadStart ()

Texture ATPP_SkyMindLAN.png is being reloaded with reduced mipmap count (clamped to 1) due to non-power-of-two dimensions: (128x748). This will be slower to load, and will look worse when zoomed out. Consider using a power-of-two texture size instead.
UnityEngine.StackTraceUtility:ExtractStackTrace ()
Verse.Log:Warning (string)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadTextureViaImageConversion (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadTexture (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadItem (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1/<LoadAllForMod>d__4<UnityEngine.Texture2D>:MoveNext ()
Verse.ModContentHolder`1<UnityEngine.Texture2D>:ReloadAll (bool)
Verse.ModContentPack:ReloadContentInt (bool)
Verse.ModContentPack/<>c__DisplayClass56_0:<ReloadContent>b__0 ()
Verse.LongEventHandler:ExecuteToExecuteWhenFinished ()
Verse.LongEventHandler:UpdateCurrentAsynchronousEvent ()
Verse.LongEventHandler:LongEventsUpdate (bool&)
Verse.Root:Update ()
Verse.Root_Entry:Update ()

Texture ATPP_SkyMindRelay.png is being reloaded with reduced mipmap count (clamped to 1) due to non-power-of-two dimensions: (128x748). This will be slower to load, and will look worse when zoomed out. Consider using a power-of-two texture size instead.
UnityEngine.StackTraceUtility:ExtractStackTrace ()
Verse.Log:Warning (string)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadTextureViaImageConversion (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadTexture (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadItem (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1/<LoadAllForMod>d__4<UnityEngine.Texture2D>:MoveNext ()
Verse.ModContentHolder`1<UnityEngine.Texture2D>:ReloadAll (bool)
Verse.ModContentPack:ReloadContentInt (bool)
Verse.ModContentPack/<>c__DisplayClass56_0:<ReloadContent>b__0 ()
Verse.LongEventHandler:ExecuteToExecuteWhenFinished ()
Verse.LongEventHandler:UpdateCurrentAsynchronousEvent ()
Verse.LongEventHandler:LongEventsUpdate (bool&)
Verse.Root:Update ()
Verse.Root_Entry:Update ()

Texture ATPP_SkyMindWAN.png is being reloaded with reduced mipmap count (clamped to 2) due to non-power-of-two dimensions: (192x1160). This will be slower to load, and will look worse when zoomed out. Consider using a power-of-two texture size instead.
UnityEngine.StackTraceUtility:ExtractStackTrace ()
Verse.Log:Warning (string)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadTextureViaImageConversion (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadTexture (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadItem (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1/<LoadAllForMod>d__4<UnityEngine.Texture2D>:MoveNext ()
Verse.ModContentHolder`1<UnityEngine.Texture2D>:ReloadAll (bool)
Verse.ModContentPack:ReloadContentInt (bool)
Verse.ModContentPack/<>c__DisplayClass56_0:<ReloadContent>b__0 ()
Verse.LongEventHandler:ExecuteToExecuteWhenFinished ()
Verse.LongEventHandler:UpdateCurrentAsynchronousEvent ()
Verse.LongEventHandler:LongEventsUpdate (bool&)
Verse.Root:Update ()
Verse.Root_Entry:Update ()

Texture CapsuleRound_a.png is being reloaded with reduced mipmap count (clamped to 1) due to non-power-of-two dimensions: (124x124). This will be slower to load, and will look worse when zoomed out. Consider using a power-of-two texture size instead.
UnityEngine.StackTraceUtility:ExtractStackTrace ()
Verse.Log:Warning (string)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadTextureViaImageConversion (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadTexture (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadItem (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1/<LoadAllForMod>d__4<UnityEngine.Texture2D>:MoveNext ()
Verse.ModContentHolder`1<UnityEngine.Texture2D>:ReloadAll (bool)
Verse.ModContentPack:ReloadContentInt (bool)
Verse.ModContentPack/<>c__DisplayClass56_0:<ReloadContent>b__0 ()
Verse.LongEventHandler:ExecuteToExecuteWhenFinished ()
Verse.LongEventHandler:UpdateCurrentAsynchronousEvent ()
Verse.LongEventHandler:LongEventsUpdate (bool&)
Verse.Root:Update ()
Verse.Root_Entry:Update ()

Texture CapsuleRound_b.png is being reloaded with reduced mipmap count (clamped to 1) due to non-power-of-two dimensions: (124x124). This will be slower to load, and will look worse when zoomed out. Consider using a power-of-two texture size instead.
UnityEngine.StackTraceUtility:ExtractStackTrace ()
Verse.Log:Warning (string)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadTextureViaImageConversion (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadTexture (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadItem (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1/<LoadAllForMod>d__4<UnityEngine.Texture2D>:MoveNext ()
Verse.ModContentHolder`1<UnityEngine.Texture2D>:ReloadAll (bool)
Verse.ModContentPack:ReloadContentInt (bool)
Verse.ModContentPack/<>c__DisplayClass56_0:<ReloadContent>b__0 ()
Verse.LongEventHandler:ExecuteToExecuteWhenFinished ()
Verse.LongEventHandler:UpdateCurrentAsynchronousEvent ()
Verse.LongEventHandler:LongEventsUpdate (bool&)
Verse.Root:Update ()
Verse.Root_Entry:Update ()

Texture Nanoswarm_shell.png is being reloaded with reduced mipmap count (clamped to 1) due to non-power-of-two dimensions: (202x197). This will be slower to load, and will look worse when zoomed out. Consider using a power-of-two texture size instead.
UnityEngine.StackTraceUtility:ExtractStackTrace ()
Verse.Log:Warning (string)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadTextureViaImageConversion (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadTexture (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadItem (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1/<LoadAllForMod>d__4<UnityEngine.Texture2D>:MoveNext ()
Verse.ModContentHolder`1<UnityEngine.Texture2D>:ReloadAll (bool)
Verse.ModContentPack:ReloadContentInt (bool)
Verse.ModContentPack/<>c__DisplayClass56_0:<ReloadContent>b__0 ()
Verse.LongEventHandler:ExecuteToExecuteWhenFinished ()
Verse.LongEventHandler:UpdateCurrentAsynchronousEvent ()
Verse.LongEventHandler:LongEventsUpdate (bool&)
Verse.Root:Update ()
Verse.Root_Entry:Update ()

Texture UnfinishedAndroid.png is being reloaded with reduced mipmap count (clamped to 1) due to non-power-of-two dimensions: (126x324). This will be slower to load, and will look worse when zoomed out. Consider using a power-of-two texture size instead.
UnityEngine.StackTraceUtility:ExtractStackTrace ()
Verse.Log:Warning (string)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadTextureViaImageConversion (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadTexture (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadItem (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1/<LoadAllForMod>d__4<UnityEngine.Texture2D>:MoveNext ()
Verse.ModContentHolder`1<UnityEngine.Texture2D>:ReloadAll (bool)
Verse.ModContentPack:ReloadContentInt (bool)
Verse.ModContentPack/<>c__DisplayClass56_0:<ReloadContent>b__0 ()
Verse.LongEventHandler:ExecuteToExecuteWhenFinished ()
Verse.LongEventHandler:UpdateCurrentAsynchronousEvent ()
Verse.LongEventHandler:LongEventsUpdate (bool&)
Verse.Root:Update ()
Verse.Root_Entry:Update ()

Texture ATPP_chip1.png is being reloaded with reduced mipmap count (clamped to 1) due to non-power-of-two dimensions: (100x100). This will be slower to load, and will look worse when zoomed out. Consider using a power-of-two texture size instead.
UnityEngine.StackTraceUtility:ExtractStackTrace ()
Verse.Log:Warning (string)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadTextureViaImageConversion (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadTexture (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadItem (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1/<LoadAllForMod>d__4<UnityEngine.Texture2D>:MoveNext ()
Verse.ModContentHolder`1<UnityEngine.Texture2D>:ReloadAll (bool)
Verse.ModContentPack:ReloadContentInt (bool)
Verse.ModContentPack/<>c__DisplayClass56_0:<ReloadContent>b__0 ()
Verse.LongEventHandler:ExecuteToExecuteWhenFinished ()
Verse.LongEventHandler:UpdateCurrentAsynchronousEvent ()
Verse.LongEventHandler:LongEventsUpdate (bool&)
Verse.Root:Update ()
Verse.Root_Entry:Update ()

Texture ATPP_chip2.png is being reloaded with reduced mipmap count (clamped to 1) due to non-power-of-two dimensions: (100x100). This will be slower to load, and will look worse when zoomed out. Consider using a power-of-two texture size instead.
UnityEngine.StackTraceUtility:ExtractStackTrace ()
Verse.Log:Warning (string)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadTextureViaImageConversion (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadTexture (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadItem (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1/<LoadAllForMod>d__4<UnityEngine.Texture2D>:MoveNext ()
Verse.ModContentHolder`1<UnityEngine.Texture2D>:ReloadAll (bool)
Verse.ModContentPack:ReloadContentInt (bool)
Verse.ModContentPack/<>c__DisplayClass56_0:<ReloadContent>b__0 ()
Verse.LongEventHandler:ExecuteToExecuteWhenFinished ()
Verse.LongEventHandler:UpdateCurrentAsynchronousEvent ()
Verse.LongEventHandler:LongEventsUpdate (bool&)
Verse.Root:Update ()
Verse.Root_Entry:Update ()

Texture ATPP_chip3.png is being reloaded with reduced mipmap count (clamped to 1) due to non-power-of-two dimensions: (100x100). This will be slower to load, and will look worse when zoomed out. Consider using a power-of-two texture size instead.
UnityEngine.StackTraceUtility:ExtractStackTrace ()
Verse.Log:Warning (string)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadTextureViaImageConversion (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadTexture (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadItem (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1/<LoadAllForMod>d__4<UnityEngine.Texture2D>:MoveNext ()
Verse.ModContentHolder`1<UnityEngine.Texture2D>:ReloadAll (bool)
Verse.ModContentPack:ReloadContentInt (bool)
Verse.ModContentPack/<>c__DisplayClass56_0:<ReloadContent>b__0 ()
Verse.LongEventHandler:ExecuteToExecuteWhenFinished ()
Verse.LongEventHandler:UpdateCurrentAsynchronousEvent ()
Verse.LongEventHandler:LongEventsUpdate (bool&)
Verse.Root:Update ()
Verse.Root_Entry:Update ()

Texture ATPP_chip4.png is being reloaded with reduced mipmap count (clamped to 1) due to non-power-of-two dimensions: (100x100). This will be slower to load, and will look worse when zoomed out. Consider using a power-of-two texture size instead.
UnityEngine.StackTraceUtility:ExtractStackTrace ()
Verse.Log:Warning (string)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadTextureViaImageConversion (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadTexture (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadItem (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1/<LoadAllForMod>d__4<UnityEngine.Texture2D>:MoveNext ()
Verse.ModContentHolder`1<UnityEngine.Texture2D>:ReloadAll (bool)
Verse.ModContentPack:ReloadContentInt (bool)
Verse.ModContentPack/<>c__DisplayClass56_0:<ReloadContent>b__0 ()
Verse.LongEventHandler:ExecuteToExecuteWhenFinished ()
Verse.LongEventHandler:UpdateCurrentAsynchronousEvent ()
Verse.LongEventHandler:LongEventsUpdate (bool&)
Verse.Root:Update ()
Verse.Root_Entry:Update ()

Texture ATPP_NoCare.png is being reloaded with reduced mipmap count (clamped to 1) due to non-power-of-two dimensions: (28x28). This will be slower to load, and will look worse when zoomed out. Consider using a power-of-two texture size instead.
UnityEngine.StackTraceUtility:ExtractStackTrace ()
Verse.Log:Warning (string)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadTextureViaImageConversion (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadTexture (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadItem (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1/<LoadAllForMod>d__4<UnityEngine.Texture2D>:MoveNext ()
Verse.ModContentHolder`1<UnityEngine.Texture2D>:ReloadAll (bool)
Verse.ModContentPack:ReloadContentInt (bool)
Verse.ModContentPack/<>c__DisplayClass56_0:<ReloadContent>b__0 ()
Verse.LongEventHandler:ExecuteToExecuteWhenFinished ()
Verse.LongEventHandler:UpdateCurrentAsynchronousEvent ()
Verse.LongEventHandler:LongEventsUpdate (bool&)
Verse.Root:Update ()
Verse.Root_Entry:Update ()

Texture ATPP_OnlyDocVisit.png is being reloaded with reduced mipmap count (clamped to 1) due to non-power-of-two dimensions: (28x28). This will be slower to load, and will look worse when zoomed out. Consider using a power-of-two texture size instead.
UnityEngine.StackTraceUtility:ExtractStackTrace ()
Verse.Log:Warning (string)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadTextureViaImageConversion (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadTexture (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadItem (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1/<LoadAllForMod>d__4<UnityEngine.Texture2D>:MoveNext ()
Verse.ModContentHolder`1<UnityEngine.Texture2D>:ReloadAll (bool)
Verse.ModContentPack:ReloadContentInt (bool)
Verse.ModContentPack/<>c__DisplayClass56_0:<ReloadContent>b__0 ()
Verse.LongEventHandler:ExecuteToExecuteWhenFinished ()
Verse.LongEventHandler:UpdateCurrentAsynchronousEvent ()
Verse.LongEventHandler:LongEventsUpdate (bool&)
Verse.Root:Update ()
Verse.Root_Entry:Update ()

Texture ATPP_PassionMajor.png is being reloaded with reduced mipmap count (clamped to 2) due to non-power-of-two dimensions: (24x24). This will be slower to load, and will look worse when zoomed out. Consider using a power-of-two texture size instead.
UnityEngine.StackTraceUtility:ExtractStackTrace ()
Verse.Log:Warning (string)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadTextureViaImageConversion (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadTexture (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadItem (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1/<LoadAllForMod>d__4<UnityEngine.Texture2D>:MoveNext ()
Verse.ModContentHolder`1<UnityEngine.Texture2D>:ReloadAll (bool)
Verse.ModContentPack:ReloadContentInt (bool)
Verse.ModContentPack/<>c__DisplayClass56_0:<ReloadContent>b__0 ()
Verse.LongEventHandler:ExecuteToExecuteWhenFinished ()
Verse.LongEventHandler:UpdateCurrentAsynchronousEvent ()
Verse.LongEventHandler:LongEventsUpdate (bool&)
Verse.Root:Update ()
Verse.Root_Entry:Update ()

Texture ATPP_PassionMinor.png is being reloaded with reduced mipmap count (clamped to 2) due to non-power-of-two dimensions: (24x24). This will be slower to load, and will look worse when zoomed out. Consider using a power-of-two texture size instead.
UnityEngine.StackTraceUtility:ExtractStackTrace ()
Verse.Log:Warning (string)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadTextureViaImageConversion (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadTexture (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadItem (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1/<LoadAllForMod>d__4<UnityEngine.Texture2D>:MoveNext ()
Verse.ModContentHolder`1<UnityEngine.Texture2D>:ReloadAll (bool)
Verse.ModContentPack:ReloadContentInt (bool)
Verse.ModContentPack/<>c__DisplayClass56_0:<ReloadContent>b__0 ()
Verse.LongEventHandler:ExecuteToExecuteWhenFinished ()
Verse.LongEventHandler:UpdateCurrentAsynchronousEvent ()
Verse.LongEventHandler:LongEventsUpdate (bool&)
Verse.Root:Update ()
Verse.Root_Entry:Update ()

Texture ATPP_PassionMinorGray.png is being reloaded with reduced mipmap count (clamped to 2) due to non-power-of-two dimensions: (24x24). This will be slower to load, and will look worse when zoomed out. Consider using a power-of-two texture size instead.
UnityEngine.StackTraceUtility:ExtractStackTrace ()
Verse.Log:Warning (string)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadTextureViaImageConversion (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadTexture (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadItem (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1/<LoadAllForMod>d__4<UnityEngine.Texture2D>:MoveNext ()
Verse.ModContentHolder`1<UnityEngine.Texture2D>:ReloadAll (bool)
Verse.ModContentPack:ReloadContentInt (bool)
Verse.ModContentPack/<>c__DisplayClass56_0:<ReloadContent>b__0 ()
Verse.LongEventHandler:ExecuteToExecuteWhenFinished ()
Verse.LongEventHandler:UpdateCurrentAsynchronousEvent ()
Verse.LongEventHandler:LongEventsUpdate (bool&)
Verse.Root:Update ()
Verse.Root_Entry:Update ()

Texture ATPP_PassionMinorGrayDisabled.png is being reloaded with reduced mipmap count (clamped to 2) due to non-power-of-two dimensions: (24x24). This will be slower to load, and will look worse when zoomed out. Consider using a power-of-two texture size instead.
UnityEngine.StackTraceUtility:ExtractStackTrace ()
Verse.Log:Warning (string)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadTextureViaImageConversion (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadTexture (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadItem (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1/<LoadAllForMod>d__4<UnityEngine.Texture2D>:MoveNext ()
Verse.ModContentHolder`1<UnityEngine.Texture2D>:ReloadAll (bool)
Verse.ModContentPack:ReloadContentInt (bool)
Verse.ModContentPack/<>c__DisplayClass56_0:<ReloadContent>b__0 ()
Verse.LongEventHandler:ExecuteToExecuteWhenFinished ()
Verse.LongEventHandler:UpdateCurrentAsynchronousEvent ()
Verse.LongEventHandler:LongEventsUpdate (bool&)
Verse.Root:Update ()
Verse.Root_Entry:Update ()

Texture ATPP_RX.png is being reloaded with reduced mipmap count (clamped to 1) due to non-power-of-two dimensions: (100x100). This will be slower to load, and will look worse when zoomed out. Consider using a power-of-two texture size instead.
UnityEngine.StackTraceUtility:ExtractStackTrace ()
Verse.Log:Warning (string)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadTextureViaImageConversion (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadTexture (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadItem (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1/<LoadAllForMod>d__4<UnityEngine.Texture2D>:MoveNext ()
Verse.ModContentHolder`1<UnityEngine.Texture2D>:ReloadAll (bool)
Verse.ModContentPack:ReloadContentInt (bool)
Verse.ModContentPack/<>c__DisplayClass56_0:<ReloadContent>b__0 ()
Verse.LongEventHandler:ExecuteToExecuteWhenFinished ()
Verse.LongEventHandler:UpdateCurrentAsynchronousEvent ()
Verse.LongEventHandler:LongEventsUpdate (bool&)
Verse.Root:Update ()
Verse.Root_Entry:Update ()

Texture ATPP_SkillUILogo.png is being reloaded with reduced mipmap count (clamped to 3) due to non-power-of-two dimensions: (480x80). This will be slower to load, and will look worse when zoomed out. Consider using a power-of-two texture size instead.
UnityEngine.StackTraceUtility:ExtractStackTrace ()
Verse.Log:Warning (string)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadTextureViaImageConversion (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadTexture (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadItem (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1/<LoadAllForMod>d__4<UnityEngine.Texture2D>:MoveNext ()
Verse.ModContentHolder`1<UnityEngine.Texture2D>:ReloadAll (bool)
Verse.ModContentPack:ReloadContentInt (bool)
Verse.ModContentPack/<>c__DisplayClass56_0:<ReloadContent>b__0 ()
Verse.LongEventHandler:ExecuteToExecuteWhenFinished ()
Verse.LongEventHandler:UpdateCurrentAsynchronousEvent ()
Verse.LongEventHandler:LongEventsUpdate (bool&)
Verse.Root:Update ()
Verse.Root_Entry:Update ()

Texture ATPP_VX0.png is being reloaded with reduced mipmap count (clamped to 1) due to non-power-of-two dimensions: (100x100). This will be slower to load, and will look worse when zoomed out. Consider using a power-of-two texture size instead.
UnityEngine.StackTraceUtility:ExtractStackTrace ()
Verse.Log:Warning (string)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadTextureViaImageConversion (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadTexture (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadItem (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1/<LoadAllForMod>d__4<UnityEngine.Texture2D>:MoveNext ()
Verse.ModContentHolder`1<UnityEngine.Texture2D>:ReloadAll (bool)
Verse.ModContentPack:ReloadContentInt (bool)
Verse.ModContentPack/<>c__DisplayClass56_0:<ReloadContent>b__0 ()
Verse.LongEventHandler:ExecuteToExecuteWhenFinished ()
Verse.LongEventHandler:UpdateCurrentAsynchronousEvent ()
Verse.LongEventHandler:LongEventsUpdate (bool&)
Verse.Root:Update ()
Verse.Root_Entry:Update ()

Texture ATPP_VX1.png is being reloaded with reduced mipmap count (clamped to 1) due to non-power-of-two dimensions: (100x100). This will be slower to load, and will look worse when zoomed out. Consider using a power-of-two texture size instead.
UnityEngine.StackTraceUtility:ExtractStackTrace ()
Verse.Log:Warning (string)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadTextureViaImageConversion (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadTexture (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadItem (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1/<LoadAllForMod>d__4<UnityEngine.Texture2D>:MoveNext ()
Verse.ModContentHolder`1<UnityEngine.Texture2D>:ReloadAll (bool)
Verse.ModContentPack:ReloadContentInt (bool)
Verse.ModContentPack/<>c__DisplayClass56_0:<ReloadContent>b__0 ()
Verse.LongEventHandler:ExecuteToExecuteWhenFinished ()
Verse.LongEventHandler:UpdateCurrentAsynchronousEvent ()
Verse.LongEventHandler:LongEventsUpdate (bool&)
Verse.Root:Update ()
Verse.Root_Entry:Update ()

Texture ATPP_VX2.png is being reloaded with reduced mipmap count (clamped to 1) due to non-power-of-two dimensions: (100x100). This will be slower to load, and will look worse when zoomed out. Consider using a power-of-two texture size instead.
UnityEngine.StackTraceUtility:ExtractStackTrace ()
Verse.Log:Warning (string)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadTextureViaImageConversion (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadTexture (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadItem (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1/<LoadAllForMod>d__4<UnityEngine.Texture2D>:MoveNext ()
Verse.ModContentHolder`1<UnityEngine.Texture2D>:ReloadAll (bool)
Verse.ModContentPack:ReloadContentInt (bool)
Verse.ModContentPack/<>c__DisplayClass56_0:<ReloadContent>b__0 ()
Verse.LongEventHandler:ExecuteToExecuteWhenFinished ()
Verse.LongEventHandler:UpdateCurrentAsynchronousEvent ()
Verse.LongEventHandler:LongEventsUpdate (bool&)
Verse.Root:Update ()
Verse.Root_Entry:Update ()

Texture ATPP_VX3.png is being reloaded with reduced mipmap count (clamped to 1) due to non-power-of-two dimensions: (100x100). This will be slower to load, and will look worse when zoomed out. Consider using a power-of-two texture size instead.
UnityEngine.StackTraceUtility:ExtractStackTrace ()
Verse.Log:Warning (string)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadTextureViaImageConversion (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadTexture (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadItem (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1/<LoadAllForMod>d__4<UnityEngine.Texture2D>:MoveNext ()
Verse.ModContentHolder`1<UnityEngine.Texture2D>:ReloadAll (bool)
Verse.ModContentPack:ReloadContentInt (bool)
Verse.ModContentPack/<>c__DisplayClass56_0:<ReloadContent>b__0 ()
Verse.LongEventHandler:ExecuteToExecuteWhenFinished ()
Verse.LongEventHandler:UpdateCurrentAsynchronousEvent ()
Verse.LongEventHandler:LongEventsUpdate (bool&)
Verse.Root:Update ()
Verse.Root_Entry:Update ()

Texture SettingsHeader.png is being reloaded with reduced mipmap count (clamped to 4) due to non-power-of-two dimensions: (800x128). This will be slower to load, and will look worse when zoomed out. Consider using a power-of-two texture size instead.
UnityEngine.StackTraceUtility:ExtractStackTrace ()
Verse.Log:Warning (string)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadTextureViaImageConversion (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadTexture (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadItem (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1/<LoadAllForMod>d__4<UnityEngine.Texture2D>:MoveNext ()
Verse.ModContentHolder`1<UnityEngine.Texture2D>:ReloadAll (bool)
Verse.ModContentPack:ReloadContentInt (bool)
Verse.ModContentPack/<>c__DisplayClass56_0:<ReloadContent>b__0 ()
Verse.LongEventHandler:ExecuteToExecuteWhenFinished ()
Verse.LongEventHandler:UpdateCurrentAsynchronousEvent ()
Verse.LongEventHandler:LongEventsUpdate (bool&)
Verse.Root:Update ()
Verse.Root_Entry:Update ()

Texture CoolantLeak.png is being reloaded with reduced mipmap count (clamped to 1) due to non-power-of-two dimensions: (20x20). This will be slower to load, and will look worse when zoomed out. Consider using a power-of-two texture size instead.
UnityEngine.StackTraceUtility:ExtractStackTrace ()
Verse.Log:Warning (string)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadTextureViaImageConversion (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadTexture (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadItem (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1/<LoadAllForMod>d__4<UnityEngine.Texture2D>:MoveNext ()
Verse.ModContentHolder`1<UnityEngine.Texture2D>:ReloadAll (bool)
Verse.ModContentPack:ReloadContentInt (bool)
Verse.ModContentPack/<>c__DisplayClass56_0:<ReloadContent>b__0 ()
Verse.LongEventHandler:ExecuteToExecuteWhenFinished ()
Verse.LongEventHandler:UpdateCurrentAsynchronousEvent ()
Verse.LongEventHandler:LongEventsUpdate (bool&)
Verse.Root:Update ()
Verse.Root_Entry:Update ()

Texture ImplantsTable_east.png is being reloaded with reduced mipmap count (clamped to 4) due to non-power-of-two dimensions: (96x224). This will be slower to load, and will look worse when zoomed out. Consider using a power-of-two texture size instead.
UnityEngine.StackTraceUtility:ExtractStackTrace ()
Verse.Log:Warning (string)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadTextureViaImageConversion (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadTexture (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadItem (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1/<LoadAllForMod>d__4<UnityEngine.Texture2D>:MoveNext ()
Verse.ModContentHolder`1<UnityEngine.Texture2D>:ReloadAll (bool)
Verse.ModContentPack:ReloadContentInt (bool)
Verse.ModContentPack/<>c__DisplayClass56_0:<ReloadContent>b__0 ()
Verse.LongEventHandler:ExecuteToExecuteWhenFinished ()
Verse.LongEventHandler:UpdateCurrentAsynchronousEvent ()
Verse.LongEventHandler:LongEventsUpdate (bool&)
Verse.Root:Update ()
Verse.Root_Entry:Update ()

Texture ImplantsTable_north.png is being reloaded with reduced mipmap count (clamped to 4) due to non-power-of-two dimensions: (224x96). This will be slower to load, and will look worse when zoomed out. Consider using a power-of-two texture size instead.
UnityEngine.StackTraceUtility:ExtractStackTrace ()
Verse.Log:Warning (string)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadTextureViaImageConversion (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadTexture (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadItem (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1/<LoadAllForMod>d__4<UnityEngine.Texture2D>:MoveNext ()
Verse.ModContentHolder`1<UnityEngine.Texture2D>:ReloadAll (bool)
Verse.ModContentPack:ReloadContentInt (bool)
Verse.ModContentPack/<>c__DisplayClass56_0:<ReloadContent>b__0 ()
Verse.LongEventHandler:ExecuteToExecuteWhenFinished ()
Verse.LongEventHandler:UpdateCurrentAsynchronousEvent ()
Verse.LongEventHandler:LongEventsUpdate (bool&)
Verse.Root:Update ()
Verse.Root_Entry:Update ()

Texture ImplantsTable_south.png is being reloaded with reduced mipmap count (clamped to 4) due to non-power-of-two dimensions: (224x96). This will be slower to load, and will look worse when zoomed out. Consider using a power-of-two texture size instead.
UnityEngine.StackTraceUtility:ExtractStackTrace ()
Verse.Log:Warning (string)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadTextureViaImageConversion (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadTexture (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadItem (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1/<LoadAllForMod>d__4<UnityEngine.Texture2D>:MoveNext ()
Verse.ModContentHolder`1<UnityEngine.Texture2D>:ReloadAll (bool)
Verse.ModContentPack:ReloadContentInt (bool)
Verse.ModContentPack/<>c__DisplayClass56_0:<ReloadContent>b__0 ()
Verse.LongEventHandler:ExecuteToExecuteWhenFinished ()
Verse.LongEventHandler:UpdateCurrentAsynchronousEvent ()
Verse.LongEventHandler:LongEventsUpdate (bool&)
Verse.Root:Update ()
Verse.Root_Entry:Update ()

Texture PartsTable_east.png is being reloaded with reduced mipmap count (clamped to 4) due to non-power-of-two dimensions: (96x224). This will be slower to load, and will look worse when zoomed out. Consider using a power-of-two texture size instead.
UnityEngine.StackTraceUtility:ExtractStackTrace ()
Verse.Log:Warning (string)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadTextureViaImageConversion (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadTexture (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadItem (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1/<LoadAllForMod>d__4<UnityEngine.Texture2D>:MoveNext ()
Verse.ModContentHolder`1<UnityEngine.Texture2D>:ReloadAll (bool)
Verse.ModContentPack:ReloadContentInt (bool)
Verse.ModContentPack/<>c__DisplayClass56_0:<ReloadContent>b__0 ()
Verse.LongEventHandler:ExecuteToExecuteWhenFinished ()
Verse.LongEventHandler:UpdateCurrentAsynchronousEvent ()
Verse.LongEventHandler:LongEventsUpdate (bool&)
Verse.Root:Update ()
Verse.Root_Entry:Update ()

Texture PartsTable_north.png is being reloaded with reduced mipmap count (clamped to 4) due to non-power-of-two dimensions: (224x96). This will be slower to load, and will look worse when zoomed out. Consider using a power-of-two texture size instead.
UnityEngine.StackTraceUtility:ExtractStackTrace ()
Verse.Log:Warning (string)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadTextureViaImageConversion (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadTexture (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadItem (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1/<LoadAllForMod>d__4<UnityEngine.Texture2D>:MoveNext ()
Verse.ModContentHolder`1<UnityEngine.Texture2D>:ReloadAll (bool)
Verse.ModContentPack:ReloadContentInt (bool)
Verse.ModContentPack/<>c__DisplayClass56_0:<ReloadContent>b__0 ()
Verse.LongEventHandler:ExecuteToExecuteWhenFinished ()
Verse.LongEventHandler:UpdateCurrentAsynchronousEvent ()
Verse.LongEventHandler:LongEventsUpdate (bool&)
Verse.Root:Update ()
Verse.Root_Entry:Update ()

Texture PartsTable_south.png is being reloaded with reduced mipmap count (clamped to 4) due to non-power-of-two dimensions: (224x96). This will be slower to load, and will look worse when zoomed out. Consider using a power-of-two texture size instead.
UnityEngine.StackTraceUtility:ExtractStackTrace ()
Verse.Log:Warning (string)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadTextureViaImageConversion (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadTexture (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadItem (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1/<LoadAllForMod>d__4<UnityEngine.Texture2D>:MoveNext ()
Verse.ModContentHolder`1<UnityEngine.Texture2D>:ReloadAll (bool)
Verse.ModContentPack:ReloadContentInt (bool)
Verse.ModContentPack/<>c__DisplayClass56_0:<ReloadContent>b__0 ()
Verse.LongEventHandler:ExecuteToExecuteWhenFinished ()
Verse.LongEventHandler:UpdateCurrentAsynchronousEvent ()
Verse.LongEventHandler:LongEventsUpdate (bool&)
Verse.Root:Update ()
Verse.Root_Entry:Update ()

Texture RChicken_east.png is being reloaded with reduced mipmap count (clamped to 1) due to non-power-of-two dimensions: (124x124). This will be slower to load, and will look worse when zoomed out. Consider using a power-of-two texture size instead.
UnityEngine.StackTraceUtility:ExtractStackTrace ()
Verse.Log:Warning (string)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadTextureViaImageConversion (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadTexture (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadItem (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1/<LoadAllForMod>d__4<UnityEngine.Texture2D>:MoveNext ()
Verse.ModContentHolder`1<UnityEngine.Texture2D>:ReloadAll (bool)
Verse.ModContentPack:ReloadContentInt (bool)
Verse.ModContentPack/<>c__DisplayClass56_0:<ReloadContent>b__0 ()
Verse.LongEventHandler:ExecuteToExecuteWhenFinished ()
Verse.LongEventHandler:UpdateCurrentAsynchronousEvent ()
Verse.LongEventHandler:LongEventsUpdate (bool&)
Verse.Root:Update ()
Verse.Root_Entry:Update ()

Texture RChicken_north.png is being reloaded with reduced mipmap count (clamped to 1) due to non-power-of-two dimensions: (124x124). This will be slower to load, and will look worse when zoomed out. Consider using a power-of-two texture size instead.
UnityEngine.StackTraceUtility:ExtractStackTrace ()
Verse.Log:Warning (string)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadTextureViaImageConversion (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadTexture (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadItem (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1/<LoadAllForMod>d__4<UnityEngine.Texture2D>:MoveNext ()
Verse.ModContentHolder`1<UnityEngine.Texture2D>:ReloadAll (bool)
Verse.ModContentPack:ReloadContentInt (bool)
Verse.ModContentPack/<>c__DisplayClass56_0:<ReloadContent>b__0 ()
Verse.LongEventHandler:ExecuteToExecuteWhenFinished ()
Verse.LongEventHandler:UpdateCurrentAsynchronousEvent ()
Verse.LongEventHandler:LongEventsUpdate (bool&)
Verse.Root:Update ()
Verse.Root_Entry:Update ()

Texture RChicken_south.png is being reloaded with reduced mipmap count (clamped to 1) due to non-power-of-two dimensions: (124x124). This will be slower to load, and will look worse when zoomed out. Consider using a power-of-two texture size instead.
UnityEngine.StackTraceUtility:ExtractStackTrace ()
Verse.Log:Warning (string)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadTextureViaImageConversion (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadTexture (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadItem (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1/<LoadAllForMod>d__4<UnityEngine.Texture2D>:MoveNext ()
Verse.ModContentHolder`1<UnityEngine.Texture2D>:ReloadAll (bool)
Verse.ModContentPack:ReloadContentInt (bool)
Verse.ModContentPack/<>c__DisplayClass56_0:<ReloadContent>b__0 ()
Verse.LongEventHandler:ExecuteToExecuteWhenFinished ()
Verse.LongEventHandler:UpdateCurrentAsynchronousEvent ()
Verse.LongEventHandler:LongEventsUpdate (bool&)
Verse.Root:Update ()
Verse.Root_Entry:Update ()

Texture RMilker_east.png is being reloaded with reduced mipmap count (clamped to 3) due to non-power-of-two dimensions: (400x400). This will be slower to load, and will look worse when zoomed out. Consider using a power-of-two texture size instead.
UnityEngine.StackTraceUtility:ExtractStackTrace ()
Verse.Log:Warning (string)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadTextureViaImageConversion (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadTexture (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadItem (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1/<LoadAllForMod>d__4<UnityEngine.Texture2D>:MoveNext ()
Verse.ModContentHolder`1<UnityEngine.Texture2D>:ReloadAll (bool)
Verse.ModContentPack:ReloadContentInt (bool)
Verse.ModContentPack/<>c__DisplayClass56_0:<ReloadContent>b__0 ()
Verse.LongEventHandler:ExecuteToExecuteWhenFinished ()
Verse.LongEventHandler:UpdateCurrentAsynchronousEvent ()
Verse.LongEventHandler:LongEventsUpdate (bool&)
Verse.Root:Update ()
Verse.Root_Entry:Update ()

Texture RMilker_north.png is being reloaded with reduced mipmap count (clamped to 1) due to non-power-of-two dimensions: (290x290). This will be slower to load, and will look worse when zoomed out. Consider using a power-of-two texture size instead.
UnityEngine.StackTraceUtility:ExtractStackTrace ()
Verse.Log:Warning (string)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadTextureViaImageConversion (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadTexture (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadItem (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1/<LoadAllForMod>d__4<UnityEngine.Texture2D>:MoveNext ()
Verse.ModContentHolder`1<UnityEngine.Texture2D>:ReloadAll (bool)
Verse.ModContentPack:ReloadContentInt (bool)
Verse.ModContentPack/<>c__DisplayClass56_0:<ReloadContent>b__0 ()
Verse.LongEventHandler:ExecuteToExecuteWhenFinished ()
Verse.LongEventHandler:UpdateCurrentAsynchronousEvent ()
Verse.LongEventHandler:LongEventsUpdate (bool&)
Verse.Root:Update ()
Verse.Root_Entry:Update ()

Texture RMilker_south.png is being reloaded with reduced mipmap count (clamped to 1) due to non-power-of-two dimensions: (290x290). This will be slower to load, and will look worse when zoomed out. Consider using a power-of-two texture size instead.
UnityEngine.StackTraceUtility:ExtractStackTrace ()
Verse.Log:Warning (string)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadTextureViaImageConversion (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadTexture (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadItem (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1/<LoadAllForMod>d__4<UnityEngine.Texture2D>:MoveNext ()
Verse.ModContentHolder`1<UnityEngine.Texture2D>:ReloadAll (bool)
Verse.ModContentPack:ReloadContentInt (bool)
Verse.ModContentPack/<>c__DisplayClass56_0:<ReloadContent>b__0 ()
Verse.LongEventHandler:ExecuteToExecuteWhenFinished ()
Verse.LongEventHandler:UpdateCurrentAsynchronousEvent ()
Verse.LongEventHandler:LongEventsUpdate (bool&)
Verse.Root:Update ()
Verse.Root_Entry:Update ()

Texture RGrower_east.png is being reloaded with reduced mipmap count (clamped to 1) due to non-power-of-two dimensions: (364x362). This will be slower to load, and will look worse when zoomed out. Consider using a power-of-two texture size instead.
UnityEngine.StackTraceUtility:ExtractStackTrace ()
Verse.Log:Warning (string)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadTextureViaImageConversion (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadTexture (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadItem (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1/<LoadAllForMod>d__4<UnityEngine.Texture2D>:MoveNext ()
Verse.ModContentHolder`1<UnityEngine.Texture2D>:ReloadAll (bool)
Verse.ModContentPack:ReloadContentInt (bool)
Verse.ModContentPack/<>c__DisplayClass56_0:<ReloadContent>b__0 ()
Verse.LongEventHandler:ExecuteToExecuteWhenFinished ()
Verse.LongEventHandler:UpdateCurrentAsynchronousEvent ()
Verse.LongEventHandler:LongEventsUpdate (bool&)
Verse.Root:Update ()
Verse.Root_Entry:Update ()

Texture RGrower_north.png is being reloaded with reduced mipmap count (clamped to 1) due to non-power-of-two dimensions: (286x282). This will be slower to load, and will look worse when zoomed out. Consider using a power-of-two texture size instead.
UnityEngine.StackTraceUtility:ExtractStackTrace ()
Verse.Log:Warning (string)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadTextureViaImageConversion (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadTexture (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadItem (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1/<LoadAllForMod>d__4<UnityEngine.Texture2D>:MoveNext ()
Verse.ModContentHolder`1<UnityEngine.Texture2D>:ReloadAll (bool)
Verse.ModContentPack:ReloadContentInt (bool)
Verse.ModContentPack/<>c__DisplayClass56_0:<ReloadContent>b__0 ()
Verse.LongEventHandler:ExecuteToExecuteWhenFinished ()
Verse.LongEventHandler:UpdateCurrentAsynchronousEvent ()
Verse.LongEventHandler:LongEventsUpdate (bool&)
Verse.Root:Update ()
Verse.Root_Entry:Update ()

Texture RGrower_south.png is being reloaded with reduced mipmap count (clamped to 1) due to non-power-of-two dimensions: (294x284). This will be slower to load, and will look worse when zoomed out. Consider using a power-of-two texture size instead.
UnityEngine.StackTraceUtility:ExtractStackTrace ()
Verse.Log:Warning (string)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadTextureViaImageConversion (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadTexture (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadItem (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1/<LoadAllForMod>d__4<UnityEngine.Texture2D>:MoveNext ()
Verse.ModContentHolder`1<UnityEngine.Texture2D>:ReloadAll (bool)
Verse.ModContentPack:ReloadContentInt (bool)
Verse.ModContentPack/<>c__DisplayClass56_0:<ReloadContent>b__0 ()
Verse.LongEventHandler:ExecuteToExecuteWhenFinished ()
Verse.LongEventHandler:UpdateCurrentAsynchronousEvent ()
Verse.LongEventHandler:LongEventsUpdate (bool&)
Verse.Root:Update ()
Verse.Root_Entry:Update ()

Texture Leaking.png is being reloaded with reduced mipmap count (clamped to 1) due to non-power-of-two dimensions: (20x20). This will be slower to load, and will look worse when zoomed out. Consider using a power-of-two texture size instead.
UnityEngine.StackTraceUtility:ExtractStackTrace ()
Verse.Log:Warning (string)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadTextureViaImageConversion (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadTexture (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadItem (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1/<LoadAllForMod>d__4<UnityEngine.Texture2D>:MoveNext ()
Verse.ModContentHolder`1<UnityEngine.Texture2D>:ReloadAll (bool)
Verse.ModContentPack:ReloadContentInt (bool)
Verse.ModContentPack/<>c__DisplayClass56_0:<ReloadContent>b__0 ()
Verse.LongEventHandler:ExecuteToExecuteWhenFinished ()
Verse.LongEventHandler:UpdateCurrentAsynchronousEvent ()
Verse.LongEventHandler:LongEventsUpdate (bool&)
Verse.Root:Update ()
Verse.Root_Entry:Update ()

Texture Naked_Male_east.png is being reloaded with reduced mipmap count (clamped to 6) due to non-power-of-two dimensions: (384x384). This will be slower to load, and will look worse when zoomed out. Consider using a power-of-two texture size instead.
UnityEngine.StackTraceUtility:ExtractStackTrace ()
Verse.Log:Warning (string)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadTextureViaImageConversion (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadTexture (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadItem (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1/<LoadAllForMod>d__4<UnityEngine.Texture2D>:MoveNext ()
Verse.ModContentHolder`1<UnityEngine.Texture2D>:ReloadAll (bool)
Verse.ModContentPack:ReloadContentInt (bool)
Verse.ModContentPack/<>c__DisplayClass56_0:<ReloadContent>b__0 ()
Verse.LongEventHandler:ExecuteToExecuteWhenFinished ()
Verse.LongEventHandler:UpdateCurrentAsynchronousEvent ()
Verse.LongEventHandler:LongEventsUpdate (bool&)
Verse.Root:Update ()
Verse.Root_Entry:Update ()

Texture Naked_Male_eastm.png is being reloaded with reduced mipmap count (clamped to 6) due to non-power-of-two dimensions: (384x384). This will be slower to load, and will look worse when zoomed out. Consider using a power-of-two texture size instead.
UnityEngine.StackTraceUtility:ExtractStackTrace ()
Verse.Log:Warning (string)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadTextureViaImageConversion (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadTexture (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadItem (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1/<LoadAllForMod>d__4<UnityEngine.Texture2D>:MoveNext ()
Verse.ModContentHolder`1<UnityEngine.Texture2D>:ReloadAll (bool)
Verse.ModContentPack:ReloadContentInt (bool)
Verse.ModContentPack/<>c__DisplayClass56_0:<ReloadContent>b__0 ()
Verse.LongEventHandler:ExecuteToExecuteWhenFinished ()
Verse.LongEventHandler:UpdateCurrentAsynchronousEvent ()
Verse.LongEventHandler:LongEventsUpdate (bool&)
Verse.Root:Update ()
Verse.Root_Entry:Update ()

Texture Naked_Male_north.png is being reloaded with reduced mipmap count (clamped to 6) due to non-power-of-two dimensions: (384x384). This will be slower to load, and will look worse when zoomed out. Consider using a power-of-two texture size instead.
UnityEngine.StackTraceUtility:ExtractStackTrace ()
Verse.Log:Warning (string)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadTextureViaImageConversion (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadTexture (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadItem (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1/<LoadAllForMod>d__4<UnityEngine.Texture2D>:MoveNext ()
Verse.ModContentHolder`1<UnityEngine.Texture2D>:ReloadAll (bool)
Verse.ModContentPack:ReloadContentInt (bool)
Verse.ModContentPack/<>c__DisplayClass56_0:<ReloadContent>b__0 ()
Verse.LongEventHandler:ExecuteToExecuteWhenFinished ()
Verse.LongEventHandler:UpdateCurrentAsynchronousEvent ()
Verse.LongEventHandler:LongEventsUpdate (bool&)
Verse.Root:Update ()
Verse.Root_Entry:Update ()

Texture Naked_Male_northm.png is being reloaded with reduced mipmap count (clamped to 6) due to non-power-of-two dimensions: (384x384). This will be slower to load, and will look worse when zoomed out. Consider using a power-of-two texture size instead.
UnityEngine.StackTraceUtility:ExtractStackTrace ()
Verse.Log:Warning (string)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadTextureViaImageConversion (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadTexture (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadItem (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1/<LoadAllForMod>d__4<UnityEngine.Texture2D>:MoveNext ()
Verse.ModContentHolder`1<UnityEngine.Texture2D>:ReloadAll (bool)
Verse.ModContentPack:ReloadContentInt (bool)
Verse.ModContentPack/<>c__DisplayClass56_0:<ReloadContent>b__0 ()
Verse.LongEventHandler:ExecuteToExecuteWhenFinished ()
Verse.LongEventHandler:UpdateCurrentAsynchronousEvent ()
Verse.LongEventHandler:LongEventsUpdate (bool&)
Verse.Root:Update ()
Verse.Root_Entry:Update ()

Texture Naked_Male_south.png is being reloaded with reduced mipmap count (clamped to 6) due to non-power-of-two dimensions: (384x384). This will be slower to load, and will look worse when zoomed out. Consider using a power-of-two texture size instead.
UnityEngine.StackTraceUtility:ExtractStackTrace ()
Verse.Log:Warning (string)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadTextureViaImageConversion (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadTexture (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadItem (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1/<LoadAllForMod>d__4<UnityEngine.Texture2D>:MoveNext ()
Verse.ModContentHolder`1<UnityEngine.Texture2D>:ReloadAll (bool)
Verse.ModContentPack:ReloadContentInt (bool)
Verse.ModContentPack/<>c__DisplayClass56_0:<ReloadContent>b__0 ()
Verse.LongEventHandler:ExecuteToExecuteWhenFinished ()
Verse.LongEventHandler:UpdateCurrentAsynchronousEvent ()
Verse.LongEventHandler:LongEventsUpdate (bool&)
Verse.Root:Update ()
Verse.Root_Entry:Update ()

Texture Naked_Male_southm.png is being reloaded with reduced mipmap count (clamped to 6) due to non-power-of-two dimensions: (384x384). This will be slower to load, and will look worse when zoomed out. Consider using a power-of-two texture size instead.
UnityEngine.StackTraceUtility:ExtractStackTrace ()
Verse.Log:Warning (string)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadTextureViaImageConversion (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadTexture (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadItem (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1/<LoadAllForMod>d__4<UnityEngine.Texture2D>:MoveNext ()
Verse.ModContentHolder`1<UnityEngine.Texture2D>:ReloadAll (bool)
Verse.ModContentPack:ReloadContentInt (bool)
Verse.ModContentPack/<>c__DisplayClass56_0:<ReloadContent>b__0 ()
Verse.LongEventHandler:ExecuteToExecuteWhenFinished ()
Verse.LongEventHandler:UpdateCurrentAsynchronousEvent ()
Verse.LongEventHandler:LongEventsUpdate (bool&)
Verse.Root:Update ()
Verse.Root_Entry:Update ()

Texture Naked_Male_east.png is being reloaded with reduced mipmap count (clamped to 6) due to non-power-of-two dimensions: (384x384). This will be slower to load, and will look worse when zoomed out. Consider using a power-of-two texture size instead.
UnityEngine.StackTraceUtility:ExtractStackTrace ()
Verse.Log:Warning (string)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadTextureViaImageConversion (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadTexture (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadItem (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1/<LoadAllForMod>d__4<UnityEngine.Texture2D>:MoveNext ()
Verse.ModContentHolder`1<UnityEngine.Texture2D>:ReloadAll (bool)
Verse.ModContentPack:ReloadContentInt (bool)
Verse.ModContentPack/<>c__DisplayClass56_0:<ReloadContent>b__0 ()
Verse.LongEventHandler:ExecuteToExecuteWhenFinished ()
Verse.LongEventHandler:UpdateCurrentAsynchronousEvent ()
Verse.LongEventHandler:LongEventsUpdate (bool&)
Verse.Root:Update ()
Verse.Root_Entry:Update ()

Texture Naked_Male_eastm.png is being reloaded with reduced mipmap count (clamped to 6) due to non-power-of-two dimensions: (384x384). This will be slower to load, and will look worse when zoomed out. Consider using a power-of-two texture size instead.
UnityEngine.StackTraceUtility:ExtractStackTrace ()
Verse.Log:Warning (string)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadTextureViaImageConversion (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadTexture (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadItem (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1/<LoadAllForMod>d__4<UnityEngine.Texture2D>:MoveNext ()
Verse.ModContentHolder`1<UnityEngine.Texture2D>:ReloadAll (bool)
Verse.ModContentPack:ReloadContentInt (bool)
Verse.ModContentPack/<>c__DisplayClass56_0:<ReloadContent>b__0 ()
Verse.LongEventHandler:ExecuteToExecuteWhenFinished ()
Verse.LongEventHandler:UpdateCurrentAsynchronousEvent ()
Verse.LongEventHandler:LongEventsUpdate (bool&)
Verse.Root:Update ()
Verse.Root_Entry:Update ()

Texture Naked_Male_north.png is being reloaded with reduced mipmap count (clamped to 6) due to non-power-of-two dimensions: (384x384). This will be slower to load, and will look worse when zoomed out. Consider using a power-of-two texture size instead.
UnityEngine.StackTraceUtility:ExtractStackTrace ()
Verse.Log:Warning (string)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadTextureViaImageConversion (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadTexture (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadItem (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1/<LoadAllForMod>d__4<UnityEngine.Texture2D>:MoveNext ()
Verse.ModContentHolder`1<UnityEngine.Texture2D>:ReloadAll (bool)
Verse.ModContentPack:ReloadContentInt (bool)
Verse.ModContentPack/<>c__DisplayClass56_0:<ReloadContent>b__0 ()
Verse.LongEventHandler:ExecuteToExecuteWhenFinished ()
Verse.LongEventHandler:UpdateCurrentAsynchronousEvent ()
Verse.LongEventHandler:LongEventsUpdate (bool&)
Verse.Root:Update ()
Verse.Root_Entry:Update ()

Texture Naked_Male_northm.png is being reloaded with reduced mipmap count (clamped to 6) due to non-power-of-two dimensions: (384x384). This will be slower to load, and will look worse when zoomed out. Consider using a power-of-two texture size instead.
UnityEngine.StackTraceUtility:ExtractStackTrace ()
Verse.Log:Warning (string)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadTextureViaImageConversion (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadTexture (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadItem (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1/<LoadAllForMod>d__4<UnityEngine.Texture2D>:MoveNext ()
Verse.ModContentHolder`1<UnityEngine.Texture2D>:ReloadAll (bool)
Verse.ModContentPack:ReloadContentInt (bool)
Verse.ModContentPack/<>c__DisplayClass56_0:<ReloadContent>b__0 ()
Verse.LongEventHandler:ExecuteToExecuteWhenFinished ()
Verse.LongEventHandler:UpdateCurrentAsynchronousEvent ()
Verse.LongEventHandler:LongEventsUpdate (bool&)
Verse.Root:Update ()
Verse.Root_Entry:Update ()

Texture Naked_Male_south.png is being reloaded with reduced mipmap count (clamped to 6) due to non-power-of-two dimensions: (384x384). This will be slower to load, and will look worse when zoomed out. Consider using a power-of-two texture size instead.
UnityEngine.StackTraceUtility:ExtractStackTrace ()
Verse.Log:Warning (string)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadTextureViaImageConversion (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadTexture (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadItem (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1/<LoadAllForMod>d__4<UnityEngine.Texture2D>:MoveNext ()
Verse.ModContentHolder`1<UnityEngine.Texture2D>:ReloadAll (bool)
Verse.ModContentPack:ReloadContentInt (bool)
Verse.ModContentPack/<>c__DisplayClass56_0:<ReloadContent>b__0 ()
Verse.LongEventHandler:ExecuteToExecuteWhenFinished ()
Verse.LongEventHandler:UpdateCurrentAsynchronousEvent ()
Verse.LongEventHandler:LongEventsUpdate (bool&)
Verse.Root:Update ()
Verse.Root_Entry:Update ()

Texture Naked_Male_southm.png is being reloaded with reduced mipmap count (clamped to 6) due to non-power-of-two dimensions: (384x384). This will be slower to load, and will look worse when zoomed out. Consider using a power-of-two texture size instead.
UnityEngine.StackTraceUtility:ExtractStackTrace ()
Verse.Log:Warning (string)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadTextureViaImageConversion (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadTexture (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadItem (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1/<LoadAllForMod>d__4<UnityEngine.Texture2D>:MoveNext ()
Verse.ModContentHolder`1<UnityEngine.Texture2D>:ReloadAll (bool)
Verse.ModContentPack:ReloadContentInt (bool)
Verse.ModContentPack/<>c__DisplayClass56_0:<ReloadContent>b__0 ()
Verse.LongEventHandler:ExecuteToExecuteWhenFinished ()
Verse.LongEventHandler:UpdateCurrentAsynchronousEvent ()
Verse.LongEventHandler:LongEventsUpdate (bool&)
Verse.Root:Update ()
Verse.Root_Entry:Update ()

Texture t2bottomjaw.png is being reloaded with reduced mipmap count (clamped to 1) due to non-power-of-two dimensions: (38x14). This will be slower to load, and will look worse when zoomed out. Consider using a power-of-two texture size instead.
UnityEngine.StackTraceUtility:ExtractStackTrace ()
Verse.Log:Warning (string)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadTextureViaImageConversion (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadTexture (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadItem (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1/<LoadAllForMod>d__4<UnityEngine.Texture2D>:MoveNext ()
Verse.ModContentHolder`1<UnityEngine.Texture2D>:ReloadAll (bool)
Verse.ModContentPack:ReloadContentInt (bool)
Verse.ModContentPack/<>c__DisplayClass56_0:<ReloadContent>b__0 ()
Verse.LongEventHandler:ExecuteToExecuteWhenFinished ()
Verse.LongEventHandler:UpdateCurrentAsynchronousEvent ()
Verse.LongEventHandler:LongEventsUpdate (bool&)
Verse.Root:Update ()
Verse.Root_Entry:Update ()

Texture t2jawside.png is being reloaded with reduced mipmap count (clamped to 1) due to non-power-of-two dimensions: (44x14). This will be slower to load, and will look worse when zoomed out. Consider using a power-of-two texture size instead.
UnityEngine.StackTraceUtility:ExtractStackTrace ()
Verse.Log:Warning (string)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadTextureViaImageConversion (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadTexture (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadItem (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1/<LoadAllForMod>d__4<UnityEngine.Texture2D>:MoveNext ()
Verse.ModContentHolder`1<UnityEngine.Texture2D>:ReloadAll (bool)
Verse.ModContentPack:ReloadContentInt (bool)
Verse.ModContentPack/<>c__DisplayClass56_0:<ReloadContent>b__0 ()
Verse.LongEventHandler:ExecuteToExecuteWhenFinished ()
Verse.LongEventHandler:UpdateCurrentAsynchronousEvent ()
Verse.LongEventHandler:LongEventsUpdate (bool&)
Verse.Root:Update ()
Verse.Root_Entry:Update ()

Texture tier2topjaw.png is being reloaded with reduced mipmap count (clamped to 1) due to non-power-of-two dimensions: (51x45). This will be slower to load, and will look worse when zoomed out. Consider using a power-of-two texture size instead.
UnityEngine.StackTraceUtility:ExtractStackTrace ()
Verse.Log:Warning (string)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadTextureViaImageConversion (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadTexture (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1<UnityEngine.Texture2D>:LoadItem (RimWorld.IO.VirtualFile)
Verse.ModContentLoader`1/<LoadAllForMod>d__4<UnityEngine.Texture2D>:MoveNext ()
Verse.ModContentHolder`1<UnityEngine.Texture2D>:ReloadAll (bool)
Verse.ModContentPack:ReloadContentInt (bool)
Verse.ModContentPack/<>c__DisplayClass56_0:<ReloadContent>b__0 ()
Verse.LongEventHandler:ExecuteToExecuteWhenFinished ()
Verse.LongEventHandler:UpdateCurrentAsynchronousEvent ()
Verse.LongEventHandler:LongEventsUpdate (bool&)
Verse.Root:Update ()
Verse.Root_Entry:Update ()

Texture SurrogatePod_east has dimensions of 256 x 128, but its mask has 128 x 256. This is not supported, texture will be excluded from atlas
UnityEngine.StackTraceUtility:ExtractStackTrace ()
Verse.Log:Warning (string)
Verse.GlobalTextureAtlasManager:TryInsertStatic (Verse.TextureAtlasGroup,UnityEngine.Texture2D,UnityEngine.Texture2D)
Verse.Graphic_Multi:TryInsertIntoAtlas (Verse.TextureAtlasGroup)
Verse.ThingDef:<PostLoad>b__398_0 ()
Verse.LongEventHandler:ExecuteToExecuteWhenFinished ()
Verse.LongEventHandler:UpdateCurrentAsynchronousEvent ()
Verse.LongEventHandler:LongEventsUpdate (bool&)
Verse.Root:Update ()
Verse.Root_Entry:Update ()

Translation data for language Portuguese Brazilian has 30 errors. Generate translation report for more info.
UnityEngine.StackTraceUtility:ExtractStackTrace ()
Verse.Log:Warning (string)
Verse.LoadedLanguage:InjectIntoData_AfterImpliedDefs ()
Verse.PlayDataLoader/<>c:<DoPlayLoad>b__4_3 ()
Verse.LongEventHandler:ExecuteToExecuteWhenFinished ()
Verse.LongEventHandler:UpdateCurrentAsynchronousEvent ()
Verse.LongEventHandler:LongEventsUpdate (bool&)
Verse.Root:Update ()
Verse.Root_Entry:Update ()

Alien race successfully completed 278 patches (50 pre, 82 post, 146 trans) with harmony.
UnityEngine.StackTraceUtility:ExtractStackTrace ()
Verse.Log:Message (string)
AlienRace.HarmonyPatches:.cctor () (at C:/Program Files (x86)/Steam/steamapps/common/RimWorld/Mods/AlienRaces/Source/AlienRace/AlienRace/HarmonyPatches.cs:408)
System.Runtime.CompilerServices.RuntimeHelpers:RunClassConstructor (System.RuntimeTypeHandle)
Verse.StaticConstructorOnStartupUtility:CallAll ()
Verse.PlayDataLoader/<>c:<DoPlayLoad>b__4_4 ()
Verse.LongEventHandler:ExecuteToExecuteWhenFinished ()
Verse.LongEventHandler:UpdateCurrentAsynchronousEvent ()
Verse.LongEventHandler:LongEventsUpdate (bool&)
Verse.Root:Update ()
Verse.Root_Entry:Update ()

Error in static constructor of MOARANDROIDS.HarmonyPatches: System.TypeInitializationException: The type initializer for 'MOARANDROIDS.HarmonyPatches' threw an exception. ---> HarmonyLib.HarmonyException: Ambiguous match for HarmonyMethod[(class=RimWorld.MemoryThoughtHandler, methodname=TryGainMemoryFast, type=Normal, args=undefined)] ---> System.Reflection.AmbiguousMatchException: Ambiguous match found.
[Ref E7DD75BD]
  at System.RuntimeType.GetMethodImplCommon (System.String name, System.Int32 genericParameterCount, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, System.Reflection.CallingConventions callConv, System.Type[] types, System.Reflection.ParameterModifier[] modifiers) [0x00050] in <51fded79cd284d4d911c5949aff4cb21>:0 
  at System.RuntimeType.GetMethodImpl (System.String name, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, System.Reflection.CallingConventions callConv, System.Type[] types, System.Reflection.ParameterModifier[] modifiers) [0x00000] in <51fded79cd284d4d911c5949aff4cb21>:0 
  at System.Type.GetMethod (System.String name, System.Reflection.BindingFlags bindingAttr) [0x0000e] in <51fded79cd284d4d911c5949aff4cb21>:0 
  at HarmonyLib.AccessTools.DeclaredMethod (System.Type type, System.String name, System.Type[] parameters, System.Type[] generics) [0x0002d] in <e53399289d9b419d83f9f5b02c5cf609>:0 
  at HarmonyLib.PatchTools.GetOriginalMethod (HarmonyLib.HarmonyMethod attr) [0x000d1] in <e53399289d9b419d83f9f5b02c5cf609>:0 
   --- End of inner exception stack trace ---
[Ref 78B15BF2]
  at HarmonyLib.PatchClassProcessor.ReportException (System.Exception exception, System.Reflection.MethodBase original) [0x0013c] in <e53399289d9b419d83f9f5b02c5cf609>:0 
  at HarmonyLib.PatchClassProcessor.Patch () [0x00096] in <e53399289d9b419d83f9f5b02c5cf609>:0 
  at HarmonyLib.Harmony.<PatchAll>b__10_1 (System.Type type) [0x00007] in <e53399289d9b419d83f9f5b02c5cf609>:0 
  at HarmonyLib.CollectionExtensions.Do[T] (System.Collections.Generic.IEnumerable`1[T] sequence, System.Action`1[T] action) [0x00014] in <e53399289d9b419d83f9f5b02c5cf609>:0 
  at HarmonyLib.CollectionExtensions.DoIf[T] (System.Collections.Generic.IEnumerable`1[T] sequence, System.Func`2[T,TResult] condition, System.Action`1[T] action) [0x00007] in <e53399289d9b419d83f9f5b02c5cf609>:0 
  at HarmonyLib.Harmony.PatchAll (System.Reflection.Assembly assembly) [0x00006] in <e53399289d9b419d83f9f5b02c5cf609>:0 
MOARANDROIDS.HarmonyPatches..cctor()
   --- End of inner exception stack trace ---
[Ref 3C43976E]
(wrapper managed-to-native) System.Runtime.CompilerServices.RuntimeHelpers.RunClassConstructor(intptr)
  at System.Runtime.CompilerServices.RuntimeHelpers.RunClassConstructor (System.RuntimeTypeHandle type) [0x0002a] in <51fded79cd284d4d911c5949aff4cb21>:0 
  at Verse.StaticConstructorOnStartupUtility.CallAll () [0x00025] in <46372f5dadbf4af8939e608076251180>:0 
UnityEngine.StackTraceUtility:ExtractStackTrace ()
Verse.Log:Error (string)
Verse.StaticConstructorOnStartupUtility:CallAll ()
Verse.PlayDataLoader/<>c:<DoPlayLoad>b__4_4 ()
Verse.LongEventHandler:ExecuteToExecuteWhenFinished ()
Verse.LongEventHandler:UpdateCurrentAsynchronousEvent ()
Verse.LongEventHandler:LongEventsUpdate (bool&)
Verse.Root:Update ()
Verse.Root_Entry:Update ()

[ATPP] 15 Care job collected for crafting injection
UnityEngine.StackTraceUtility:ExtractStackTrace ()
Verse.Log:Message (string)
MOARANDROIDS.GC_ATPP:.ctor (Verse.Game)
System.Reflection.RuntimeConstructorInfo:InternalInvoke (object,object[],bool)
System.Reflection.RuntimeConstructorInfo:DoInvoke (object,System.Reflection.BindingFlags,System.Reflection.Binder,object[],System.Globalization.CultureInfo)
System.Reflection.RuntimeConstructorInfo:Invoke (System.Reflection.BindingFlags,System.Reflection.Binder,object[],System.Globalization.CultureInfo)
System.RuntimeType:CreateInstanceImpl (System.Reflection.BindingFlags,System.Reflection.Binder,object[],System.Globalization.CultureInfo,object[],System.Threading.StackCrawlMark&)
System.Activator:CreateInstance (System.Type,System.Reflection.BindingFlags,System.Reflection.Binder,object[],System.Globalization.CultureInfo,object[])
System.Activator:CreateInstance (System.Type,object[])
Verse.Game:FillComponents ()
Verse.Game:.ctor ()
Verse.Root_Play:SetupForQuickTestPlay ()
RimWorld.MainMenuDrawer/<>c:<DoMainMenuControls>b__24_10 ()
Verse.LongEventHandler:RunEventFromAnotherThread (System.Action)
Verse.LongEventHandler/<>c:<UpdateCurrentAsynchronousEvent>b__28_0 ()
System.Threading.ThreadHelper:ThreadStart_Context (object)
System.Threading.ExecutionContext:RunInternal (System.Threading.ExecutionContext,System.Threading.ContextCallback,object,bool)
System.Threading.ExecutionContext:Run (System.Threading.ExecutionContext,System.Threading.ContextCallback,object,bool)
System.Threading.ExecutionContext:Run (System.Threading.ExecutionContext,System.Threading.ContextCallback,object)
System.Threading.ThreadHelper:ThreadStart ()

[ATPP] 4 MentalBreaks collected
UnityEngine.StackTraceUtility:ExtractStackTrace ()
Verse.Log:Message (string)
MOARANDROIDS.GC_ATPP:.ctor (Verse.Game)
System.Reflection.RuntimeConstructorInfo:InternalInvoke (object,object[],bool)
System.Reflection.RuntimeConstructorInfo:DoInvoke (object,System.Reflection.BindingFlags,System.Reflection.Binder,object[],System.Globalization.CultureInfo)
System.Reflection.RuntimeConstructorInfo:Invoke (System.Reflection.BindingFlags,System.Reflection.Binder,object[],System.Globalization.CultureInfo)
System.RuntimeType:CreateInstanceImpl (System.Reflection.BindingFlags,System.Reflection.Binder,object[],System.Globalization.CultureInfo,object[],System.Threading.StackCrawlMark&)
System.Activator:CreateInstance (System.Type,System.Reflection.BindingFlags,System.Reflection.Binder,object[],System.Globalization.CultureInfo,object[])
System.Activator:CreateInstance (System.Type,object[])
Verse.Game:FillComponents ()
Verse.Game:.ctor ()
Verse.Root_Play:SetupForQuickTestPlay ()
RimWorld.MainMenuDrawer/<>c:<DoMainMenuControls>b__24_10 ()
Verse.LongEventHandler:RunEventFromAnotherThread (System.Action)
Verse.LongEventHandler/<>c:<UpdateCurrentAsynchronousEvent>b__28_0 ()
System.Threading.ThreadHelper:ThreadStart_Context (object)
System.Threading.ExecutionContext:RunInternal (System.Threading.ExecutionContext,System.Threading.ContextCallback,object,bool)
System.Threading.ExecutionContext:Run (System.Threading.ExecutionContext,System.Threading.ContextCallback,object,bool)
System.Threading.ExecutionContext:Run (System.Threading.ExecutionContext,System.Threading.ContextCallback,object)
System.Threading.ThreadHelper:ThreadStart ()

--- Thread 78 ---
 65.354ms Loading language data: English


Hotspot analysis
----------------------------------------
1x Loading language data: English -> 65.354 ms (total (w/children): 65.354 ms)

UnityEngine.StackTraceUtility:ExtractStackTrace ()
Verse.Log:Message (string)
Verse.ThreadLocalDeepProfiler:Output (Verse.ThreadLocalDeepProfiler/Watcher)
Verse.ThreadLocalDeepProfiler:End ()
Verse.DeepProfiler:End ()
Verse.LoadedLanguage:LoadData ()
Verse.LoadedLanguage:TryGetStringsFromFile (string,System.Collections.Generic.List`1<string>&)
Verse.Translator:TryGetTranslatedStringsForFile (string,System.Collections.Generic.List`1<string>&)
Verse.Grammar.Rule_File:LoadStringsFromFile (string)
Verse.Grammar.Rule_File:Init ()
Verse.Grammar.RulePack:GetRulesResolved (System.Collections.Generic.List`1<Verse.Grammar.Rule>,System.Collections.Generic.List`1<string>,System.Collections.Generic.List`1<string>)
Verse.Grammar.RulePack:get_Rules ()
Verse.RulePackDef:get_RulesPlusIncludes ()
Verse.Grammar.GrammarResolver:ResolveUnsafe (string,Verse.Grammar.GrammarRequest,bool&,string,bool,bool,System.Collections.Generic.List`1<string>,System.Collections.Generic.List`1<string>,bool)
Verse.Grammar.GrammarResolver:Resolve (string,Verse.Grammar.GrammarRequest,string,bool,string,System.Collections.Generic.List`1<string>,System.Collections.Generic.List`1<string>,bool)
Verse.GenText:RandomSeedString ()
Verse.Root_Play:SetupForQuickTestPlay ()
RimWorld.MainMenuDrawer/<>c:<DoMainMenuControls>b__24_10 ()
Verse.LongEventHandler:RunEventFromAnotherThread (System.Action)
Verse.LongEventHandler/<>c:<UpdateCurrentAsynchronousEvent>b__28_0 ()
System.Threading.ThreadHelper:ThreadStart_Context (object)
System.Threading.ExecutionContext:RunInternal (System.Threading.ExecutionContext,System.Threading.ContextCallback,object,bool)
System.Threading.ExecutionContext:Run (System.Threading.ExecutionContext,System.Threading.ContextCallback,object,bool)
System.Threading.ExecutionContext:Run (System.Threading.ExecutionContext,System.Threading.ContextCallback,object)
System.Threading.ThreadHelper:ThreadStart ()

No string files for WordParts/Syllables_Pig_Maiúscula.
UnityEngine.StackTraceUtility:ExtractStackTrace ()
Verse.Log:Error (string)
Verse.Translator:TryGetTranslatedStringsForFile (string,System.Collections.Generic.List`1<string>&)
Verse.Grammar.Rule_File:LoadStringsFromFile (string)
Verse.Grammar.Rule_File:Init ()
Verse.Grammar.RulePack:GetRulesResolved (System.Collections.Generic.List`1<Verse.Grammar.Rule>,System.Collections.Generic.List`1<string>,System.Collections.Generic.List`1<string>)
Verse.Grammar.RulePack:get_Rules ()
Verse.RulePackDef:get_RulesPlusIncludes ()
Verse.Grammar.GrammarResolver:ResolveUnsafe (string,Verse.Grammar.GrammarRequest,bool&,string,bool,bool,System.Collections.Generic.List`1<string>,System.Collections.Generic.List`1<string>,bool)
Verse.Grammar.GrammarResolver:Resolve (string,Verse.Grammar.GrammarRequest,string,bool,string,System.Collections.Generic.List`1<string>,System.Collections.Generic.List`1<string>,bool)
Verse.GenText:RandomSeedString ()
Verse.Root_Play:SetupForQuickTestPlay ()
RimWorld.MainMenuDrawer/<>c:<DoMainMenuControls>b__24_10 ()
Verse.LongEventHandler:RunEventFromAnotherThread (System.Action)
Verse.LongEventHandler/<>c:<UpdateCurrentAsynchronousEvent>b__28_0 ()
System.Threading.ThreadHelper:ThreadStart_Context (object)
System.Threading.ExecutionContext:RunInternal (System.Threading.ExecutionContext,System.Threading.ContextCallback,object,bool)
System.Threading.ExecutionContext:Run (System.Threading.ExecutionContext,System.Threading.ContextCallback,object,bool)
System.Threading.ExecutionContext:Run (System.Threading.ExecutionContext,System.Threading.ContextCallback,object)
System.Threading.ThreadHelper:ThreadStart ()

Grammar unresolvable. Root 'r_name'

GRAMMAR RESOLUTION TRACE
1    r_name → [placeNameCore]
2      placeNameCore → [SylI_M][placeEnd]
         SylI_M → UNRESOLVABLE
3        placeEnd → que
2      placeNameCore → [SylI_M][SylI]
         SylI_M → UNRESOLVABLE
3        SylI->(43 strings from file: WordParts/Syllables_Impid)
2      placeNameCore → [SylI_M][SylI][SylI]
         SylI_M → UNRESOLVABLE
3        SylI->(43 strings from file: WordParts/Syllables_Impid)
3        SylI->(43 strings from file: WordParts/Syllables_Impid)
2      placeNameCore → [SylI_M][SylI][placeEnd]
         SylI_M → UNRESOLVABLE
3        SylI->(43 strings from file: WordParts/Syllables_Impid)
3        placeEnd → s
       placeNameCore → UNRESOLVABLE
1    r_name → [faction] of [placeNameCore]
2      faction → sprintship
       placeNameCore → UNRESOLVABLE
1    r_name → [placeNameCore] [faction]
       placeNameCore → UNRESOLVABLE
2      faction → flamehome
     r_name → UNRESOLVABLE

INCLUDES
NamerFactionTribalImpid
ImpidUtility

CUSTOM RULES

UnityEngine.StackTraceUtility:ExtractStackTrace ()
Verse.Log:Error (string)
Verse.Log:ErrorOnce (string,int)
Verse.Grammar.GrammarResolver:ResolveUnsafe (string,Verse.Grammar.GrammarRequest,bool&,string,bool,bool,System.Collections.Generic.List`1<string>,System.Collections.Generic.List`1<string>,bool)
Verse.Grammar.GrammarResolver:ResolveUnsafe (string,Verse.Grammar.GrammarRequest,string,bool,bool,System.Collections.Generic.List`1<string>,System.Collections.Generic.List`1<string>,bool)
Verse.Grammar.GrammarResolver:ResolveUnsafe (string,Verse.Grammar.GrammarRequest,bool&,string,bool,bool,System.Collections.Generic.List`1<string>,System.Collections.Generic.List`1<string>,bool)
Verse.Grammar.GrammarResolver:Resolve (string,Verse.Grammar.GrammarRequest,string,bool,string,System.Collections.Generic.List`1<string>,System.Collections.Generic.List`1<string>,bool)
RimWorld.NameGenerator:GenerateName (Verse.Grammar.GrammarRequest,System.Predicate`1<string>,bool,string,string)
RimWorld.NameGenerator:GenerateName (Verse.RulePackDef,System.Predicate`1<string>,bool,string,string,System.Collections.Generic.List`1<Verse.Grammar.Rule>)
RimWorld.NameGenerator:GenerateName (Verse.RulePackDef,System.Collections.Generic.IEnumerable`1<string>,bool,string)
RimWorld.FactionGenerator:NewGeneratedFaction (RimWorld.Planet.PlanetLayer,RimWorld.FactionGeneratorParms)
RimWorld.FactionGenerator:CreateFactionAndAddToManager (RimWorld.Planet.PlanetLayer,RimWorld.FactionDef)
RimWorld.FactionGenerator:AddFactionToManager (RimWorld.Planet.PlanetLayer,RimWorld.FactionDef)
RimWorld.FactionGenerator:InitializeFactions (RimWorld.Planet.PlanetLayer,System.Collections.Generic.List`1<RimWorld.FactionDef>)
(wrapper dynamic-method) MonoMod.Utils.DynamicMethodDefinition:RimWorld.FactionGenerator.GenerateFactionsIntoWorldLayer_Patch1 (RimWorld.Planet.PlanetLayer,System.Collections.Generic.List`1<RimWorld.FactionDef>)
RimWorld.Planet.WorldGenStep_Factions:GenerateFresh (string,RimWorld.Planet.PlanetLayer)
RimWorld.Planet.WorldGenerator:GeneratePlanetLayer (RimWorld.Planet.PlanetLayer,string,int)
RimWorld.Planet.WorldGenerator:GenerateWorld (single,string,RimWorld.Planet.OverallRainfall,RimWorld.Planet.OverallTemperature,RimWorld.Planet.OverallPopulation,RimWorld.Planet.LandmarkDensity,System.Collections.Generic.List`1<RimWorld.FactionDef>,single)
Verse.Root_Play:SetupForQuickTestPlay ()
RimWorld.MainMenuDrawer/<>c:<DoMainMenuControls>b__24_10 ()
Verse.LongEventHandler:RunEventFromAnotherThread (System.Action)
Verse.LongEventHandler/<>c:<UpdateCurrentAsynchronousEvent>b__28_0 ()
System.Threading.ThreadHelper:ThreadStart_Context (object)
System.Threading.ExecutionContext:RunInternal (System.Threading.ExecutionContext,System.Threading.ContextCallback,object,bool)
System.Threading.ExecutionContext:Run (System.Threading.ExecutionContext,System.Threading.ContextCallback,object,bool)
System.Threading.ExecutionContext:Run (System.Threading.ExecutionContext,System.Threading.ContextCallback,object)
System.Threading.ThreadHelper:ThreadStart ()

Failed to resolve text. Trying again with English.
UnityEngine.StackTraceUtility:ExtractStackTrace ()
Verse.Log:Error (string)
Verse.Log:ErrorOnce (string,int)
Verse.Grammar.GrammarResolver:Resolve (string,Verse.Grammar.GrammarRequest,string,bool,string,System.Collections.Generic.List`1<string>,System.Collections.Generic.List`1<string>,bool)
RimWorld.NameGenerator:GenerateName (Verse.Grammar.GrammarRequest,System.Predicate`1<string>,bool,string,string)
RimWorld.NameGenerator:GenerateName (Verse.RulePackDef,System.Predicate`1<string>,bool,string,string,System.Collections.Generic.List`1<Verse.Grammar.Rule>)
RimWorld.NameGenerator:GenerateName (Verse.RulePackDef,System.Collections.Generic.IEnumerable`1<string>,bool,string)
RimWorld.FactionGenerator:NewGeneratedFaction (RimWorld.Planet.PlanetLayer,RimWorld.FactionGeneratorParms)
RimWorld.FactionGenerator:CreateFactionAndAddToManager (RimWorld.Planet.PlanetLayer,RimWorld.FactionDef)
RimWorld.FactionGenerator:AddFactionToManager (RimWorld.Planet.PlanetLayer,RimWorld.FactionDef)
RimWorld.FactionGenerator:InitializeFactions (RimWorld.Planet.PlanetLayer,System.Collections.Generic.List`1<RimWorld.FactionDef>)
(wrapper dynamic-method) MonoMod.Utils.DynamicMethodDefinition:RimWorld.FactionGenerator.GenerateFactionsIntoWorldLayer_Patch1 (RimWorld.Planet.PlanetLayer,System.Collections.Generic.List`1<RimWorld.FactionDef>)
RimWorld.Planet.WorldGenStep_Factions:GenerateFresh (string,RimWorld.Planet.PlanetLayer)
RimWorld.Planet.WorldGenerator:GeneratePlanetLayer (RimWorld.Planet.PlanetLayer,string,int)
RimWorld.Planet.WorldGenerator:GenerateWorld (single,string,RimWorld.Planet.OverallRainfall,RimWorld.Planet.OverallTemperature,RimWorld.Planet.OverallPopulation,RimWorld.Planet.LandmarkDensity,System.Collections.Generic.List`1<RimWorld.FactionDef>,single)
Verse.Root_Play:SetupForQuickTestPlay ()
RimWorld.MainMenuDrawer/<>c:<DoMainMenuControls>b__24_10 ()
Verse.LongEventHandler:RunEventFromAnotherThread (System.Action)
Verse.LongEventHandler/<>c:<UpdateCurrentAsynchronousEvent>b__28_0 ()
System.Threading.ThreadHelper:ThreadStart_Context (object)
System.Threading.ExecutionContext:RunInternal (System.Threading.ExecutionContext,System.Threading.ContextCallback,object,bool)
System.Threading.ExecutionContext:Run (System.Threading.ExecutionContext,System.Threading.ContextCallback,object,bool)
System.Threading.ExecutionContext:Run (System.Threading.ExecutionContext,System.Threading.ContextCallback,object)
System.Threading.ThreadHelper:ThreadStart ()

Grammar unresolvable. Root 'r_name'

GRAMMAR RESOLUTION TRACE
1    r_name → [placeNameCore]
2      placeNameCore → [SylI_M][SylI]
         SylI_M → UNRESOLVABLE
3        SylI->(43 strings from file: WordParts/Syllables_Impid)
2      placeNameCore → [SylI_M][SylI][SylI]
         SylI_M → UNRESOLVABLE
3        SylI->(43 strings from file: WordParts/Syllables_Impid)
3        SylI->(43 strings from file: WordParts/Syllables_Impid)
2      placeNameCore → [SylI_M][SylI][placeEnd]
         SylI_M → UNRESOLVABLE
3        SylI->(43 strings from file: WordParts/Syllables_Impid)
3        placeEnd → m
2      placeNameCore → [SylI_M][placeEnd]
         SylI_M → UNRESOLVABLE
3        placeEnd → zos
       placeNameCore → UNRESOLVABLE
1    r_name → [faction] of [placeNameCore]
2      faction → flamehome
       placeNameCore → UNRESOLVABLE
1    r_name → [placeNameCore] [faction]
       placeNameCore → UNRESOLVABLE
2      faction → runship
     r_name → UNRESOLVABLE

INCLUDES
NamerFactionTribalImpid
ImpidUtility

CUSTOM RULES

UnityEngine.StackTraceUtility:ExtractStackTrace ()
Verse.Log:Error (string)
Verse.Log:ErrorOnce (string,int)
Verse.Grammar.GrammarResolver:ResolveUnsafe (string,Verse.Grammar.GrammarRequest,bool&,string,bool,bool,System.Collections.Generic.List`1<string>,System.Collections.Generic.List`1<string>,bool)
Verse.Grammar.GrammarResolver:ResolveUnsafe (string,Verse.Grammar.GrammarRequest,string,bool,bool,System.Collections.Generic.List`1<string>,System.Collections.Generic.List`1<string>,bool)
Verse.Grammar.GrammarResolver:ResolveUnsafe (string,Verse.Grammar.GrammarRequest,bool&,string,bool,bool,System.Collections.Generic.List`1<string>,System.Collections.Generic.List`1<string>,bool)
Verse.Grammar.GrammarResolver:Resolve (string,Verse.Grammar.GrammarRequest,string,bool,string,System.Collections.Generic.List`1<string>,System.Collections.Generic.List`1<string>,bool)
RimWorld.NameGenerator:GenerateName (Verse.Grammar.GrammarRequest,System.Predicate`1<string>,bool,string,string)
RimWorld.NameGenerator:GenerateName (Verse.RulePackDef,System.Predicate`1<string>,bool,string,string,System.Collections.Generic.List`1<Verse.Grammar.Rule>)
RimWorld.NameGenerator:GenerateName (Verse.RulePackDef,System.Collections.Generic.IEnumerable`1<string>,bool,string)
RimWorld.FactionGenerator:NewGeneratedFaction (RimWorld.Planet.PlanetLayer,RimWorld.FactionGeneratorParms)
RimWorld.FactionGenerator:CreateFactionAndAddToManager (RimWorld.Planet.PlanetLayer,RimWorld.FactionDef)
RimWorld.FactionGenerator:AddFactionToManager (RimWorld.Planet.PlanetLayer,RimWorld.FactionDef)
RimWorld.FactionGenerator:InitializeFactions (RimWorld.Planet.PlanetLayer,System.Collections.Generic.List`1<RimWorld.FactionDef>)
(wrapper dynamic-method) MonoMod.Utils.DynamicMethodDefinition:RimWorld.FactionGenerator.GenerateFactionsIntoWorldLayer_Patch1 (RimWorld.Planet.PlanetLayer,System.Collections.Generic.List`1<RimWorld.FactionDef>)
RimWorld.Planet.WorldGenStep_Factions:GenerateFresh (string,RimWorld.Planet.PlanetLayer)
RimWorld.Planet.WorldGenerator:GeneratePlanetLayer (RimWorld.Planet.PlanetLayer,string,int)
RimWorld.Planet.WorldGenerator:GenerateWorld (single,string,RimWorld.Planet.OverallRainfall,RimWorld.Planet.OverallTemperature,RimWorld.Planet.OverallPopulation,RimWorld.Planet.LandmarkDensity,System.Collections.Generic.List`1<RimWorld.FactionDef>,single)
Verse.Root_Play:SetupForQuickTestPlay ()
RimWorld.MainMenuDrawer/<>c:<DoMainMenuControls>b__24_10 ()
Verse.LongEventHandler:RunEventFromAnotherThread (System.Action)
Verse.LongEventHandler/<>c:<UpdateCurrentAsynchronousEvent>b__28_0 ()
System.Threading.ThreadHelper:ThreadStart_Context (object)
System.Threading.ExecutionContext:RunInternal (System.Threading.ExecutionContext,System.Threading.ContextCallback,object,bool)
System.Threading.ExecutionContext:Run (System.Threading.ExecutionContext,System.Threading.ContextCallback,object,bool)
System.Threading.ExecutionContext:Run (System.Threading.ExecutionContext,System.Threading.ContextCallback,object)
System.Threading.ThreadHelper:ThreadStart ()

Grammar unresolvable. Root 'r_name'

GRAMMAR RESOLUTION TRACE
1    r_name → [placeNameCore]
2      placeNameCore → [SylI_M][SylI][placeEnd]
         SylI_M → UNRESOLVABLE
3        SylI->(43 strings from file: WordParts/Syllables_Impid)
3        placeEnd → m
2      placeNameCore → [SylI_M][SylI][SylI]
         SylI_M → UNRESOLVABLE
3        SylI->(43 strings from file: WordParts/Syllables_Impid)
3        SylI->(43 strings from file: WordParts/Syllables_Impid)
2      placeNameCore → [SylI_M][SylI]
         SylI_M → UNRESOLVABLE
3        SylI->(43 strings from file: WordParts/Syllables_Impid)
2      placeNameCore → [SylI_M][placeEnd]
         SylI_M → UNRESOLVABLE
3        placeEnd → l
       placeNameCore → UNRESOLVABLE
1    r_name → [faction] of [placeNameCore]
2      faction → flamehome
       placeNameCore → UNRESOLVABLE
1    r_name → [placeNameCore] [faction]
       placeNameCore → UNRESOLVABLE
2      faction → league
     r_name → UNRESOLVABLE

INCLUDES
NamerFactionTribalImpid
ImpidUtility

CUSTOM RULES

UnityEngine.StackTraceUtility:ExtractStackTrace ()
Verse.Log:Error (string)
Verse.Log:ErrorOnce (string,int)
Verse.Grammar.GrammarResolver:ResolveUnsafe (string,Verse.Grammar.GrammarRequest,bool&,string,bool,bool,System.Collections.Generic.List`1<string>,System.Collections.Generic.List`1<string>,bool)
Verse.Grammar.GrammarResolver:ResolveUnsafe (string,Verse.Grammar.GrammarRequest,string,bool,bool,System.Collections.Generic.List`1<string>,System.Collections.Generic.List`1<string>,bool)
Verse.Grammar.GrammarResolver:ResolveUnsafe (string,Verse.Grammar.GrammarRequest,bool&,string,bool,bool,System.Collections.Generic.List`1<string>,System.Collections.Generic.List`1<string>,bool)
Verse.Grammar.GrammarResolver:Resolve (string,Verse.Grammar.GrammarRequest,string,bool,string,System.Collections.Generic.List`1<string>,System.Collections.Generic.List`1<string>,bool)
RimWorld.NameGenerator:GenerateName (Verse.Grammar.GrammarRequest,System.Predicate`1<string>,bool,string,string)
RimWorld.NameGenerator:GenerateName (Verse.RulePackDef,System.Predicate`1<string>,bool,string,string,System.Collections.Generic.List`1<Verse.Grammar.Rule>)
RimWorld.NameGenerator:GenerateName (Verse.RulePackDef,System.Collections.Generic.IEnumerable`1<string>,bool,string)
RimWorld.FactionGenerator:NewGeneratedFaction (RimWorld.Planet.PlanetLayer,RimWorld.FactionGeneratorParms)
RimWorld.FactionGenerator:CreateFactionAndAddToManager (RimWorld.Planet.PlanetLayer,RimWorld.FactionDef)
RimWorld.FactionGenerator:AddFactionToManager (RimWorld.Planet.PlanetLayer,RimWorld.FactionDef)
RimWorld.FactionGenerator:InitializeFactions (RimWorld.Planet.PlanetLayer,System.Collections.Generic.List`1<RimWorld.FactionDef>)
(wrapper dynamic-method) MonoMod.Utils.DynamicMethodDefinition:RimWorld.FactionGenerator.GenerateFactionsIntoWorldLayer_Patch1 (RimWorld.Planet.PlanetLayer,System.Collections.Generic.List`1<RimWorld.FactionDef>)
RimWorld.Planet.WorldGenStep_Factions:GenerateFresh (string,RimWorld.Planet.PlanetLayer)
RimWorld.Planet.WorldGenerator:GeneratePlanetLayer (RimWorld.Planet.PlanetLayer,string,int)
RimWorld.Planet.WorldGenerator:GenerateWorld (single,string,RimWorld.Planet.OverallRainfall,RimWorld.Planet.OverallTemperature,RimWorld.Planet.OverallPopulation,RimWorld.Planet.LandmarkDensity,System.Collections.Generic.List`1<RimWorld.FactionDef>,single)
Verse.Root_Play:SetupForQuickTestPlay ()
RimWorld.MainMenuDrawer/<>c:<DoMainMenuControls>b__24_10 ()
Verse.LongEventHandler:RunEventFromAnotherThread (System.Action)
Verse.LongEventHandler/<>c:<UpdateCurrentAsynchronousEvent>b__28_0 ()
System.Threading.ThreadHelper:ThreadStart_Context (object)
System.Threading.ExecutionContext:RunInternal (System.Threading.ExecutionContext,System.Threading.ContextCallback,object,bool)
System.Threading.ExecutionContext:Run (System.Threading.ExecutionContext,System.Threading.ContextCallback,object,bool)
System.Threading.ExecutionContext:Run (System.Threading.ExecutionContext,System.Threading.ContextCallback,object)
System.Threading.ThreadHelper:ThreadStart ()

Grammar unresolvable. Root 'r_name'

GRAMMAR RESOLUTION TRACE
1    r_name → [placeNameCore]
2      placeNameCore → [SylI_M][placeEnd]
         SylI_M → UNRESOLVABLE
3        placeEnd → z
2      placeNameCore → [SylI_M][SylI][placeEnd]
         SylI_M → UNRESOLVABLE
3        SylI->(43 strings from file: WordParts/Syllables_Impid)
3        placeEnd → te
2      placeNameCore → [SylI_M][SylI][SylI]
         SylI_M → UNRESOLVABLE
3        SylI->(43 strings from file: WordParts/Syllables_Impid)
3        SylI->(43 strings from file: WordParts/Syllables_Impid)
2      placeNameCore → [SylI_M][SylI]
         SylI_M → UNRESOLVABLE
3        SylI->(43 strings from file: WordParts/Syllables_Impid)
       placeNameCore → UNRESOLVABLE
1    r_name → [faction] of [placeNameCore]
2      faction → firehome
       placeNameCore → UNRESOLVABLE
1    r_name → [placeNameCore] [faction]
       placeNameCore → UNRESOLVABLE
2      faction → league
     r_name → UNRESOLVABLE

INCLUDES
NamerFactionTribalImpid
ImpidUtility

CUSTOM RULES

UnityEngine.StackTraceUtility:ExtractStackTrace ()
Verse.Log:Error (string)
Verse.Log:ErrorOnce (string,int)
Verse.Grammar.GrammarResolver:ResolveUnsafe (string,Verse.Grammar.GrammarRequest,bool&,string,bool,bool,System.Collections.Generic.List`1<string>,System.Collections.Generic.List`1<string>,bool)
Verse.Grammar.GrammarResolver:ResolveUnsafe (string,Verse.Grammar.GrammarRequest,string,bool,bool,System.Collections.Generic.List`1<string>,System.Collections.Generic.List`1<string>,bool)
Verse.Grammar.GrammarResolver:ResolveUnsafe (string,Verse.Grammar.GrammarRequest,bool&,string,bool,bool,System.Collections.Generic.List`1<string>,System.Collections.Generic.List`1<string>,bool)
Verse.Grammar.GrammarResolver:Resolve (string,Verse.Grammar.GrammarRequest,string,bool,string,System.Collections.Generic.List`1<string>,System.Collections.Generic.List`1<string>,bool)
RimWorld.NameGenerator:GenerateName (Verse.Grammar.GrammarRequest,System.Predicate`1<string>,bool,string,string)
RimWorld.NameGenerator:GenerateName (Verse.RulePackDef,System.Predicate`1<string>,bool,string,string,System.Collections.Generic.List`1<Verse.Grammar.Rule>)
RimWorld.NameGenerator:GenerateName (Verse.RulePackDef,System.Collections.Generic.IEnumerable`1<string>,bool,string)
RimWorld.FactionGenerator:NewGeneratedFaction (RimWorld.Planet.PlanetLayer,RimWorld.FactionGeneratorParms)
RimWorld.FactionGenerator:CreateFactionAndAddToManager (RimWorld.Planet.PlanetLayer,RimWorld.FactionDef)
RimWorld.FactionGenerator:AddFactionToManager (RimWorld.Planet.PlanetLayer,RimWorld.FactionDef)
RimWorld.FactionGenerator:InitializeFactions (RimWorld.Planet.PlanetLayer,System.Collections.Generic.List`1<RimWorld.FactionDef>)
(wrapper dynamic-method) MonoMod.Utils.DynamicMethodDefinition:RimWorld.FactionGenerator.GenerateFactionsIntoWorldLayer_Patch1 (RimWorld.Planet.PlanetLayer,System.Collections.Generic.List`1<RimWorld.FactionDef>)
RimWorld.Planet.WorldGenStep_Factions:GenerateFresh (string,RimWorld.Planet.PlanetLayer)
RimWorld.Planet.WorldGenerator:GeneratePlanetLayer (RimWorld.Planet.PlanetLayer,string,int)
RimWorld.Planet.WorldGenerator:GenerateWorld (single,string,RimWorld.Planet.OverallRainfall,RimWorld.Planet.OverallTemperature,RimWorld.Planet.OverallPopulation,RimWorld.Planet.LandmarkDensity,System.Collections.Generic.List`1<RimWorld.FactionDef>,single)
Verse.Root_Play:SetupForQuickTestPlay ()
RimWorld.MainMenuDrawer/<>c:<DoMainMenuControls>b__24_10 ()
Verse.LongEventHandler:RunEventFromAnotherThread (System.Action)
Verse.LongEventHandler/<>c:<UpdateCurrentAsynchronousEvent>b__28_0 ()
System.Threading.ThreadHelper:ThreadStart_Context (object)
System.Threading.ExecutionContext:RunInternal (System.Threading.ExecutionContext,System.Threading.ContextCallback,object,bool)
System.Threading.ExecutionContext:Run (System.Threading.ExecutionContext,System.Threading.ContextCallback,object,bool)
System.Threading.ExecutionContext:Run (System.Threading.ExecutionContext,System.Threading.ContextCallback,object)
System.Threading.ThreadHelper:ThreadStart ()

Grammar unresolvable. Root 'r_name'

GRAMMAR RESOLUTION TRACE
1    r_name → [placeNameCore]
2      placeNameCore → [SylI_M][SylI][SylI]
         SylI_M → UNRESOLVABLE
3        SylI->(43 strings from file: WordParts/Syllables_Impid)
3        SylI->(43 strings from file: WordParts/Syllables_Impid)
2      placeNameCore → [SylI_M][placeEnd]
         SylI_M → UNRESOLVABLE
3        placeEnd → te
2      placeNameCore → [SylI_M][SylI]
         SylI_M → UNRESOLVABLE
3        SylI->(43 strings from file: WordParts/Syllables_Impid)
2      placeNameCore → [SylI_M][SylI][placeEnd]
         SylI_M → UNRESOLVABLE
3        SylI->(43 strings from file: WordParts/Syllables_Impid)
3        placeEnd → z
       placeNameCore → UNRESOLVABLE
1    r_name → [faction] of [placeNameCore]
2      faction → sprintship
       placeNameCore → UNRESOLVABLE
1    r_name → [placeNameCore] [faction]
       placeNameCore → UNRESOLVABLE
2      faction → sprintship
     r_name → UNRESOLVABLE

INCLUDES
NamerFactionTribalImpid
ImpidUtility

CUSTOM RULES

UnityEngine.StackTraceUtility:ExtractStackTrace ()
Verse.Log:Error (string)
Verse.Log:ErrorOnce (string,int)
Verse.Grammar.GrammarResolver:ResolveUnsafe (string,Verse.Grammar.GrammarRequest,bool&,string,bool,bool,System.Collections.Generic.List`1<string>,System.Collections.Generic.List`1<string>,bool)
Verse.Grammar.GrammarResolver:ResolveUnsafe (string,Verse.Grammar.GrammarRequest,string,bool,bool,System.Collections.Generic.List`1<string>,System.Collections.Generic.List`1<string>,bool)
Verse.Grammar.GrammarResolver:ResolveUnsafe (string,Verse.Grammar.GrammarRequest,bool&,string,bool,bool,System.Collections.Generic.List`1<string>,System.Collections.Generic.List`1<string>,bool)
Verse.Grammar.GrammarResolver:Resolve (string,Verse.Grammar.GrammarRequest,string,bool,string,System.Collections.Generic.List`1<string>,System.Collections.Generic.List`1<string>,bool)
RimWorld.NameGenerator:GenerateName (Verse.Grammar.GrammarRequest,System.Predicate`1<string>,bool,string,string)
RimWorld.NameGenerator:GenerateName (Verse.RulePackDef,System.Predicate`1<string>,bool,string,string,System.Collections.Generic.List`1<Verse.Grammar.Rule>)
RimWorld.NameGenerator:GenerateName (Verse.RulePackDef,System.Collections.Generic.IEnumerable`1<string>,bool,string)
RimWorld.FactionGenerator:NewGeneratedFaction (RimWorld.Planet.PlanetLayer,RimWorld.FactionGeneratorParms)
RimWorld.FactionGenerator:CreateFactionAndAddToManager (RimWorld.Planet.PlanetLayer,RimWorld.FactionDef)
RimWorld.FactionGenerator:AddFactionToManager (RimWorld.Planet.PlanetLayer,RimWorld.FactionDef)
RimWorld.FactionGenerator:InitializeFactions (RimWorld.Planet.PlanetLayer,System.Collections.Generic.List`1<RimWorld.FactionDef>)
(wrapper dynamic-method) MonoMod.Utils.DynamicMethodDefinition:RimWorld.FactionGenerator.GenerateFactionsIntoWorldLayer_Patch1 (RimWorld.Planet.PlanetLayer,System.Collections.Generic.List`1<RimWorld.FactionDef>)
RimWorld.Planet.WorldGenStep_Factions:GenerateFresh (string,RimWorld.Planet.PlanetLayer)
RimWorld.Planet.WorldGenerator:GeneratePlanetLayer (RimWorld.Planet.PlanetLayer,string,int)
RimWorld.Planet.WorldGenerator:GenerateWorld (single,string,RimWorld.Planet.OverallRainfall,RimWorld.Planet.OverallTemperature,RimWorld.Planet.OverallPopulation,RimWorld.Planet.LandmarkDensity,System.Collections.Generic.List`1<RimWorld.FactionDef>,single)
Verse.Root_Play:SetupForQuickTestPlay ()
RimWorld.MainMenuDrawer/<>c:<DoMainMenuControls>b__24_10 ()
Verse.LongEventHandler:RunEventFromAnotherThread (System.Action)
Verse.LongEventHandler/<>c:<UpdateCurrentAsynchronousEvent>b__28_0 ()
System.Threading.ThreadHelper:ThreadStart_Context (object)
System.Threading.ExecutionContext:RunInternal (System.Threading.ExecutionContext,System.Threading.ContextCallback,object,bool)
System.Threading.ExecutionContext:Run (System.Threading.ExecutionContext,System.Threading.ContextCallback,object,bool)
System.Threading.ExecutionContext:Run (System.Threading.ExecutionContext,System.Threading.ContextCallback,object)
System.Threading.ThreadHelper:ThreadStart ()

Grammar unresolvable. Root 'r_name'

GRAMMAR RESOLUTION TRACE
1    r_name → [placeNameCore] [faction]
2      placeNameCore → [SylI_M][SylI][placeEnd]
         SylI_M → UNRESOLVABLE
3        SylI->(43 strings from file: WordParts/Syllables_Impid)
3        placeEnd → que
2      placeNameCore → [SylI_M][SylI]
         SylI_M → UNRESOLVABLE
3        SylI->(43 strings from file: WordParts/Syllables_Impid)
2      placeNameCore → [SylI_M][SylI][SylI]
         SylI_M → UNRESOLVABLE
3        SylI->(43 strings from file: WordParts/Syllables_Impid)
3        SylI->(43 strings from file: WordParts/Syllables_Impid)
2      placeNameCore → [SylI_M][placeEnd]
         SylI_M → UNRESOLVABLE
3        placeEnd → s
       placeNameCore → UNRESOLVABLE
2      faction → league
1    r_name → [placeNameCore]
       placeNameCore → UNRESOLVABLE
1    r_name → [faction] of [placeNameCore]
2      faction → firehome
       placeNameCore → UNRESOLVABLE
     r_name → UNRESOLVABLE

INCLUDES
NamerFactionTribalImpid
ImpidUtility

CUSTOM RULES

UnityEngine.StackTraceUtility:ExtractStackTrace ()
Verse.Log:Error (string)
Verse.Log:ErrorOnce (string,int)
Verse.Grammar.GrammarResolver:ResolveUnsafe (string,Verse.Grammar.GrammarRequest,bool&,string,bool,bool,System.Collections.Generic.List`1<string>,System.Collections.Generic.List`1<string>,bool)
Verse.Grammar.GrammarResolver:ResolveUnsafe (string,Verse.Grammar.GrammarRequest,string,bool,bool,System.Collections.Generic.List`1<string>,System.Collections.Generic.List`1<string>,bool)
Verse.Grammar.GrammarResolver:ResolveUnsafe (string,Verse.Grammar.GrammarRequest,bool&,string,bool,bool,System.Collections.Generic.List`1<string>,System.Collections.Generic.List`1<string>,bool)
Verse.Grammar.GrammarResolver:Resolve (string,Verse.Grammar.GrammarRequest,string,bool,string,System.Collections.Generic.List`1<string>,System.Collections.Generic.List`1<string>,bool)
RimWorld.NameGenerator:GenerateName (Verse.Grammar.GrammarRequest,System.Predicate`1<string>,bool,string,string)
RimWorld.NameGenerator:GenerateName (Verse.RulePackDef,System.Predicate`1<string>,bool,string,string,System.Collections.Generic.List`1<Verse.Grammar.Rule>)
RimWorld.NameGenerator:GenerateName (Verse.RulePackDef,System.Collections.Generic.IEnumerable`1<string>,bool,string)
RimWorld.FactionGenerator:NewGeneratedFaction (RimWorld.Planet.PlanetLayer,RimWorld.FactionGeneratorParms)
RimWorld.FactionGenerator:CreateFactionAndAddToManager (RimWorld.Planet.PlanetLayer,RimWorld.FactionDef)
RimWorld.FactionGenerator:AddFactionToManager (RimWorld.Planet.PlanetLayer,RimWorld.FactionDef)
RimWorld.FactionGenerator:InitializeFactions (RimWorld.Planet.PlanetLayer,System.Collections.Generic.List`1<RimWorld.FactionDef>)
(wrapper dynamic-method) MonoMod.Utils.DynamicMethodDefinition:RimWorld.FactionGenerator.GenerateFactionsIntoWorldLayer_Patch1 (RimWorld.Planet.PlanetLayer,System.Collections.Generic.List`1<RimWorld.FactionDef>)
RimWorld.Planet.WorldGenStep_Factions:GenerateFresh (string,RimWorld.Planet.PlanetLayer)
RimWorld.Planet.WorldGenerator:GeneratePlanetLayer (RimWorld.Planet.PlanetLayer,string,int)
RimWorld.Planet.WorldGenerator:GenerateWorld (single,string,RimWorld.Planet.OverallRainfall,RimWorld.Planet.OverallTemperature,RimWorld.Planet.OverallPopulation,RimWorld.Planet.LandmarkDensity,System.Collections.Generic.List`1<RimWorld.FactionDef>,single)
Verse.Root_Play:SetupForQuickTestPlay ()
RimWorld.MainMenuDrawer/<>c:<DoMainMenuControls>b__24_10 ()
Verse.LongEventHandler:RunEventFromAnotherThread (System.Action)
Verse.LongEventHandler/<>c:<UpdateCurrentAsynchronousEvent>b__28_0 ()
System.Threading.ThreadHelper:ThreadStart_Context (object)
System.Threading.ExecutionContext:RunInternal (System.Threading.ExecutionContext,System.Threading.ContextCallback,object,bool)
System.Threading.ExecutionContext:Run (System.Threading.ExecutionContext,System.Threading.ContextCallback,object,bool)
System.Threading.ExecutionContext:Run (System.Threading.ExecutionContext,System.Threading.ContextCallback,object)
System.Threading.ThreadHelper:ThreadStart ()

Grammar unresolvable. Root 'r_name'

GRAMMAR RESOLUTION TRACE
1    r_name → [placeNameCore]
2      placeNameCore → [SylI_M][SylI][SylI]
         SylI_M → UNRESOLVABLE
3        SylI->(43 strings from file: WordParts/Syllables_Impid)
3        SylI->(43 strings from file: WordParts/Syllables_Impid)
2      placeNameCore → [SylI_M][SylI]
         SylI_M → UNRESOLVABLE
3        SylI->(43 strings from file: WordParts/Syllables_Impid)
2      placeNameCore → [SylI_M][SylI][placeEnd]
         SylI_M → UNRESOLVABLE
3        SylI->(43 strings from file: WordParts/Syllables_Impid)
3        placeEnd → s
2      placeNameCore → [SylI_M][placeEnd]
         SylI_M → UNRESOLVABLE
3        placeEnd → zos
       placeNameCore → UNRESOLVABLE
1    r_name → [placeNameCore] [faction]
       placeNameCore → UNRESOLVABLE
2      faction → clade
1    r_name → [faction] of [placeNameCore]
2      faction → firehome
       placeNameCore → UNRESOLVABLE
     r_name → UNRESOLVABLE

INCLUDES
NamerFactionTribalImpid
ImpidUtility

CUSTOM RULES

UnityEngine.StackTraceUtility:ExtractStackTrace ()
Verse.Log:Error (string)
Verse.Log:ErrorOnce (string,int)
Verse.Grammar.GrammarResolver:ResolveUnsafe (string,Verse.Grammar.GrammarRequest,bool&,string,bool,bool,System.Collections.Generic.List`1<string>,System.Collections.Generic.List`1<string>,bool)
Verse.Grammar.GrammarResolver:ResolveUnsafe (string,Verse.Grammar.GrammarRequest,string,bool,bool,System.Collections.Generic.List`1<string>,System.Collections.Generic.List`1<string>,bool)
Verse.Grammar.GrammarResolver:ResolveUnsafe (string,Verse.Grammar.GrammarRequest,bool&,string,bool,bool,System.Collections.Generic.List`1<string>,System.Collections.Generic.List`1<string>,bool)
Verse.Grammar.GrammarResolver:Resolve (string,Verse.Grammar.GrammarRequest,string,bool,string,System.Collections.Generic.List`1<string>,System.Collections.Generic.List`1<string>,bool)
RimWorld.NameGenerator:GenerateName (Verse.Grammar.GrammarRequest,System.Predicate`1<string>,bool,string,string)
RimWorld.NameGenerator:GenerateName (Verse.RulePackDef,System.Predicate`1<string>,bool,string,string,System.Collections.Generic.List`1<Verse.Grammar.Rule>)
RimWorld.NameGenerator:GenerateName (Verse.RulePackDef,System.Collections.Generic.IEnumerable`1<string>,bool,string)
RimWorld.FactionGenerator:NewGeneratedFaction (RimWorld.Planet.PlanetLayer,RimWorld.FactionGeneratorParms)
RimWorld.FactionGenerator:CreateFactionAndAddToManager (RimWorld.Planet.PlanetLayer,RimWorld.FactionDef)
RimWorld.FactionGenerator:AddFactionToManager (RimWorld.Planet.PlanetLayer,RimWorld.FactionDef)
RimWorld.FactionGenerator:InitializeFactions (RimWorld.Planet.PlanetLayer,System.Collections.Generic.List`1<RimWorld.FactionDef>)
(wrapper dynamic-method) MonoMod.Utils.DynamicMethodDefinition:RimWorld.FactionGenerator.GenerateFactionsIntoWorldLayer_Patch1 (RimWorld.Planet.PlanetLayer,System.Collections.Generic.List`1<RimWorld.FactionDef>)
RimWorld.Planet.WorldGenStep_Factions:GenerateFresh (string,RimWorld.Planet.PlanetLayer)
RimWorld.Planet.WorldGenerator:GeneratePlanetLayer (RimWorld.Planet.PlanetLayer,string,int)
RimWorld.Planet.WorldGenerator:GenerateWorld (single,string,RimWorld.Planet.OverallRainfall,RimWorld.Planet.OverallTemperature,RimWorld.Planet.OverallPopulation,RimWorld.Planet.LandmarkDensity,System.Collections.Generic.List`1<RimWorld.FactionDef>,single)
Verse.Root_Play:SetupForQuickTestPlay ()
RimWorld.MainMenuDrawer/<>c:<DoMainMenuControls>b__24_10 ()
Verse.LongEventHandler:RunEventFromAnotherThread (System.Action)
Verse.LongEventHandler/<>c:<UpdateCurrentAsynchronousEvent>b__28_0 ()
System.Threading.ThreadHelper:ThreadStart_Context (object)
System.Threading.ExecutionContext:RunInternal (System.Threading.ExecutionContext,System.Threading.ContextCallback,object,bool)
System.Threading.ExecutionContext:Run (System.Threading.ExecutionContext,System.Threading.ContextCallback,object,bool)
System.Threading.ExecutionContext:Run (System.Threading.ExecutionContext,System.Threading.ContextCallback,object)
System.Threading.ThreadHelper:ThreadStart ()

Grammar unresolvable. Root 'r_name'

GRAMMAR RESOLUTION TRACE
1    r_name → [faction] of [placeNameCore]
2      faction → runship
2      placeNameCore → [SylI_M][SylI][SylI]
         SylI_M → UNRESOLVABLE
3        SylI->(43 strings from file: WordParts/Syllables_Impid)
3        SylI->(43 strings from file: WordParts/Syllables_Impid)
2      placeNameCore → [SylI_M][SylI]
         SylI_M → UNRESOLVABLE
3        SylI->(43 strings from file: WordParts/Syllables_Impid)
2      placeNameCore → [SylI_M][SylI][placeEnd]
         SylI_M → UNRESOLVABLE
3        SylI->(43 strings from file: WordParts/Syllables_Impid)
3        placeEnd → te
2      placeNameCore → [SylI_M][placeEnd]
         SylI_M → UNRESOLVABLE
3        placeEnd → tches
       placeNameCore → UNRESOLVABLE
1    r_name → [placeNameCore]
       placeNameCore → UNRESOLVABLE
1    r_name → [placeNameCore] [faction]
       placeNameCore → UNRESOLVABLE
2      faction → league
     r_name → UNRESOLVABLE

INCLUDES
NamerFactionTribalImpid
ImpidUtility

CUSTOM RULES

UnityEngine.StackTraceUtility:ExtractStackTrace ()
Verse.Log:Error (string)
Verse.Log:ErrorOnce (string,int)
Verse.Grammar.GrammarResolver:ResolveUnsafe (string,Verse.Grammar.GrammarRequest,bool&,string,bool,bool,System.Collections.Generic.List`1<string>,System.Collections.Generic.List`1<string>,bool)
Verse.Grammar.GrammarResolver:ResolveUnsafe (string,Verse.Grammar.GrammarRequest,string,bool,bool,System.Collections.Generic.List`1<string>,System.Collections.Generic.List`1<string>,bool)
Verse.Grammar.GrammarResolver:ResolveUnsafe (string,Verse.Grammar.GrammarRequest,bool&,string,bool,bool,System.Collections.Generic.List`1<string>,System.Collections.Generic.List`1<string>,bool)
Verse.Grammar.GrammarResolver:Resolve (string,Verse.Grammar.GrammarRequest,string,bool,string,System.Collections.Generic.List`1<string>,System.Collections.Generic.List`1<string>,bool)
RimWorld.NameGenerator:GenerateName (Verse.Grammar.GrammarRequest,System.Predicate`1<string>,bool,string,string)
RimWorld.NameGenerator:GenerateName (Verse.RulePackDef,System.Predicate`1<string>,bool,string,string,System.Collections.Generic.List`1<Verse.Grammar.Rule>)
RimWorld.NameGenerator:GenerateName (Verse.RulePackDef,System.Collections.Generic.IEnumerable`1<string>,bool,string)
RimWorld.FactionGenerator:NewGeneratedFaction (RimWorld.Planet.PlanetLayer,RimWorld.FactionGeneratorParms)
RimWorld.FactionGenerator:CreateFactionAndAddToManager (RimWorld.Planet.PlanetLayer,RimWorld.FactionDef)
RimWorld.FactionGenerator:AddFactionToManager (RimWorld.Planet.PlanetLayer,RimWorld.FactionDef)
RimWorld.FactionGenerator:InitializeFactions (RimWorld.Planet.PlanetLayer,System.Collections.Generic.List`1<RimWorld.FactionDef>)
(wrapper dynamic-method) MonoMod.Utils.DynamicMethodDefinition:RimWorld.FactionGenerator.GenerateFactionsIntoWorldLayer_Patch1 (RimWorld.Planet.PlanetLayer,System.Collections.Generic.List`1<RimWorld.FactionDef>)
RimWorld.Planet.WorldGenStep_Factions:GenerateFresh (string,RimWorld.Planet.PlanetLayer)
RimWorld.Planet.WorldGenerator:GeneratePlanetLayer (RimWorld.Planet.PlanetLayer,string,int)
RimWorld.Planet.WorldGenerator:GenerateWorld (single,string,RimWorld.Planet.OverallRainfall,RimWorld.Planet.OverallTemperature,RimWorld.Planet.OverallPopulation,RimWorld.Planet.LandmarkDensity,System.Collections.Generic.List`1<RimWorld.FactionDef>,single)
Verse.Root_Play:SetupForQuickTestPlay ()
RimWorld.MainMenuDrawer/<>c:<DoMainMenuControls>b__24_10 ()
Verse.LongEventHandler:RunEventFromAnotherThread (System.Action)
Verse.LongEventHandler/<>c:<UpdateCurrentAsynchronousEvent>b__28_0 ()
System.Threading.ThreadHelper:ThreadStart_Context (object)
System.Threading.ExecutionContext:RunInternal (System.Threading.ExecutionContext,System.Threading.ContextCallback,object,bool)
System.Threading.ExecutionContext:Run (System.Threading.ExecutionContext,System.Threading.ContextCallback,object,bool)
System.Threading.ExecutionContext:Run (System.Threading.ExecutionContext,System.Threading.ContextCallback,object)
System.Threading.ThreadHelper:ThreadStart ()

Grammar unresolvable. Root 'r_name'

GRAMMAR RESOLUTION TRACE
1    r_name → [placeNameCore] [faction]
2      placeNameCore → [SylI_M][SylI]
         SylI_M → UNRESOLVABLE
3        SylI->(43 strings from file: WordParts/Syllables_Impid)
2      placeNameCore → [SylI_M][SylI][placeEnd]
         SylI_M → UNRESOLVABLE
3        SylI->(43 strings from file: WordParts/Syllables_Impid)
3        placeEnd → z
2      placeNameCore → [SylI_M][placeEnd]
         SylI_M → UNRESOLVABLE
3        placeEnd → tches
2      placeNameCore → [SylI_M][SylI][SylI]
         SylI_M → UNRESOLVABLE
3        SylI->(43 strings from file: WordParts/Syllables_Impid)
3        SylI->(43 strings from file: WordParts/Syllables_Impid)
       placeNameCore → UNRESOLVABLE
2      faction → league
1    r_name → [placeNameCore]
       placeNameCore → UNRESOLVABLE
1    r_name → [faction] of [placeNameCore]
2      faction → runship
       placeNameCore → UNRESOLVABLE
     r_name → UNRESOLVABLE

INCLUDES
NamerFactionTribalImpid
ImpidUtility

CUSTOM RULES

UnityEngine.StackTraceUtility:ExtractStackTrace ()
Verse.Log:Error (string)
Verse.Log:ErrorOnce (string,int)
Verse.Grammar.GrammarResolver:ResolveUnsafe (string,Verse.Grammar.GrammarRequest,bool&,string,bool,bool,System.Collections.Generic.List`1<string>,System.Collections.Generic.List`1<string>,bool)
Verse.Grammar.GrammarResolver:ResolveUnsafe (string,Verse.Grammar.GrammarRequest,string,bool,bool,System.Collections.Generic.List`1<string>,System.Collections.Generic.List`1<string>,bool)
Verse.Grammar.GrammarResolver:ResolveUnsafe (string,Verse.Grammar.GrammarRequest,bool&,string,bool,bool,System.Collections.Generic.List`1<string>,System.Collections.Generic.List`1<string>,bool)
Verse.Grammar.GrammarResolver:Resolve (string,Verse.Grammar.GrammarRequest,string,bool,string,System.Collections.Generic.List`1<string>,System.Collections.Generic.List`1<string>,bool)
RimWorld.NameGenerator:GenerateName (Verse.Grammar.GrammarRequest,System.Predicate`1<string>,bool,string,string)
RimWorld.NameGenerator:GenerateName (Verse.RulePackDef,System.Predicate`1<string>,bool,string,string,System.Collections.Generic.List`1<Verse.Grammar.Rule>)
RimWorld.NameGenerator:GenerateName (Verse.RulePackDef,System.Collections.Generic.IEnumerable`1<string>,bool,string)
RimWorld.FactionGenerator:NewGeneratedFaction (RimWorld.Planet.PlanetLayer,RimWorld.FactionGeneratorParms)
RimWorld.FactionGenerator:CreateFactionAndAddToManager (RimWorld.Planet.PlanetLayer,RimWorld.FactionDef)
RimWorld.FactionGenerator:AddFactionToManager (RimWorld.Planet.PlanetLayer,RimWorld.FactionDef)
RimWorld.FactionGenerator:InitializeFactions (RimWorld.Planet.PlanetLayer,System.Collections.Generic.List`1<RimWorld.FactionDef>)
(wrapper dynamic-method) MonoMod.Utils.DynamicMethodDefinition:RimWorld.FactionGenerator.GenerateFactionsIntoWorldLayer_Patch1 (RimWorld.Planet.PlanetLayer,System.Collections.Generic.List`1<RimWorld.FactionDef>)
RimWorld.Planet.WorldGenStep_Factions:GenerateFresh (string,RimWorld.Planet.PlanetLayer)
RimWorld.Planet.WorldGenerator:GeneratePlanetLayer (RimWorld.Planet.PlanetLayer,string,int)
RimWorld.Planet.WorldGenerator:GenerateWorld (single,string,RimWorld.Planet.OverallRainfall,RimWorld.Planet.OverallTemperature,RimWorld.Planet.OverallPopulation,RimWorld.Planet.LandmarkDensity,System.Collections.Generic.List`1<RimWorld.FactionDef>,single)
Verse.Root_Play:SetupForQuickTestPlay ()
RimWorld.MainMenuDrawer/<>c:<DoMainMenuControls>b__24_10 ()
Verse.LongEventHandler:RunEventFromAnotherThread (System.Action)
Verse.LongEventHandler/<>c:<UpdateCurrentAsynchronousEvent>b__28_0 ()
System.Threading.ThreadHelper:ThreadStart_Context (object)
System.Threading.ExecutionContext:RunInternal (System.Threading.ExecutionContext,System.Threading.ContextCallback,object,bool)
System.Threading.ExecutionContext:Run (System.Threading.ExecutionContext,System.Threading.ContextCallback,object,bool)
System.Threading.ExecutionContext:Run (System.Threading.ExecutionContext,System.Threading.ContextCallback,object)
System.Threading.ThreadHelper:ThreadStart ()

Grammar unresolvable. Root 'r_name'

GRAMMAR RESOLUTION TRACE
1    r_name → [placeNameCore]
2      placeNameCore → [SylI_M][SylI]
         SylI_M → UNRESOLVABLE
3        SylI->(43 strings from file: WordParts/Syllables_Impid)
2      placeNameCore → [SylI_M][SylI][placeEnd]
         SylI_M → UNRESOLVABLE
3        SylI->(43 strings from file: WordParts/Syllables_Impid)
3        placeEnd → m
2      placeNameCore → [SylI_M][placeEnd]
         SylI_M → UNRESOLVABLE
3        placeEnd → ns
2      placeNameCore → [SylI_M][SylI][SylI]
         SylI_M → UNRESOLVABLE
3        SylI->(43 strings from file: WordParts/Syllables_Impid)
3        SylI->(43 strings from file: WordParts/Syllables_Impid)
       placeNameCore → UNRESOLVABLE
1    r_name → [faction] of [placeNameCore]
2      faction → league
       placeNameCore → UNRESOLVABLE
1    r_name → [placeNameCore] [faction]
       placeNameCore → UNRESOLVABLE
2      faction → clade
     r_name → UNRESOLVABLE

INCLUDES
NamerFactionTribalImpid
ImpidUtility

CUSTOM RULES

UnityEngine.StackTraceUtility:ExtractStackTrace ()
Verse.Log:Error (string)
Verse.Log:ErrorOnce (string,int)
Verse.Grammar.GrammarResolver:ResolveUnsafe (string,Verse.Grammar.GrammarRequest,bool&,string,bool,bool,System.Collections.Generic.List`1<string>,System.Collections.Generic.List`1<string>,bool)
Verse.Grammar.GrammarResolver:ResolveUnsafe (string,Verse.Grammar.GrammarRequest,string,bool,bool,System.Collections.Generic.List`1<string>,System.Collections.Generic.List`1<string>,bool)
Verse.Grammar.GrammarResolver:ResolveUnsafe (string,Verse.Grammar.GrammarRequest,bool&,string,bool,bool,System.Collections.Generic.List`1<string>,System.Collections.Generic.List`1<string>,bool)
Verse.Grammar.GrammarResolver:Resolve (string,Verse.Grammar.GrammarRequest,string,bool,string,System.Collections.Generic.List`1<string>,System.Collections.Generic.List`1<string>,bool)
RimWorld.NameGenerator:GenerateName (Verse.Grammar.GrammarRequest,System.Predicate`1<string>,bool,string,string)
RimWorld.NameGenerator:GenerateName (Verse.RulePackDef,System.Predicate`1<string>,bool,string,string,System.Collections.Generic.List`1<Verse.Grammar.Rule>)
RimWorld.NameGenerator:GenerateName (Verse.RulePackDef,System.Collections.Generic.IEnumerable`1<string>,bool,string)
RimWorld.FactionGenerator:NewGeneratedFaction (RimWorld.Planet.PlanetLayer,RimWorld.FactionGeneratorParms)
RimWorld.FactionGenerator:CreateFactionAndAddToManager (RimWorld.Planet.PlanetLayer,RimWorld.FactionDef)
RimWorld.FactionGenerator:AddFactionToManager (RimWorld.Planet.PlanetLayer,RimWorld.FactionDef)
RimWorld.FactionGenerator:InitializeFactions (RimWorld.Planet.PlanetLayer,System.Collections.Generic.List`1<RimWorld.FactionDef>)
(wrapper dynamic-method) MonoMod.Utils.DynamicMethodDefinition:RimWorld.FactionGenerator.GenerateFactionsIntoWorldLayer_Patch1 (RimWorld.Planet.PlanetLayer,System.Collections.Generic.List`1<RimWorld.FactionDef>)
RimWorld.Planet.WorldGenStep_Factions:GenerateFresh (string,RimWorld.Planet.PlanetLayer)
RimWorld.Planet.WorldGenerator:GeneratePlanetLayer (RimWorld.Planet.PlanetLayer,string,int)
RimWorld.Planet.WorldGenerator:GenerateWorld (single,string,RimWorld.Planet.OverallRainfall,RimWorld.Planet.OverallTemperature,RimWorld.Planet.OverallPopulation,RimWorld.Planet.LandmarkDensity,System.Collections.Generic.List`1<RimWorld.FactionDef>,single)
Verse.Root_Play:SetupForQuickTestPlay ()
RimWorld.MainMenuDrawer/<>c:<DoMainMenuControls>b__24_10 ()
Verse.LongEventHandler:RunEventFromAnotherThread (System.Action)
Verse.LongEventHandler/<>c:<UpdateCurrentAsynchronousEvent>b__28_0 ()
System.Threading.ThreadHelper:ThreadStart_Context (object)
System.Threading.ExecutionContext:RunInternal (System.Threading.ExecutionContext,System.Threading.ContextCallback,object,bool)
System.Threading.ExecutionContext:Run (System.Threading.ExecutionContext,System.Threading.ContextCallback,object,bool)
System.Threading.ExecutionContext:Run (System.Threading.ExecutionContext,System.Threading.ContextCallback,object)
System.Threading.ThreadHelper:ThreadStart ()

Grammar unresolvable. Root 'r_name'

GRAMMAR RESOLUTION TRACE
1    r_name → [placeNameCore]
2      placeNameCore → [SylI_M][SylI][placeEnd]
         SylI_M → UNRESOLVABLE
3        SylI->(43 strings from file: WordParts/Syllables_Impid)
3        placeEnd → que
2      placeNameCore → [SylI_M][SylI][SylI]
         SylI_M → UNRESOLVABLE
3        SylI->(43 strings from file: WordParts/Syllables_Impid)
3        SylI->(43 strings from file: WordParts/Syllables_Impid)
2      placeNameCore → [SylI_M][placeEnd]
         SylI_M → UNRESOLVABLE
3        placeEnd → tches
2      placeNameCore → [SylI_M][SylI]
         SylI_M → UNRESOLVABLE
3        SylI->(43 strings from file: WordParts/Syllables_Impid)
       placeNameCore → UNRESOLVABLE
     r_name → UNRESOLVABLE

INCLUDES
NamerSettlementTribalImpid
ImpidUtility

CUSTOM RULES

UnityEngine.StackTraceUtility:ExtractStackTrace ()
Verse.Log:Error (string)
Verse.Log:ErrorOnce (string,int)
Verse.Grammar.GrammarResolver:ResolveUnsafe (string,Verse.Grammar.GrammarRequest,bool&,string,bool,bool,System.Collections.Generic.List`1<string>,System.Collections.Generic.List`1<string>,bool)
Verse.Grammar.GrammarResolver:ResolveUnsafe (string,Verse.Grammar.GrammarRequest,string,bool,bool,System.Collections.Generic.List`1<string>,System.Collections.Generic.List`1<string>,bool)
Verse.Grammar.GrammarResolver:ResolveUnsafe (string,Verse.Grammar.GrammarRequest,bool&,string,bool,bool,System.Collections.Generic.List`1<string>,System.Collections.Generic.List`1<string>,bool)
Verse.Grammar.GrammarResolver:Resolve (string,Verse.Grammar.GrammarRequest,string,bool,string,System.Collections.Generic.List`1<string>,System.Collections.Generic.List`1<string>,bool)
RimWorld.NameGenerator:GenerateName (Verse.Grammar.GrammarRequest,System.Predicate`1<string>,bool,string,string)
RimWorld.NameGenerator:GenerateName (Verse.RulePackDef,System.Predicate`1<string>,bool,string,string,System.Collections.Generic.List`1<Verse.Grammar.Rule>)
RimWorld.NameGenerator:GenerateName (Verse.RulePackDef,System.Collections.Generic.IEnumerable`1<string>,bool,string)
RimWorld.Planet.SettlementNameGenerator:GenerateSettlementName (RimWorld.Planet.WorldObject,Verse.RulePackDef)
RimWorld.FactionGenerator:NewGeneratedFaction (RimWorld.Planet.PlanetLayer,RimWorld.FactionGeneratorParms)
RimWorld.FactionGenerator:CreateFactionAndAddToManager (RimWorld.Planet.PlanetLayer,RimWorld.FactionDef)
RimWorld.FactionGenerator:AddFactionToManager (RimWorld.Planet.PlanetLayer,RimWorld.FactionDef)
RimWorld.FactionGenerator:InitializeFactions (RimWorld.Planet.PlanetLayer,System.Collections.Generic.List`1<RimWorld.FactionDef>)
(wrapper dynamic-method) MonoMod.Utils.DynamicMethodDefinition:RimWorld.FactionGenerator.GenerateFactionsIntoWorldLayer_Patch1 (RimWorld.Planet.PlanetLayer,System.Collections.Generic.List`1<RimWorld.FactionDef>)
RimWorld.Planet.WorldGenStep_Factions:GenerateFresh (string,RimWorld.Planet.PlanetLayer)
RimWorld.Planet.WorldGenerator:GeneratePlanetLayer (RimWorld.Planet.PlanetLayer,string,int)
RimWorld.Planet.WorldGenerator:GenerateWorld (single,string,RimWorld.Planet.OverallRainfall,RimWorld.Planet.OverallTemperature,RimWorld.Planet.OverallPopulation,RimWorld.Planet.LandmarkDensity,System.Collections.Generic.List`1<RimWorld.FactionDef>,single)
Verse.Root_Play:SetupForQuickTestPlay ()
RimWorld.MainMenuDrawer/<>c:<DoMainMenuControls>b__24_10 ()
Verse.LongEventHandler:RunEventFromAnotherThread (System.Action)
Verse.LongEventHandler/<>c:<UpdateCurrentAsynchronousEvent>b__28_0 ()
System.Threading.ThreadHelper:ThreadStart_Context (object)
System.Threading.ExecutionContext:RunInternal (System.Threading.ExecutionContext,System.Threading.ContextCallback,object,bool)
System.Threading.ExecutionContext:Run (System.Threading.ExecutionContext,System.Threading.ContextCallback,object,bool)
System.Threading.ExecutionContext:Run (System.Threading.ExecutionContext,System.Threading.ContextCallback,object)
System.Threading.ThreadHelper:ThreadStart ()

Grammar unresolvable. Root 'r_name'

GRAMMAR RESOLUTION TRACE
1    r_name → [placeNameCore]
2      placeNameCore → [SylI_M][placeEnd]
         SylI_M → UNRESOLVABLE
3        placeEnd → te
2      placeNameCore → [SylI_M][SylI][SylI]
         SylI_M → UNRESOLVABLE
3        SylI->(43 strings from file: WordParts/Syllables_Impid)
3        SylI->(43 strings from file: WordParts/Syllables_Impid)
2      placeNameCore → [SylI_M][SylI]
         SylI_M → UNRESOLVABLE
3        SylI->(43 strings from file: WordParts/Syllables_Impid)
2      placeNameCore → [SylI_M][SylI][placeEnd]
         SylI_M → UNRESOLVABLE
3        SylI->(43 strings from file: WordParts/Syllables_Impid)
3        placeEnd → tches
       placeNameCore → UNRESOLVABLE
     r_name → UNRESOLVABLE

INCLUDES
NamerSettlementTribalImpid
ImpidUtility

CUSTOM RULES

UnityEngine.StackTraceUtility:ExtractStackTrace ()
Verse.Log:Error (string)
Verse.Log:ErrorOnce (string,int)
Verse.Grammar.GrammarResolver:ResolveUnsafe (string,Verse.Grammar.GrammarRequest,bool&,string,bool,bool,System.Collections.Generic.List`1<string>,System.Collections.Generic.List`1<string>,bool)
Verse.Grammar.GrammarResolver:ResolveUnsafe (string,Verse.Grammar.GrammarRequest,string,bool,bool,System.Collections.Generic.List`1<string>,System.Collections.Generic.List`1<string>,bool)
Verse.Grammar.GrammarResolver:ResolveUnsafe (string,Verse.Grammar.GrammarRequest,bool&,string,bool,bool,System.Collections.Generic.List`1<string>,System.Collections.Generic.List`1<string>,bool)
Verse.Grammar.GrammarResolver:Resolve (string,Verse.Grammar.GrammarRequest,string,bool,string,System.Collections.Generic.List`1<string>,System.Collections.Generic.List`1<string>,bool)
RimWorld.NameGenerator:GenerateName (Verse.Grammar.GrammarRequest,System.Predicate`1<string>,bool,string,string)
RimWorld.NameGenerator:GenerateName (Verse.RulePackDef,System.Predicate`1<string>,bool,string,string,System.Collections.Generic.List`1<Verse.Grammar.Rule>)
RimWorld.NameGenerator:GenerateName (Verse.RulePackDef,System.Collections.Generic.IEnumerable`1<string>,bool,string)
RimWorld.Planet.SettlementNameGenerator:GenerateSettlementName (RimWorld.Planet.WorldObject,Verse.RulePackDef)
(wrapper dynamic-method) MonoMod.Utils.DynamicMethodDefinition:RimWorld.FactionGenerator.GenerateFactionsIntoWorldLayer_Patch1 (RimWorld.Planet.PlanetLayer,System.Collections.Generic.List`1<RimWorld.FactionDef>)
RimWorld.Planet.WorldGenStep_Factions:GenerateFresh (string,RimWorld.Planet.PlanetLayer)
RimWorld.Planet.WorldGenerator:GeneratePlanetLayer (RimWorld.Planet.PlanetLayer,string,int)
RimWorld.Planet.WorldGenerator:GenerateWorld (single,string,RimWorld.Planet.OverallRainfall,RimWorld.Planet.OverallTemperature,RimWorld.Planet.OverallPopulation,RimWorld.Planet.LandmarkDensity,System.Collections.Generic.List`1<RimWorld.FactionDef>,single)
Verse.Root_Play:SetupForQuickTestPlay ()
RimWorld.MainMenuDrawer/<>c:<DoMainMenuControls>b__24_10 ()
Verse.LongEventHandler:RunEventFromAnotherThread (System.Action)
Verse.LongEventHandler/<>c:<UpdateCurrentAsynchronousEvent>b__28_0 ()
System.Threading.ThreadHelper:ThreadStart_Context (object)
System.Threading.ExecutionContext:RunInternal (System.Threading.ExecutionContext,System.Threading.ContextCallback,object,bool)
System.Threading.ExecutionContext:Run (System.Threading.ExecutionContext,System.Threading.ContextCallback,object,bool)
System.Threading.ExecutionContext:Run (System.Threading.ExecutionContext,System.Threading.ContextCallback,object)
System.Threading.ThreadHelper:ThreadStart ()

Grammar unresolvable. Root 'r_name'

GRAMMAR RESOLUTION TRACE
1    r_name → [placeNameCore]
2      placeNameCore → [SylI_M][SylI][placeEnd]
         SylI_M → UNRESOLVABLE
3        SylI->(43 strings from file: WordParts/Syllables_Impid)
3        placeEnd → z
2      placeNameCore → [SylI_M][placeEnd]
         SylI_M → UNRESOLVABLE
3        placeEnd → ns
2      placeNameCore → [SylI_M][SylI][SylI]
         SylI_M → UNRESOLVABLE
3        SylI->(43 strings from file: WordParts/Syllables_Impid)
3        SylI->(43 strings from file: WordParts/Syllables_Impid)
2      placeNameCore → [SylI_M][SylI]
         SylI_M → UNRESOLVABLE
3        SylI->(43 strings from file: WordParts/Syllables_Impid)
       placeNameCore → UNRESOLVABLE
     r_name → UNRESOLVABLE

INCLUDES
NamerSettlementTribalImpid
ImpidUtility

CUSTOM RULES

UnityEngine.StackTraceUtility:ExtractStackTrace ()
Verse.Log:Error (string)
Verse.Log:ErrorOnce (string,int)
Verse.Grammar.GrammarResolver:ResolveUnsafe (string,Verse.Grammar.GrammarRequest,bool&,string,bool,bool,System.Collections.Generic.List`1<string>,System.Collections.Generic.List`1<string>,bool)
Verse.Grammar.GrammarResolver:ResolveUnsafe (string,Verse.Grammar.GrammarRequest,string,bool,bool,System.Collections.Generic.List`1<string>,System.Collections.Generic.List`1<string>,bool)
Verse.Grammar.GrammarResolver:ResolveUnsafe (string,Verse.Grammar.GrammarRequest,bool&,string,bool,bool,System.Collections.Generic.List`1<string>,System.Collections.Generic.List`1<string>,bool)
Verse.Grammar.GrammarResolver:Resolve (string,Verse.Grammar.GrammarRequest,string,bool,string,System.Collections.Generic.List`1<string>,System.Collections.Generic.List`1<string>,bool)
RimWorld.NameGenerator:GenerateName (Verse.Grammar.GrammarRequest,System.Predicate`1<string>,bool,string,string)
RimWorld.NameGenerator:GenerateName (Verse.RulePackDef,System.Predicate`1<string>,bool,string,string,System.Collections.Generic.List`1<Verse.Grammar.Rule>)
RimWorld.NameGenerator:GenerateName (Verse.RulePackDef,System.Collections.Generic.IEnumerable`1<string>,bool,string)
RimWorld.Planet.SettlementNameGenerator:GenerateSettlementName (RimWorld.Planet.WorldObject,Verse.RulePackDef)
(wrapper dynamic-method) MonoMod.Utils.DynamicMethodDefinition:RimWorld.FactionGenerator.GenerateFactionsIntoWorldLayer_Patch1 (RimWorld.Planet.PlanetLayer,System.Collections.Generic.List`1<RimWorld.FactionDef>)
RimWorld.Planet.WorldGenStep_Factions:GenerateFresh (string,RimWorld.Planet.PlanetLayer)
RimWorld.Planet.WorldGenerator:GeneratePlanetLayer (RimWorld.Planet.PlanetLayer,string,int)
RimWorld.Planet.WorldGenerator:GenerateWorld (single,string,RimWorld.Planet.OverallRainfall,RimWorld.Planet.OverallTemperature,RimWorld.Planet.OverallPopulation,RimWorld.Planet.LandmarkDensity,System.Collections.Generic.List`1<RimWorld.FactionDef>,single)
Verse.Root_Play:SetupForQuickTestPlay ()
RimWorld.MainMenuDrawer/<>c:<DoMainMenuControls>b__24_10 ()
Verse.LongEventHandler:RunEventFromAnotherThread (System.Action)
Verse.LongEventHandler/<>c:<UpdateCurrentAsynchronousEvent>b__28_0 ()
System.Threading.ThreadHelper:ThreadStart_Context (object)
System.Threading.ExecutionContext:RunInternal (System.Threading.ExecutionContext,System.Threading.ContextCallback,object,bool)
System.Threading.ExecutionContext:Run (System.Threading.ExecutionContext,System.Threading.ContextCallback,object,bool)
System.Threading.ExecutionContext:Run (System.Threading.ExecutionContext,System.Threading.ContextCallback,object)
System.Threading.ThreadHelper:ThreadStart ()

Grammar unresolvable. Root 'r_name'

GRAMMAR RESOLUTION TRACE
1    r_name → [placeNameCore]
2      placeNameCore → [SylI_M][SylI][placeEnd]
         SylI_M → UNRESOLVABLE
3        SylI->(43 strings from file: WordParts/Syllables_Impid)
3        placeEnd → z
2      placeNameCore → [SylI_M][SylI]
         SylI_M → UNRESOLVABLE
3        SylI->(43 strings from file: WordParts/Syllables_Impid)
2      placeNameCore → [SylI_M][placeEnd]
         SylI_M → UNRESOLVABLE
3        placeEnd → te
2      placeNameCore → [SylI_M][SylI][SylI]
         SylI_M → UNRESOLVABLE
3        SylI->(43 strings from file: WordParts/Syllables_Impid)
3        SylI->(43 strings from file: WordParts/Syllables_Impid)
       placeNameCore → UNRESOLVABLE
     r_name → UNRESOLVABLE

INCLUDES
NamerSettlementTribalImpid
ImpidUtility

CUSTOM RULES

UnityEngine.StackTraceUtility:ExtractStackTrace ()
Verse.Log:Error (string)
Verse.Log:ErrorOnce (string,int)
Verse.Grammar.GrammarResolver:ResolveUnsafe (string,Verse.Grammar.GrammarRequest,bool&,string,bool,bool,System.Collections.Generic.List`1<string>,System.Collections.Generic.List`1<string>,bool)
Verse.Grammar.GrammarResolver:ResolveUnsafe (string,Verse.Grammar.GrammarRequest,string,bool,bool,System.Collections.Generic.List`1<string>,System.Collections.Generic.List`1<string>,bool)
Verse.Grammar.GrammarResolver:ResolveUnsafe (string,Verse.Grammar.GrammarRequest,bool&,string,bool,bool,System.Collections.Generic.List`1<string>,System.Collections.Generic.List`1<string>,bool)
Verse.Grammar.GrammarResolver:Resolve (string,Verse.Grammar.GrammarRequest,string,bool,string,System.Collections.Generic.List`1<string>,System.Collections.Generic.List`1<string>,bool)
RimWorld.NameGenerator:GenerateName (Verse.Grammar.GrammarRequest,System.Predicate`1<string>,bool,string,string)
RimWorld.NameGenerator:GenerateName (Verse.RulePackDef,System.Predicate`1<string>,bool,string,string,System.Collections.Generic.List`1<Verse.Grammar.Rule>)
RimWorld.NameGenerator:GenerateName (Verse.RulePackDef,System.Collections.Generic.IEnumerable`1<string>,bool,string)
RimWorld.Planet.SettlementNameGenerator:GenerateSettlementName (RimWorld.Planet.WorldObject,Verse.RulePackDef)
(wrapper dynamic-method) MonoMod.Utils.DynamicMethodDefinition:RimWorld.FactionGenerator.GenerateFactionsIntoWorldLayer_Patch1 (RimWorld.Planet.PlanetLayer,System.Collections.Generic.List`1<RimWorld.FactionDef>)
RimWorld.Planet.WorldGenStep_Factions:GenerateFresh (string,RimWorld.Planet.PlanetLayer)
RimWorld.Planet.WorldGenerator:GeneratePlanetLayer (RimWorld.Planet.PlanetLayer,string,int)
RimWorld.Planet.WorldGenerator:GenerateWorld (single,string,RimWorld.Planet.OverallRainfall,RimWorld.Planet.OverallTemperature,RimWorld.Planet.OverallPopulation,RimWorld.Planet.LandmarkDensity,System.Collections.Generic.List`1<RimWorld.FactionDef>,single)
Verse.Root_Play:SetupForQuickTestPlay ()
RimWorld.MainMenuDrawer/<>c:<DoMainMenuControls>b__24_10 ()
Verse.LongEventHandler:RunEventFromAnotherThread (System.Action)
Verse.LongEventHandler/<>c:<UpdateCurrentAsynchronousEvent>b__28_0 ()
System.Threading.ThreadHelper:ThreadStart_Context (object)
System.Threading.ExecutionContext:RunInternal (System.Threading.ExecutionContext,System.Threading.ContextCallback,object,bool)
System.Threading.ExecutionContext:Run (System.Threading.ExecutionContext,System.Threading.ContextCallback,object,bool)
System.Threading.ExecutionContext:Run (System.Threading.ExecutionContext,System.Threading.ContextCallback,object)
System.Threading.ThreadHelper:ThreadStart ()

Grammar unresolvable. Root 'r_name'

GRAMMAR RESOLUTION TRACE
1    r_name → [placeNameCore]
2      placeNameCore → [SylI_M][SylI][SylI]
         SylI_M → UNRESOLVABLE
3        SylI->(43 strings from file: WordParts/Syllables_Impid)
3        SylI->(43 strings from file: WordParts/Syllables_Impid)
2      placeNameCore → [SylI_M][SylI][placeEnd]
         SylI_M → UNRESOLVABLE
3        SylI->(43 strings from file: WordParts/Syllables_Impid)
3        placeEnd → que
2      placeNameCore → [SylI_M][SylI]
         SylI_M → UNRESOLVABLE
3        SylI->(43 strings from file: WordParts/Syllables_Impid)
2      placeNameCore → [SylI_M][placeEnd]
         SylI_M → UNRESOLVABLE
3        placeEnd → m
       placeNameCore → UNRESOLVABLE
     r_name → UNRESOLVABLE

INCLUDES
NamerSettlementTribalImpid
ImpidUtility

CUSTOM RULES

UnityEngine.StackTraceUtility:ExtractStackTrace ()
Verse.Log:Error (string)
Verse.Log:ErrorOnce (string,int)
Verse.Grammar.GrammarResolver:ResolveUnsafe (string,Verse.Grammar.GrammarRequest,bool&,string,bool,bool,System.Collections.Generic.List`1<string>,System.Collections.Generic.List`1<string>,bool)
Verse.Grammar.GrammarResolver:ResolveUnsafe (string,Verse.Grammar.GrammarRequest,string,bool,bool,System.Collections.Generic.List`1<string>,System.Collections.Generic.List`1<string>,bool)
Verse.Grammar.GrammarResolver:ResolveUnsafe (string,Verse.Grammar.GrammarRequest,bool&,string,bool,bool,System.Collections.Generic.List`1<string>,System.Collections.Generic.List`1<string>,bool)
Verse.Grammar.GrammarResolver:Resolve (string,Verse.Grammar.GrammarRequest,string,bool,string,System.Collections.Generic.List`1<string>,System.Collections.Generic.List`1<string>,bool)
RimWorld.NameGenerator:GenerateName (Verse.Grammar.GrammarRequest,System.Predicate`1<string>,bool,string,string)
RimWorld.NameGenerator:GenerateName (Verse.RulePackDef,System.Predicate`1<string>,bool,string,string,System.Collections.Generic.List`1<Verse.Grammar.Rule>)
RimWorld.NameGenerator:GenerateName (Verse.RulePackDef,System.Collections.Generic.IEnumerable`1<string>,bool,string)
RimWorld.Planet.SettlementNameGenerator:GenerateSettlementName (RimWorld.Planet.WorldObject,Verse.RulePackDef)
(wrapper dynamic-method) MonoMod.Utils.DynamicMethodDefinition:RimWorld.FactionGenerator.GenerateFactionsIntoWorldLayer_Patch1 (RimWorld.Planet.PlanetLayer,System.Collections.Generic.List`1<RimWorld.FactionDef>)
RimWorld.Planet.WorldGenStep_Factions:GenerateFresh (string,RimWorld.Planet.PlanetLayer)
RimWorld.Planet.WorldGenerator:GeneratePlanetLayer (RimWorld.Planet.PlanetLayer,string,int)
RimWorld.Planet.WorldGenerator:GenerateWorld (single,string,RimWorld.Planet.OverallRainfall,RimWorld.Planet.OverallTemperature,RimWorld.Planet.OverallPopulation,RimWorld.Planet.LandmarkDensity,System.Collections.Generic.List`1<RimWorld.FactionDef>,single)
Verse.Root_Play:SetupForQuickTestPlay ()
RimWorld.MainMenuDrawer/<>c:<DoMainMenuControls>b__24_10 ()
Verse.LongEventHandler:RunEventFromAnotherThread (System.Action)
Verse.LongEventHandler/<>c:<UpdateCurrentAsynchronousEvent>b__28_0 ()
System.Threading.ThreadHelper:ThreadStart_Context (object)
System.Threading.ExecutionContext:RunInternal (System.Threading.ExecutionContext,System.Threading.ContextCallback,object,bool)
System.Threading.ExecutionContext:Run (System.Threading.ExecutionContext,System.Threading.ContextCallback,object,bool)
System.Threading.ExecutionContext:Run (System.Threading.ExecutionContext,System.Threading.ContextCallback,object)
System.Threading.ThreadHelper:ThreadStart ()

Grammar unresolvable. Root 'r_name'

GRAMMAR RESOLUTION TRACE
1    r_name → [placeNameCore]
2      placeNameCore → [SylI_M][SylI][SylI]
         SylI_M → UNRESOLVABLE
3        SylI->(43 strings from file: WordParts/Syllables_Impid)
3        SylI->(43 strings from file: WordParts/Syllables_Impid)
2      placeNameCore → [SylI_M][SylI][placeEnd]
         SylI_M → UNRESOLVABLE
3        SylI->(43 strings from file: WordParts/Syllables_Impid)
3        placeEnd → m
2      placeNameCore → [SylI_M][SylI]
         SylI_M → UNRESOLVABLE
3        SylI->(43 strings from file: WordParts/Syllables_Impid)
2      placeNameCore → [SylI_M][placeEnd]
         SylI_M → UNRESOLVABLE
3        placeEnd → z
       placeNameCore → UNRESOLVABLE
     r_name → UNRESOLVABLE

INCLUDES
NamerSettlementTribalImpid
ImpidUtility

CUSTOM RULES

UnityEngine.StackTraceUtility:ExtractStackTrace ()
Verse.Log:Error (string)
Verse.Log:ErrorOnce (string,int)
Verse.Grammar.GrammarResolver:ResolveUnsafe (string,Verse.Grammar.GrammarRequest,bool&,string,bool,bool,System.Collections.Generic.List`1<string>,System.Collections.Generic.List`1<string>,bool)
Verse.Grammar.GrammarResolver:ResolveUnsafe (string,Verse.Grammar.GrammarRequest,string,bool,bool,System.Collections.Generic.List`1<string>,System.Collections.Generic.List`1<string>,bool)
Verse.Grammar.GrammarResolver:ResolveUnsafe (string,Verse.Grammar.GrammarRequest,bool&,string,bool,bool,System.Collections.Generic.List`1<string>,System.Collections.Generic.List`1<string>,bool)
Verse.Grammar.GrammarResolver:Resolve (string,Verse.Grammar.GrammarRequest,string,bool,string,System.Collections.Generic.List`1<string>,System.Collections.Generic.List`1<string>,bool)
RimWorld.NameGenerator:GenerateName (Verse.Grammar.GrammarRequest,System.Predicate`1<string>,bool,string,string)
RimWorld.NameGenerator:GenerateName (Verse.RulePackDef,System.Predicate`1<string>,bool,string,string,System.Collections.Generic.List`1<Verse.Grammar.Rule>)
RimWorld.NameGenerator:GenerateName (Verse.RulePackDef,System.Collections.Generic.IEnumerable`1<string>,bool,string)
RimWorld.Planet.SettlementNameGenerator:GenerateSettlementName (RimWorld.Planet.WorldObject,Verse.RulePackDef)
(wrapper dynamic-method) MonoMod.Utils.DynamicMethodDefinition:RimWorld.FactionGenerator.GenerateFactionsIntoWorldLayer_Patch1 (RimWorld.Planet.PlanetLayer,System.Collections.Generic.List`1<RimWorld.FactionDef>)
RimWorld.Planet.WorldGenStep_Factions:GenerateFresh (string,RimWorld.Planet.PlanetLayer)
RimWorld.Planet.WorldGenerator:GeneratePlanetLayer (RimWorld.Planet.PlanetLayer,string,int)
RimWorld.Planet.WorldGenerator:GenerateWorld (single,string,RimWorld.Planet.OverallRainfall,RimWorld.Planet.OverallTemperature,RimWorld.Planet.OverallPopulation,RimWorld.Planet.LandmarkDensity,System.Collections.Generic.List`1<RimWorld.FactionDef>,single)
Verse.Root_Play:SetupForQuickTestPlay ()
RimWorld.MainMenuDrawer/<>c:<DoMainMenuControls>b__24_10 ()
Verse.LongEventHandler:RunEventFromAnotherThread (System.Action)
Verse.LongEventHandler/<>c:<UpdateCurrentAsynchronousEvent>b__28_0 ()
System.Threading.ThreadHelper:ThreadStart_Context (object)
System.Threading.ExecutionContext:RunInternal (System.Threading.ExecutionContext,System.Threading.ContextCallback,object,bool)
System.Threading.ExecutionContext:Run (System.Threading.ExecutionContext,System.Threading.ContextCallback,object,bool)
System.Threading.ExecutionContext:Run (System.Threading.ExecutionContext,System.Threading.ContextCallback,object)
System.Threading.ThreadHelper:ThreadStart ()

Grammar unresolvable. Root 'r_name'

GRAMMAR RESOLUTION TRACE
1    r_name → [placeNameCore]
2      placeNameCore → [SylI_M][SylI]
         SylI_M → UNRESOLVABLE
3        SylI->(43 strings from file: WordParts/Syllables_Impid)
2      placeNameCore → [SylI_M][placeEnd]
         SylI_M → UNRESOLVABLE
3        placeEnd → que
2      placeNameCore → [SylI_M][SylI][placeEnd]
         SylI_M → UNRESOLVABLE
3        SylI->(43 strings from file: WordParts/Syllables_Impid)
3        placeEnd → z
2      placeNameCore → [SylI_M][SylI][SylI]
         SylI_M → UNRESOLVABLE
3        SylI->(43 strings from file: WordParts/Syllables_Impid)
3        SylI->(43 strings from file: WordParts/Syllables_Impid)
       placeNameCore → UNRESOLVABLE
     r_name → UNRESOLVABLE

INCLUDES
NamerSettlementTribalImpid
ImpidUtility

CUSTOM RULES

UnityEngine.StackTraceUtility:ExtractStackTrace ()
Verse.Log:Error (string)
Verse.Log:ErrorOnce (string,int)
Verse.Grammar.GrammarResolver:ResolveUnsafe (string,Verse.Grammar.GrammarRequest,bool&,string,bool,bool,System.Collections.Generic.List`1<string>,System.Collections.Generic.List`1<string>,bool)
Verse.Grammar.GrammarResolver:ResolveUnsafe (string,Verse.Grammar.GrammarRequest,string,bool,bool,System.Collections.Generic.List`1<string>,System.Collections.Generic.List`1<string>,bool)
Verse.Grammar.GrammarResolver:ResolveUnsafe (string,Verse.Grammar.GrammarRequest,bool&,string,bool,bool,System.Collections.Generic.List`1<string>,System.Collections.Generic.List`1<string>,bool)
Verse.Grammar.GrammarResolver:Resolve (string,Verse.Grammar.GrammarRequest,string,bool,string,System.Collections.Generic.List`1<string>,System.Collections.Generic.List`1<string>,bool)
RimWorld.NameGenerator:GenerateName (Verse.Grammar.GrammarRequest,System.Predicate`1<string>,bool,string,string)
RimWorld.NameGenerator:GenerateName (Verse.RulePackDef,System.Predicate`1<string>,bool,string,string,System.Collections.Generic.List`1<Verse.Grammar.Rule>)
RimWorld.NameGenerator:GenerateName (Verse.RulePackDef,System.Collections.Generic.IEnumerable`1<string>,bool,string)
RimWorld.Planet.SettlementNameGenerator:GenerateSettlementName (RimWorld.Planet.WorldObject,Verse.RulePackDef)
(wrapper dynamic-method) MonoMod.Utils.DynamicMethodDefinition:RimWorld.FactionGenerator.GenerateFactionsIntoWorldLayer_Patch1 (RimWorld.Planet.PlanetLayer,System.Collections.Generic.List`1<RimWorld.FactionDef>)
RimWorld.Planet.WorldGenStep_Factions:GenerateFresh (string,RimWorld.Planet.PlanetLayer)
RimWorld.Planet.WorldGenerator:GeneratePlanetLayer (RimWorld.Planet.PlanetLayer,string,int)
RimWorld.Planet.WorldGenerator:GenerateWorld (single,string,RimWorld.Planet.OverallRainfall,RimWorld.Planet.OverallTemperature,RimWorld.Planet.OverallPopulation,RimWorld.Planet.LandmarkDensity,System.Collections.Generic.List`1<RimWorld.FactionDef>,single)
Verse.Root_Play:SetupForQuickTestPlay ()
RimWorld.MainMenuDrawer/<>c:<DoMainMenuControls>b__24_10 ()
Verse.LongEventHandler:RunEventFromAnotherThread (System.Action)
Verse.LongEventHandler/<>c:<UpdateCurrentAsynchronousEvent>b__28_0 ()
System.Threading.ThreadHelper:ThreadStart_Context (object)
System.Threading.ExecutionContext:RunInternal (System.Threading.ExecutionContext,System.Threading.ContextCallback,object,bool)
System.Threading.ExecutionContext:Run (System.Threading.ExecutionContext,System.Threading.ContextCallback,object,bool)
System.Threading.ExecutionContext:Run (System.Threading.ExecutionContext,System.Threading.ContextCallback,object)
System.Threading.ThreadHelper:ThreadStart ()

Grammar unresolvable. Root 'r_name'

GRAMMAR RESOLUTION TRACE
1    r_name → [placeNameCore]
2      placeNameCore → [SylI_M][SylI]
         SylI_M → UNRESOLVABLE
3        SylI->(43 strings from file: WordParts/Syllables_Impid)
2      placeNameCore → [SylI_M][SylI][SylI]
         SylI_M → UNRESOLVABLE
3        SylI->(43 strings from file: WordParts/Syllables_Impid)
3        SylI->(43 strings from file: WordParts/Syllables_Impid)
2      placeNameCore → [SylI_M][SylI][placeEnd]
         SylI_M → UNRESOLVABLE
3        SylI->(43 strings from file: WordParts/Syllables_Impid)
3        placeEnd → que
2      placeNameCore → [SylI_M][placeEnd]
         SylI_M → UNRESOLVABLE
3        placeEnd → ns
       placeNameCore → UNRESOLVABLE
     r_name → UNRESOLVABLE

INCLUDES
NamerSettlementTribalImpid
ImpidUtility

CUSTOM RULES

UnityEngine.StackTraceUtility:ExtractStackTrace ()
Verse.Log:Error (string)
Verse.Log:ErrorOnce (string,int)
Verse.Grammar.GrammarResolver:ResolveUnsafe (string,Verse.Grammar.GrammarRequest,bool&,string,bool,bool,System.Collections.Generic.List`1<string>,System.Collections.Generic.List`1<string>,bool)
Verse.Grammar.GrammarResolver:ResolveUnsafe (string,Verse.Grammar.GrammarRequest,string,bool,bool,System.Collections.Generic.List`1<string>,System.Collections.Generic.List`1<string>,bool)
Verse.Grammar.GrammarResolver:ResolveUnsafe (string,Verse.Grammar.GrammarRequest,bool&,string,bool,bool,System.Collections.Generic.List`1<string>,System.Collections.Generic.List`1<string>,bool)
Verse.Grammar.GrammarResolver:Resolve (string,Verse.Grammar.GrammarRequest,string,bool,string,System.Collections.Generic.List`1<string>,System.Collections.Generic.List`1<string>,bool)
RimWorld.NameGenerator:GenerateName (Verse.Grammar.GrammarRequest,System.Predicate`1<string>,bool,string,string)
RimWorld.NameGenerator:GenerateName (Verse.RulePackDef,System.Predicate`1<string>,bool,string,string,System.Collections.Generic.List`1<Verse.Grammar.Rule>)
RimWorld.NameGenerator:GenerateName (Verse.RulePackDef,System.Collections.Generic.IEnumerable`1<string>,bool,string)
RimWorld.Planet.SettlementNameGenerator:GenerateSettlementName (RimWorld.Planet.WorldObject,Verse.RulePackDef)
(wrapper dynamic-method) MonoMod.Utils.DynamicMethodDefinition:RimWorld.FactionGenerator.GenerateFactionsIntoWorldLayer_Patch1 (RimWorld.Planet.PlanetLayer,System.Collections.Generic.List`1<RimWorld.FactionDef>)
RimWorld.Planet.WorldGenStep_Factions:GenerateFresh (string,RimWorld.Planet.PlanetLayer)
RimWorld.Planet.WorldGenerator:GeneratePlanetLayer (RimWorld.Planet.PlanetLayer,string,int)
RimWorld.Planet.WorldGenerator:GenerateWorld (single,string,RimWorld.Planet.OverallRainfall,RimWorld.Planet.OverallTemperature,RimWorld.Planet.OverallPopulation,RimWorld.Planet.LandmarkDensity,System.Collections.Generic.List`1<RimWorld.FactionDef>,single)
Verse.Root_Play:SetupForQuickTestPlay ()
RimWorld.MainMenuDrawer/<>c:<DoMainMenuControls>b__24_10 ()
Verse.LongEventHandler:RunEventFromAnotherThread (System.Action)
Verse.LongEventHandler/<>c:<UpdateCurrentAsynchronousEvent>b__28_0 ()
System.Threading.ThreadHelper:ThreadStart_Context (object)
System.Threading.ExecutionContext:RunInternal (System.Threading.ExecutionContext,System.Threading.ContextCallback,object,bool)
System.Threading.ExecutionContext:Run (System.Threading.ExecutionContext,System.Threading.ContextCallback,object,bool)
System.Threading.ExecutionContext:Run (System.Threading.ExecutionContext,System.Threading.ContextCallback,object)
System.Threading.ThreadHelper:ThreadStart ()

Grammar unresolvable. Root 'r_name'

GRAMMAR RESOLUTION TRACE
1    r_name → [placeNameCore]
2      placeNameCore → [SylI_M][SylI]
         SylI_M → UNRESOLVABLE
3        SylI->(43 strings from file: WordParts/Syllables_Impid)
2      placeNameCore → [SylI_M][SylI][SylI]
         SylI_M → UNRESOLVABLE
3        SylI->(43 strings from file: WordParts/Syllables_Impid)
3        SylI->(43 strings from file: WordParts/Syllables_Impid)
2      placeNameCore → [SylI_M][SylI][placeEnd]
         SylI_M → UNRESOLVABLE
3        SylI->(43 strings from file: WordParts/Syllables_Impid)
3        placeEnd → zos
2      placeNameCore → [SylI_M][placeEnd]
         SylI_M → UNRESOLVABLE
3        placeEnd → que
       placeNameCore → UNRESOLVABLE
     r_name → UNRESOLVABLE

INCLUDES
NamerSettlementTribalImpid
ImpidUtility

CUSTOM RULES

UnityEngine.StackTraceUtility:ExtractStackTrace ()
Verse.Log:Error (string)
Verse.Log:ErrorOnce (string,int)
Verse.Grammar.GrammarResolver:ResolveUnsafe (string,Verse.Grammar.GrammarRequest,bool&,string,bool,bool,System.Collections.Generic.List`1<string>,System.Collections.Generic.List`1<string>,bool)
Verse.Grammar.GrammarResolver:ResolveUnsafe (string,Verse.Grammar.GrammarRequest,string,bool,bool,System.Collections.Generic.List`1<string>,System.Collections.Generic.List`1<string>,bool)
Verse.Grammar.GrammarResolver:ResolveUnsafe (string,Verse.Grammar.GrammarRequest,bool&,string,bool,bool,System.Collections.Generic.List`1<string>,System.Collections.Generic.List`1<string>,bool)
Verse.Grammar.GrammarResolver:Resolve (string,Verse.Grammar.GrammarRequest,string,bool,string,System.Collections.Generic.List`1<string>,System.Collections.Generic.List`1<string>,bool)
RimWorld.NameGenerator:GenerateName (Verse.Grammar.GrammarRequest,System.Predicate`1<string>,bool,string,string)
RimWorld.NameGenerator:GenerateName (Verse.RulePackDef,System.Predicate`1<string>,bool,string,string,System.Collections.Generic.List`1<Verse.Grammar.Rule>)
RimWorld.NameGenerator:GenerateName (Verse.RulePackDef,System.Collections.Generic.IEnumerable`1<string>,bool,string)
RimWorld.Planet.SettlementNameGenerator:GenerateSettlementName (RimWorld.Planet.WorldObject,Verse.RulePackDef)
(wrapper dynamic-method) MonoMod.Utils.DynamicMethodDefinition:RimWorld.FactionGenerator.GenerateFactionsIntoWorldLayer_Patch1 (RimWorld.Planet.PlanetLayer,System.Collections.Generic.List`1<RimWorld.FactionDef>)
RimWorld.Planet.WorldGenStep_Factions:GenerateFresh (string,RimWorld.Planet.PlanetLayer)
RimWorld.Planet.WorldGenerator:GeneratePlanetLayer (RimWorld.Planet.PlanetLayer,string,int)
RimWorld.Planet.WorldGenerator:GenerateWorld (single,string,RimWorld.Planet.OverallRainfall,RimWorld.Planet.OverallTemperature,RimWorld.Planet.OverallPopulation,RimWorld.Planet.LandmarkDensity,System.Collections.Generic.List`1<RimWorld.FactionDef>,single)
Verse.Root_Play:SetupForQuickTestPlay ()
RimWorld.MainMenuDrawer/<>c:<DoMainMenuControls>b__24_10 ()
Verse.LongEventHandler:RunEventFromAnotherThread (System.Action)
Verse.LongEventHandler/<>c:<UpdateCurrentAsynchronousEvent>b__28_0 ()
System.Threading.ThreadHelper:ThreadStart_Context (object)
System.Threading.ExecutionContext:RunInternal (System.Threading.ExecutionContext,System.Threading.ContextCallback,object,bool)
System.Threading.ExecutionContext:Run (System.Threading.ExecutionContext,System.Threading.ContextCallback,object,bool)
System.Threading.ExecutionContext:Run (System.Threading.ExecutionContext,System.Threading.ContextCallback,object)
System.Threading.ThreadHelper:ThreadStart ()

Grammar unresolvable. Root 'r_name'

GRAMMAR RESOLUTION TRACE
1    r_name → [placeNameCore]
2      placeNameCore → [SylI_M][SylI][SylI]
         SylI_M → UNRESOLVABLE
3        SylI->(43 strings from file: WordParts/Syllables_Impid)
3        SylI->(43 strings from file: WordParts/Syllables_Impid)
2      placeNameCore → [SylI_M][placeEnd]
         SylI_M → UNRESOLVABLE
3        placeEnd → te
2      placeNameCore → [SylI_M][SylI][placeEnd]
         SylI_M → UNRESOLVABLE
3        SylI->(43 strings from file: WordParts/Syllables_Impid)
3        placeEnd → s
2      placeNameCore → [SylI_M][SylI]
         SylI_M → UNRESOLVABLE
3        SylI->(43 strings from file: WordParts/Syllables_Impid)
       placeNameCore → UNRESOLVABLE
     r_name → UNRESOLVABLE

INCLUDES
NamerSettlementTribalImpid
ImpidUtility

CUSTOM RULES

UnityEngine.StackTraceUtility:ExtractStackTrace ()
Verse.Log:Error (string)
Verse.Log:ErrorOnce (string,int)
Verse.Grammar.GrammarResolver:ResolveUnsafe (string,Verse.Grammar.GrammarRequest,bool&,string,bool,bool,System.Collections.Generic.List`1<string>,System.Collections.Generic.List`1<string>,bool)
Verse.Grammar.GrammarResolver:ResolveUnsafe (string,Verse.Grammar.GrammarRequest,string,bool,bool,System.Collections.Generic.List`1<string>,System.Collections.Generic.List`1<string>,bool)
Verse.Grammar.GrammarResolver:ResolveUnsafe (string,Verse.Grammar.GrammarRequest,bool&,string,bool,bool,System.Collections.Generic.List`1<string>,System.Collections.Generic.List`1<string>,bool)
Verse.Grammar.GrammarResolver:Resolve (string,Verse.Grammar.GrammarRequest,string,bool,string,System.Collections.Generic.List`1<string>,System.Collections.Generic.List`1<string>,bool)
RimWorld.NameGenerator:GenerateName (Verse.Grammar.GrammarRequest,System.Predicate`1<string>,bool,string,string)
RimWorld.NameGenerator:GenerateName (Verse.RulePackDef,System.Predicate`1<string>,bool,string,string,System.Collections.Generic.List`1<Verse.Grammar.Rule>)
RimWorld.NameGenerator:GenerateName (Verse.RulePackDef,System.Collections.Generic.IEnumerable`1<string>,bool,string)
RimWorld.Planet.SettlementNameGenerator:GenerateSettlementName (RimWorld.Planet.WorldObject,Verse.RulePackDef)
(wrapper dynamic-method) MonoMod.Utils.DynamicMethodDefinition:RimWorld.FactionGenerator.GenerateFactionsIntoWorldLayer_Patch1 (RimWorld.Planet.PlanetLayer,System.Collections.Generic.List`1<RimWorld.FactionDef>)
RimWorld.Planet.WorldGenStep_Factions:GenerateFresh (string,RimWorld.Planet.PlanetLayer)
RimWorld.Planet.WorldGenerator:GeneratePlanetLayer (RimWorld.Planet.PlanetLayer,string,int)
RimWorld.Planet.WorldGenerator:GenerateWorld (single,string,RimWorld.Planet.OverallRainfall,RimWorld.Planet.OverallTemperature,RimWorld.Planet.OverallPopulation,RimWorld.Planet.LandmarkDensity,System.Collections.Generic.List`1<RimWorld.FactionDef>,single)
Verse.Root_Play:SetupForQuickTestPlay ()
RimWorld.MainMenuDrawer/<>c:<DoMainMenuControls>b__24_10 ()
Verse.LongEventHandler:RunEventFromAnotherThread (System.Action)
Verse.LongEventHandler/<>c:<UpdateCurrentAsynchronousEvent>b__28_0 ()
System.Threading.ThreadHelper:ThreadStart_Context (object)
System.Threading.ExecutionContext:RunInternal (System.Threading.ExecutionContext,System.Threading.ContextCallback,object,bool)
System.Threading.ExecutionContext:Run (System.Threading.ExecutionContext,System.Threading.ContextCallback,object,bool)
System.Threading.ExecutionContext:Run (System.Threading.ExecutionContext,System.Threading.ContextCallback,object)
System.Threading.ThreadHelper:ThreadStart ()

Grammar unresolvable. Root 'r_name'

GRAMMAR RESOLUTION TRACE
1    r_name → [placeNameCore]
2      placeNameCore → [SylI_M][SylI][SylI]
         SylI_M → UNRESOLVABLE
3        SylI->(43 strings from file: WordParts/Syllables_Impid)
3        SylI->(43 strings from file: WordParts/Syllables_Impid)
2      placeNameCore → [SylI_M][placeEnd]
         SylI_M → UNRESOLVABLE
3        placeEnd → zos
2      placeNameCore → [SylI_M][SylI]
         SylI_M → UNRESOLVABLE
3        SylI->(43 strings from file: WordParts/Syllables_Impid)
2      placeNameCore → [SylI_M][SylI][placeEnd]
         SylI_M → UNRESOLVABLE
3        SylI->(43 strings from file: WordParts/Syllables_Impid)
3        placeEnd → z
       placeNameCore → UNRESOLVABLE
     r_name → UNRESOLVABLE

INCLUDES
NamerSettlementTribalImpid
ImpidUtility

CUSTOM RULES

UnityEngine.StackTraceUtility:ExtractStackTrace ()
Verse.Log:Error (string)
Verse.Log:ErrorOnce (string,int)
Verse.Grammar.GrammarResolver:ResolveUnsafe (string,Verse.Grammar.GrammarRequest,bool&,string,bool,bool,System.Collections.Generic.List`1<string>,System.Collections.Generic.List`1<string>,bool)
Verse.Grammar.GrammarResolver:ResolveUnsafe (string,Verse.Grammar.GrammarRequest,string,bool,bool,System.Collections.Generic.List`1<string>,System.Collections.Generic.List`1<string>,bool)
Verse.Grammar.GrammarResolver:ResolveUnsafe (string,Verse.Grammar.GrammarRequest,bool&,string,bool,bool,System.Collections.Generic.List`1<string>,System.Collections.Generic.List`1<string>,bool)
Verse.Grammar.GrammarResolver:Resolve (string,Verse.Grammar.GrammarRequest,string,bool,string,System.Collections.Generic.List`1<string>,System.Collections.Generic.List`1<string>,bool)
RimWorld.NameGenerator:GenerateName (Verse.Grammar.GrammarRequest,System.Predicate`1<string>,bool,string,string)
RimWorld.NameGenerator:GenerateName (Verse.RulePackDef,System.Predicate`1<string>,bool,string,string,System.Collections.Generic.List`1<Verse.Grammar.Rule>)
RimWorld.NameGenerator:GenerateName (Verse.RulePackDef,System.Collections.Generic.IEnumerable`1<string>,bool,string)
RimWorld.Planet.SettlementNameGenerator:GenerateSettlementName (RimWorld.Planet.WorldObject,Verse.RulePackDef)
(wrapper dynamic-method) MonoMod.Utils.DynamicMethodDefinition:RimWorld.FactionGenerator.GenerateFactionsIntoWorldLayer_Patch1 (RimWorld.Planet.PlanetLayer,System.Collections.Generic.List`1<RimWorld.FactionDef>)
RimWorld.Planet.WorldGenStep_Factions:GenerateFresh (string,RimWorld.Planet.PlanetLayer)
RimWorld.Planet.WorldGenerator:GeneratePlanetLayer (RimWorld.Planet.PlanetLayer,string,int)
RimWorld.Planet.WorldGenerator:GenerateWorld (single,string,RimWorld.Planet.OverallRainfall,RimWorld.Planet.OverallTemperature,RimWorld.Planet.OverallPopulation,RimWorld.Planet.LandmarkDensity,System.Collections.Generic.List`1<RimWorld.FactionDef>,single)
Verse.Root_Play:SetupForQuickTestPlay ()
RimWorld.MainMenuDrawer/<>c:<DoMainMenuControls>b__24_10 ()
Verse.LongEventHandler:RunEventFromAnotherThread (System.Action)
Verse.LongEventHandler/<>c:<UpdateCurrentAsynchronousEvent>b__28_0 ()
System.Threading.ThreadHelper:ThreadStart_Context (object)
System.Threading.ExecutionContext:RunInternal (System.Threading.ExecutionContext,System.Threading.ContextCallback,object,bool)
System.Threading.ExecutionContext:Run (System.Threading.ExecutionContext,System.Threading.ContextCallback,object,bool)
System.Threading.ExecutionContext:Run (System.Threading.ExecutionContext,System.Threading.ContextCallback,object)
System.Threading.ThreadHelper:ThreadStart ()

Initializing new game with mods:
  - brrainz.harmony
  - Ludeon.RimWorld
  - Ludeon.RimWorld.Royalty
  - Ludeon.RimWorld.Ideology
  - Ludeon.RimWorld.Biotech
  - Ludeon.RimWorld.Anomaly
  - Ludeon.RimWorld.Odyssey
  - erdelf.HumanoidAlienRaces
  - CarnySenpai.EnableOversizedWeapons
  - Atlas.AndroidTiers
UnityEngine.StackTraceUtility:ExtractStackTrace ()
Verse.Log:Message (string)
(wrapper dynamic-method) MonoMod.Utils.DynamicMethodDefinition:Verse.Game.InitNewGame_Patch1 (Verse.Game)
Verse.Root_Play/<>c:<Start>b__1_2 ()
Verse.LongEventHandler:RunEventFromAnotherThread (System.Action)
Verse.LongEventHandler/<>c:<UpdateCurrentAsynchronousEvent>b__28_0 ()
System.Threading.ThreadHelper:ThreadStart_Context (object)
System.Threading.ExecutionContext:RunInternal (System.Threading.ExecutionContext,System.Threading.ContextCallback,object,bool)
System.Threading.ExecutionContext:Run (System.Threading.ExecutionContext,System.Threading.ContextCallback,object,bool)
System.Threading.ExecutionContext:Run (System.Threading.ExecutionContext,System.Threading.ContextCallback,object)
System.Threading.ThreadHelper:ThreadStart ()

Error in GenStep: System.InvalidCastException: Specified cast is not valid.
[Ref 85E607D]
  at MOARANDROIDS.CompSkyMind.PostSpawnSetup (System.Boolean respawningAfterLoad) [0x000b4] in <e472a85f363145d2b74be79a25443ffd>:0 
  at Verse.ThingWithComps.SpawnSetup (Verse.Map map, System.Boolean respawningAfterLoad) [0x00020] in <46372f5dadbf4af8939e608076251180>:0 
  at Verse.Corpse.SpawnSetup (Verse.Map map, System.Boolean respawningAfterLoad) [0x00025] in <46372f5dadbf4af8939e608076251180>:0 
  at Verse.GenSpawn.Spawn (Verse.Thing newThing, Verse.IntVec3 loc, Verse.Map map, Verse.Rot4 rot, Verse.WipeMode wipeMode, System.Boolean respawningAfterLoad, System.Boolean forbidLeavings) [0x00276] in <46372f5dadbf4af8939e608076251180>:0 
  at Verse.GenSpawn.Spawn (Verse.Thing newThing, Verse.IntVec3 loc, Verse.Map map, Verse.WipeMode wipeMode) [0x00000] in <46372f5dadbf4af8939e608076251180>:0 
  at RimWorld.GenStep_Monolith.GenerateMonolith (Verse.IntVec3 loc, Verse.Map map) [0x002c1] in <46372f5dadbf4af8939e608076251180>:0 
  at RimWorld.GenStep_Monolith.ScatterAt (Verse.IntVec3 loc, Verse.Map map, Verse.GenStepParams parms, System.Int32 count) [0x00000] in <46372f5dadbf4af8939e608076251180>:0 
  at Verse.GenStep_Scatterer.Generate (Verse.Map map, Verse.GenStepParams parms) [0x0004f] in <46372f5dadbf4af8939e608076251180>:0 
  at Verse.MapGenerator.GenerateContentsIntoMap (System.Collections.Generic.IEnumerable`1[T] genStepDefs, Verse.Map map, System.Int32 seed, System.Boolean stepDebugger) [0x0016a] in <46372f5dadbf4af8939e608076251180>:0 
UnityEngine.StackTraceUtility:ExtractStackTrace ()
Verse.Log:Error (string)
Verse.MapGenerator:GenerateContentsIntoMap (System.Collections.Generic.IEnumerable`1<Verse.GenStepWithParams>,Verse.Map,int,bool)
Verse.MapGenerator:GenerateMap (Verse.IntVec3,RimWorld.Planet.MapParent,Verse.MapGeneratorDef,System.Collections.Generic.IEnumerable`1<Verse.GenStepWithParams>,System.Action`1<Verse.Map>,bool,bool)
(wrapper dynamic-method) MonoMod.Utils.DynamicMethodDefinition:Verse.Game.InitNewGame_Patch1 (Verse.Game)
Verse.Root_Play/<>c:<Start>b__1_2 ()
Verse.LongEventHandler:RunEventFromAnotherThread (System.Action)
Verse.LongEventHandler/<>c:<UpdateCurrentAsynchronousEvent>b__28_0 ()
System.Threading.ThreadHelper:ThreadStart_Context (object)
System.Threading.ExecutionContext:RunInternal (System.Threading.ExecutionContext,System.Threading.ContextCallback,object,bool)
System.Threading.ExecutionContext:Run (System.Threading.ExecutionContext,System.Threading.ContextCallback,object,bool)
System.Threading.ExecutionContext:Run (System.Threading.ExecutionContext,System.Threading.ContextCallback,object)
System.Threading.ThreadHelper:ThreadStart ()

--- Thread 114 ---
 2227.189ms (self: 4.381 ms) InitNewGeneratedMap
 - 2030.257ms (91%) (self: 4.068 ms) Generate contents into map
 - - 1268.904ms (62%) (self: 1268.904 ms) GenStep - Plants
 - - 132.551ms (6.5%) (self: 132.551 ms) GenStep - RockChunks
 - - 131.157ms (6.5%) (self: 131.157 ms) GenStep - Terrain
 - - 100.472ms (4.9%) (self: 100.472 ms) GenStep - ScatterShrines
 - - 75.180ms (3.7%) (self: 75.180 ms) GenStep - ElevationFertility
 - - 60.459ms (3%) (self: 60.459 ms) GenStep - RocksFromGrid
 - - 56.568ms (2.8%) (self: 15.514 ms) GenStep - FindPlayerStartSpot
 - - - 41.054ms (73%) (self: 41.054 ms) RebuildAllRegions
 - - 35.589ms (1.8%) (self: 35.589 ms) GenStep - AncientJunkClusters
 - - 27.755ms (1.4%) (self: 0.220 ms) GenStep - Fog
 - - - 27.535ms (99%) (self: 27.535 ms) GenerateInitialFogGrid
 - - 22.740ms (1.1%) (self: 22.740 ms) GenStep - AncientLandingPad
 - - 16.613ms (0.82%) (self: 16.613 ms) GenStep - ScenParts
 - - 14.050ms (0.69%) (self: 14.050 ms) GenStep - Animals
 - - 13.382ms (0.66%) (self: 13.382 ms) GenStep - AncientUtilityBuilding
 - - 11.901ms (0.59%) (self: 11.901 ms) GenStep - ScatterRuinsSimple
 - - 11.557ms (0.57%) (self: 11.557 ms) GenStep - VoidMonolith
 - - 11.327ms (0.56%) (self: 11.327 ms) GenStep - CaveHives
 - - 10.492ms (0.52%) (self: 10.492 ms) GenStep - MechanoidRemains
 - - 5.775ms (0.28%) (self: 5.775 ms) GenStep - SteamGeysers
 - - 3.125ms (0.15%) (self: 3.125 ms) GenStep - AncientFences
 - - 3.032ms (0.15%) (self: 3.032 ms) GenStep - AncientExostriderRemains
 - - 2.577ms (0.13%) (self: 2.577 ms) GenStep - AncientMechs
 - - 2.457ms (0.12%) (self: 2.457 ms) GenStep - AnimaTrees
 - - 2.449ms (0.12%) (self: 2.449 ms) GenStep - ScatterRoadDebris
 - - 2.026ms (0.1%) (self: 2.026 ms) GenStep - Pollution
 - - 1.451ms (0.07%) (self: 1.451 ms) GenStep - Roads
 - - 0.648ms (0.03%) (self: 0.648 ms) GenStep - PoluxTrees
 - - 0.428ms (0.02%) (self: 0.428 ms) GenStep - Snow
 - - 0.427ms (0.02%) (self: 0.427 ms) GenStep - MutatorPostElevationFertility
 - - 0.416ms (0.02%) (self: 0.416 ms) GenStep - MutatorPostTerrain
 - - 0.180ms (0.01%) (self: 0.180 ms) GenStep - MutatorFinal
 - - 0.151ms (0.01%) (self: 0.151 ms) GenStep - AncientPipelineSection
 - - 0.134ms (0.01%) (self: 0.134 ms) GenStep - ScatterCaveDebris
 - - 0.086ms (0%) (self: 0.086 ms) GenStep - MutatorCriticalStructures
 - - 0.078ms (0%) (self: 0.078 ms) GenStep - AncientTurret
 - - 0.049ms (0%) (self: 0.049 ms) GenStep - MutatorNonCriticalStructures
 - - 0.006ms (0%) (self: 0.006 ms) GenStep - AncientPollutionJunk
 - 154.447ms (6.9%) (self: 7.957 ms) Finalize map init
 - - 136.672ms (88%) (self: 136.672 ms) Finalize geometry
 - - 5.576ms (3.6%) (self: 5.576 ms) wealthWatcher.ForceRecount()
 - - 2.796ms (1.8%) (self: 2.796 ms) Thing.PostMapInit()
 - - 1.324ms (0.86%) (self: 1.324 ms) listerFilthInHomeArea.RebuildAll()
 - - 0.123ms (0.08%) (self: 0.123 ms) resourceCounter.UpdateResourceCounts()
 - 37.280ms (1.7%) (self: 37.280 ms) Set up map
 - 0.498ms (0.02%) (self: 0.498 ms) Map generator post init
 - 0.327ms (0.01%) (self: 0.327 ms) MapComponent.MapGenerated()


Hotspot analysis
----------------------------------------
1x GenStep - Plants -> 1268.904 ms (total (w/children): 1268.904 ms)
1x Finalize geometry -> 136.672 ms (total (w/children): 136.672 ms)
1x GenStep - RockChunks -> 132.551 ms (total (w/children): 132.551 ms)
1x GenStep - Terrain -> 131.157 ms (total (w/children): 131.157 ms)
1x GenStep - ScatterShrines -> 100.472 ms (total (w/children): 100.472 ms)
1x GenStep - ElevationFertility -> 75.180 ms (total (w/children): 75.180 ms)
1x GenStep - RocksFromGrid -> 60.459 ms (total (w/children): 60.459 ms)
1x RebuildAllRegions -> 41.054 ms (total (w/children): 41.054 ms)
1x Set up map -> 37.280 ms (total (w/children): 37.280 ms)
1x GenStep - AncientJunkClusters -> 35.589 ms (total (w/children): 35.589 ms)
1x GenerateInitialFogGrid -> 27.535 ms (total (w/children): 27.535 ms)
1x GenStep - AncientLandingPad -> 22.740 ms (total (w/children): 22.740 ms)
1x GenStep - ScenParts -> 16.613 ms (total (w/children): 16.613 ms)
1x GenStep - FindPlayerStartSpot -> 15.514 ms (total (w/children): 56.568 ms)
1x GenStep - Animals -> 14.050 ms (total (w/children): 14.050 ms)
1x GenStep - AncientUtilityBuilding -> 13.382 ms (total (w/children): 13.382 ms)
1x GenStep - ScatterRuinsSimple -> 11.901 ms (total (w/children): 11.901 ms)
1x GenStep - VoidMonolith -> 11.557 ms (total (w/children): 11.557 ms)
1x GenStep - CaveHives -> 11.327 ms (total (w/children): 11.327 ms)
1x GenStep - MechanoidRemains -> 10.492 ms (total (w/children): 10.492 ms)
1x Finalize map init -> 7.957 ms (total (w/children): 154.447 ms)
1x GenStep - SteamGeysers -> 5.775 ms (total (w/children): 5.775 ms)
1x wealthWatcher.ForceRecount() -> 5.576 ms (total (w/children): 5.576 ms)
1x InitNewGeneratedMap -> 4.381 ms (total (w/children): 2227.189 ms)
1x Generate contents into map -> 4.068 ms (total (w/children): 2030.257 ms)
1x GenStep - AncientFences -> 3.125 ms (total (w/children): 3.125 ms)
1x GenStep - AncientExostriderRemains -> 3.032 ms (total (w/children): 3.032 ms)
1x Thing.PostMapInit() -> 2.796 ms (total (w/children): 2.796 ms)
1x GenStep - AncientMechs -> 2.577 ms (total (w/children): 2.577 ms)
1x GenStep - AnimaTrees -> 2.457 ms (total (w/children): 2.457 ms)
1x GenStep - ScatterRoadDebris -> 2.449 ms (total (w/children): 2.449 ms)
1x GenStep - Pollution -> 2.026 ms (total (w/children): 2.026 ms)
1x GenStep - Roads -> 1.451 ms (total (w/children): 1.451 ms)
1x listerFilthInHomeArea.RebuildAll() -> 1.324 ms (total (w/children): 1.324 ms)
1x GenStep - PoluxTrees -> 0.648 ms (total (w/children): 0.648 ms)
1x Map generator post init -> 0.498 ms (total (w/children): 0.498 ms)
1x GenStep - Snow -> 0.428 ms (total (w/children): 0.428 ms)
1x GenStep - MutatorPostElevationFertility -> 0.427 ms (total (w/children): 0.427 ms)
1x GenStep - MutatorPostTerrain -> 0.416 ms (total (w/children): 0.416 ms)
1x MapComponent.MapGenerated() -> 0.327 ms (total (w/children): 0.327 ms)
1x GenStep - Fog -> 0.220 ms (total (w/children): 27.755 ms)
1x GenStep - MutatorFinal -> 0.180 ms (total (w/children): 0.180 ms)
1x GenStep - AncientPipelineSection -> 0.151 ms (total (w/children): 0.151 ms)
1x GenStep - ScatterCaveDebris -> 0.134 ms (total (w/children): 0.134 ms)
1x resourceCounter.UpdateResourceCounts() -> 0.123 ms (total (w/children): 0.123 ms)
1x GenStep - MutatorCriticalStructures -> 0.086 ms (total (w/children): 0.086 ms)
1x GenStep - AncientTurret -> 0.078 ms (total (w/children): 0.078 ms)
1x GenStep - MutatorNonCriticalStructures -> 0.049 ms (total (w/children): 0.049 ms)
1x GenStep - AncientPollutionJunk -> 0.006 ms (total (w/children): 0.006 ms)

UnityEngine.StackTraceUtility:ExtractStackTrace ()
Verse.Log:Message (string)
Verse.ThreadLocalDeepProfiler:Output (Verse.ThreadLocalDeepProfiler/Watcher)
Verse.ThreadLocalDeepProfiler:End ()
Verse.DeepProfiler:End ()
Verse.MapGenerator:GenerateMap (Verse.IntVec3,RimWorld.Planet.MapParent,Verse.MapGeneratorDef,System.Collections.Generic.IEnumerable`1<Verse.GenStepWithParams>,System.Action`1<Verse.Map>,bool,bool)
(wrapper dynamic-method) MonoMod.Utils.DynamicMethodDefinition:Verse.Game.InitNewGame_Patch1 (Verse.Game)
Verse.Root_Play/<>c:<Start>b__1_2 ()
Verse.LongEventHandler:RunEventFromAnotherThread (System.Action)
Verse.LongEventHandler/<>c:<UpdateCurrentAsynchronousEvent>b__28_0 ()
System.Threading.ThreadHelper:ThreadStart_Context (object)
System.Threading.ExecutionContext:RunInternal (System.Threading.ExecutionContext,System.Threading.ContextCallback,object,bool)
System.Threading.ExecutionContext:Run (System.Threading.ExecutionContext,System.Threading.ContextCallback,object,bool)
System.Threading.ExecutionContext:Run (System.Threading.ExecutionContext,System.Threading.ContextCallback,object)
System.Threading.ThreadHelper:ThreadStart ()

Random state stack is not empty. There were more calls to PushState than PopState. Fixing.
UnityEngine.StackTraceUtility:ExtractStackTrace ()
Verse.Log:Warning (string)
Verse.Rand:EnsureStateStackEmpty ()
Verse.Root:Update ()
Verse.Root_Play:Update ()

Exception ticking AncientCryptosleepCasket4705 (at (44, 0, 18)): System.InvalidCastException: Specified cast is not valid.
[Ref 5BCD2705]
  at MOARANDROIDS.CompAndroidState.initComp () [0x00017] in <e472a85f363145d2b74be79a25443ffd>:0 
  at MOARANDROIDS.CompAndroidState.CompTickRare () [0x00016] in <e472a85f363145d2b74be79a25443ffd>:0 
  at Verse.Corpse.TickRareInt () [0x00024] in <46372f5dadbf4af8939e608076251180>:0 
  at Verse.Corpse.TickRare () [0x00000] in <46372f5dadbf4af8939e608076251180>:0 
  at Verse.Thing.DoTick () [0x00152] in <46372f5dadbf4af8939e608076251180>:0 
  at Verse.ThingOwner.DoTick () [0x0001c] in <46372f5dadbf4af8939e608076251180>:0 
  at Verse.Thing.DoTick () [0x0022c] in <46372f5dadbf4af8939e608076251180>:0 
  at Verse.TickList.Tick () [0x00139] in <46372f5dadbf4af8939e608076251180>:0 
UnityEngine.StackTraceUtility:ExtractStackTrace ()
Verse.Log:Error (string)
Verse.TickList:Tick ()
Verse.TickManager:DoSingleTick ()
Verse.TickManager:TickManagerUpdate ()
Verse.Game:UpdatePlay ()
Verse.Root_Play:Update ()

Exception ticking AncientCryptosleepCasket4713 (at (41, 0, 18)): System.InvalidCastException: Specified cast is not valid.
[Ref 5BCD2705] Duplicate stacktrace, see ref for original
UnityEngine.StackTraceUtility:ExtractStackTrace ()
Verse.Log:Error (string)
Verse.TickList:Tick ()
Verse.TickManager:DoSingleTick ()
Verse.TickManager:TickManagerUpdate ()
Verse.Game:UpdatePlay ()
Verse.Root_Play:Update ()

Exception ticking AncientCryptosleepCasket4692 (at (44, 0, 20)): System.InvalidCastException: Specified cast is not valid.
[Ref 5BCD2705] Duplicate stacktrace, see ref for original
UnityEngine.StackTraceUtility:ExtractStackTrace ()
Verse.Log:Error (string)
Verse.TickList:Tick ()
Verse.TickManager:DoSingleTick ()
Verse.TickManager:TickManagerUpdate ()
Verse.Game:UpdatePlay ()
Verse.Root_Play:Update ()

Exception ticking AncientCryptosleepCasket4687 (at (47, 0, 20)): System.InvalidCastException: Specified cast is not valid.
[Ref 5BCD2705] Duplicate stacktrace, see ref for original
UnityEngine.StackTraceUtility:ExtractStackTrace ()
Verse.Log:Error (string)
Verse.TickList:Tick ()
Verse.TickManager:DoSingleTick ()
Verse.TickManager:TickManagerUpdate ()
Verse.Game:UpdatePlay ()
Verse.Root_Play:Update ()

Exception ticking Corpse_Human23730 (at (184, 0, 194)): System.InvalidCastException: Specified cast is not valid.
[Ref 9446F7EF]
  at MOARANDROIDS.CompAndroidState.initComp () [0x00017] in <e472a85f363145d2b74be79a25443ffd>:0 
  at MOARANDROIDS.CompAndroidState.CompTickRare () [0x00016] in <e472a85f363145d2b74be79a25443ffd>:0 
  at Verse.Corpse.TickRareInt () [0x00024] in <46372f5dadbf4af8939e608076251180>:0 
  at Verse.Corpse.TickRare () [0x00000] in <46372f5dadbf4af8939e608076251180>:0 
  at Verse.Thing.DoTick () [0x00152] in <46372f5dadbf4af8939e608076251180>:0 
  at Verse.TickList.Tick () [0x00139] in <46372f5dadbf4af8939e608076251180>:0 
UnityEngine.StackTraceUtility:ExtractStackTrace ()
Verse.Log:Error (string)
Verse.TickList:Tick ()
Verse.TickManager:DoSingleTick ()
Verse.TickManager:TickManagerUpdate ()
Verse.Game:UpdatePlay ()
Verse.Root_Play:Update ()

Error while determining if Android3Tier23750 should have Need Chemical_Alcohol: System.NullReferenceException: Object reference not set to an instance of an object
[Ref C482EB5D]
  at RimWorld.LifeStageWorker_HumanlikeAdult.Notify_LifeStageStarted (Verse.Pawn pawn, RimWorld.LifeStageDef previousLifeStage) [0x00050] in <46372f5dadbf4af8939e608076251180>:0 
    - TRANSPILER rimworld.erdelf.alien_race.main: IEnumerable`1 AlienRace.HarmonyPatches:AdultLifeStageStartedTranspiler(IEnumerable`1 instructions)
    - POSTFIX rimworld.erdelf.alien_race.main: Void AlienRace.HarmonyPatches:AdultLifeStageStartedPostfix(Pawn pawn)
  at Verse.Pawn_AgeTracker.RecalculateLifeStageIndex () [0x00167] in <46372f5dadbf4af8939e608076251180>:0 
    - TRANSPILER rimworld.erdelf.alien_race.main: IEnumerable`1 AlienRace.HarmonyPatches:RecalculateLifeStageIndexTranspiler(IEnumerable`1 instructions)
  at Verse.Pawn_AgeTracker.get_CurLifeStageIndex () [0x00009] in <46372f5dadbf4af8939e608076251180>:0 
  at Verse.Pawn_AgeTracker.get_CurLifeStageRace () [0x00000] in <46372f5dadbf4af8939e608076251180>:0 
  at Verse.Pawn_AgeTracker.get_CurLifeStage () [0x00000] in <46372f5dadbf4af8939e608076251180>:0 
  at Verse.Pawn.get_DevelopmentalStage () [0x00012] in <46372f5dadbf4af8939e608076251180>:0 
  at RimWorld.Pawn_NeedsTracker.ShouldHaveNeed (RimWorld.NeedDef nd) [0x0001a] in <46372f5dadbf4af8939e608076251180>:0 
  at RimWorld.Pawn_NeedsTracker.AddOrRemoveNeedsAsAppropriate () [0x00013] in <46372f5dadbf4af8939e608076251180>:0 
UnityEngine.StackTraceUtility:ExtractStackTrace ()
Verse.Log:Error (string)
RimWorld.Pawn_NeedsTracker:AddOrRemoveNeedsAsAppropriate ()
RimWorld.Pawn_NeedsTracker:.ctor (Verse.Pawn)
RimWorld.PawnComponentsUtility:CreateInitialComponents (Verse.Pawn)
(wrapper dynamic-method) MonoMod.Utils.DynamicMethodDefinition:Verse.PawnGenerator.TryGenerateNewPawnInternal_Patch1 (Verse.PawnGenerationRequest&,string&,bool,bool)
Verse.PawnGenerator:GenerateNewPawnInternal (Verse.PawnGenerationRequest&)
Verse.PawnGenerator:GenerateOrRedressPawnInternal (Verse.PawnGenerationRequest)
(wrapper dynamic-method) MonoMod.Utils.DynamicMethodDefinition:Verse.PawnGenerator.GeneratePawn_Patch1 (Verse.PawnGenerationRequest)
Verse.PawnGenerator:GeneratePawn (Verse.PawnKindDef,RimWorld.Faction,System.Nullable`1<RimWorld.Planet.PlanetTile>)
Verse.DebugToolsSpawning/<>c__DisplayClass0_0:<SpawnPawn>b__2 ()
LudeonTK.DebugTool:DebugToolOnGUI ()
LudeonTK.DebugTools:DebugToolsOnGUI ()
RimWorld.UIRoot_Play:UIRootOnGUI ()
Verse.Root:OnGUI ()

Tried to get CurKindLifeStage from humanlike pawn Justin
UnityEngine.StackTraceUtility:ExtractStackTrace ()
Verse.Log:Error (string)
Verse.Log:ErrorOnce (string,int)
Verse.Pawn_AgeTracker:get_CurKindLifeStage ()
Verse.PawnRenderNode_AnimalPart:GraphicFor (Verse.Pawn)
Verse.PawnRenderNode_AnimalPart:MeshSetFor (Verse.Pawn)
Verse.PawnRenderNode:.ctor (Verse.Pawn,Verse.PawnRenderNodeProperties,Verse.PawnRenderTree)
Verse.PawnRenderNode_AnimalPart:.ctor (Verse.Pawn,Verse.PawnRenderNodeProperties,Verse.PawnRenderTree)
System.Reflection.RuntimeConstructorInfo:InternalInvoke (object,object[],bool)
System.Reflection.RuntimeConstructorInfo:DoInvoke (object,System.Reflection.BindingFlags,System.Reflection.Binder,object[],System.Globalization.CultureInfo)
System.Reflection.RuntimeConstructorInfo:Invoke (System.Reflection.BindingFlags,System.Reflection.Binder,object[],System.Globalization.CultureInfo)
System.RuntimeType:CreateInstanceImpl (System.Reflection.BindingFlags,System.Reflection.Binder,object[],System.Globalization.CultureInfo,object[],System.Threading.StackCrawlMark&)
System.Activator:CreateInstance (System.Type,System.Reflection.BindingFlags,System.Reflection.Binder,object[],System.Globalization.CultureInfo,object[])
System.Activator:CreateInstance (System.Type,object[])
Verse.PawnRenderNode:Init (Verse.Pawn)
Verse.PawnRenderNode:.ctor (Verse.Pawn,Verse.PawnRenderNodeProperties,Verse.PawnRenderTree)
Verse.PawnRenderNode_Parent:.ctor (Verse.Pawn,Verse.PawnRenderNodeProperties,Verse.PawnRenderTree)
System.Reflection.RuntimeConstructorInfo:InternalInvoke (object,object[],bool)
System.Reflection.RuntimeConstructorInfo:DoInvoke (object,System.Reflection.BindingFlags,System.Reflection.Binder,object[],System.Globalization.CultureInfo)
System.Reflection.RuntimeConstructorInfo:Invoke (System.Reflection.BindingFlags,System.Reflection.Binder,object[],System.Globalization.CultureInfo)
System.RuntimeType:CreateInstanceImpl (System.Reflection.BindingFlags,System.Reflection.Binder,object[],System.Globalization.CultureInfo,object[],System.Threading.StackCrawlMark&)
System.Activator:CreateInstance (System.Type,System.Reflection.BindingFlags,System.Reflection.Binder,object[],System.Globalization.CultureInfo,object[])
System.Activator:CreateInstance (System.Type,object[])
(wrapper dynamic-method) MonoMod.Utils.DynamicMethodDefinition:Verse.PawnRenderTree.TrySetupGraphIfNeeded_Patch1 (Verse.PawnRenderTree)
(wrapper dynamic-method) MonoMod.Utils.DynamicMethodDefinition:Verse.PawnRenderTree.EnsureInitialized_Patch1 (Verse.PawnRenderTree,Verse.PawnRenderFlags)
Verse.PawnRenderer:EnsureGraphicsInitialized ()
Verse.PawnRenderer:DynamicDrawPhaseAt (Verse.DrawPhase,UnityEngine.Vector3,System.Nullable`1<Verse.Rot4>,bool)
Verse.Pawn:DynamicDrawPhaseAt (Verse.DrawPhase,UnityEngine.Vector3,bool)
Verse.Thing:DynamicDrawPhase (Verse.DrawPhase)
Verse.DynamicDrawManager:DrawDynamicThings ()
Verse.Map:MapUpdate ()
Verse.Game:UpdatePlay ()
Verse.Root_Play:Update ()

Exception when initializing node Root for pawn Justin: System.Reflection.TargetInvocationException: Exception has been thrown by the target of an invocation. ---> System.NullReferenceException: Object reference not set to an instance of an object
[Ref 5D9F4BB1]
  at Verse.PawnRenderNode_AnimalPart.GraphicFor (Verse.Pawn pawn) [0x0003d] in <46372f5dadbf4af8939e608076251180>:0 
  at Verse.PawnRenderNode_AnimalPart.MeshSetFor (Verse.Pawn pawn) [0x00000] in <46372f5dadbf4af8939e608076251180>:0 
Verse.PawnRenderNode..ctor(Pawn pawn, PawnRenderNodeProperties props, PawnRenderTree tree)
Verse.PawnRenderNode_AnimalPart..ctor(Pawn pawn, PawnRenderNodeProperties props, PawnRenderTree tree)
(wrapper managed-to-native) System.Reflection.RuntimeConstructorInfo.InternalInvoke(System.Reflection.RuntimeConstructorInfo,object,object[],System.Exception&)
  at System.Reflection.RuntimeConstructorInfo.InternalInvoke (System.Object obj, System.Object[] parameters, System.Boolean wrapExceptions) [0x00005] in <51fded79cd284d4d911c5949aff4cb21>:0 
   --- End of inner exception stack trace ---
[Ref AD616277]
  at System.Reflection.RuntimeConstructorInfo.InternalInvoke (System.Object obj, System.Object[] parameters, System.Boolean wrapExceptions) [0x0001a] in <51fded79cd284d4d911c5949aff4cb21>:0 
  at System.Reflection.RuntimeConstructorInfo.DoInvoke (System.Object obj, System.Reflection.BindingFlags invokeAttr, System.Reflection.Binder binder, System.Object[] parameters, System.Globalization.CultureInfo culture) [0x00086] in <51fded79cd284d4d911c5949aff4cb21>:0 
  at System.Reflection.RuntimeConstructorInfo.Invoke (System.Reflection.BindingFlags invokeAttr, System.Reflection.Binder binder, System.Object[] parameters, System.Globalization.CultureInfo culture) [0x00000] in <51fded79cd284d4d911c5949aff4cb21>:0 
  at System.RuntimeType.CreateInstanceImpl (System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, System.Object[] args, System.Globalization.CultureInfo culture, System.Object[] activationAttributes, System.Threading.StackCrawlMark& stackMark) [0x0022b] in <51fded79cd284d4d911c5949aff4cb21>:0 
  at System.Activator.CreateInstance (System.Type type, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, System.Object[] args, System.Globalization.CultureInfo culture, System.Object[] activationAttributes) [0x0009c] in <51fded79cd284d4d911c5949aff4cb21>:0 
  at System.Activator.CreateInstance (System.Type type, System.Object[] args) [0x00000] in <51fded79cd284d4d911c5949aff4cb21>:0 
  at Verse.PawnRenderNode.Init (Verse.Pawn pawn) [0x0007f] in <46372f5dadbf4af8939e608076251180>:0 
Verse.PawnRenderNode..ctor(Pawn pawn, PawnRenderNodeProperties props, PawnRenderTree tree)
UnityEngine.StackTraceUtility:ExtractStackTrace ()
Verse.Log:Error (string)
Verse.PawnRenderNode:.ctor (Verse.Pawn,Verse.PawnRenderNodeProperties,Verse.PawnRenderTree)
Verse.PawnRenderNode_Parent:.ctor (Verse.Pawn,Verse.PawnRenderNodeProperties,Verse.PawnRenderTree)
System.Reflection.RuntimeConstructorInfo:InternalInvoke (object,object[],bool)
System.Reflection.RuntimeConstructorInfo:DoInvoke (object,System.Reflection.BindingFlags,System.Reflection.Binder,object[],System.Globalization.CultureInfo)
System.Reflection.RuntimeConstructorInfo:Invoke (System.Reflection.BindingFlags,System.Reflection.Binder,object[],System.Globalization.CultureInfo)
System.RuntimeType:CreateInstanceImpl (System.Reflection.BindingFlags,System.Reflection.Binder,object[],System.Globalization.CultureInfo,object[],System.Threading.StackCrawlMark&)
System.Activator:CreateInstance (System.Type,System.Reflection.BindingFlags,System.Reflection.Binder,object[],System.Globalization.CultureInfo,object[])
System.Activator:CreateInstance (System.Type,object[])
(wrapper dynamic-method) MonoMod.Utils.DynamicMethodDefinition:Verse.PawnRenderTree.TrySetupGraphIfNeeded_Patch1 (Verse.PawnRenderTree)
(wrapper dynamic-method) MonoMod.Utils.DynamicMethodDefinition:Verse.PawnRenderTree.EnsureInitialized_Patch1 (Verse.PawnRenderTree,Verse.PawnRenderFlags)
Verse.PawnRenderer:EnsureGraphicsInitialized ()
Verse.PawnRenderer:DynamicDrawPhaseAt (Verse.DrawPhase,UnityEngine.Vector3,System.Nullable`1<Verse.Rot4>,bool)
Verse.Pawn:DynamicDrawPhaseAt (Verse.DrawPhase,UnityEngine.Vector3,bool)
Verse.Thing:DynamicDrawPhase (Verse.DrawPhase)
Verse.DynamicDrawManager:DrawDynamicThings ()
Verse.Map:MapUpdate ()
Verse.Game:UpdatePlay ()
Verse.Root_Play:Update ()

Node is null - you must called EnsureGraphicsInitialized() on the drawn dynamic thing Justin before drawing it.
UnityEngine.StackTraceUtility:ExtractStackTrace ()
Verse.Log:Error (string)
Verse.Log:ErrorOnce (string,int)
Verse.PawnRenderTree:TraverseTree (System.Action`1<Verse.PawnRenderNode>)
Verse.PawnRenderTree:InitializeAncestors ()
(wrapper dynamic-method) MonoMod.Utils.DynamicMethodDefinition:Verse.PawnRenderTree.TrySetupGraphIfNeeded_Patch1 (Verse.PawnRenderTree)
(wrapper dynamic-method) MonoMod.Utils.DynamicMethodDefinition:Verse.PawnRenderTree.EnsureInitialized_Patch1 (Verse.PawnRenderTree,Verse.PawnRenderFlags)
Verse.PawnRenderer:EnsureGraphicsInitialized ()
Verse.PawnRenderer:DynamicDrawPhaseAt (Verse.DrawPhase,UnityEngine.Vector3,System.Nullable`1<Verse.Rot4>,bool)
Verse.Pawn:DynamicDrawPhaseAt (Verse.DrawPhase,UnityEngine.Vector3,bool)
Verse.Thing:DynamicDrawPhase (Verse.DrawPhase)
Verse.DynamicDrawManager:DrawDynamicThings ()
Verse.Map:MapUpdate ()
Verse.Game:UpdatePlay ()
Verse.Root_Play:Update ()

Tried to ensure initialized null PawnRenderNode.
UnityEngine.StackTraceUtility:ExtractStackTrace ()
Verse.Log:Warning (string)
Verse.PawnRenderNode:EnsureInitialized (Verse.PawnRenderFlags)
(wrapper dynamic-method) MonoMod.Utils.DynamicMethodDefinition:Verse.PawnRenderTree.EnsureInitialized_Patch1 (Verse.PawnRenderTree,Verse.PawnRenderFlags)
Verse.PawnRenderer:EnsureGraphicsInitialized ()
Verse.PawnRenderer:DynamicDrawPhaseAt (Verse.DrawPhase,UnityEngine.Vector3,System.Nullable`1<Verse.Rot4>,bool)
Verse.Pawn:DynamicDrawPhaseAt (Verse.DrawPhase,UnityEngine.Vector3,bool)
Verse.Thing:DynamicDrawPhase (Verse.DrawPhase)
Verse.DynamicDrawManager:DrawDynamicThings ()
Verse.Map:MapUpdate ()
Verse.Game:UpdatePlay ()
Verse.Root_Play:Update ()

Exception drawing Justin: System.NullReferenceException: Object reference not set to an instance of an object
[Ref BCD45751]
  at Verse.PawnRenderNode.get_RecacheRequested () [0x00016] in <46372f5dadbf4af8939e608076251180>:0 
  at Verse.PawnRenderNode.EnsureInitialized (Verse.PawnRenderFlags defaultRenderFlagsNow) [0x00010] in <46372f5dadbf4af8939e608076251180>:0 
  at Verse.PawnRenderTree.EnsureInitialized (Verse.PawnRenderFlags defaultRenderFlagsNow) [0x00013] in <46372f5dadbf4af8939e608076251180>:0 
    - POSTFIX rimworld.erdelf.alien_race.main: Void AlienRace.AlienRenderTreePatches:PawnRenderTreeEnsureInitializedPostfix(PawnRenderTree __instance)
  at Verse.PawnRenderer.EnsureGraphicsInitialized () [0x0000c] in <46372f5dadbf4af8939e608076251180>:0 
  at Verse.PawnRenderer.RenderPawnAt (UnityEngine.Vector3 drawLoc, System.Nullable`1[T] rotOverride, System.Boolean neverAimWeapon) [0x0000d] in <46372f5dadbf4af8939e608076251180>:0 
  at Verse.PawnRenderer.DynamicDrawPhaseAt (Verse.DrawPhase phase, UnityEngine.Vector3 drawLoc, System.Nullable`1[T] rotOverride, System.Boolean neverAimWeapon) [0x0001d] in <46372f5dadbf4af8939e608076251180>:0 
  at Verse.Pawn.DynamicDrawPhaseAt (Verse.DrawPhase phase, UnityEngine.Vector3 drawLoc, System.Boolean flip) [0x0000f] in <46372f5dadbf4af8939e608076251180>:0 
  at Verse.Thing.DynamicDrawPhase (Verse.DrawPhase phase) [0x00017] in <46372f5dadbf4af8939e608076251180>:0 
  at Verse.DynamicDrawManager.DrawDynamicThings () [0x000ec] in <46372f5dadbf4af8939e608076251180>:0 
UnityEngine.StackTraceUtility:ExtractStackTrace ()
Verse.Log:Error (string)
Verse.DynamicDrawManager:DrawDynamicThings ()
Verse.Map:MapUpdate ()
Verse.Game:UpdatePlay ()
Verse.Root_Play:Update ()

Error rendering pawn portrait: System.NullReferenceException: Object reference not set to an instance of an object
[Ref 57F9E45C]
  at Verse.PawnRenderNode.get_RecacheRequested () [0x00016] in <46372f5dadbf4af8939e608076251180>:0 
  at Verse.PawnRenderNode.EnsureInitialized (Verse.PawnRenderFlags defaultRenderFlagsNow) [0x00010] in <46372f5dadbf4af8939e608076251180>:0 
  at Verse.PawnRenderTree.EnsureInitialized (Verse.PawnRenderFlags defaultRenderFlagsNow) [0x00013] in <46372f5dadbf4af8939e608076251180>:0 
    - POSTFIX rimworld.erdelf.alien_race.main: Void AlienRace.AlienRenderTreePatches:PawnRenderTreeEnsureInitializedPostfix(PawnRenderTree __instance)
  at Verse.PawnRenderer.RenderCache (Verse.Rot4 rotation, System.Single angle, UnityEngine.Vector3 positionOffset, System.Boolean renderHead, System.Boolean portrait, System.Boolean renderHeadgear, System.Boolean renderClothes, System.Collections.Generic.IReadOnlyDictionary`2[TKey,TValue] overrideApparelColor, System.Nullable`1[T] overrideHairColor, System.Boolean stylingStation) [0x00145] in <46372f5dadbf4af8939e608076251180>:0 
UnityEngine.StackTraceUtility:ExtractStackTrace ()
Verse.Log:Error (string)
Verse.PawnRenderer:RenderCache (Verse.Rot4,single,UnityEngine.Vector3,bool,bool,bool,bool,System.Collections.Generic.IReadOnlyDictionary`2<RimWorld.Apparel, UnityEngine.Color>,System.Nullable`1<UnityEngine.Color>,bool)
RimWorld.PawnCacheRenderer:OnPostRender ()
(wrapper dynamic-method) MonoMod.Utils.DynamicMethodDefinition:RimWorld.PawnCacheRenderer.RenderPawn_Patch1 (RimWorld.PawnCacheRenderer,Verse.Pawn,UnityEngine.RenderTexture,UnityEngine.Vector3,single,single,Verse.Rot4,bool,bool,bool,bool,UnityEngine.Vector3,System.Collections.Generic.IReadOnlyDictionary`2<RimWorld.Apparel, UnityEngine.Color>,System.Nullable`1<UnityEngine.Color>,bool)
RimWorld.PortraitsCache/PortraitParams:RenderPortrait (Verse.Pawn,UnityEngine.RenderTexture)
RimWorld.PortraitsCache:Get (Verse.Pawn,UnityEngine.Vector2,Verse.Rot4,UnityEngine.Vector3,single,bool,bool,bool,bool,System.Collections.Generic.IReadOnlyDictionary`2<RimWorld.Apparel, UnityEngine.Color>,System.Nullable`1<UnityEngine.Color>,bool,System.Nullable`1<Verse.PawnHealthState>)
RimWorld.ColonistBarColonistDrawer:DrawColonist (UnityEngine.Rect,Verse.Pawn,Verse.Map,bool,bool)
RimWorld.ColonistBar:ColonistBarOnGUI ()
RimWorld.MapInterface:MapInterfaceOnGUI_BeforeMainTabs ()
RimWorld.UIRoot_Play:UIRootOnGUI ()
Verse.Root:OnGUI ()

Root level exception in Update(): System.NullReferenceException: Object reference not set to an instance of an object
[Ref B57FC1D8]
  at Verse.PawnRenderNode.get_RecacheRequested () [0x00016] in <46372f5dadbf4af8939e608076251180>:0 
  at Verse.PawnRenderNode.EnsureInitialized (Verse.PawnRenderFlags defaultRenderFlagsNow) [0x00010] in <46372f5dadbf4af8939e608076251180>:0 
  at Verse.PawnRenderTree.EnsureInitialized (Verse.PawnRenderFlags defaultRenderFlagsNow) [0x00013] in <46372f5dadbf4af8939e608076251180>:0 
    - POSTFIX rimworld.erdelf.alien_race.main: Void AlienRace.AlienRenderTreePatches:PawnRenderTreeEnsureInitializedPostfix(PawnRenderTree __instance)
  at Verse.PawnRenderer.EnsureGraphicsInitialized () [0x0000c] in <46372f5dadbf4af8939e608076251180>:0 
  at Verse.PawnRenderer.DynamicDrawPhaseAt (Verse.DrawPhase phase, UnityEngine.Vector3 drawLoc, System.Nullable`1[T] rotOverride, System.Boolean neverAimWeapon) [0x00003] in <46372f5dadbf4af8939e608076251180>:0 
  at Verse.Pawn.DynamicDrawPhaseAt (Verse.DrawPhase phase, UnityEngine.Vector3 drawLoc, System.Boolean flip) [0x0000f] in <46372f5dadbf4af8939e608076251180>:0 
  at Verse.Thing.DynamicDrawPhase (Verse.DrawPhase phase) [0x00017] in <46372f5dadbf4af8939e608076251180>:0 
  at Verse.DynamicDrawManager.DrawDynamicThings () [0x0006f] in <46372f5dadbf4af8939e608076251180>:0 
  at Verse.Map.MapUpdate () [0x000d4] in <46372f5dadbf4af8939e608076251180>:0 
  at Verse.Game.UpdatePlay () [0x00049] in <46372f5dadbf4af8939e608076251180>:0 
  at Verse.Root_Play.Update () [0x00032] in <46372f5dadbf4af8939e608076251180>:0 
UnityEngine.StackTraceUtility:ExtractStackTrace ()
Verse.Log:Error (string)
Verse.Root_Play:Update ()

Root level exception in Update(): System.NullReferenceException: Object reference not set to an instance of an object
[Ref B57FC1D8] Duplicate stacktrace, see ref for original
UnityEngine.StackTraceUtility:ExtractStackTrace ()
Verse.Log:Error (string)
Verse.Root_Play:Update ()
