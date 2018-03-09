namespace YoutubeSnoop.Api.Entities.Activities
{
    public class ActivityPlaylistItem : ActivityItem
    {
        /// <summary>
        /// The value that YouTube uses to uniquely identify the playlist.
        /// </summary>
        public string PlaylistId { get; set; }

        /// <summary>
        /// The value that YouTube uses to uniquely identify the item in the playlist.
        /// </summary>
        public string PlaylistItemId { get; set; }
    }
}