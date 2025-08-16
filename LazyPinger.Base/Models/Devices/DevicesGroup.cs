using System.ComponentModel.DataAnnotations;

namespace LazyPinger.Base.Models.Devices
{
    public class DevicesGroup
    {
        [Key]
        public int ID { get; set; }

        public bool Type { get; set; }

        public string Color { get; set; } = "FFFFFF";

        List<DevicePing> DevicePings { get; set; } = new();
    }
}
