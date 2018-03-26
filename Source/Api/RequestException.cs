using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
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

        public static RequestException FromWebException(WebException ex)
        {
            string errorJson;

            using (var reader = new StreamReader(ex.Response.GetResponseStream())) errorJson = reader.ReadToEnd();

            return FromJson(errorJson);
        }
    }
}