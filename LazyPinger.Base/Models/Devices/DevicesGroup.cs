using System.ComponentModel.DataAnnotations;

namespace LazyPinger.Base.Models.Devices
{
    public class DevicesGroup
    {
        [Key]
        public int ID { get; set; }

        public string Type { get; set; } = string.Empty;

        public string Color { get; set; } = "FFFFFF";

        public List<DevicePing> DevicePings { get; set; } = new();
    }
}
