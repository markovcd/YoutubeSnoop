using System.Collections.Generic;

namespace YoutubeSnoop.Interfaces
{
    public interface IYoutubeCollection<TItem> : IEnumerable<TItem>
         where TItem : IYoutubeItem
    {
    }
}