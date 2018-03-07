namespace YoutubeSnoop.Api.Entities
{
    public class ProcessingProgress
    {
        public long? PartsTotal { get; set; }
        public long? PartsProcessed { get; set; }
        public long? TimeLeftMs { get; set; }
    }
}