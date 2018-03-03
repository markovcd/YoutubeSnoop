using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using YoutubeSnoop;
using YoutubeSnoop.Arguments;
using YoutubeSnoop.Enums;

namespace UnitTests
{
    [TestClass]
    public class ExtensionsTests
    {
        [TestMethod]
        public void GetUrl_ThrowsException()
        {
            Action a = () => Extensions.GetUrl(ResourceKind.SubscriptionListResponse, "someId");

            Assert.ThrowsException<InvalidOperationException>(a);
        }

        [TestMethod]
        public void GetUrl_Channel()
        {
            var actual = Extensions.GetUrl(ResourceKind.Channel, "UCTxdujUsyc9TsjW1BnBxivg");
            var expected = "https://www.youtube.com/channel/UCTxdujUsyc9TsjW1BnBxivg";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetUrl_Playlist()
        {
            var actual = Extensions.GetUrl(ResourceKind.Playlist, "PLg-NWZjrm22usa_eVDKCADwbJ29JYOrDI");
            var expected = "https://www.youtube.com/playlist?list=PLg-NWZjrm22usa_eVDKCADwbJ29JYOrDI";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetUrl_Video()
        {
            var actual = Extensions.GetUrl(ResourceKind.Video, "ybipOaP0o1I");
            var expected = "https://www.youtube.com/watch?v=ybipOaP0o1I";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetDescription_ReturnsNull()
        {
            var actual = Extensions.GetDescription(ResourceKind.Video);

            Assert.IsNull(actual);
        }

        [TestMethod]
        public void GetDescription_ReturnsString()
        {
            var actual = Extensions.GetDescription(LanguageCode.Pl);
            var expected = "Polish";

            Assert.AreEqual(expected, actual);
        }
    }
}