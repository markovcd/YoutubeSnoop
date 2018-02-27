using System.Collections.Generic;

namespace YoutubeSnoop.Entities
{
    public class ChannelBrandingSettings
    {
        public ChannelBrandingSettingsChannel Channel { get; set; }
        public ChannelBrandingSettingsImage Image { get; set; }
        public IList<Hint> Hints { get; set; }
    }
}