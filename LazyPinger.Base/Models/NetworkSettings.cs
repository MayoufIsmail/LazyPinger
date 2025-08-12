using System.ComponentModel.DataAnnotations;

namespace LazyPinger.Core.Models
{
    public class NetworkSettings
    {
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        public string IpAddress { get; set; }

        public string SubnetAddress { get; set; }

        public string GatewayAddress { get; set; }

    }
}
