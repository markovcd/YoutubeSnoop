using System.Collections.Generic;
using YoutubeSnoop.Interfaces;

namespace YoutubeSnoop
{
    public class YoutubeCollectionRequest<TSettings, TItem>
         where TItem : IResponse
         where TSettings : IApiRequestSettings
    {
        public TSettings Settings { get; }
        protected IEnumerable<TItem> Responses { get; }
        public int ResultsPerPage { get; }
        public int TotalItems { get; private set; } // TODO

        protected YoutubeCollectionRequest(TSettings settings, int resultsPerPage = 20)
        {
            Settings = settings;
            var api = new ApiRequest<TItem, TSettings>(settings, null, resultsPerPage);

            Responses = api.TotalItems;
            ResultsPerPage = resultsPerPage;
        }
    }
}