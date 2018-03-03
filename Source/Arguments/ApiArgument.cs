using System;

namespace YoutubeSnoop.Arguments
{
    public class ApiArgument
    {
        public string ArgumentName { get; }
        public string ArgumentValue { get; }

        public ApiArgument(string argumentName, string argumentValue)
        {
            if (string.IsNullOrWhiteSpace(argumentName)) throw new ArgumentNullException(nameof(argumentName));

            ArgumentName = argumentName;
            ArgumentValue = argumentValue;
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

        public ApiArgument(string argumentName, T argumentValue) : base(argumentName, argumentValue?.ToString().ToCamelCase())
        {
            Value = argumentValue;
        }
    }
}