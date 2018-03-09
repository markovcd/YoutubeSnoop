namespace YoutubeSnoop.Api.Entities.PlaylistItems
{
    public class PlaylistItem : Response
    {
        /// <summary>
        /// The ID that YouTube uses to uniquely identify the playlist item.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// The snippet object contains basic details about the playlist item, such as its title and position in the playlist.
        /// </summary>
        public Snippet Snippet { get; set; }

        /// <summary>
        /// The contentDetails object is included in the resource if the included item is a YouTube video. The object contains additional information about the video.
        /// </summary>
        public ContentDetails ContentDetails { get; set; }

        /// <summary>
        /// The status object contains information about the playlist item's privacy status.
        /// </summary>
        public Status Status { get; set; }
    }
}