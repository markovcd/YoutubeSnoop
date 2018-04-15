using System.Collections.Generic;

namespace YoutubeSnoop
{
    public interface IYoutubeCollection<TItem> : IEnumerable<TItem>
         where TItem : IYoutubeItem
    {
        int? ResultsPerPage { get; }
        int? TotalResults { get; }
    }
}