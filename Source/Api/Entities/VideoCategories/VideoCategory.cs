namespace YoutubeSnoop.Api.Entities.VideoCategories
{
    public class VideoCategory : Response
    {
        /// <summary>
        /// The ID that YouTube uses to uniquely identify the video category.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// The snippet object contains basic details about the video category, including its title.
        /// </summary>
        public Snippet Snippet { get; set; }
    }
}
