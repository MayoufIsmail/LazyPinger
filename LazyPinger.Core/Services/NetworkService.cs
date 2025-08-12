using LazyPinger.Base.IServices;
using LazyPinger.Base.Models;
using System.Net;

namespace LazyPinger.Core.Services
{
    public class NetworkService : INetworkService
    {
        public NetworkSettings NetworkSettings { get; set; } = new();

        public NetworkService() 
        {
            _ = InitNetworkSettings();
        }

        private async Task InitNetworkSettings()
        {
           var res = await GetHostIPs();
           NetworkSettings.HostAddresses = res.ToList();
        }

        public async Task<IPAddress[]> GetHostIPs()
        {
            var ipHostInfo = await Dns.GetHostEntryAsync(Dns.GetHostName());
            return ipHostInfo.AddressList;
        }
    }
}
