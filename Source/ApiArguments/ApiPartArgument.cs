using System.Collections.Generic;
using System.Linq;

namespace YoutubeSnoop.ApiArguments
{
    public enum PartType
    {
        Snippet
    }

    public class ApiPartArgument : ApiArgument
    {
        private const string _argumentName = "part";

        public ApiPartArgument(IEnumerable<PartType> partTypes) : base(_argumentName)
        {
            PartTypes = partTypes;
        }

        public ApiPartArgument(PartType partType) : this(new[] { partType }) { }

        public override string ArgumentValue => PartTypes.Aggregate("", (s, p) => $"{s},{p}").Substring(1);
        public virtual IEnumerable<PartType> PartTypes { get; }
    }
}
