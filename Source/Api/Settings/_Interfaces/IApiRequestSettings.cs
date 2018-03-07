using System.Collections.Generic;
using YoutubeSnoop.Api.Settings.Arguments;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Api.Settings
{
    public interface IApiRequestSettings
    {
        RequestType RequestType { get; }
        IEnumerable<ApiArgument> GetArguments();
    }
}