using YoutubeSnoop.Interfaces;

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
            SetProperties(response);
            _propertiesSet = true;
        }

        protected abstract void SetProperties(TResponse response);

        protected T S<T>(T field)
        {
            if (!_propertiesSet) SetProperties(Request.FirstItem);
            _propertiesSet = true;
            return field;
        }

    }
}
