using System.Linq;
using System.Net;
using YoutubeSnoop.Static;
using Newtonsoft.Json;
using YoutubeSnoop.ApiRequests.Settings;
using YoutubeSnoop.Entities.Interfaces;
using System.Collections.Generic;
using System.Collections;
using YoutubeSnoop.Entities.Enumerables;
using YoutubeSnoop.ApiRequests.Settings.Interfaces;

namespace YoutubeSnoop.ApiRequests
{
    public abstract class ApiRequest<TResponse, TItem> : IEnumerable<TItem>
        where TResponse : class, IPagedResponse<TItem>
        where TItem : ISnippetResponse
    {
        private const string _apiKey = "AIzaSyAHVb6LDoO5aARmDlUe9PIeU_U1et1bWd8"; // project Api key, do not touch!
        private const string _apiUrl = "https://www.googleapis.com/youtube/v3/{0}?{1}&key={2}";

        private TResponse _response;
        public TResponse Response => _response ?? (_response = Deserialize(PageToken));

        public IApiRequestSettings Settings { get; }
        public ApiRequestType RequestType { get; }
        public int MaxResults { get; }
        public string PageToken { get; set; }

        protected ApiRequest(ApiRequestType requestType, int maxResults, IApiRequestSettings settings, string pageToken = null)
        {
            RequestType = requestType;
            MaxResults = maxResults;
            Settings = settings;
            PageToken = pageToken;
        }

        protected static string FormatApiUrl(ApiRequestType requestType, string pageToken, int maxResults, IApiRequestSettings settings)
        {
            var arguments = settings.GetArguments().ToList();
            arguments.Add(new Arguments.ApiPartArgument(Arguments.PartType.Snippet));
            arguments.Add(new Arguments.ApiArgument("pageToken", pageToken));
            arguments.Add(new Arguments.ApiArgument<int>("maxResults", maxResults));

            var argumentString = arguments.Aggregate("", (s, a) => $"{s}&{a}").Substring(1);

            return string.Format(_apiUrl, requestType.GetDescription(), argumentString, _apiKey);
        }

        protected static string RequestData(string requestUrl)
        {
            var http = new WebClient();
            return http.DownloadString(requestUrl);
        }

        protected static string RequestData(ApiRequestType requestType, string pageToken, int maxResults, IApiRequestSettings settings)
        {
            return RequestData(FormatApiUrl(requestType, pageToken, maxResults, settings));
        }

        protected static TResponse Deserialize(ApiRequestType requestType, string pageToken, int maxResults, IApiRequestSettings settings)
        {
            var data = RequestData(requestType, pageToken, maxResults, settings);
            return JsonConvert.DeserializeObject<TResponse>(data);
        }

        protected TResponse Deserialize(string pageToken)
        {
            return Deserialize(RequestType, pageToken, MaxResults, Settings);
        }

        public IEnumerator<TItem> GetEnumerator()
        {
            var enumerable = new PagedResponseEnumerable<TResponse, TItem>(Response, Deserialize);
            return enumerable.SelectMany(r => r.Items).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    
}
