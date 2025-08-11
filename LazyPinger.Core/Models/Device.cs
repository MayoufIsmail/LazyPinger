using System.ComponentModel.DataAnnotations;

namespace LazyPinger.Core.Models
{
    public class Device
    {
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string IP {  get; set; }

        [Required]
        public int Port { get; set; }

        [Required]
        public string MacAddress { get; set; }


    }
}
