using System.Collections.Generic;
using System.Linq;
using YoutubeSnoop.Interfaces;

namespace YoutubeSnoop
{
    public class YoutubeCollectionRequest<TSettings, TItem>
         where TItem : IResponse
         where TSettings : IApiRequestSettings
    {
        public TSettings Settings { get; }
        protected IList<TItem> Responses { get; }

        protected YoutubeCollectionRequest(TSettings settings)
        {
            Settings = settings;
            var api = new ApiRequest<TItem, TSettings>(settings);
            Responses = api.TotalItems.ToList(); // TODO: async
        }
    }
}