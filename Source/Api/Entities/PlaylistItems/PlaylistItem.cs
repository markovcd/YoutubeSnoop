namespace YoutubeSnoop.Api.Entities.PlaylistItems
{
    public class PlaylistItem : Response
    {
        /// <summary>
        /// 
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Snippet Snippet { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public ContentDetails ContentDetails { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Status Status { get; set; }
    }
}