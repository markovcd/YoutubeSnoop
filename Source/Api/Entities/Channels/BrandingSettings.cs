using System.Collections.Generic;

namespace YoutubeSnoop.Api.Entities.Channels
{
    public class BrandingSettings
    {
        public BrandingSettingsChannel Channel { get; set; }
        public BrandingSettingsImage Image { get; set; }
        public IList<PropertyValue> Hints { get; set; }
    }
}