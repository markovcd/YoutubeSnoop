using System;
using YoutubeSnoop.Api.Attributes;
using YoutubeSnoop.Api.Converters;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Api
{
    public sealed class ActivitySettings : Settings
    {
        public override RequestType RequestType => RequestType.Activities;

        /// <summary>
        /// Specifies a unique YouTube channel ID. The API will then return a list of that channel's activities.
        /// </summary>
        public string ChannelId { get; set; }

        /// <summary>
        /// Specifies the earliest date and time that an activity could have occurred for that activity to be included in the API response. If the parameter value specifies a day, but not a time, then any activities that occurred that day will be included in the result set.
        /// </summary>
        [ToStringConvert(typeof(DateTimeConverter))]
        public DateTime? PublishedAfter { get; set; }

        /// <summary>
        /// Specifies the date and time before which an activity must have occurred for that activity to be included in the API response. If the parameter value specifies a day, but not a time, then any activities that occurred that day will be excluded from the result set.
        /// </summary>
        [ToStringConvert(typeof(DateTimeConverter))]
        public DateTime? PublishedBefore { get; set; }

        /// <summary>
        /// Instructs the API to return results for the specified country. The parameter value is an ISO 3166-1 alpha-2 country code. YouTube uses this value when the authorized user's previous activity on YouTube does not provide enough information to generate the activity feed.
        /// </summary>
        public string RegionCode { get; set; }
    }
}