using System.Collections;
using System.Collections.Generic;

namespace YoutubePlaylistSnoop
{
    class YoutubePlaylistEnumerator : IEnumerator<YoutubeVideoInfo>
    {
        private readonly YoutubePlaylist _parent;

        private int _index;
        private Entities.Playlist _playlist;

        public YoutubeVideoInfo Current { get; private set; }
        object IEnumerator.Current => Current;

        public YoutubePlaylistEnumerator(YoutubePlaylist parent)
        {
            _parent = parent;
            Reset();
        }

        private Entities.Playlist GetPlaylist(string pageToken = "")
        {
            return PlaylistDeserializer.Deserialize(_parent.PlaylistId, pageToken, _parent.Buffer);
        }

        private void UpdateCurrent()
        {
            Current = new YoutubeVideoInfo(_playlist.Items[_index].Snippet);
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
