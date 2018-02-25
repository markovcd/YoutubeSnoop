using System.Collections.Generic;
using YoutubeSnoop.ApiRequests.Arguments;

namespace YoutubeSnoop.ApiRequests.Settings
{
    public class VideoApiRequestSettings : Interfaces.IApiRequestSettings
    {
        public string Id { get; set; }

        public IEnumerable<ApiArgument> GetArguments()
        {
            yield return new ApiArgument("id", Id);
        }
    }
}
