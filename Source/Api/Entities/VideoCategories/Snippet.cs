namespace YoutubeSnoop.Api.Entities.VideoCategories
{
    public class Snippet
    {
        /// <summary>
        /// The YouTube channel that created the video category.
        /// </summary>
        public string ChannelId { get; set; }

        /// <summary>
        /// The video category's title.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Indicates whether videos can be associated with the category.
        /// </summary>
        public bool? Assignable { get; set; }
    }
}