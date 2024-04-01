using Exiled.API.Features;
using Exiled.API.Interfaces;
using PluginAPI.Core.Interfaces;

namespace O49SpeedBuff_Exiled8
{
    public class Plugin : Plugin<Config>
    {
        public override void OnEnabled()
        {
            base.OnEnabled();
            Exiled.Events.Handlers.Player.Spawned += PlayerHandler.OnSpawning;
        }
    }
}