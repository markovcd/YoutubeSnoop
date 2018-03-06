using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using YoutubeSnoop.Entities.Playlists;
using YoutubeSnoop.Enums;
using YoutubeSnoop.Settings;

namespace YoutubeSnoop.Fluent
{
    public static partial class Youtube
    {
        public static YoutubePlaylists Playlists(PlaylistApiRequestSettings settings, params PartType[] partTypes)
        {
            var request = DefaultRequest<Playlist, PlaylistApiRequestSettings>(settings, partTypes);
            return new YoutubePlaylists(request);
        }

        public static YoutubePlaylist Playlist(PlaylistApiRequestSettings settings, params PartType[] partTypes)
        {
            var request = DefaultRequest<Playlist, PlaylistApiRequestSettings>(settings, partTypes);
            return new YoutubePlaylist(request);
        }

        public static YoutubePlaylists Playlists(PlaylistApiRequestSettings settings = null)
        {
            return Playlists(settings ?? new PlaylistApiRequestSettings(), PartType.Snippet);
        }

        public static YoutubePlaylist Playlist(PlaylistApiRequestSettings settings = null)
        {
            return Playlist(settings ?? new PlaylistApiRequestSettings(), PartType.Snippet);
        }

        public static YoutubePlaylists Playlists(IEnumerable<string> ids)
        {
            return Playlists(new PlaylistApiRequestSettings { Id = ids.Aggregate((s1, s2) => $"{s1},{s2}") });
        }

        public static YoutubePlaylist Playlist(string id)
        {
            return Playlist(new PlaylistApiRequestSettings { Id = id });
        }

        public static YoutubePlaylists RequestId(this YoutubePlaylists playlists, string id)
        {
            var request = playlists.Request.Clone();
            if (request.Settings.Id == null) request.Settings.Id = "";
            var ids = request.Settings.Id.Split(',').Append(id).Distinct();
            request.Settings.Id = ids.Aggregate((s1, s2) => $"{s1},{s2}");
            return new YoutubePlaylists(request);
        }

        public static YoutubePlaylist RequestPart(this YoutubePlaylist playlist, PartType partType)
        {
            var request = playlist.Request.RequestPart(partType);
            return new YoutubePlaylist(request);
        }

        public static YoutubePlaylists RequestPart(this YoutubePlaylists playlists, PartType partType)
        {
            var request = playlists.Request.RequestPart(partType);
            return new YoutubePlaylists(request);
        }

        public static YoutubePlaylists ChannelId(this YoutubePlaylists playlists, string id)
        {
            var request = playlists.Request.Clone();
            request.Settings.ChannelId = id;
            return new YoutubePlaylists(request);
        }

        public static YoutubePlaylistItems Items(this YoutubePlaylist playlist)
        {
            return PlaylistItems(playlist.Id);
        }
    }
}
