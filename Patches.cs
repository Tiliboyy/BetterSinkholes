using System;
using CustomPlayerEffects;
using Exiled.API.Features;
using player = Exiled.API.Features.Player;
using HarmonyLib;
using Hazards;
using Mirror;
using PlayerRoles;
using RemoteAdmin;
using UnityEngine;

namespace BetterSinkholes.Handlers
{
    [HarmonyPatch(typeof(SinkholeEnvironmentalHazard), nameof(SinkholeEnvironmentalHazard.OnStay))]
    public class BetterSinkHole
    {
        public static bool Prefix(SinkholeEnvironmentalHazard __instance, ReferenceHub player)
        {
            if (Plugin.Instance == null ||
                !(Vector3.Distance(__instance.gameObject.transform.position, player.transform.position) <=
                  Plugin.Instance.Config.TeleportDistance)) return false;
            player.playerEffectsController.EnableEffect<Corroding>();

            return false;
        }
    }
}
