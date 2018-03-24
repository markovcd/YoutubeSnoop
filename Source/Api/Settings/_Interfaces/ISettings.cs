using System.Collections.Generic;
using YoutubeSnoop.Api.Arguments;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Api
{
    public interface ISettings
    {
        RequestType RequestType { get; }

        IEnumerable<Argument> GetArguments();
    }
}