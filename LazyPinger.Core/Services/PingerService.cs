using LazyPinger.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyPinger.Core.Services
{
    public class PingerService : IPingerService
    {
        public NetworkSettings NetworkSettings { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public List<DevicePing> GetDevicesOnSubnet()
        {
            throw new NotImplementedException();
        }

        public List<DevicePing> GetDevicesOnSubnet(string ipAddress)
        {
            throw new NotImplementedException();
        }
    }
}
