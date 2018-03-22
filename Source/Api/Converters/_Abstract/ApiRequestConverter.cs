namespace YoutubeSnoop.Api.Converters
{
    /// <summary>
    /// Override this class to implement custom conversion of API request arguments. Class can then be used as argument for ApiRequestConverterAttribute.
    /// </summary>
    public abstract class ApiRequestConverter<T> : IApiRequestConverter<T>
    {
        public abstract string Convert(T value);

        public string Convert(object value)
        {
            return Convert((T)value);
        }
    }
}
