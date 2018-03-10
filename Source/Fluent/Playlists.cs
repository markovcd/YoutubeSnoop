using System.Collections.Generic;
using System.Linq;
using YoutubeSnoop.Api.Entities.Playlists;
using YoutubeSnoop.Api.Settings;
using YoutubeSnoop.Enums;

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

        public static YoutubePlaylists RequestId(this YoutubePlaylists playlists, params string[] ids)
        {
            var request = playlists.Request.Clone();
            if (request.Settings.Id == null) request.Settings.Id = "";
            
            request.Settings.Id = request.Settings
                                         .Id
                                         .Split(',')
                                         .Concat(ids)
                                         .Distinct()
                                         .ToArray()
                                         .Aggregate((s1, s2) => $"{s1},{s2}");

            return new YoutubePlaylists(request);
        }

        public static YoutubePlaylists RequestPart(this YoutubePlaylists playlists, PartType partType)
        {
            var request = playlists.Request.RequestPart(partType);
            return new YoutubePlaylists(request);
        }

        public static YoutubePlaylists RequestContentDetails(this YoutubePlaylists playlists)
        {
            return playlists.RequestPart(PartType.ContentDetails);
        }       

        public static YoutubePlaylists RequestStatus(this YoutubePlaylists playlists)
        {
            return playlists.RequestPart(PartType.Status);
        }

        public static YoutubePlaylists RequestLocalizations(this YoutubePlaylists playlists)
        {
            return playlists.RequestPart(PartType.Localizations);
        }

        public static YoutubePlaylists RequestPlayer(this YoutubePlaylists playlists)
        {
            return playlists.RequestPart(PartType.Player);
        }

        public static YoutubePlaylists RequestSnippet(this YoutubePlaylists playlists)
        {
            return playlists.RequestPart(PartType.Snippet);
        }

        public static YoutubePlaylists RequestAllParts(this YoutubePlaylists playlists)
        {
            return playlists.RequestContentDetails()
                            .RequestStatus()
                            .RequestLocalizations()
                            .RequestPlayer()
                            .RequestSnippet();
        }

        public static YoutubePlaylist RequestPart(this YoutubePlaylist playlist, PartType partType)
        {
            var request = playlist.Request.RequestPart(partType);
            return new YoutubePlaylist(request);
        }

        public static YoutubePlaylist RequestContentDetails(this YoutubePlaylist playlist)
        {
            return playlist.RequestPart(PartType.ContentDetails);
        }

        public static YoutubePlaylist RequestStatus(this YoutubePlaylist playlist)
        {
            return playlist.RequestPart(PartType.Status);
        }

        public static YoutubePlaylist RequestLocalizations(this YoutubePlaylist playlist)
        {
            return playlist.RequestPart(PartType.Localizations);
        }

        public static YoutubePlaylist RequestPlayer(this YoutubePlaylist playlist)
        {
            return playlist.RequestPart(PartType.Player);
        }

        public static YoutubePlaylist RequestSnippet(this YoutubePlaylist playlist)
        {
            return playlist.RequestPart(PartType.Snippet);
        }

        public static YoutubePlaylist RequestAllParts(this YoutubePlaylist playlist)
        {
            return playlist.RequestContentDetails()
                           .RequestStatus()
                           .RequestLocalizations()
                           .RequestPlayer()
                           .RequestSnippet();
        }

        public static YoutubePlaylistItems Items(this YoutubePlaylist playlist)
        {
            return PlaylistItems(playlist.Id);
        }

        public static YoutubePlaylists ChannelId(this YoutubePlaylists playlists, string id)
        {
            var request = playlists.Request.Clone();
            request.Settings.ChannelId = id;
            return new YoutubePlaylists(request);
        }
    }
}
