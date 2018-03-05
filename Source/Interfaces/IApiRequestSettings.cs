using System.Collections.Generic;
using YoutubeSnoop.Arguments;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Interfaces
{
    public interface IApiRequestSettings
    {
        RequestType RequestType { get; }
        IEnumerable<ApiArgument> GetArguments();
    }
}