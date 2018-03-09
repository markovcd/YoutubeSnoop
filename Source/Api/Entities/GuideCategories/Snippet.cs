namespace YoutubeSnoop.Api.Entities.GuideCategories
{
    public class Snippet
    {
        /// <summary>
        /// The ID that YouTube uses to uniquely identify the channel publishing the guide category.
        /// </summary>
        public string ChannelId { get; set; }

        /// <summary>
        /// The category's title.
        /// </summary>
        public string Title { get; set; }
    }
}