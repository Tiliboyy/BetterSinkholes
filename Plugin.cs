using BetterSinkholes.Configuration;
using Exiled.API.Features;
using HarmonyLib;

namespace BetterSinkholes
{
    internal class Plugin : Plugin<Config>
    {
        public static Harmony? harmony { set; get; }
        public static Plugin? Instance;

        public override void OnEnabled()
        {
            Instance = this;
            harmony = new Harmony($"Tiliboyy.BetterSinkholes.Patches");
            harmony.PatchAll();
                

        }

        public override void OnDisabled()
        {
            Instance = null;
            harmony?.UnpatchAll();
        }
    }
}
