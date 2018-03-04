using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using YoutubeSnoop.Entities;

namespace YoutubeSnoop.Exceptions
{
    class YoutubeException : Exception
    {
        public IList<Error> Errors { get; set; }
        public int Code { get; set; }
        public new string Message { get; set; }

        public static YoutubeException FromJson(string json)
        {
            return JObject.Parse(json).SelectToken("error").ToObject<YoutubeException>();
        }

        public static YoutubeException FromWebException(WebException ex)
        {
            string errorJson;

            using (var reader = new StreamReader(ex.Response.GetResponseStream())) errorJson = reader.ReadToEnd();

            return FromJson(errorJson);
        }
    }
}
