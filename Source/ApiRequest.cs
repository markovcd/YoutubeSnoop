using System;
using System.Collections.Generic;
using System.Linq;
using YoutubeSnoop.Arguments;
using YoutubeSnoop.Entities;
using YoutubeSnoop.Enumerables;
using YoutubeSnoop.Enums;
using YoutubeSnoop.Interfaces;

namespace YoutubeSnoop
{   
    public class ApiRequest<TItem, TSettings>
        where TItem : IResponse
        where TSettings : IApiRequestSettings
    {
        private const string _apiUrl = "https://www.googleapis.com/youtube/v3/{0}?{1}";

        private const string _apiKey = "AIzaSyAHVb6LDoO5aARmDlUe9PIeU_U1et1bWd8"; // project Api key, do not touch!
        private const bool _prettyPrint = false;

        private const string _prettyPrintName = "prettyPrint";
        private const string _apiKeyName = "key";

        private static readonly ApiArgument _prettyPrintArgument = new ApiArgument<bool>(_prettyPrintName, _prettyPrint);
        private static readonly ApiArgument _apiKeyArgument = new ApiArgument(_apiKeyName, _apiKey);       

        public IEnumerable<Response<TItem>> Responses { get; }
        public IEnumerable<TItem> Items { get; }

        public TSettings Settings { get; }
        public int ResultsPerPage { get; }

        public IEnumerable<PartType> PartTypes { get; }
          
        public ApiRequest(TSettings settings, IEnumerable<PartType> partTypes, int resultsPerPage = 20)
        {
            ResultsPerPage = resultsPerPage;
            Settings = settings;
            PartTypes = partTypes ?? new[] { PartType.Snippet };         

            Responses = new PagedResponseEnumerable<TItem>(Deserialize);
            Items = Responses.SelectMany(r => r.Items);
        }

        public ApiRequest(TSettings settings, PartType partType, int resultsPerPage = 20)
            : this(settings, new[] { partType }, resultsPerPage) { }

        public ApiRequest(TSettings settings, int resultsPerPage = 20)
            : this(settings, null, resultsPerPage) { }

        public static string FormatApiUrl(TSettings settings, IEnumerable<PartType> partTypes, string pageToken, int resultsPerPage)
        {
            var arguments = settings.GetArguments().ToList();
            arguments.Add(new ApiPartArgument(partTypes));
            arguments.Add(new ApiArgument(nameof(pageToken), pageToken));
            arguments.Add(new ApiArgument<int>(nameof(resultsPerPage), resultsPerPage));
            arguments.Add(_prettyPrintArgument);
            arguments.Add(_apiKeyArgument);

            var argumentString = arguments.Select(a => a.ToString())
                                          .Where(s => !string.IsNullOrEmpty(s))
                                          .Aggregate((s1, s2) => $"{s1}&{s2}");

            return string.Format(_apiUrl, settings.RequestType.ToCamelCase(), argumentString);
        }

        public static Response<TItem> Deserialize(TSettings settings, IEnumerable<PartType> partTypes, string pageToken, int resultsPerPage = 20)
        {
            var requestUrl = FormatApiUrl(settings, partTypes, pageToken, resultsPerPage);
            var json = JsonDownloader.Download(requestUrl);
            return ResourceFactory.DeserializeResponse<TItem>(json);
        }

        public Response<TItem> Deserialize(string pageToken = null)
        {
            return Deserialize(Settings, PartTypes, pageToken, ResultsPerPage);
        }     
    }
}