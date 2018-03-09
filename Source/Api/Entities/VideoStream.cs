namespace YoutubeSnoop.Api.Entities
{
    public class VideoStream
    {

        /// <summary>
        /// 
        /// </summary>
        public int? WidthPixels { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int? HeightPixels { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double? FrameRateFps { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double? AspectRatio { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Codec { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public long? BitrateBps { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Rotation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Vendor { get; set; }
    }
}