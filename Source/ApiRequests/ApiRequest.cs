using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using YoutubeSnoop.ApiArguments;
using YoutubeSnoop.Static;
using Newtonsoft.Json;

namespace YoutubeSnoop.ApiRequests
{
    public enum ApiRequestType
    {
        [Description("videos")]
        Videos,
        [Description("playlistItems")]
        PlaylistItems
    }

    class ApiRequest
    {
        private const string _apiKey = "AIzaSyAHVb6LDoO5aARmDlUe9PIeU_U1et1bWd8"; // project Api key, do not touch!
        private const string _apiUrl = "https://www.googleapis.com/youtube/v3/{0}?{1}&key={2}";

        private string _data;
        private Entities.Response _response;

        public ApiRequestType RequestType { get; }
        public IEnumerable<ApiArgument> Arguments { get; }
    
        public string Data => _data ?? (_data = RequestData(Url));
        public Entities.Response Response => _response ?? (_response = Deserialize(Data));
        public string Url { get; }

        public ApiRequest(ApiRequestType requestType, IEnumerable<ApiArgument> arguments)
        {
            RequestType = requestType;
            Arguments = arguments;
            Url = FormatApiUrl(requestType, arguments);
        }

        protected static string FormatApiUrl(ApiRequestType requestType, IEnumerable<ApiArgument> arguments)
        {
            var requestTypeString = requestType.GetDescription();
            var argumentString = arguments.Aggregate("", (s, a) => $"{s}&{a}").Substring(1);

            return string.Format(_apiUrl, requestTypeString, argumentString, _apiKey);
        }

        protected static string RequestData(string requestUrl)
        {
            var http = new WebClient();
            return http.DownloadString(requestUrl);
        }

        protected static Entities.Response Deserialize(string data)
        {
            return JsonConvert.DeserializeObject<Entities.Response>(data);
        }

    }

    
}
