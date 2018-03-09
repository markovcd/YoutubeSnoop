namespace YoutubeSnoop.Api.Entities.Comments
{
    public class Comment : Response
    {
        /// <summary>
        /// The ID that YouTube uses to uniquely identify the comment.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// The snippet object contains basic details about the comment.
        /// </summary>
        public Snippet Snippet { get; set; }
    }
}
