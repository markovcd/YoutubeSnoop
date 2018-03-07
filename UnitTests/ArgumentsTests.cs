using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using YoutubeSnoop.Api.Settings.Arguments;
using YoutubeSnoop.Enums;

namespace UnitTests
{
    [TestClass]
    public class ArgumentsTests
    {
        [TestMethod]
        public void ToString_Simple()
        {
            var name = "SomeName";
            var value = "SomeValue";
            var actual = new ApiArgument(name, value).ToString();
            var expected = "SomeName=SomeValue";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToString_SimpleTyped()
        {
            var name = "SomeName";
            var value = true;
            var actual = new ApiArgument<bool>(name, value).ToString();
            var expected = "SomeName=true";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToString_ReturnsEmpty()
        {
            var name = "SomeName";
            var value = string.Empty;
            var actual = new ApiArgument(name, value).ToString();
            var expected = string.Empty;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToString_ThrowsException()
        {
            Action a = () => new ApiArgument(null, "value").ToString();

            Assert.ThrowsException<ArgumentNullException>(a);
        }

        [TestMethod]
        public void ToString_SimpleApiPart()
        {
            var actual = new ApiPartArgument(PartType.Statistics).ToString();
            var expected = "part=statistics";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToString_MultipleApiPart()
        {
            var e = new[] { PartType.Statistics, PartType.BrandingSettings, PartType.TopicDetails };
            var actual = new ApiPartArgument(e).ToString();
            var expected = "part=statistics,brandingSettings,topicDetails";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToString_ApiPartThrowsException()
        {
            Action a = () => new ApiPartArgument(Enumerable.Empty<PartType>()).ToString();
            Assert.ThrowsException<InvalidOperationException>(a);
        }
    }
}