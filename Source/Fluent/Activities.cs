using System.Linq;
using YoutubeSnoop.Api.Entities.Activities;
using YoutubeSnoop.Api.Settings;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Fluent
{
    public static partial class Youtube
    {
        public static YoutubeActivities Activities(ActivityApiRequestSettings settings, params PartType[] partTypes)
        {
            var request = DefaultRequest<Activity, ActivityApiRequestSettings>(settings, partTypes);
            return new YoutubeActivities(request);
        }

        public static YoutubeActivity Activity(ActivityApiRequestSettings settings, params PartType[] partTypes)
        {
            var request = DefaultRequest<Activity, ActivityApiRequestSettings>(settings, partTypes);
            return new YoutubeActivity(request);
        }

        public static YoutubeActivities Activities(ActivityApiRequestSettings settings = null)
        {
            return Activities(settings ?? new ActivityApiRequestSettings(), PartType.Snippet);
        }

        public static YoutubeActivity Activity(ActivityApiRequestSettings settings = null)
        {
            return Activity(settings ?? new ActivityApiRequestSettings(), PartType.Snippet);
        }
    }
}
