﻿using YoutubeSnoop.Enums;
using YoutubeSnoop.Interfaces;

namespace YoutubeSnoop.Entities
{
    public class Response : IResponse
    {
        public string Etag { get; set; }
        public ResourceKind Kind { get; set; }
    }
}
