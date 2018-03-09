using System.Collections.Generic;

namespace YoutubeSnoop.Api.Entities.Channels
{
    public class BrandingSettings
    {
        /// <summary>
        /// 
        /// </summary>
        public BrandingSettingsChannel Channel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public BrandingSettingsImage Image { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public IList<PropertyValue> Hints { get; set; }
    }
}