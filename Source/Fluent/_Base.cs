using YoutubeSnoop.Api;
using YoutubeSnoop.Api.Entities;
using System.Linq;
using System;
using System.Collections.Generic;

namespace YoutubeSnoop.Fluent
{
    public static partial class Youtube
    {
        public static int ResultsPerPage { get; set; } = 20;
    }
}