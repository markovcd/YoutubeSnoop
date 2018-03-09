using System.Collections.Generic;

namespace YoutubeSnoop.Api.Entities.Channels
{
    public class BrandingSettingsChannel : TitleDescription
    {
        /// <summary>
        /// 
        /// </summary>
        public string Keywords { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string DefaultTab { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string TrackingAnalyticsAccountId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool? ModerateComments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool? ShowRelatedChannels { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool? ShowBrowseView { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string FeaturedChannelsTitle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public IList<string> FeaturedChannelsUrls { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string UnsubscribedTrailer { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string ProfileColor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string DefaultLanguage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Country { get; set; }
    }
}