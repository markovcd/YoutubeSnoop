using YoutubeSnoop.Api;
using YoutubeSnoop.Api.Entities;
using YoutubeSnoop.Api.Settings;

namespace YoutubeSnoop
{
    public abstract class YoutubeItem<TResponse, TSettings>
        where TResponse : IResponse
        where TSettings : IApiRequestSettings
    {
        private bool _propertiesSet;

        public IApiRequest<TResponse, TSettings> Request { get; }

        protected YoutubeItem(IApiRequest<TResponse, TSettings> request)
        {
            Request = request;
        }

        protected YoutubeItem(TResponse response)
        {
            #pragma warning disable RECS0021 // Don't tell me how to live my life, fucker
            SetProperties(response);
            #pragma warning restore RECS0021

            _propertiesSet = true;
        }

        protected abstract void SetProperties(TResponse response);

        protected T Set<T>(ref T field)
        {
            if (!_propertiesSet) SetProperties(Request.FirstItem);
            _propertiesSet = true;
            return field;
        }

    }
}
