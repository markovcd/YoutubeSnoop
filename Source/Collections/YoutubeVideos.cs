using System.Collections.Generic;
using YoutubeSnoop.Api;
using YoutubeSnoop.Api.Entities.Videos;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop
{
    public sealed class YoutubeVideos : YoutubeCollection<YoutubeVideo, Video, VideoSettings>
    {
        public YoutubeVideos(VideoSettings settings, IEnumerable<PartType> partTypes = null, int resultsPerPage = 20)
            : base(settings, partTypes, resultsPerPage)
        {
        }
    }
}