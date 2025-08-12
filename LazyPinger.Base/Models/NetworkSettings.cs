using System.ComponentModel.DataAnnotations;
using System.Net;

namespace LazyPinger.Base.Models
{
    public class NetworkSettings
    {
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        public string IpAddress { get; set; }

        public List<IPAddress> HostAddresses { get; set; }

        public string SubnetAddress { get; set; }

        public string GatewayAddress { get; set; }

        public string MacDictionaryFile = "ListofMAC.txt";
    }
}
