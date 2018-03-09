namespace YoutubeSnoop.Api.Entities
{
    public class ProcessingProgress
    {
        /// <summary>
        /// 
        /// </summary>
        public long? PartsTotal { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public long? PartsProcessed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public long? TimeLeftMs { get; set; }
    }
}