using System;

namespace YoutubeSnoop.Api.Settings.Arguments
{
    public class ApiArgument
    {
        public string Name { get; }
        public string Value { get; }

        public ApiArgument(string argumentName, string argumentValue)
        {
            if (string.IsNullOrWhiteSpace(argumentName)) throw new ArgumentNullException(nameof(argumentName));

            Name = argumentName;
            Value = argumentValue;
        }

        public override string ToString()
        {
            if (string.IsNullOrEmpty(Value)) return string.Empty;
            return $"{Name}={Value}";
        }
    }

    public class ApiArgument<T> : ApiArgument
    {
        public new T Value { get; }

        public ApiArgument(string name, T value) : base(name, value?.ToString().ToCamelCase())
        {
            Value = value;
        }
    }
}