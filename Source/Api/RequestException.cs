using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net;
using YoutubeSnoop.Api.Entities;

namespace YoutubeSnoop.Api
{
    public class RequestException : Exception
    {
        public IList<Error> Errors { get; set; }
        public HttpStatusCode Code { get; set; }
        public new string Message { get; set; }

        public static RequestException FromJson(string json)
        {
            return JObject.Parse(json).SelectToken("error").ToObject<RequestException>();
        }
    }
}