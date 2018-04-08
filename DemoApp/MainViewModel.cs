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
    internal class MainViewModel : BindableBase
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

        public ICommand OpenUrlCommand => new RelayCommand<string>(OpenUrl, s => !string.IsNullOrEmpty(s));
        public ICommand SearchCommand => new RelayCommand(Search, () => !string.IsNullOrEmpty(SearchQuery) && !IsSearching);
        public ICommand ShowCommentCommentThreadCommand => new RelayCommand<YoutubeComment>(ShowCommentCommentThread, c => c != null);
        public ICommand ShowCommentVideoCommand => new RelayCommand<YoutubeComment>(ShowCommentVideo, c => c != null);
        public ICommand ShowCommentParentCommand => new RelayCommand<YoutubeComment>(ShowCommentParent, c => c?.ParentId != null);                
        public ICommand ShowCommentThreadDetailsCommand => new RelayCommand<YoutubeCommentThread>(ShowCommentThreadDetails, c => c != null);
        public ICommand ShowCommentThreadRepliesCommand => new RelayCommand<YoutubeCommentThread>(ShowCommentThreadReplies, c => c?.TotalReplyCount != 0);
        public ICommand ShowCommentThreadVideoCommand => new RelayCommand<YoutubeCommentThread>(ShowCommentThreadVideo, c => c != null);
        public ICommand ShowChannelUploadsCommand => new RelayCommand<YoutubeChannel>(ShowChannelUploads, c => c?.UploadsCount != 0);
        public ICommand ShowSearchResultDetailsCommand => new RelayCommand<YoutubeSearchResult>(ShowSearchResultDetails, s => s != null);
        public ICommand ShowPlaylistItemDetailsCommand => new RelayCommand<YoutubePlaylistItem>(ShowPlaylistItemDetails, p => p != null);
        public ICommand ShowPlaylistItemsCommand => new RelayCommand<YoutubePlaylist>(ShowPlaylistItems, p => p != null && !IsSearching);
        public ICommand ShowRelatedVideosCommand => new RelayCommand<YoutubeVideo>(ShowRelatedVideos, v => v != null && !IsSearching);
        public ICommand ShowVideoCommentThreadsCommand => new RelayCommand<YoutubeVideo>(ShowVideoCommentThreads, v => !IsSearching && v?.CommentCount != 0);
        public ICommand ShowVideoChannelCommand => new RelayCommand<YoutubeVideo>(ShowVideoChannel, v => !string.IsNullOrEmpty(v?.ChannelId));

        private void OpenUrl(string url)
        {
            Process.Start(new ProcessStartInfo(url));
        }

        private void Search()
        {
            var searchQuery = SearchQuery;
            FillList(Youtube.Search(searchQuery).Take(50));
        }

        private void ShowCommentCommentThread(YoutubeComment comment)
        {
            SelectedItem = comment.CommentThread();
        }

        private void ShowCommentVideo(YoutubeComment comment)
        {
            SelectedItem = comment.Video();
        }

        private void ShowCommentParent(YoutubeComment comment)
        {
            SelectedItem = comment.Parent();
        }

        private void ShowCommentThreadDetails(YoutubeCommentThread commentThread)
        {
            SelectedItem = commentThread.TopLevelComment;
        }

        private void ShowCommentThreadReplies(YoutubeCommentThread commentThread)
        {
            FillList(commentThread.Replies);
        }

        private void ShowCommentThreadVideo(YoutubeCommentThread commentThread)
        {
            SelectedItem = commentThread.Video();
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
