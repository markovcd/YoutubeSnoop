using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Api.Entities.Activities
{
    public class ActivitySocial : ActivityItem
    {
        /// <summary>
        /// The name of the social network.
        /// </summary>
        public SocialType? Type { get; set; }

        /// <summary>
        /// The author of the social network post.
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// The URL of the social network post.
        /// </summary>
        public string ReferenceUrl { get; set; }

        /// <summary>
        /// An image of the post's author.
        /// </summary>
        public string ImageUrl { get; set; }
    }
}