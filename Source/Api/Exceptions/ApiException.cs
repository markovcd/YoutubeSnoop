using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using YoutubeSnoop.Api.Entities;

namespace YoutubeSnoop.Api.Exceptions
{
    internal class ApiException : Exception
    {
        public IList<Error> Errors { get; set; }
        public HttpStatusCode Code { get; set; }
        public new string Message { get; set; }

        public static ApiException FromJson(string json)
        {
            return JObject.Parse(json).SelectToken("error").ToObject<ApiException>();
        }

        public static ApiException FromWebException(WebException ex)
        {
            string errorJson;

            using (var reader = new StreamReader(ex.Response.GetResponseStream())) errorJson = reader.ReadToEnd();

            return FromJson(errorJson);
        }
    }
}