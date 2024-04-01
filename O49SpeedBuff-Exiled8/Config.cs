using System.ComponentModel;
using Exiled.API.Interfaces;

namespace O49SpeedBuff_Exiled8
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public bool Debug { get; set; } = false;

        [Description("Intensity of the speed boost effect 0 - 255, 0 = disabled")]
        public byte intensity { get; set; } = 10;
    }
}