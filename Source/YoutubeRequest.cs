using System.Linq;
using YoutubeSnoop.Interfaces;

namespace YoutubeSnoop
{
    public class YoutubeRequest<TSettings, TItem> : YoutubeCollectionRequest<TSettings, TItem>
        where TItem : IResponse
        where TSettings : IApiRequestSettings
    {
        public TItem Response { get; }

        protected YoutubeRequest(TSettings settings) : base(settings)
        {
            Response = Responses.FirstOrDefault();
        }
    }
}
