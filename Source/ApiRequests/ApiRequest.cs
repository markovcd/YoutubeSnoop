using System.Linq;
using System.Net;
using YoutubeSnoop.Static;
using Newtonsoft.Json;
using YoutubeSnoop.ApiRequests.Settings;

namespace YoutubeSnoop.ApiRequests
{
    static class ApiRequest
    {
        private const string _apiKey = "AIzaSyAHVb6LDoO5aARmDlUe9PIeU_U1et1bWd8"; // project Api key, do not touch!
        private const string _apiUrl = "https://www.googleapis.com/youtube/v3/{0}?{1}&key={2}";

        public static string FormatApiUrl(IApiRequestSettings settings)
        {
            var requestTypeString = settings.RequestType.GetDescription();
            var argumentString = settings.GetArguments().Aggregate("", (s, a) => $"{s}&{a}").Substring(1);

            return string.Format(_apiUrl, requestTypeString, argumentString, _apiKey);
        }

        public static string RequestData(string requestUrl)
        {
            var http = new WebClient();
            return http.DownloadString(requestUrl);
        }

        public static string RequestData(IApiRequestSettings settings)
        {
            return RequestData(FormatApiUrl(settings));
        }

        public static Entities.Response Deserialize(string data)
        {
            return JsonConvert.DeserializeObject<Entities.Response>(data);
        }

        public static Entities.Response Deserialize(this IApiRequestSettings settings)
        {
            return Deserialize(RequestData(settings));
        }
    }

    
}
