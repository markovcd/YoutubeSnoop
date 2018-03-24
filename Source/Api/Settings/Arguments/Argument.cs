using System;

namespace YoutubeSnoop.Api.Arguments
{
    public class Argument
    {
        public string Name { get; }
        public string Value { get; }

        public Argument(string argumentName, string argumentValue)
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

    public class Argument<T> : Argument
    {
        public new T Value { get; }

        public Argument(string name, T value) : base(name, value?.ToString().ToCamelCase())
        {
            Value = value;
        }
    }
}