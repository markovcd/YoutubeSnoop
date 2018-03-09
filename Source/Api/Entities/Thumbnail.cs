using Newtonsoft.Json;
using YoutubeSnoop.Api.Converters;

namespace YoutubeSnoop.Api.Entities
{
    [JsonConverter(typeof(ThumbnailConverter))]
    public class Thumbnail
    {
        /// <summary>
        /// The image's URL.
        /// </summary>
        public string Url { get; }

        /// <summary>
        /// The image's width.
        /// </summary>
        public int Width { get; }

        /// <summary>
        /// The image's height.
        /// </summary>
        public int Height { get; }

        public Thumbnail(string url, int width, int height)
        {
            Url = url; Width = width; Height = height;
        }
    }
}