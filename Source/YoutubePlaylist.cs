//using YoutubeSnoop.Settings;
//using YoutubeSnoop.Entities;
//using System.Collections.Generic;
//using System.Linq;
//using YoutubeSnoop.Enums;
//using YoutubeSnoop.Interfaces;
//using System;
//using YoutubeSnoop.Entities.PlaylistItems;

//namespace YoutubeSnoop
//{
//    public class YoutubePlaylistItems : YoutubeSnippetsBase<PlaylistItemsApiRequestSettings, Snippet, PlaylistItem>
//    {
//        private const string _youtubeUrl = @"https://www.youtube.com/playlist?list={0}";
        
//        public YoutubePlaylistItems(string playlistId) : this(new PlaylistItemsApiRequestSettings {  PlaylistId = playlistId }) { }

//        public YoutubePlaylistItems(PlaylistItemsApiRequestSettings settings) : base(settings)
//        {
//            PlaylistId = settings.PlaylistId;
//            Url = string.Format(_youtubeUrl, PlaylistId);
//            Resources = Snippets.Select(s => s.ResourceId);

//        }

//        public string Url { get; }
//        public string PlaylistId { get; }

//        public IEnumerable<IYoutubeResource> Resources { get; }
//    }

//    public static class YoutubeResourceFactory
//    {
//        public IYoutubeResource Create(IResource resourceId)
//        {
//            switch (resourceId.Kind)
//            {
//                case ResourceKind.Video: return new YoutubeVideo(((VideoResourceId)resourceId).VideoId);
//                default: throw new InvalidOperationException();
//            }
//        }
//    }
//}