namespace YoutubeSnoop.Api.Entities.Activities
{
    public class Activity : Response
    {
        /// <summary>
        /// The ID that YouTube uses to uniquely identify the activity.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// The snippet object contains basic details about the activity, including the activity's type and group ID.
        /// </summary>
        public Snippet Snippet { get; set; }

        /// <summary>
        /// The contentDetails object contains information about the content associated with the activity. For example, if the snippet.type value is videoRated, then the contentDetails object's content identifies the rated video.
        /// </summary>
        public ContentDetails ContentDetails { get; set; }
    }
}