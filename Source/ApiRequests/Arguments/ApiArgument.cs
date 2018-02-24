namespace YoutubeSnoop.ApiRequests.Arguments
{
    public class ApiArgument
    {
        public virtual string ArgumentName { get; }
        public virtual string ArgumentValue { get; }

        protected ApiArgument(string argumentName, string argumentValue)
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
}
