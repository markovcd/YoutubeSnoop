using System.Collections.Generic;

namespace YoutubeSnoop.Entities
{
    public class VideoContentDetails
    {
        public string Duration { get; set; }
        public string Dimension { get; set; }
        public string Definition { get; set; }
        public string Caption { get; set; }
        public string LicensedContent { get; set; }
        public string Projection { get; set; }
        public bool? HasCustomThumbnail { get; set; }
        public RegionRestriction RegionRestriction { get; set; }
        public IDictionary<string, object> ContentRating { get; set; }
    }

    
}