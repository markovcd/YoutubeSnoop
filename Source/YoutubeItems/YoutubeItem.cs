using YoutubeSnoop.Interfaces;

namespace YoutubeSnoop
{
    public abstract class YoutubeItem<TResponse, TSettings>
        where TResponse : IResponse
        where TSettings : IApiRequestSettings
    {

        protected bool PropertiesSet { get; set; }

        public IApiRequest<TResponse, TSettings> Request { get; }


        protected YoutubeItem(IApiRequest<TResponse, TSettings> request)
        {
            Request = request;
            Request.FirstItemDownloaded += (s, e) => SetProperties(Request.FirstItem);
        }

        protected YoutubeItem() { }

        protected abstract void SetProperties(TResponse response);

        protected T S<T>(T field)
        {
            if (!PropertiesSet) SetProperties(Request.FirstItem);
            return field;
        }

    }
}
