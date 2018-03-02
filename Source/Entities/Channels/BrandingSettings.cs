using System.Collections.Generic;

namespace YoutubeSnoop.Entities.Channels
{
    public class BrandingSettings
    {
        public BrandingSettingsChannel Channel { get; set; }
        public BrandingSettingsImage Image { get; set; }
        public IList<Hint> Hints { get; set; }
    }
}