using System.Collections.Generic;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Interfaces
{
    public interface IApiUrlFormatter<TSettings>
    where TSettings : IApiRequestSettings
    {
        string Format(TSettings settings, IEnumerable<PartType> partTypes, string pageToken, int resultsPerPage);
    }
}
