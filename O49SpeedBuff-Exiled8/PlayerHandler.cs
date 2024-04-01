using Exiled.API.Interfaces;

namespace O49SpeedBuff_Exiled8
{
    public class PlayerHandler : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public bool Debug { get; set; } = false;
    }
}