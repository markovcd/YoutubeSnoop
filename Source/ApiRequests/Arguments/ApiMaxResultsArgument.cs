namespace YoutubeSnoop.ApiRequests.Arguments
{
    public class ApiMaxResultsArgument : ApiArgument
    {
        private const string _argumentName = "maxResults";

        public ApiMaxResultsArgument(int maxResults) : base(_argumentName)
        {
            MaxResults = maxResults;
        }

        public override string ArgumentValue => MaxResults.ToString();
        public virtual int MaxResults { get; }
    }
}
