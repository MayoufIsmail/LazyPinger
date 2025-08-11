
using LazyPinger.Core.Models;

namespace LazyPinger.Core.Services
{
    public interface IPingerService
    {
        public NetworkSettings NetworkSettings { get; set; }

        public List<DevicePing> GetDevicesOnSubnet();

        public List<DevicePing> GetDevicesOnSubnet(string ipAddress);

    }
}
