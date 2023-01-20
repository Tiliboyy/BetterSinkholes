using System;
using Exiled.API.Interfaces;
using System.ComponentModel;

namespace BetterSinkholes.Configuration
{
    [Serializable]
    public class Config : IConfig
    {
        [Description("Enable/disable BetterSinkholes")]
        public bool IsEnabled { get; set; } = true;
        
        public bool Debug { get; set; } = false;

        [Description("Distance from the center of a sinkhole where you get teleported")]
        public float TeleportDistance { get; set; } = 2f;
    }
}
