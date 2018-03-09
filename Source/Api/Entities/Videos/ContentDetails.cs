using System;
using System.Collections.Generic;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Api.Entities.Videos
{
    public class ContentDetails
    {
        /// <summary>
        /// The length of the video. 
        /// </summary>
        public TimeSpan? Duration { get; set; } //  ISO 8601  check if Json automatically converts

        /// <summary>
        /// Indicates whether the video is available in 3D or in 2D.
        /// </summary>
        public Dimension? Dimension { get; set; }

        /// <summary>
        /// Indicates whether the video is available in high definition (HD) or only in standard definition.
        /// </summary>
        public Definition? Definition { get; set; }

        /// <summary>
        /// Indicates whether captions are available for the video.
        /// </summary>
        public bool? Caption { get; set; }

        /// <summary>
        /// Indicates whether the video represents licensed content, which means that the content was uploaded to a channel linked to a YouTube content partner and then claimed by that partner.
        /// </summary>
        public string LicensedContent { get; set; }

        /// <summary>
        /// Specifies the projection format of the video.
        /// </summary>
        public string Projection { get; set; } // TODO enum - valid values 360 and rectangular

        /// <summary>
        /// Indicates whether the video uploader has provided a custom thumbnail image for the video. This property is only visible to the video uploader.
        /// </summary>
        public bool? HasCustomThumbnail { get; set; }

        /// <summary>
        /// he regionRestriction object contains information about the countries where a video is (or is not) viewable. The object will contain either the contentDetails.regionRestriction.allowed property or the contentDetails.regionRestriction.blocked property.
        /// </summary>
        public RegionRestriction RegionRestriction { get; set; }

        /// <summary>
        /// Specifies the ratings that the video received under various rating schemes.
        /// </summary>
        // public IDictionary<string, object> ContentRating { get; set; } TODO
    }
}