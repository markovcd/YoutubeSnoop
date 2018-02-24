using System.Collections.Generic;
using System.Linq;
using YoutubeSnoop.ApiArguments;

namespace YoutubeSnoop.ApiRequests
{
    class VideoApiRequest : ApiRequest
    {
        public VideoApiRequest(string id) : base(ApiRequestType.Videos, GetArguments(id).ToArray()) { }

        protected static IEnumerable<ApiArgument> GetArguments(string id)
        {
            yield return new ApiPartArgument(PartType.Snippet);
            yield return new ApiIdArgument(id);
        }
    }
}
