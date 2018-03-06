namespace YoutubeSnoop.Entities.PlaylistItems
{
    public class PlaylistItem : Response
    {
        public string Id { get; set; }
        public Snippet Snippet { get; set; }
        public ContentDetails ContentDetails { get; set; }
        public Status Status { get; set; }
    }
}