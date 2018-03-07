using System.Collections.Generic;

namespace YoutubeSnoop.Api.Entities.Channels
{
    public class BrandingSettings
    {
        public BrandingSettingsChannel Channel { get; set; }
        public BrandingSettingsImage Image { get; set; }
        public IList<Hint> Hints { get; set; }
    }
}