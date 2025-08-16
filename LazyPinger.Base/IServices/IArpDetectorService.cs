using LazyPinger.Base.Models.Network;

namespace LazyPinger.Base.Services
{
    public interface IArpDetectorService
    {
        public Task ArpInit();

        public ArpType ArpType { get; set; }
    }
}
