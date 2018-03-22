using System.Collections.Generic;
using System.Linq;
using YoutubeSnoop.Api.Settings;
using YoutubeSnoop.Api.Settings.Arguments;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Api
{
    /// <summary>
    /// Default API request URL formatter for YoutubeSnoop. Use this in the constructor of ApiRequest class.
    /// </summary>
    public class ApiUrlFormatter : IApiUrlFormatter
    {
        private const string _apiUrl = "https://www.googleapis.com/youtube/v3/{0}?{1}";

        private const string _apiKey = "AIzaSyAHVb6LDoO5aARmDlUe9PIeU_U1et1bWd8"; // project Api key, do not touch!
        private const bool _prettyPrint = false;

        private const string _prettyPrintName = "prettyPrint";
        private const string _apiKeyName = "key";

        private static readonly ApiArgument _prettyPrintArgument = new ApiArgument<bool>(_prettyPrintName, _prettyPrint);
        private static readonly ApiArgument _apiKeyArgument = new ApiArgument(_apiKeyName, _apiKey);

        public static string Format(IApiRequestSettings settings, IEnumerable<PartType> partTypes, string pageToken, int resultsPerPage)
        {
            var arguments = settings.GetArguments().ToList();
            arguments.Add(new ApiPartArgument(partTypes));
            arguments.Add(new ApiArgument(nameof(pageToken), pageToken));
            arguments.Add(new ApiArgument<int>(nameof(resultsPerPage), resultsPerPage));
            arguments.Add(_prettyPrintArgument);
            arguments.Add(_apiKeyArgument);

            var argumentString = arguments.Select(a => a.ToString())
                                          .Where(s => !string.IsNullOrEmpty(s))
                                          .Aggregate('&');

            return string.Format(_apiUrl, settings.RequestType.ToCamelCase(), argumentString);
        }

        string IApiUrlFormatter.Format(IApiRequestSettings settings, IEnumerable<PartType> partTypes, string pageToken, int resultsPerPage)
        {
            return Format(settings, partTypes, pageToken, resultsPerPage);
        }
    }
}