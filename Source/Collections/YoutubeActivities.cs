using System.Collections.Generic;
using YoutubeSnoop.Api;
using YoutubeSnoop.Api.Entities.Activities;
using YoutubeSnoop.Api.Settings;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop
{
    public sealed class YoutubeActivities : YoutubeCollection<YoutubeActivity, Activity, ActivityApiRequestSettings>
    {
        public YoutubeActivities(IApiRequest<Activity, ActivityApiRequestSettings> request) : base(request)
        {
        }

        public YoutubeActivities(ActivityApiRequestSettings settings = null, IEnumerable<PartType> partTypes = null, int resultsPerPage = 20) 
            : base(settings, partTypes, resultsPerPage)
        {
        }
    }
}