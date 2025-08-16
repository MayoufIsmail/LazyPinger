using System.Collections.ObjectModel;
using System.Net.Sockets;
using System.Net;
using LazyPinger.Base.Models.Devices;

namespace LazyPinger.Base.Services
{
    public interface IPingerService
    {
        public List<DevicePing> GetDevicesOnSubnet();

        public List<DevicePing> GetDevicesOnSubnet(string ipAddress);

        public Task<TcpListener> StartServer(string selectedIP, int selectedPort);

        public Task<bool> PingAll(ref ObservableCollection<DevicePing> foundDevices);

        public List<String> GetMacAddresses();

        public bool SendUdpMessage(string selectedIP, string messageToSend, int defaultPort);

    }
}
