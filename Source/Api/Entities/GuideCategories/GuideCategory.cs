namespace YoutubeSnoop.Api.Entities.GuideCategories
{
    public class GuideCategory : Response
    {
        /// <summary>
        /// The ID that YouTube uses to uniquely identify the guide category.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// The snippet object contains basic details about the category, such as its title.
        /// </summary>
        public Snippet Snippet { get; set; }
    }
}
