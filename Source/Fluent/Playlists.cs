﻿using System.Linq;
using YoutubeSnoop.Api.Settings;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Fluent
{
    public static partial class Youtube
    {
        public static YoutubePlaylists Playlists(PlaylistApiRequestSettings settings, params PartType[] partTypes)
        {
            return new YoutubePlaylists(settings, partTypes, ResultsPerPage);
        }

        public static YoutubePlaylist Playlist(PlaylistApiRequestSettings settings, params PartType[] partTypes)
        {
            return new YoutubePlaylist(settings, partTypes);
        }

        public static YoutubePlaylists Playlists(PlaylistApiRequestSettings settings = null)
        {
            return Playlists(settings, PartType.Snippet);
        }

        public static YoutubePlaylist Playlist(PlaylistApiRequestSettings settings = null)
        {
            return Playlist(settings, PartType.Snippet);
        }

        public static YoutubePlaylists Playlists(params string[] ids)
        {
            return Playlists(new PlaylistApiRequestSettings { Id = ids.Aggregate() });
        }

        public static YoutubePlaylist Playlist(string id)
        {
            return Playlist(new PlaylistApiRequestSettings { Id = id });
        }

        public static YoutubePlaylists RequestId(this YoutubePlaylists playlists, params string[] ids)
        {
            var settings = playlists.Settings.Clone();
            settings.Id = settings.Id.AddItems(ids);
            return Playlists(settings, playlists.PartTypes.ToArray());
        }

        public static YoutubePlaylists RequestPart(this YoutubePlaylists playlists, PartType partType)
        {
            return Playlists(playlists.Settings.Clone(), playlists.PartTypes.Append(partType).ToArray());
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
            return Playlist(playlist.Settings.Clone(), playlist.PartTypes.Append(partType).ToArray());
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

        public static YoutubePlaylists ForChannelId(this YoutubePlaylists playlists, string id)
        {
            var settings = playlists.Settings.Clone();
            settings.ChannelId = id;
            return Playlists(settings, playlists.PartTypes.ToArray());
        }
    }
}