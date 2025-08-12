using LazyPinger.Base.Models;

namespace LazyPinger.Base.IServices
{
    public interface INetworkService
    {   
        public NetworkSettings NetworkSettings { get; set; }
    }
}
