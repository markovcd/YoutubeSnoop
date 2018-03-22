namespace YoutubeSnoop.Api.Converters
{
    public interface IApiRequestConverter<T> : IApiRequestConverter
    {
        string Convert(T value);
    }

    public interface IApiRequestConverter
    {
        string Convert(object value);
    }
}