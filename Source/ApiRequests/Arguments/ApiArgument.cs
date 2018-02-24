﻿namespace YoutubeSnoop.ApiRequests.Arguments
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
            return $"{ArgumentName}={ArgumentValue}";
        }
    }

    public class ApiArgument<T> : ApiArgument
    {
        public ApiArgument(string argumentName, T argumentValue) : base(argumentName, argumentValue.ToString()) { }
    }
}
