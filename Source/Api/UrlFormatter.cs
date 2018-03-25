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
       
        private const bool _prettyPrint = false;
        private const string _prettyPrintName = "prettyPrint";
      
        private static readonly Argument _prettyPrintArgument = new Argument<bool>(_prettyPrintName, _prettyPrint);

        public static string Format(ISettings settings, IEnumerable<PartType> partTypes, string pageToken, int resultsPerPage, string key)
        {
            var arguments = settings.GetArguments().ToList();
            arguments.Add(new PartTypeArgument(partTypes));
            arguments.Add(new Argument(nameof(pageToken), pageToken));
            arguments.Add(new Argument<int>(nameof(resultsPerPage), resultsPerPage));
            arguments.Add(new Argument(nameof(key), key));
            arguments.Add(_prettyPrintArgument);

            var argumentString = arguments.Select(a => a.ToString())
                                          .Where(s => !string.IsNullOrEmpty(s))
                                          .Aggregate('&');

            return string.Format(_apiUrl, settings.RequestType.ToCamelCase(), argumentString);
        }

        string IUrlFormatter.Format(ISettings settings, IEnumerable<PartType> partTypes, string pageToken, int resultsPerPage, string key)
        {
            return Format(settings, partTypes, pageToken, resultsPerPage, key);
        }
    }
}