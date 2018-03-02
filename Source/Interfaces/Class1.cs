using System;
using System.Collections.Generic;
using System.Text;

namespace YoutubeSnoop.Interfaces
{
    public interface IYoutubeItem<TSnippet>
    {
        TSnippet Snippet { get; }
    }

    public interface IYoutubeCollection<TItem, TSnippet>
        where TItem : IYoutubeItem<TSnippet>
    {
        IList<TItem> Items { get; }
    }
}
