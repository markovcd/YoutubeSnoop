namespace YoutubeSnoop.ApiArguments
{
    public class ApiIdArgument : ApiArgument
    {
        private const string _argumentName = "id";

        public ApiIdArgument(string id) : base(_argumentName, id) { }

        public virtual string Id => ArgumentValue;
    }
}
