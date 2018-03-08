using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Api.Settings
{
    public sealed class CommentApiRequestSettings : ApiRequestSettings
    {
        public override RequestType RequestType => RequestType.Comments;


    }
}