using System.Collections.Generic;
using System.Linq;
using YoutubeSnoop.Enums;
using YoutubeSnoop.Interfaces;

namespace YoutubeSnoop
{
    public class ApiRequestSingle<TItem, TSettings> : ApiRequest<TItem, TSettings>
        where TItem : IResponse
        where TSettings : IApiRequestSettings
    {
        public TItem Item { get; }

        public ApiRequestSingle(TSettings settings, IEnumerable<PartType> partTypes) : base(settings, partTypes)
        {
            Item = Items.FirstOrDefault();
        }

        public ApiRequestSingle(TSettings settings, PartType partType) : this(settings, new[] { partType }) { }

        public ApiRequestSingle(TSettings settings) : this(settings, null) { }
    }
}