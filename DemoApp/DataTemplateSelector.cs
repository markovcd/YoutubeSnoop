using System.Windows;
using System.Windows.Controls;
using YoutubeSnoop;

namespace DemoApp
{
    class YoutubeTemplateSelector : DataTemplateSelector
    {
        public DataTemplate ActivityTemplate { get; set; }
        public DataTemplate ChannelTemplate { get; set; }
        public DataTemplate CommentTemplate { get; set; }
        public DataTemplate CommentThreadTemplate { get; set; }
        public DataTemplate PlaylistTemplate { get; set; }
        public DataTemplate PlaylistItemTemplate { get; set; }
        public DataTemplate SearchResultTemplate { get; set; }
        public DataTemplate VideoTemplate { get; set; }

        public DataTemplate DefaultTemplate { get; set; }       

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            if (item is YoutubeActivity) return ActivityTemplate;
            if (item is YoutubeComment) return CommentTemplate;
            if (item is YoutubeCommentThread) return CommentThreadTemplate;
            if (item is YoutubeVideo) return VideoTemplate;
            if (item is YoutubeChannel) return ChannelTemplate;
            if (item is YoutubePlaylist) return PlaylistTemplate;
            if (item is YoutubePlaylistItem) return PlaylistItemTemplate;
            if (item is YoutubeSearchResult) return SearchResultTemplate;

            return DefaultTemplate;
        }
    }
}
