namespace YoutubeSnoop.Entities
{
    public class AudioStream
    {
        public int? ChannelCount { get; set; }
        public string Codec { get; set; }
        public long? BitrateBps { get; set; }
        public long? Vendor { get; set; }
    }
}