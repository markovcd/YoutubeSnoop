using System.Collections.Generic;
using YoutubeSnoop.Api.Settings;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Api
{
    public interface IApiUrlFormatter<TSettings>
    where TSettings : IApiRequestSettings
    {
        string Format(TSettings settings, IEnumerable<PartType> partTypes, string pageToken, int resultsPerPage);
    }
}
