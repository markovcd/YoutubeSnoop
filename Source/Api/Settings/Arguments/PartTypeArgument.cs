using System.Collections.Generic;
using System.Linq;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Api.Arguments
{
    public class PartTypeArgument : Argument
    {
        private const string _argumentName = "part";

        public PartTypeArgument(IEnumerable<PartType> partTypes) : base(_argumentName, partTypes.Select(pt => pt.ToCamelCase()).Aggregate())
        {
            PartTypes = partTypes;
        }

        public PartTypeArgument(PartType partType)
            : this(new[] { partType }) { }

        public IEnumerable<PartType> PartTypes { get; }
    }
}