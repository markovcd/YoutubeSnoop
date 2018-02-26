using System.Collections.Generic;
using YoutubeSnoop.Arguments;
using YoutubeSnoop.Enums;
using YoutubeSnoop.Interfaces;

namespace YoutubeSnoop.Settings
{
    public class VideoApiRequestSettings : IApiRequestSettings
    {
        public ApiRequestType RequestType => ApiRequestType.Videos;

        public string Id { get; set; }

        public IEnumerable<ApiArgument> GetArguments()
        {
            yield return new ApiArgument("id", Id);
        }
    }
}