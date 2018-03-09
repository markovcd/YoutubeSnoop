using System.Collections.Generic;

namespace YoutubeSnoop.Api.Entities.Channels
{
    public class BrandingSettingsChannel : TitleDescription
    {
        /// <summary>
        /// Keywords associated with your channel. The value is a space-separated list of strings.
        /// </summary>
        public string Keywords { get; set; }

        /// <summary>
        /// The content tab that users should display by default when viewers arrive at your channel page.
        /// </summary>
        public string DefaultTab { get; set; }

        /// <summary>
        /// The ID for a Google Analytics account that you want to use to track and measure traffic to your channel.
        /// </summary>
        public string TrackingAnalyticsAccountId { get; set; }

        /// <summary>
        /// This setting determines whether user-submitted comments left on the channel page need to be approved by the channel owner to be publicly visible. The default value is false.
        /// </summary>
        public bool? ModerateComments { get; set; }

        /// <summary>
        /// This setting indicates whether YouTube should show an algorithmically generated list of related channels on your channel page.
        /// </summary>
        public bool? ShowRelatedChannels { get; set; }

        /// <summary>
        /// This setting indicates whether the channel page should display content in a browse or feed view. For example, the browse view might display separate sections for uploaded videos, playlists, and liked videos. The feed view, on the other hand, displays the channel's activity feed.
        /// </summary>
        public bool? ShowBrowseView { get; set; }

        /// <summary>
        /// The title that displays above the featured channels module. The title has a maximum length of 30 characters.
        /// </summary>
        public string FeaturedChannelsTitle { get; set; }

        /// <summary>
        /// A list of up to 100 channels that you would like to link to from the featured channels module. The property value is a list of YouTube channel ID values, each of which uniquely identifies a channel.
        /// </summary>
        public IList<string> FeaturedChannelsUrls { get; set; }

        /// <summary>
        /// The video that should play in the featured video module in the channel page's browse view for unsubscribed viewers. Subscribed viewers may see a different video that highlights more recent channel activity.
        /// If specified, the property's value must be the YouTube video ID of a public or unlisted video that is owned by the channel owner.
        /// </summary>
        public string UnsubscribedTrailer { get; set; }

        /// <summary>
        /// A prominent color that complements the channel's content.
        /// </summary>
        public string ProfileColor { get; set; }

        /// <summary>
        /// The language of the text in the channel resource's snippet.title and snippet.description properties.
        /// </summary>
        public string DefaultLanguage { get; set; }

        /// <summary>
        /// The country with which the channel is associated. Update this property to set the value of the snippet.country property.
        /// </summary>
        public string Country { get; set; }
    }
}