using System;
using System.Linq;
using YoutubeSnoop.Api;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Fluent
{
    public static partial class Youtube
    {
        public static YoutubeActivities Activities(ActivitySettings settings, params PartType[] partTypes)
        {
            return new YoutubeActivities(settings, partTypes, ResultsPerPage);
        }

        public static YoutubeActivity Activity(ActivitySettings settings, params PartType[] partTypes)
        {
            return new YoutubeActivity(settings, partTypes);
        }

        public static YoutubeActivities Activities(ActivitySettings settings = null)
        {
            return Activities(settings, PartType.Snippet);
        }

        public static YoutubeActivity Activity(ActivitySettings settings = null)
        {
            return Activity(settings, PartType.Snippet);
        }

        public static YoutubeActivity RequestPart(this YoutubeActivity activity, PartType partType)
        {
            return Activity(activity.Settings.Clone(), activity.PartTypes.Append(partType).ToArray());
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
            return Activities(activities.Settings.Clone(), activities.PartTypes.Append(partType).ToArray());
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

        public static YoutubeActivities ForChannelId(this YoutubeActivities activities, string id)
        {
            var settings = activities.Settings.Clone();
            settings.ChannelId = id;
            return Activities(settings, activities.PartTypes.ToArray());
        }

        public static YoutubeActivities PublishedBefore(this YoutubeActivities activities, DateTime d)
        {
            var settings = activities.Settings.Clone();
            settings.PublishedBefore = d;
            return Activities(settings, activities.PartTypes.ToArray());
        }

        public static YoutubeActivities PublishedAfter(this YoutubeActivities activities, DateTime d)
        {
            var settings = activities.Settings.Clone();
            settings.PublishedAfter = d;
            return Activities(settings, activities.PartTypes.ToArray());
        }
    }
}