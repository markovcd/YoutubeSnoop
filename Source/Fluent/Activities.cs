using System;
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

        public static YoutubeActivity RequestPart(this YoutubeActivity activity, PartType partType)
        {
            var request = activity.Request.RequestPart(partType);
            return new YoutubeActivity(request);
        }

        public static YoutubeActivity RequestContentDetails(this YoutubeActivity activity)
        {
            return activity.RequestPart(PartType.ContentDetails);
        }

        public static YoutubeActivity RequestSnippet(this YoutubeActivity activity)
        {
            return activity.RequestPart(PartType.Snippet);
        }

        public static YoutubeActivity RequestAllParts(this YoutubeActivity activity)
        {
            return activity.RequestSnippet().RequestContentDetails();
        }

        public static YoutubeActivities RequestPart(this YoutubeActivities activities, PartType partType)
        {
            var request = activities.Request.RequestPart(partType);
            return new YoutubeActivities(request);
        }

        public static YoutubeActivities RequestContentDetails(this YoutubeActivities activities)
        {
            return activities.RequestPart(PartType.ContentDetails);
        }

        public static YoutubeActivities RequestSnippet(this YoutubeActivities activities)
        {
            return activities.RequestPart(PartType.Snippet);
        }

        public static YoutubeActivities RequestAllParts(this YoutubeActivities activities)
        {
            return activities.RequestSnippet().RequestContentDetails();
        }

        public static YoutubeActivities ChannelId(this YoutubeActivities activities, string id)
        {
            var request = activities.Request.Clone();
            request.Settings.ChannelId = id;
            return new YoutubeActivities(request);
        }

        public static YoutubeActivities PublishedBefore(this YoutubeActivities activities, DateTime d)
        {
            var request = activities.Request.Clone();
            request.Settings.PublishedBefore = d;
            return new YoutubeActivities(request);
        }

        public static YoutubeActivities PublishedAfter(this YoutubeActivities activities, DateTime d)
        {
            var request = activities.Request.Clone();
            request.Settings.PublishedAfter = d;
            return new YoutubeActivities(request);
        }
    }
}
