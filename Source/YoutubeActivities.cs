using YoutubeSnoop.Api;
using YoutubeSnoop.Api.Entities.Activities;
using YoutubeSnoop.Api.Settings;

namespace YoutubeSnoop
{
    public class YoutubeActivities : YoutubeCollection<YoutubeActivity, Activity, ActivityApiRequestSettings>
    {        
        public YoutubeActivities(IApiRequest<Activity, ActivityApiRequestSettings> request) : base(request) {  }

        protected override YoutubeActivity CreateItem(Activity response)
        {
            return new YoutubeActivity(response);
        }
    }
}