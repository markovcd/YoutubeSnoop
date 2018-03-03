using System.Collections.Generic;
using System.Linq;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Arguments
{
    public class ApiPartArgument : ApiArgument
    {
        private const string _argumentName = "part";

        public ApiPartArgument(IEnumerable<PartType> partTypes) : base(_argumentName, partTypes.Select(pt => pt.ToCamelCase()).Aggregate((s, p) => $"{s},{p}"))
        {
            PartTypes = partTypes;
        }

        public ApiPartArgument(PartType partType)
            : this(new[] { partType }) { }

        public IEnumerable<PartType> PartTypes { get; }
    }
}