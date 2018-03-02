﻿using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Settings
{
    public sealed class VideoApiRequestSettings : ApiRequestSettings
    {
        public override RequestType RequestType => RequestType.Videos;

        public string Id { get; set; }
        public Chart? Chart { get; set; }
        public string Hl { get; set; }
        public int? MaxHeight { get; set; }
        public int? MaxWidth { get; set; }
        public CountryCode? RegionCode { get; set; }
        public string VideoCategoryId { get; set; }
    }
}