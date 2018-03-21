using YoutubeSnoop.Api;
using YoutubeSnoop.Api.Entities.I18nRegions;
using YoutubeSnoop.Api.Settings;

namespace YoutubeSnoop
{
    public sealed class YoutubeCountries : YoutubeCollection<YoutubeCountry, I18nRegion, I18nRegionApiRequestSettings>
    {
        public YoutubeCountries(IApiRequest<I18nRegion, I18nRegionApiRequestSettings> request) : base(request)
        {
        }

        protected override YoutubeCountry CreateItem(I18nRegion response)
        {
            return new YoutubeCountry(response);
        }
    }
}