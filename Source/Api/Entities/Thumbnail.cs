using Newtonsoft.Json;
using YoutubeSnoop.Api.Converters;

namespace YoutubeSnoop.Api.Entities
{
    [JsonConverter(typeof(ThumbnailConverter))]
    public class Thumbnail
    {
        /// <summary>
        /// 
        /// </summary>
        public string Url { get; }

        /// <summary>
        /// 
        /// </summary>
        public int Width { get; }

        /// <summary>
        /// 
        /// </summary>
        public int Height { get; }

        public Thumbnail(string url, int width, int height)
        {
            Url = url; Width = width; Height = height;
        }
    }
}