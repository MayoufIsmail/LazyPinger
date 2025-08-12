using LazyPinger.Base.IServices;
using LazyPinger.Base.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyPinger.Core.Services
{
    public class NetworkService : INetworkService
    {
        public NetworkSettings NetworkSettings { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
