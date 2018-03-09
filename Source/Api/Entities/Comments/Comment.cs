namespace YoutubeSnoop.Api.Entities.Comments
{
    public class Comment : Response
    {
        /// <summary>
        /// 
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Snippet Snippet { get; set; }
    }
}
