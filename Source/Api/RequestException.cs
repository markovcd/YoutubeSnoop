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
            if (string.IsNullOrWhiteSpace(json)) return null;
            if (!JObject.Parse(json).TryGetValue("error", out var requestException)) return null;

            return requestException?.ToObject<RequestException>();
        }
    }
}