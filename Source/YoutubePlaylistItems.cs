using YoutubeSnoop.Settings;
using YoutubeSnoop.Entities;
using System.Collections.Generic;
using System.Linq;
using YoutubeSnoop.Enums;
using YoutubeSnoop.Interfaces;
using System;
using YoutubeSnoop.Entities.PlaylistItems;

namespace YoutubeSnoop
{
    public class YoutubePlaylistItems : YoutubeCollectionRequest<PlaylistItemsApiRequestSettings, Snippet, PlaylistItem>, IYoutubeCollection<YoutubePlaylistItem, Snippet>
    {


        public YoutubePlaylistItems(PlaylistItemsApiRequestSettings settings) : base(settings)
        {
            
        }

        public IList<YoutubePlaylistItem> Items => throw new NotImplementedException();
    }

    
}