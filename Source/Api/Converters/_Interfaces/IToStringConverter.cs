namespace YoutubeSnoop.Api.Converters
{
    public interface IToStringConverter<T> : IToStringConverter
    {
        string Convert(T value);
    }

    public interface IToStringConverter
    {
        string Convert(object value);
    }
}