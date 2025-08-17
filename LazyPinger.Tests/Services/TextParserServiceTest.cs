using LazyPinger.Core.Services;

namespace LazyPinger.Tests.Services
{
    [TestClass]
    public sealed class TextParserServiceTest
    {
        private TextParserService textParser = new();

        //[TestInitialize]
        //public void setup()
        //{
        //    textParser = new TextParserService();
        //}

        [TestMethod]
        public void GetSubnetFromAddressTest_ValidIp()
        {
            var res = textParser.GetSubnetFromAddress("192.168.1.10");
            Assert.AreEqual("192.168.1.", res);
        }

        [TestMethod]
        public void GetSubnetFromAddressTest_TwoParts()
        {
            var res = textParser.GetSubnetFromAddress("192.168");
            Assert.AreEqual("192.", res);
        }

        [TestMethod]
        public void GetSubnetFromAddressTest_OnePart()
        {
            var res = textParser.GetSubnetFromAddress("192");
            Assert.AreEqual("", res);
        }

        [TestMethod]
        public void GetSubnetFromAddressTest_EmptyString()
        {
            var res = textParser.GetSubnetFromAddress("");
            Assert.AreEqual("", res);
        }

        [TestMethod]
        public void GetSubnetFromAddressTest_ExtraDot()
        {
            var res = textParser.GetSubnetFromAddress("192.168.1.10.");
            Assert.AreEqual("192.168.1.10.", res);
        }

        [TestMethod]
        public void GetSubnetFromAddressTest_DoubleDots()
        {
            var res = textParser.GetSubnetFromAddress("192..1.10");
            Assert.AreEqual("192..1.", res);
        }

        [TestMethod]
        public void GetSubnetFromAddressTest_AllZeros()
        {
            var res = textParser.GetSubnetFromAddress("0.0.0.0");
            Assert.AreEqual("0.0.0.", res);
        }

        [TestMethod]
        public void GetSubnetFromAddressTest_All255s()
        {
            var res = textParser.GetSubnetFromAddress("255.255.255.255");
            Assert.AreEqual("255.255.255.", res);
        }

    }
 }
