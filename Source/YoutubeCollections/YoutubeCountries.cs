using YoutubeSnoop.Entities.I18nRegions;
using YoutubeSnoop.Settings;

namespace YoutubeSnoop
{
    public class YoutubeCountries : YoutubeCollection<YoutubeCountry, I18nRegion, I18nRegionApiRequestSettings>
    {
        public YoutubeCountries(IApiRequest<I18nRegion, I18nRegionApiRequestSettings> request) : base(request) { }

        protected override YoutubeCountry CreateItem(I18nRegion response)
        {
            return new YoutubeCountry(response);
        }
    }
}