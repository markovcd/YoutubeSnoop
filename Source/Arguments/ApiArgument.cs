namespace YoutubeSnoop.Arguments
{
    public class ApiArgument
    {
        public virtual string ArgumentName { get; }
        public virtual string ArgumentValue { get; }

        public ApiArgument(string argumentName, string argumentValue)
        {
            ArgumentName = argumentName;
            ArgumentValue = argumentValue;
        }

        protected ApiArgument(string argumentName)
        {
            ArgumentName = argumentName;
        }

        public override string ToString()
        {
            if (string.IsNullOrEmpty(ArgumentValue)) return string.Empty;
            return $"{ArgumentName}={ArgumentValue}";
        }
    }

    public class ApiArgument<T> : ApiArgument
    {
        public T Value { get; }

        public ApiArgument(string argumentName, T argumentValue) : base(argumentName, argumentValue?.ToString())
        {
            Value = argumentValue;
        }
    }
}