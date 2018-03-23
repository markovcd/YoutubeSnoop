using System.Collections.Generic;
using YoutubeSnoop.Api;
using YoutubeSnoop.Api.Entities.I18nRegions;
using YoutubeSnoop.Api.Settings;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop
{
    public sealed class YoutubeCountries : YoutubeCollection<YoutubeCountry, I18nRegion, I18nRegionApiRequestSettings>
    {
        public YoutubeCountries(IApiRequest<I18nRegion, I18nRegionApiRequestSettings> request) : base(request)
        {
        }

        public YoutubeCountries(I18nRegionApiRequestSettings settings = null, IEnumerable<PartType> partTypes = null, int resultsPerPage = 20)
            : base(settings, partTypes, resultsPerPage)
        {
        }
    }
}