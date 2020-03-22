using TUNING;
using UnityEngine;

namespace SterlingEngine
{
    internal class SterlingEngineConfig: IBuildingConfig
    {
        public const string Id = "SterlingEngine";
        public const string DisplayName = "Sterling Engine";
        public const string Description = "Nobody knows how it actually works, but it sure look cool.";
        public static string Effect = "Slightly gas hotter than its surroundings to generate some power.";
        public override BuildingDef CreateBuildingDef()
        {
            var def = BuildingTemplates.CreateBuildingDef(
                Id, 
                2, // Width
                3, // Height
                "generatorwood_kanim", // Animation string?
                BUILDINGS.HITPOINTS.TIER2,
                20f, // Build time
                BUILDINGS.CONSTRUCTION_MASS_KG.TIER2, // How much mass is this anyway?
                MATERIALS.REFINED_METALS, // Building material
                1600f, // Melting point??
                BuildLocationRule.OnFloor,
                BUILDINGS.DECOR.BONUS.TIER1,
                NOISE_POLLUTION.NONE
            );
            BuildingTemplates.CreateFoundationTileDef(def);
            def.AudioCategory = "Metal";
            def.Overheatable = false; // Should probably be true???
            def.ExhaustKilowattsWhenActive = 0f;
            def.SelfHeatKilowattsWhenActive = 0f;
            def.PermittedRotations = PermittedRotations.R90; // Kinda silly but I like the idea
            def.ViewMode = OverlayModes.Power.ID;
            def.GeneratorWattageRating = 120f;
            def.GeneratorBaseCapacity = 120f;
            def.PowerOutputOffset = new CellOffset(0, 0);
            //def.InputConduitType = ConduitType.Gas;
            return def;
        }

        public override void DoPostConfigureComplete(GameObject go)
        {
            //go.AddOrGet<GasConduitConsumer>();
            //go.AddOrGetDef<PoweredActiveController.Def>();
        }
    }
}
