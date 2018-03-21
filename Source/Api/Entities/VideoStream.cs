using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Api.Entities
{
    public class VideoStream
    {
        /// <summary>
        /// The encoded video content's width in pixels. You can calculate the video's encoding aspect ratio as width_pixels / height_pixels.
        /// </summary>
        public int? WidthPixels { get; set; }

        /// <summary>
        /// The encoded video content's height in pixels.
        /// </summary>
        public int? HeightPixels { get; set; }

        /// <summary>
        /// The video stream's frame rate, in frames per second.
        /// </summary>
        public double? FrameRateFps { get; set; }

        /// <summary>
        /// The video content's display aspect ratio, which specifies the aspect ratio in which the video should be displayed.
        /// </summary>
        public double? AspectRatio { get; set; }

        /// <summary>
        /// The video codec that the stream uses.
        /// </summary>
        public string Codec { get; set; }

        /// <summary>
        /// The video stream's bitrate, in bits per second.
        /// </summary>
        public long? BitrateBps { get; set; }

        /// <summary>
        /// The amount that YouTube needs to rotate the original source content to properly display the video.
        /// </summary>
        public Rotation? Rotation { get; set; }

        /// <summary>
        /// A value that uniquely identifies a video vendor. Typically, the value is a four-letter vendor code.
        /// </summary>
        public string Vendor { get; set; }
    }
}