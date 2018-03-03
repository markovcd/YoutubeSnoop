using System.Collections.Generic;

namespace YoutubeSnoop.Interfaces
{
    public interface IYoutubeCollection<TItem>
         where TItem : IYoutubeItem
    {
        IEnumerable<TItem> Items { get; }
    }
}