
using YoutubeSnoop.Api;
using YoutubeSnoop.Api.Entities.Comments;
using YoutubeSnoop.Api.Settings;

namespace YoutubeSnoop
{
    public class YoutubeComments : YoutubeCollection<YoutubeComment, Comment, CommentApiRequestSettings>
    {        
        public YoutubeComments(IApiRequest<Comment, CommentApiRequestSettings> request) : base(request) {  }

        protected override YoutubeComment CreateItem(Comment response)
        {
            return new YoutubeComment(response);
        }
    }
}