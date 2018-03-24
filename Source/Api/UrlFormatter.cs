using System.Collections.Generic;
using System.Linq;
using YoutubeSnoop.Api.Arguments;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Api
{
    /// <summary>
    /// Default API request URL formatter for YoutubeSnoop. Use this in the constructor of ApiRequest class.
    /// </summary>
    public class UrlFormatter : IUrlFormatter
    {
        private const string _apiUrl = "https://www.googleapis.com/youtube/v3/{0}?{1}";

        private const string _apiKey = "AIzaSyAHVb6LDoO5aARmDlUe9PIeU_U1et1bWd8"; // project Api key, do not touch!
        private const bool _prettyPrint = false;

        private const string _prettyPrintName = "prettyPrint";
        private const string _apiKeyName = "key";

        private static readonly Argument _prettyPrintArgument = new Argument<bool>(_prettyPrintName, _prettyPrint);
        private static readonly Argument _apiKeyArgument = new Argument(_apiKeyName, _apiKey);

        public static string Format(ISettings settings, IEnumerable<PartType> partTypes, string pageToken, int resultsPerPage)
        {
            var arguments = settings.GetArguments().ToList();
            arguments.Add(new PartTypeArgument(partTypes));
            arguments.Add(new Argument(nameof(pageToken), pageToken));
            arguments.Add(new Argument<int>(nameof(resultsPerPage), resultsPerPage));
            arguments.Add(_prettyPrintArgument);
            arguments.Add(_apiKeyArgument);

            var argumentString = arguments.Select(a => a.ToString())
                                          .Where(s => !string.IsNullOrEmpty(s))
                                          .Aggregate('&');

            return string.Format(_apiUrl, settings.RequestType.ToCamelCase(), argumentString);
        }

        string IUrlFormatter.Format(ISettings settings, IEnumerable<PartType> partTypes, string pageToken, int resultsPerPage)
        {
            return Format(settings, partTypes, pageToken, resultsPerPage);
        }
    }
}