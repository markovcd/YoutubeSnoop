using System.Collections.Generic;
using YoutubeSnoop.Api;
using YoutubeSnoop.Api.Entities.Activities;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop
{
    public sealed class YoutubeActivities : YoutubeCollection<YoutubeActivity, Activity, ActivitySettings>
    {
        public YoutubeActivities(ActivitySettings settings = null, IEnumerable<PartType> partTypes = null, int resultsPerPage = 20) 
            : base(settings, partTypes, resultsPerPage)
        {
        }
    }
}