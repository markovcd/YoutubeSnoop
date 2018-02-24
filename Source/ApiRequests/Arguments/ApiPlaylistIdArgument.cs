namespace YoutubeSnoop.ApiRequests.Arguments
{
    public class ApiPlaylistIdArgument : ApiArgument
    {
        private const string _argumentName = "playlistId";

        public ApiPlaylistIdArgument(string id) : base(_argumentName, id) { }

        public virtual string Id => ArgumentValue;
    }
}
