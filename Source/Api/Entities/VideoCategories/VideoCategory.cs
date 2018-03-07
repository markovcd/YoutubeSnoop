namespace YoutubeSnoop.Api.Entities.VideoCategories
{
    class VideoCategory : Response
    {
        public string Id { get; set; }
        public Snippet Snippet { get; set; }
    }
}
