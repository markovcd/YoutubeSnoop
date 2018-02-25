using System.Collections.Generic;
using YoutubeSnoop.ApiRequests.Arguments;

namespace YoutubeSnoop.ApiRequests.Settings.Interfaces
{
    public interface IApiRequestSettings
    {
        IEnumerable<ApiArgument> GetArguments();
    }
}
