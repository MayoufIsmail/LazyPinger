using System.ComponentModel.DataAnnotations;

namespace LazyPinger.Base.Models
{
    public class DevicePing
    {
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string IP {  get; set; }

        [Required]
        public string Port { get; set; }

        [Required]
        public string MacAddress { get; set; }

        [Required]
        public string Type { get; set; } = "Unknown";

        [Required]
        public string Image { get; set; } = "pcb_default.png";

        public string AnswerTime { get; set; } = "0ms";

    }
}
