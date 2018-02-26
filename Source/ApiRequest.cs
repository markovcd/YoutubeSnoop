using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using YoutubeSnoop.Arguments;
using YoutubeSnoop.Entities;
using YoutubeSnoop.Enumerables;
using YoutubeSnoop.Enums;
using YoutubeSnoop.Interfaces;
using YoutubeSnoop.Settings;

namespace YoutubeSnoop
{
    public static class ApiRequest
    {
        public static ApiRequest<Video, VideoApiRequestSettings> Create(VideoApiRequestSettings settings, IEnumerable<PartType> partTypes, string pageToken = null, int maxResults = 20)
        {
            return new ApiRequest<Video, VideoApiRequestSettings>(settings, partTypes, pageToken, maxResults);
        }

        public static ApiRequest<Video, VideoApiRequestSettings> Create(VideoApiRequestSettings settings, PartType partType, string pageToken = null, int maxResults = 20)
        {
            return new ApiRequest<Video, VideoApiRequestSettings>(settings, partType, pageToken, maxResults);
        }

        public static ApiRequest<Video, VideoApiRequestSettings> Create(VideoApiRequestSettings settings, string pageToken = null, int maxResults = 20)
        {
            return new ApiRequest<Video, VideoApiRequestSettings>(settings, pageToken, maxResults);
        }

        public static ApiRequest<PlaylistItem, PlaylistApiRequestSettings> Create(PlaylistApiRequestSettings settings, IEnumerable<PartType> partTypes, string pageToken = null, int maxResults = 20)
        {
            return new ApiRequest<PlaylistItem, PlaylistApiRequestSettings>(settings, partTypes, pageToken, maxResults);
        }

        public static ApiRequest<PlaylistItem, PlaylistApiRequestSettings> Create(PlaylistApiRequestSettings settings, PartType partType, string pageToken = null, int maxResults = 20)
        {
            return new ApiRequest<PlaylistItem, PlaylistApiRequestSettings>(settings, partType, pageToken, maxResults);
        }

        public static ApiRequest<PlaylistItem, PlaylistApiRequestSettings> Create(PlaylistApiRequestSettings settings, string pageToken = null, int maxResults = 20)
        {
            return new ApiRequest<PlaylistItem, PlaylistApiRequestSettings>(settings, pageToken, maxResults);
        }

        public static ApiRequest<SearchResult, SearchApiRequestSettings> Create(SearchApiRequestSettings settings, IEnumerable<PartType> partTypes, string pageToken = null, int maxResults = 20)
        {
            return new ApiRequest<SearchResult, SearchApiRequestSettings>(settings, partTypes, pageToken, maxResults);
        }

        public static ApiRequest<SearchResult, SearchApiRequestSettings> Create(SearchApiRequestSettings settings, PartType partType, string pageToken = null, int maxResults = 20)
        {
            return new ApiRequest<SearchResult, SearchApiRequestSettings>(settings, partType, pageToken, maxResults);
        }

        public static ApiRequest<SearchResult, SearchApiRequestSettings> Create(SearchApiRequestSettings settings, string pageToken = null, int maxResults = 20)
        {
            return new ApiRequest<SearchResult, SearchApiRequestSettings>(settings, pageToken, maxResults);
        }
    }

    public class ApiRequest<TItem, TSettings>
        where TItem : IResponse
        where TSettings : IApiRequestSettings
    {
        private const string _apiKey = "AIzaSyAHVb6LDoO5aARmDlUe9PIeU_U1et1bWd8"; // project Api key, do not touch!
        private const string _apiUrl = "https://www.googleapis.com/youtube/v3/{0}?{1}&key={2}";

        private Response<TItem> _response;
        private IEnumerable<Response<TItem>> _totalResponses;
        private IEnumerable<TItem> _totalItems;

        public Response<TItem> Response => _response ?? (_response = Deserialize(PageToken));
        public IEnumerable<Response<TItem>> TotalResponses => _totalResponses ?? (_totalResponses = new PagedResponseEnumerable<TItem>(Response, Deserialize));
        public IEnumerable<TItem> TotalItems => _totalItems ?? (_totalItems = TotalResponses.SelectMany(r => r.Items));

        public TSettings Settings { get; }
        public int MaxResults { get; set; }
        public string PageToken { get; set; }
        public IEnumerable<PartType> PartTypes { get; }

        public string RequestUrl { get; protected set; }

        public ApiRequest(TSettings settings, IEnumerable<PartType> partTypes, string pageToken = null, int maxResults = 20)
        {
            MaxResults = maxResults;
            Settings = settings;
            PageToken = pageToken;
            PartTypes = partTypes ?? new[] { PartType.Snippet };
        }

        public ApiRequest(TSettings settings, PartType partType, string pageToken = null, int maxResults = 20)
            : this(settings, new[] { partType }, pageToken, maxResults) { }

        public ApiRequest(TSettings settings, string pageToken = null, int maxResults = 20)
            : this(settings, null, pageToken, maxResults) { }

        protected static string FormatApiUrl(TSettings settings, IEnumerable<PartType> partTypes, string pageToken, int maxResults)
        {
            var arguments = settings.GetArguments().ToList();
            arguments.Add(new ApiPartArgument(partTypes));
            arguments.Add(new ApiArgument("pageToken", pageToken));
            arguments.Add(new ApiArgument<int>("maxResults", maxResults));
            arguments.Add(new ApiArgument<bool>("prettyPrint", false));

            var argumentString = arguments.Select(a => a.ToString()).Where(s => !string.IsNullOrEmpty(s)).Aggregate((s1, s2) => $"{s1}&{s2}");
            System.Diagnostics.Debug.Print(argumentString);
            return string.Format(_apiUrl, settings.RequestType.GetDescription(), argumentString, _apiKey);
        }

        protected static string RequestData(string requestUrl)
        {
            var http = new WebClient();
            return http.DownloadString(requestUrl);
        }

        public Response<TItem> Deserialize(string pageToken)
        {
            RequestUrl = FormatApiUrl(Settings, PartTypes, pageToken, MaxResults);
            var data = RequestData(RequestUrl);
            var response = JsonConvert.DeserializeObject<Response<TItem>>(data);
            response.Json = data;
            return response;
        }
    }
}