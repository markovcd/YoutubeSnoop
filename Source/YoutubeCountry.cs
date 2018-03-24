using YoutubeSnoop.Api.Entities.I18nRegions;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop
{
    public sealed class YoutubeCountry : IYoutubeItem
    {
        public ResourceKind Kind { get; }
        public string Id { get; }
        public string CountryCode { get; }
        public string CountryName { get; }

        public YoutubeCountry(I18nRegion response)
        {
            if (response == null) return;

            Kind = response.Kind;
            Id = response.Id;
            CountryCode = response.Snippet?.Gl;
            CountryName = response.Snippet?.Name;
        }

        public override string ToString()
        {
            return CountryCode ?? base.ToString();
        }
    }
}