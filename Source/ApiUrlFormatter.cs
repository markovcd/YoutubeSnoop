using System.Collections.Generic;
using System.Linq;
using YoutubeSnoop.Arguments;
using YoutubeSnoop.Enums;
using YoutubeSnoop.Interfaces;

namespace YoutubeSnoop
{
    public interface IApiUrlFormatter<TSettings>
        where TSettings : IApiRequestSettings
    {
        string Format(TSettings settings, IEnumerable<PartType> partTypes, string pageToken, int resultsPerPage);
    }

    public class ApiUrlFormatter<TSettings> : IApiUrlFormatter<TSettings>
        where TSettings : IApiRequestSettings
    {
        private const string _apiUrl = "https://www.googleapis.com/youtube/v3/{0}?{1}";

        private const string _apiKey = "AIzaSyAHVb6LDoO5aARmDlUe9PIeU_U1et1bWd8"; // project Api key, do not touch!
        private const bool _prettyPrint = false;

        private const string _prettyPrintName = "prettyPrint";
        private const string _apiKeyName = "key";

        private static readonly ApiArgument _prettyPrintArgument = new ApiArgument<bool>(_prettyPrintName, _prettyPrint);
        private static readonly ApiArgument _apiKeyArgument = new ApiArgument(_apiKeyName, _apiKey);

        public static string Format(TSettings settings, IEnumerable<PartType> partTypes, string pageToken, int resultsPerPage)
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

        string IApiUrlFormatter<TSettings>.Format(TSettings settings, IEnumerable<PartType> partTypes, string pageToken, int resultsPerPage)
        {
            return Format(settings, partTypes, pageToken, resultsPerPage);
        }
    }
}