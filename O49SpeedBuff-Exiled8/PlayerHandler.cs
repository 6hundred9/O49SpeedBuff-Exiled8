using Exiled.API.Enums;
using Exiled.API.Interfaces;
using Exiled.Events.EventArgs.Player;
using PlayerRoles;
using Respawning;

namespace O49SpeedBuff_Exiled8
{
    public class PlayerHandler
    {
        public static void OnSpawning(SpawnedEventArgs ev)
        {
            if (ev.Player.Role == RoleTypeId.Scp049)
            {
                ev.Player.EnableEffect(EffectType.MovementBoost, 10);
            }
        }
    }
}