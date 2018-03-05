using YoutubeSnoop.Entities.I18nRegions;
using YoutubeSnoop.Enums;
using YoutubeSnoop.Interfaces;

namespace YoutubeSnoop
{
    public class YoutubeCountry : IYoutubeItem
    {
        public ResourceKind Kind { get; }
        public string Id { get; }
        public I18nRegion Item { get; }
        public CountryCode CountryCode { get; }
        public string CountryName { get; }

        public YoutubeCountry(I18nRegion region)
        {
            Item = region;

            Kind = Item.Kind;
            Id = Item.Id;
            CountryCode = Item.Snippet.Gl;
            CountryName = Item.Snippet.Name;
        }
    }
}