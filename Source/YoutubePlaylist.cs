using System.Collections;
using System.Collections.Generic;
using YoutubeSnoop.ApiRequests;
using YoutubeSnoop.ApiRequests.Settings;

namespace YoutubeSnoop
{
    public class YoutubePlaylist : IEnumerable<YoutubeVideo>
    {
        public string Id { get; }
        public int Buffer { get; }

        public YoutubePlaylist(string id, int buffer = 20)
        {
            Id = id;
            Buffer = buffer;
        }

        public IEnumerator<YoutubeVideo> GetEnumerator()
        {
            return new YoutubePlaylistEnumerator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    class YoutubePlaylistEnumerator : IEnumerator<YoutubeVideo>
    {
        private readonly YoutubePlaylist _parent;

        private int _index;
        private Entities.Response _playlist;

        public YoutubeVideo Current { get; private set; }
        object IEnumerator.Current => Current;

        public YoutubePlaylistEnumerator(YoutubePlaylist parent)
        {
            _parent = parent;
            Reset();
        }

        private Entities.Response GetPlaylist(string pageToken = "")
        {
            var settings = new PlaylistApiRequestSettings
            {
                Id = _parent.Id,
                PageToken = pageToken,
                MaxResults = _parent.Buffer
            };
            
            return settings.Deserialize();
        }

        private void UpdateCurrent()
        {
            Current = new YoutubeVideo(_playlist.Items[_index].Snippet);
        }

        public bool MoveNext()
        {
            _index++;
            if (_index == _playlist.Items.Count)
            {
                _index = 0;
                if (string.IsNullOrWhiteSpace(_playlist.NextPageToken)) return false;
                _playlist = GetPlaylist(_playlist.NextPageToken);
            }

            UpdateCurrent();

            return true;
        }

        public void Reset()
        {
            _index = 0;
            _playlist = GetPlaylist();
            UpdateCurrent();
        }

        public void Dispose() { }
    }
}
