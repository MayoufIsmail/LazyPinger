using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using LazyPinger.Base.Localization;

namespace LazyPinger.Base.Models.Devices
{
    public class DevicePing
    {
        [Key]
        public int ID { get; set; }

        public int DevicesGroupID { get; set; }

        [ForeignKey(nameof(DevicesGroupID))]
        public DevicesGroup DevicesGroup { get; set; }

        [Required]
        public string Name { get; set; }

        public string? Description { get; set; }

        public string? IP {  get; set; }

        public string? Port { get; set; }

        public string? MacAddress { get; set; }

        [Required]
        public string Type { get; set; } = AppResources.Unknown;

        [Required]
        public string Color { get; set; } = "#212121";

        [Required]
        public byte[]? Image { get; set; }

        public string? AnswerTime { get; set; } = "0ms";

    }
}
