using System.Collections.Generic;

namespace YoutubeSnoop.Interfaces
{
    public interface IYoutubeCollection<TItem>
         where TItem : IYoutubeItem
    {
        IList<TItem> Items { get; }
    }
}
