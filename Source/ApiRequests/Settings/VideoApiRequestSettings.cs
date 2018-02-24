using System;
using System.Collections.Generic;
using System.Text;
using YoutubeSnoop.ApiRequests.Arguments;

namespace YoutubeSnoop.ApiRequests.Settings
{
    class VideoApiRequestSettings : IApiRequestSettings
    {
        public ApiRequestType RequestType => ApiRequestType.Videos;

        public string Id { get; set; }

        public IEnumerable<ApiArgument> GetArguments()
        {
            yield return new ApiPartArgument(PartType.Snippet);
            yield return new ApiArgument("id", Id);
        }
    }
}
