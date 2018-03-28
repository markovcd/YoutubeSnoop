using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using YoutubeSnoop;
using YoutubeSnoop.Fluent;

namespace DemoApp
{
    class MainViewModel : BindableBase
    {
        public ObservableCollection<IYoutubeItem> Items { get; }

        private IYoutubeItem _selectedItem;
        public IYoutubeItem SelectedItem
        {
            get => _selectedItem;
            set => SetProperty(ref _selectedItem, value);
        }

        private string _searchQuery;
        public string SearchQuery
        {
            get => _searchQuery;
            set => SetProperty(ref _searchQuery, value);
        }

        private bool _isSearching;
        public bool IsSearching
        {
            get => _isSearching;
            set => SetProperty(ref _isSearching, value);
        }

        public ICommand OpenUrlCommand => new RelayCommand<string>(OpenUrl, CanOpenUrl);
        public ICommand SearchCommand => new RelayCommand(Search, CanSearch);
        public ICommand ShowCommentParentCommand => new RelayCommand<YoutubeComment>(ShowCommentParent, CanShowCommentParent);                
        public ICommand ShowCommentThreadDetailsCommand => new RelayCommand<YoutubeCommentThread>(ShowCommentThreadDetails, CanShowCommentThreadDetails);
        public ICommand ShowCommentThreadRepliesCommand => new RelayCommand<YoutubeCommentThread>(ShowCommentThreadReplies, CanShowCommentThreadReplies);
        public ICommand ShowChannelUploadsCommand => new RelayCommand<YoutubeChannel>(ShowChannelUploads, CanShowChannelUploads);
        public ICommand ShowSearchResultDetailsCommand => new RelayCommand<YoutubeSearchResult>(ShowSearchResultDetails, CanShowSearchResultDetails);
        public ICommand ShowPlaylistItemDetailsCommand => new RelayCommand<YoutubePlaylistItem>(ShowPlaylistItemDetails, CanShowPlaylistItemDetails);
        public ICommand ShowPlaylistItemsCommand => new RelayCommand<YoutubePlaylist>(ShowPlaylistItems, CanShowPlaylistItems);
        public ICommand ShowRelatedVideosCommand => new RelayCommand<YoutubeVideo>(ShowRelatedVideos, CanShowRelatedVideos);
        public ICommand ShowVideoCommentThreadsCommand => new RelayCommand<YoutubeVideo>(ShowVideoCommentThreads, CanShowVideoCommentThreads);
        public ICommand ShowVideoChannelCommand => new RelayCommand<YoutubeVideo>(ShowVideoChannel, CanShowVideoChannel);

        private bool CanOpenUrl(string url)
        {
            return !string.IsNullOrEmpty(url); 
        }

        private bool CanSearch()
        {
            return !string.IsNullOrEmpty(SearchQuery) && !IsSearching;
        }

        private bool CanShowCommentParent(YoutubeComment comment)
        {
            return comment != null;
        }

        private bool CanShowCommentThreadDetails(YoutubeCommentThread commentThread)
        {
            return commentThread != null;
        }

        private bool CanShowCommentThreadReplies(YoutubeCommentThread commentThread)
        {
            return commentThread != null && commentThread.TotalReplyCount != 0;
        }

        private bool CanShowChannelUploads(YoutubeChannel channel)
        {
            return channel != null && channel.UploadsCount != 0;
        }

        private bool CanShowPlaylistItems(YoutubePlaylist playlist)
        {
            return playlist != null && !IsSearching;
        }

        private bool CanShowPlaylistItemDetails(YoutubePlaylistItem playlistItem)
        {
            return playlistItem != null;
        }

        private bool CanShowRelatedVideos(YoutubeVideo video)
        {
            return video != null && !IsSearching;
        }

        private bool CanShowSearchResultDetails(YoutubeSearchResult searchResult)
        {
            return searchResult != null;
        }

        private bool CanShowVideoCommentThreads(YoutubeVideo video)
        {
            return video != null && !IsSearching && video.CommentCount != 0;
        }

        private bool CanShowVideoChannel(YoutubeVideo video)
        {
            return video != null && !string.IsNullOrEmpty(video.ChannelId);
        }

        private void OpenUrl(string url)
        {
            Process.Start(new ProcessStartInfo(url));
        }

        private void Search()
        {
            var searchQuery = SearchQuery;
            FillList(Youtube.Search(searchQuery).Take(50));
        }

        private void ShowCommentParent(YoutubeComment comment)
        {
            SelectedItem = comment.Parent()?.RequestAllParts();
        }

        private void ShowCommentThreadDetails(YoutubeCommentThread commentThread)
        {
            SelectedItem = commentThread.TopLevelComment;
        }

        private void ShowCommentThreadReplies(YoutubeCommentThread commentThread)
        {
            FillList(commentThread.Replies);
        }

        private void ShowChannelUploads(YoutubeChannel channel)
        {
            FillList(channel.Uploads().RequestAllParts().Take(50));
        }

        private void ShowPlaylistItems(YoutubePlaylist playlist)
        {            
            FillList(playlist.Items().RequestAllParts().Take(50));
        }

        private void ShowPlaylistItemDetails(YoutubePlaylistItem playlistItem)
        {
            SelectedItem = playlistItem.Details().RequestAllParts();
        }

        private void ShowRelatedVideos(YoutubeVideo video)
        {
            FillList(video.RelatedVideos().Take(50));
        }

        private void ShowSearchResultDetails(YoutubeSearchResult searchResult)
        {        
            var details = searchResult.Details();

            if (details is YoutubeVideo) details = (details as YoutubeVideo).RequestAllParts();
            if (details is YoutubePlaylist) details = (details as YoutubePlaylist).RequestAllParts();
            if (details is YoutubeChannel) details = (details as YoutubeChannel).RequestAllParts();

            SelectedItem = details;
        }

        private void ShowVideoCommentThreads(YoutubeVideo video)
        {
            FillList(video.Comments().RequestAllParts().Take(50));
        }

        private void ShowVideoChannel(YoutubeVideo video)
        {
            SelectedItem = video.Channel().RequestAllParts();
        }

        private void FillList(IEnumerable<IYoutubeItem> items)
        {
            Items.Clear();
            SearchQuery = null;
            IsSearching = true;

            Task.Run(() =>
            {
                foreach (var item in items)
                {
                    App.Current.Dispatcher.BeginInvoke((Action)(() => Items.Add(item)));
                }

                App.Current.Dispatcher.BeginInvoke((Action)(() => IsSearching = false));
            });
        }

        public MainViewModel()
        {
            Items = new ObservableCollection<IYoutubeItem>();
        }
    }
}
