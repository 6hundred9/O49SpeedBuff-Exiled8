using Exiled.API.Features;
using Exiled.API.Interfaces;
using PluginAPI.Core.Interfaces;

namespace O49SpeedBuff_Exiled8
{
    public class Plugin : Plugin<Config>
    {
        public static Plugin Instance;
        public override void OnEnabled()
        {
            Instance = this;
            
            base.OnEnabled();
            Exiled.Events.Handlers.Player.Spawned += PlayerHandler.OnSpawning;
        }
    }
}