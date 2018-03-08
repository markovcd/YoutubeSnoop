namespace YoutubeSnoop.Api.Entities.VideoCategories
{
    public class VideoCategory : Response
    {
        public string Id { get; set; }
        public Snippet Snippet { get; set; }
    }
}
