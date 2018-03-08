using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Api.Settings
{
    public sealed class CaptionApiRequestSettings : ApiRequestSettings
    {
        public override RequestType RequestType => RequestType.Captions;

        /// <summary>
        /// Specifies the YouTube video ID of the video for which the API should return caption tracks.
        /// </summary>
        public string VideoId { get; set; }

        /// <summary>
        /// Specifies a comma-separated list of IDs that identify the caption resources that should be retrieved. Each ID must identify a caption track associated with the specified video.
        /// </summary>
        public string Id { get; set; }
    }
}