﻿using YoutubeSnoop.Api;
using YoutubeSnoop.Api.Entities.Videos;
using YoutubeSnoop.Api.Settings;

namespace YoutubeSnoop
{
    public class YoutubeVideos : YoutubeCollection<YoutubeVideo, Video, VideoApiRequestSettings>
    {
        public YoutubeVideos(IApiRequest<Video, VideoApiRequestSettings> request) : base(request) { }

        protected override YoutubeVideo CreateItem(Video response)
        {
            return new YoutubeVideo(response);
        }
    }
}