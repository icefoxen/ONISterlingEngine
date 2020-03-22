using Harmony;
using System.Collections.Generic;

namespace SterlingEngine
{
    public class SterlingPatches
    {
        public static class Mod_OnLoad
        {
            public static void OnLoad()
            {
                //Debug.Log("Hello world!");
            }
        }

        [HarmonyPatch(typeof(GeneratedBuildings))]
        [HarmonyPatch(nameof(GeneratedBuildings.LoadGeneratedBuildings))]
        public class GeneratedBuildings_LoadGeneratedBuildings_Patch
        {
            public static void Prefix()
            {
                Debug.Log("Attempting to load sterling engine");
                Strings.Add("STERLINGENGINE.NAME", SterlingEngineConfig.DisplayName);
                Strings.Add("STERLINGENGINE.DESC", SterlingEngineConfig.Description);
                Strings.Add("STERLINGENGINE.EFFECT", SterlingEngineConfig.Effect);
                ModUtil.AddBuildingToPlanScreen("Power", nameof(SterlingEngine));
            }

            public static void Postfix()
            {
                Debug.Log("Sterling engine hopefully loaded!");
            }
        }

        [HarmonyPatch(typeof(Db))]
        [HarmonyPatch(nameof(Db.Initialize))]
        public class Db_Initialize_Patch
        {
            public static void Prefix()
            {
                //Debug.Log("I execute before Db.Initialize!");
                List<string> tech = new List<string>(Database.Techs.TECH_GROUPING["TemperatureModulation"]) { nameof(SterlingEngine) };
                Database.Techs.TECH_GROUPING["TemperatureModulation"] = tech.ToArray();
                //Database.Techs.TECH_GROUPING["TemperatureModulation"].Append(nameof(SterlingEngine));
            }

            public static void Postfix()
            {
                //Debug.Log("I execute after Db.Initialize!");
            }
        }

    }
}
