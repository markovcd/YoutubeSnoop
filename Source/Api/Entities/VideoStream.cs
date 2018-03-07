namespace YoutubeSnoop.Api.Entities
{
    public class VideoStream
    {
        public int? WidthPixels { get; set; }
        public int? HeightPixels { get; set; }
        public double? FrameRateFps { get; set; }
        public double? AspectRatio { get; set; }
        public string Codec { get; set; }
        public long? BitrateBps { get; set; }
        public string Rotation { get; set; }
        public string Vendor { get; set; }
    }
}