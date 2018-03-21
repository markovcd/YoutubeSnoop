using System;
using System.Collections.Generic;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Api.Entities.Videos
{
    public class Snippet : TitleDescription
    {
        /// <summary>
        /// The date and time that the video was published. Note that this time might be different than the time that the video was uploaded. For example, if a video is uploaded as a private video and then made public at a later time, this property will specify the time that the video was made public.
        /// </summary>
        /// <remarks>
        /// There are a couple of special cases:
        /// If a video is uploaded as a private video and the video metadata is retrieved by the channel owner, then the property value specifies the date and time that the video was uploaded.
        /// If a video is uploaded as an unlisted video, the property value also specifies the date and time that the video was uploaded. In this case, anyone who knows the video's unique video ID can retrieve the video metadata.
        /// </remarks>
        public DateTime? PublishedAt { get; set; }

        /// <summary>
        /// The ID that YouTube uses to uniquely identify the channel that the video was uploaded to.
        /// </summary>
        public string ChannelId { get; set; }

        /// <summary>
        /// Channel title for the channel that the video belongs to.
        /// </summary>
        public string ChannelTitle { get; set; }

        /// <summary>
        /// Indicates if the video is an upcoming/active live broadcast. Or it's "none" if the video is not an upcoming/active live broadcast.
        /// </summary>
        public LiveBroadcastContent? LiveBroadcastContent { get; set; }

        /// <summary>
        /// A map of thumbnail images associated with the video. For each object in the map, the key is the name of the thumbnail image, and the value is an object that contains other information about the thumbnail.
        /// </summary>
        public IDictionary<ThumbnailSize, Thumbnail> Thumbnails { get; set; }

        /// <summary>
        /// A list of keyword tags associated with the video. Tags may contain spaces. The property value has a maximum length of 500 characters.
        /// </summary>
        /// <remarks>
        /// Note the following rules regarding the way the character limit is calculated:
        /// The property value is a list, and commas between items in the list count toward the limit.
        /// If a tag contains a space, the API server handles the tag value as though it were wrapped in quotation marks, and the quotation marks count toward the character limit.So, for the purposes of character limits, the tag Foo-Baz contains seven characters, but the tag Foo Baz contains nine characters.
        /// </remarks>
        public IList<string> Tags { get; set; }

        /// <summary>
        /// The YouTube video category associated with the video. You must set a value for this property if you call the videos.update method and are updating the snippet part of a video resource.
        /// </summary>
        public string CategoryId { get; set; }

        /// <summary>
        /// The language of the text in the video resource's snippet.title and snippet.description properties.
        /// </summary>
        public string DefaultLanguage { get; set; }

        /// <summary>
        /// The default_audio_language property specifies the language spoken in the video's default audio track.
        /// </summary>
        public string DefaultAudioLanguage { get; set; }

        /// <summary>
        /// The localized video description.
        /// </summary>
        public TitleDescription Localized { get; set; }
    }
}