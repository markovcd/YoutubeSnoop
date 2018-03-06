using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using YoutubeSnoop.Entities.Channels;
using YoutubeSnoop.Entities.I18nLanguages;
using YoutubeSnoop.Entities.I18nRegions;
using YoutubeSnoop.Entities.PlaylistItems;
using YoutubeSnoop.Entities.Playlists;
using YoutubeSnoop.Entities.Search;
using YoutubeSnoop.Entities.Videos;
using YoutubeSnoop.Enums;
using YoutubeSnoop.Interfaces;
using YoutubeSnoop.Settings;

namespace YoutubeSnoop.Fluent
{
    public static partial class Youtube
    {
        

        #region Country & Language

        public static YoutubeLanguages Languages(string languageCode = "")
        {
            var settings = new I18nLanguageApiRequestSettings { Hl = languageCode };
            var request = DefaultRequest<I18nLanguage, I18nLanguageApiRequestSettings>(settings, new[] { PartType.Snippet });
            return new YoutubeLanguages(request);
        }

        public static YoutubeCountries Countries(string languageCode = "")
        {
            var settings = new I18nRegionApiRequestSettings { Hl = languageCode };
            var request = DefaultRequest<I18nRegion, I18nRegionApiRequestSettings>(settings, new[] { PartType.Snippet });
            return new YoutubeCountries(request);
        }

        #endregion

        #region Channel

        

        #endregion

        #region PlaylistItems

        

        #endregion

        #region Playlists

        public static YoutubePlaylist Playlist(PlaylistApiRequestSettings settings, params PartType[] partTypes)
        {
            var request = DefaultRequest<Playlist, PlaylistApiRequestSettings>(settings, partTypes);
            return new YoutubePlaylist(request);
        }

        public static YoutubePlaylist Playlist(PlaylistApiRequestSettings settings)
        {
            return Playlist(settings, PartType.Snippet);
        }

        public static YoutubePlaylists Playlists(PlaylistApiRequestSettings settings, params PartType[] partTypes)
        {
            var request = DefaultRequest<Playlist, PlaylistApiRequestSettings>(settings, partTypes);
            return new YoutubePlaylists(request);
        }

        public static YoutubePlaylists Playlists(PlaylistApiRequestSettings settings = null)
        {
            return Playlists(settings ?? new PlaylistApiRequestSettings(), PartType.Snippet);
        }

        public static YoutubePlaylist Playlist(string id)
        {
            return Playlist(new PlaylistApiRequestSettings { Id = id });
        }

        public static YoutubePlaylists Playlists(IEnumerable<string> ids)
        {
            return Playlists(new PlaylistApiRequestSettings { Id = ids.Aggregate((s1, s2) => $"{s1},{s2}") });
        }

        public static YoutubePlaylists ChannelId(this YoutubePlaylists playlists, string id)
        {
            var request = playlists.Request.Clone();
            request.Settings.ChannelId = id;
            return new YoutubePlaylists(request);
        }

        public static YoutubePlaylistItems Items(this YoutubePlaylist playlist)
        {
            return PlaylistItemsFromId(playlist.Id);
        }

        #endregion

        #region Search

        public static YoutubeSearch RequestPart(this YoutubeSearch search, PartType partType)
        {
            var request = search.Request.Clone(search.Request.PartTypes.Concat(new[] { partType }).Distinct());
            return new YoutubeSearch(request);
        }

        public static YoutubeSearch Search(SearchApiRequestSettings settings, params PartType[] partTypes)
        {
            var request = DefaultRequest<SearchResult, SearchApiRequestSettings>(settings, partTypes);
            return new YoutubeSearch(request);
        }

        public static YoutubeSearch Search(string query = null, params PartType[] partTypes)
        {
            var request = DefaultRequest<SearchResult, SearchApiRequestSettings>(new SearchApiRequestSettings { Query = query }, partTypes);
            return new YoutubeSearch(request);
        }

        public static YoutubeSearch ForCountry(this YoutubeSearch search, YoutubeCountry country)
        {
            var request = search.Request.Clone();
            request.Settings.RegionCode = country.CountryCode;
            return new YoutubeSearch(request);
        }

        public static YoutubeSearch ForChannelId(this YoutubeSearch search, string id)
        {
            var request = search.Request.Clone();
            request.Settings.ChannelId = id;
            return new YoutubeSearch(request);
        }

        public static YoutubeSearch OrderBy(this YoutubeSearch search, SearchOrder order)
        {
            var request = search.Request.Clone();
            request.Settings.Order = order;
            return new YoutubeSearch(request);
        }

        public static YoutubeSearch PublishedAfter(this YoutubeSearch search, DateTime d)
        {
            var request = search.Request.Clone();
            request.Settings.PublishedAfter = d;
            return new YoutubeSearch(request);
        }

        public static YoutubeSearch PublishedBefore(this YoutubeSearch search, DateTime d)
        {
            var request = search.Request.Clone();
            request.Settings.PublishedBefore = d;
            return new YoutubeSearch(request);
        }

        public static YoutubeSearch Type(this YoutubeSearch search, ResourceKind t)
        {
            var request = search.Request.Clone();
            request.Settings.Type = t;
            return new YoutubeSearch(request);
        }

        public static YoutubeSearch SafeSearch(this YoutubeSearch search, SafeSearch s)
        {
            var request = search.Request.Clone();
            request.Settings.SafeSearch = s;
            return new YoutubeSearch(request);
        }

        public static YoutubeSearch Search(SearchApiRequestSettings settings)
        {
            return Search(settings, PartType.Snippet);
        }

        #endregion

        #region Videos

        public static YoutubeVideo Video(VideoApiRequestSettings settings, params PartType[] partTypes)
        {
            var request = DefaultRequest<Video, VideoApiRequestSettings>(settings, partTypes);
            return new YoutubeVideo(request);
        }

        public static YoutubeVideo Video(VideoApiRequestSettings settings)
        {
            return Video(settings, PartType.Snippet);
        }

        public static YoutubeVideo Video(string id)
        {
            return Video(new VideoApiRequestSettings { Id = id });
        }

        public static YoutubeVideos Videos(IEnumerable<string> ids)
        {
            return Videos(new VideoApiRequestSettings { Id = ids.Aggregate((s1, s2) => $"{s1},{s2}") });
        }

        public static YoutubeVideos Videos(VideoApiRequestSettings settings, params PartType[] partTypes)
        {
            var request = DefaultRequest<Video, VideoApiRequestSettings>(settings, partTypes);
            return new YoutubeVideos(request);
        }

        public static YoutubeVideos Videos(VideoApiRequestSettings settings)
        {
            return Videos(settings, PartType.Snippet);
        }

        public static YoutubeSearch Related(this YoutubeVideo video)
        {
            return Search(new SearchApiRequestSettings { RelatedToVideoId = video.Id, Type = ResourceKind.Video });
        }

        #endregion
    }
}
