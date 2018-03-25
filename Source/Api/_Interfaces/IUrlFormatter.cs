using System.Collections.Generic;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Api
{
    public interface IUrlFormatter
    {
        string Format(ISettings settings, IEnumerable<PartType> partTypes, string pageToken, int resultsPerPage, string key);
    }
}