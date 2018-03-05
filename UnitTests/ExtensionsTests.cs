using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using YoutubeSnoop;
using YoutubeSnoop.Arguments;
using YoutubeSnoop.Entities;
using YoutubeSnoop.Enums;

namespace UnitTests
{
    [TestClass]
    public class ExtensionsTests
    {
        //[TestMethod]
        //public void GetUrl_ThrowsException()
        //{
        //    Action a = () => Extensions.Url(ResourceKind.SubscriptionListResponse, "someId");

        //    Assert.ThrowsException<InvalidOperationException>(a);
        //}

        //[TestMethod]
        //public void GetUrl_Channel()
        //{
        //    var actual = Extensions.Url(ResourceKind.Channel, "UCTxdujUsyc9TsjW1BnBxivg");
        //    var expected = "https://www.youtube.com/channel/UCTxdujUsyc9TsjW1BnBxivg";

        //    Assert.AreEqual(expected, actual);
        //}

        //[TestMethod]
        //public void GetUrl_Playlist()
        //{
        //    var actual = Extensions.Url(ResourceKind.Playlist, "PLg-NWZjrm22usa_eVDKCADwbJ29JYOrDI");
        //    var expected = "https://www.youtube.com/playlist?list=PLg-NWZjrm22usa_eVDKCADwbJ29JYOrDI";

        //    Assert.AreEqual(expected, actual);
        //}

        //[TestMethod]
        //public void GetUrl_Video()
        //{
        //    var actual = Extensions.Url(ResourceKind.Video, "ybipOaP0o1I");
        //    var expected = "https://www.youtube.com/watch?v=ybipOaP0o1I";

        //    Assert.AreEqual(expected, actual);
        //}

        [TestMethod]
        public void GetDescription_ReturnsNull()
        {
            var actual = Extensions.GetDescription(ResourceKind.Video);

            Assert.IsNull(actual);
        }

        //[TestMethod]
        //public void GetDescription_ReturnsString()
        //{
        //    var actual = Extensions.GetDescription(LanguageCode.Pl);
        //    var expected = "Polish";

        //    Assert.AreEqual(expected, actual);
        //}

        [TestMethod]
        public void ToCamelCase_Simple()
        {
            var actual = Extensions.ToCamelCase("PascalCaseText");
            var expected = "pascalCaseText";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToCamelCase_EmptyString()
        {
            var actual = Extensions.ToCamelCase("");

            Assert.IsNull(actual);
        }

        [TestMethod]
        public void GetId_ThrowsException()
        {
            var invalid = new ResourceIdChannel { Kind = ResourceKind.GuideCategoryListResponse, ChannelId = "invalid" };
            Action a = () => Extensions.Id(invalid); 

            Assert.ThrowsException<InvalidOperationException>(a);
        }

        [TestMethod]
        public void GetId_Channel()
        {
            var channel = new ResourceIdChannel { Kind = ResourceKind.Channel, ChannelId = "UCTxdujUsyc9TsjW1BnBxivg" };
            var actual = Extensions.Id(channel);
            var expected = "UCTxdujUsyc9TsjW1BnBxivg";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetId_Playlist()
        {
            var playlist = new ResourceIdPlaylist { Kind = ResourceKind.Playlist, PlaylistId = "PLg-NWZjrm22usa_eVDKCADwbJ29JYOrDI" };
            var actual = Extensions.Id(playlist);
            var expected = "PLg-NWZjrm22usa_eVDKCADwbJ29JYOrDI";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetId_Video()
        {
            var video = new ResourceIdVideo { Kind = ResourceKind.Video, VideoId = "ybipOaP0o1I" };
            var actual = Extensions.Id(video);
            var expected = "ybipOaP0o1I";

            Assert.AreEqual(expected, actual);
        }
    }
}