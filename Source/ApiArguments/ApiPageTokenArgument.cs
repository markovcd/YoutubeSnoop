namespace YoutubeSnoop.ApiArguments
{
    public class ApiPageTokenArgument : ApiArgument
    {
        private const string _argumentName = "pageToken";

        public ApiPageTokenArgument(string pageToken) : base(_argumentName, pageToken) { }

        public virtual string PageToken => ArgumentValue;
    }
}
