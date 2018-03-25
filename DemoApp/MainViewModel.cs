using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

        public ICommand SearchCommand => new RelayCommand(Search, CanSearch);
        public ICommand ShowSearchResultDetailsCommand => new RelayCommand<YoutubeSearchResult>(ShowSearchResultDetails, CanShowSearchResultDetails);
        public ICommand ShowPlaylistItemsCommand => new RelayCommand<YoutubePlaylist>(ShowPlaylistItems, CanShowPlaylistItemsCommand);

        private bool CanShowPlaylistItemsCommand(YoutubePlaylist playlist)
        {
            return playlist != null && !IsSearching;
        }

        private void ShowPlaylistItems(YoutubePlaylist playlist)
        {            
            Items.Clear();
            SearchQuery = null;
            IsSearching = true;

            Task.Run(() =>
            {
                foreach (var playlistItem in playlist.Items().RequestAllParts())
                {
                    App.Current.Dispatcher.BeginInvoke((Action)(() => Items.Add(playlistItem)));
                }

                App.Current.Dispatcher.BeginInvoke((Action)(() => IsSearching = false));
            });
        }

        private bool CanShowSearchResultDetails(YoutubeSearchResult searchResult)
        {
            return searchResult != null;
        }

        private void ShowSearchResultDetails(YoutubeSearchResult searchResult)
        {        
            var details = searchResult.Details();

            if (details is YoutubeVideo) details = (details as YoutubeVideo).RequestAllParts();
            if (details is YoutubePlaylist) details = (details as YoutubePlaylist).RequestAllParts();
            if (details is YoutubeChannel) details = (details as YoutubeChannel).RequestAllParts();

            SelectedItem = details;
        }

        private bool CanSearch()
        {
            return !string.IsNullOrEmpty(SearchQuery) && !IsSearching;
        }

        private void Search()
        {
            Items.Clear();
            var searchQuery = SearchQuery;
            SearchQuery = null;
            IsSearching = true;

            Task.Run(() =>
            {
                foreach (var searchResult in Youtube.Search(searchQuery).Take(50))
                {
                    App.Current.Dispatcher.BeginInvoke((Action)(() => Items.Add(searchResult)));              
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
