using LazyPinger.Core.Services;

namespace LazyPinger.Tests
{
    [TestClass]
    public sealed class NetworkServiceTest
    {
        [TestMethod]
        public void InitNetworkSettingsTest()
        {
            var networkService = new NetworkService();
            var res = networkService.InitNetworkSettings();
            Assert.IsNotNull(res);
        }
    }
}
