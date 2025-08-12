using LazyPinger.Base.Models;

namespace LazyPinger.Base.Services
{
    public interface IArpDetectorService
    {
        public Task ArpInit();

        public ArpType ArpType { get; set; }
    }
}
