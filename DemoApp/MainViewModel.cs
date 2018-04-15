using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using YoutubeSnoop;
using YoutubeSnoop.Fluent;

namespace DemoApp
{
    internal class MainViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<IYoutubeItem> Items { get; } = new ObservableCollection<IYoutubeItem>();

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

        private bool _isIdle = true;
        public bool IsIdle
        {
            get => _isIdle;
            set => SetProperty(ref _isIdle, value);
        }

        public ICommand OpenUrlCommand => new RelayCommand<string>(OpenUrl, s => !string.IsNullOrEmpty(s));
        public ICommand SearchCommand => new RelayCommand(Search, () => !string.IsNullOrEmpty(SearchQuery) && IsIdle);
        public ICommand ShowCommentCommentThreadCommand => new RelayCommand<YoutubeComment>(ShowCommentCommentThread, c => c != null);
        public ICommand ShowCommentVideoCommand => new RelayCommand<YoutubeComment>(ShowCommentVideo, c => c != null);
        public ICommand ShowCommentParentCommand => new RelayCommand<YoutubeComment>(ShowCommentParent, c => c?.ParentId != null);                
        public ICommand ShowCommentThreadDetailsCommand => new RelayCommand<YoutubeCommentThread>(ShowCommentThreadDetails, c => c != null);
        public ICommand ShowCommentThreadRepliesCommand => new RelayCommand<YoutubeCommentThread>(ShowCommentThreadReplies, c => c?.TotalReplyCount != 0);
        public ICommand ShowCommentThreadVideoCommand => new RelayCommand<YoutubeCommentThread>(ShowCommentThreadVideo, c => c != null);
        public ICommand ShowChannelUploadsCommand => new RelayCommand<YoutubeChannel>(ShowChannelUploads, c => c?.UploadsCount != 0);
        public ICommand ShowChannelPlaylistsCommand => new RelayCommand<YoutubeChannel>(ShowChannelPlaylists, c => c != null);
        public ICommand ShowSearchResultDetailsCommand => new RelayCommand<YoutubeSearchResult>(ShowSearchResultDetails, s => s != null);
        public ICommand ShowPlaylistItemDetailsCommand => new RelayCommand<YoutubePlaylistItem>(ShowPlaylistItemDetails, p => p != null);
        public ICommand ShowPlaylistItemsCommand => new RelayCommand<YoutubePlaylist>(ShowPlaylistItems, p => p != null && IsIdle);
        public ICommand ShowRelatedVideosCommand => new RelayCommand<YoutubeVideo>(ShowRelatedVideos, v => v != null && IsIdle);
        public ICommand ShowVideoCommentThreadsCommand => new RelayCommand<YoutubeVideo>(ShowVideoCommentThreads, v => IsIdle && v?.CommentCount != 0);
        public ICommand ShowVideoChannelCommand => new RelayCommand<YoutubeVideo>(ShowVideoChannel, v => !string.IsNullOrEmpty(v?.ChannelId));

        public MainViewModel()
        {
            Youtube.ResultsPerPage = 50;
        }

        private void OpenUrl(string url)
        {
            Process.Start(new ProcessStartInfo(url));
        }

        private void Search()
        {
            var searchQuery = SearchQuery;
            FillList(Youtube.Search(searchQuery).TakePages(2));
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
            FillList(channel.Uploads().RequestAllParts().TakePage());
        }

        private void ShowChannelPlaylists(YoutubeChannel channel)
        {
            FillList(channel.Playlists().RequestAllParts().TakePage());
        }

        private void ShowPlaylistItems(YoutubePlaylist playlist)
        {            
            FillList(playlist.Items().RequestAllParts().TakePage());
        }

        private void ShowPlaylistItemDetails(YoutubePlaylistItem playlistItem)
        {
            SelectedItem = playlistItem.Details().RequestAllParts();
        }

        private void ShowRelatedVideos(YoutubeVideo video)
        {
            FillList(video.RelatedVideos().TakePage());
        }

        private void ShowSearchResultDetails(YoutubeSearchResult searchResult)
        {        
            var details = searchResult.Details();

            if (details is YoutubeVideo) details = (details as YoutubeVideo)?.RequestAllParts();
            if (details is YoutubePlaylist) details = (details as YoutubePlaylist)?.RequestAllParts();
            if (details is YoutubeChannel) details = (details as YoutubeChannel)?.RequestAllParts();

            SelectedItem = details;
        }

        private void ShowVideoCommentThreads(YoutubeVideo video)
        {
            FillList(video.Comments().RequestAllParts().TakePage());
        }

        private void ShowVideoChannel(YoutubeVideo video)
        {
            SelectedItem = video.Channel().RequestAllParts();
        }
#pragma warning disable RECS0165
        private async void FillList(IEnumerable<IYoutubeItem> items)
#pragma warning restore RECS0165
        {
            Items.Clear();
            SearchQuery = null;
            IsIdle = false;

            foreach (var item in items)
            {
                await App.Current.Dispatcher.BeginInvoke((Action)(() => Items.Add(item)));
            }

            IsIdle = true;
        }

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        protected bool SetProperty<T>(ref T storage, T value, [CallerMemberName] string propertyName = null)
        {
            if (Equals(storage, value)) return false;

            storage = value;
            OnPropertyChanged(propertyName);

            return true;
        }

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}
