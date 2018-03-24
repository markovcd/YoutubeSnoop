using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using YoutubeSnoop.Api.Arguments;
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
            var actual = new Argument(name, value).ToString();
            var expected = "SomeName=SomeValue";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToString_SimpleTyped()
        {
            var name = "SomeName";
            var value = true;
            var actual = new Argument<bool>(name, value).ToString();
            var expected = "SomeName=true";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToString_ReturnsEmpty()
        {
            var name = "SomeName";
            var value = string.Empty;
            var actual = new Argument(name, value).ToString();
            var expected = string.Empty;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToString_ThrowsException()
        {
            Action a = () => new Argument(null, "value").ToString();

            Assert.ThrowsException<ArgumentNullException>(a);
        }

        [TestMethod]
        public void ToString_SimpleApiPart()
        {
            var actual = new PartTypeArgument(PartType.Statistics).ToString();
            var expected = "part=statistics";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToString_MultipleApiPart()
        {
            var e = new[] { PartType.Statistics, PartType.BrandingSettings, PartType.TopicDetails };
            var actual = new PartTypeArgument(e).ToString();
            var expected = "part=statistics,brandingSettings,topicDetails";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToString_ApiPartThrowsException()
        {
            Action a = () => new PartTypeArgument(Enumerable.Empty<PartType>()).ToString();
            Assert.ThrowsException<InvalidOperationException>(a);
        }
    }
}