using System;
using Exiled.API.Features;
using Exiled.API.Interfaces;
using PluginAPI.Core.Interfaces;

namespace O49SpeedBuff_Exiled8
{
    public class Plugin : Plugin<Config>
    {
        public static Plugin Instance;
        public override string Author { get; } = "6hundred9";
        public override string Name { get; } = "049 Speed Buff";
        public override string Prefix { get; } = "DocSpeed";
        public override Version RequiredExiledVersion { get; } = new Version(8, 8, 0);

        public override void OnEnabled()
        {
            Instance = this;
            
            base.OnEnabled();
            Exiled.Events.Handlers.Player.Spawned += PlayerHandler.OnSpawning;
        }
    }
}