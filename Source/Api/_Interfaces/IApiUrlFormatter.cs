using System.Collections.Generic;
using YoutubeSnoop.Api.Settings;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Api
{
    public interface IApiUrlFormatter
    {
        string Format(IApiRequestSettings settings, IEnumerable<PartType> partTypes, string pageToken, int resultsPerPage);
    }
}
