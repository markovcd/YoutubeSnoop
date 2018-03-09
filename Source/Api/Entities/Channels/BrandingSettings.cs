using System.Collections.Generic;

namespace YoutubeSnoop.Api.Entities.Channels
{
    public class BrandingSettings
    {
        /// <summary>
        /// The channel object encapsulates branding properties of the channel page.
        /// </summary>
        public BrandingSettingsChannel Channel { get; set; }

        /// <summary>
        /// The image object encapsulates information about images that display on the channel's channel page or video watch pages.
        /// </summary>
        public BrandingSettingsImage Image { get; set; }

        /// <summary>
        /// The hints object encapsulates additional branding properties.
        /// </summary>
        public IList<PropertyValue> Hints { get; set; }
    }
}