﻿using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Settings
{
    public sealed class I18nRegionApiRequestSettings : ApiRequestSettings
    {
        public override RequestType RequestType => RequestType.I18nRegions;

        public string Hl { get; set; }
    }
}