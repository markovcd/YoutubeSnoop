using System;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Api.Entities.Captions
{
    public class Snippet
    {
        /// <summary>
        /// The ID that YouTube uses to uniquely identify the video associated with the caption track.
        /// </summary>
        public string VideoId { get; set; }

        /// <summary>
        /// The date and time when the caption track was last updated.
        /// </summary>
        public DateTime? LastUpdated { get; set; }

        /// <summary>
        /// The caption track's type.
        /// </summary>
        public CaptionType? TrackKind { get; set; }

        /// <summary>
        /// The language of the caption track. The property value is a BCP-47 language tag.
        /// </summary>
        public string Language { get; set; }

        /// <summary>
        /// The name of the caption track. The name is intended to be visible to the user as an option during playback.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The type of audio track associated with the caption track.
        /// </summary>
        public AudioTrackType? AudioTrackType { get; set; }

        /// <summary>
        /// Indicates whether the track contains closed captions for the deaf and hard of hearing. The default value is false.
        /// </summary>
        public bool? IsCC { get; set; }

        /// <summary>
        /// Indicates whether the caption track uses large text for the vision-impaired. The default value is false.
        /// </summary>
        public bool? IsLarge { get; set; }

        /// <summary>
        /// Indicates whether caption track is formatted for "easy reader," meaning it is at a third-grade level for language learners. The default value is false.
        /// </summary>
        public bool? IsEasyReader { get; set; }

        /// <summary>
        /// Indicates whether the caption track is a draft. If the value is true, then the track is not publicly visible. The default value is false.
        /// </summary>
        public bool? IsDraft { get; set; }

        /// <summary>
        /// Indicates whether YouTube synchronized the caption track to the audio track in the video. The value will be true if a sync was explicitly requested when the caption track was uploaded. For example, when calling the captions.insert or captions.update methods, you can set the sync parameter to true to instruct YouTube to sync the uploaded track to the video. If the value is false, YouTube uses the time codes in the uploaded caption track to determine when to display captions.
        /// </summary>
        public bool? IsAutoSynced { get; set; }

        /// <summary>
        /// The caption track's status.
        /// </summary>
        public CaptionStatus? Status { get; set; }

        /// <summary>
        /// The reason that YouTube failed to process the caption track. This property is only present if the state property's value is failed.
        /// </summary>
        public CaptionFailureReason? FailureReason { get; set; }
    }
}
