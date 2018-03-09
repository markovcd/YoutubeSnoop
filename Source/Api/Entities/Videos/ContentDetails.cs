using System.Collections.Generic;

namespace YoutubeSnoop.Api.Entities.Videos
{
    public class ContentDetails
    {
        /// <summary>
        /// 
        /// </summary>
        public string Duration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Dimension { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Definition { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Caption { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string LicensedContent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Projection { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool? HasCustomThumbnail { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public RegionRestriction RegionRestriction { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public IDictionary<string, object> ContentRating { get; set; }
    }
}