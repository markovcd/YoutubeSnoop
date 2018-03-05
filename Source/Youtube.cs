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

namespace YoutubeSnoop
{
    public static class Youtube
    {
        public static int ResultsPerPage { get; set; } = 20;

        private static IJsonDownloader GetDefaultJsonDownloader()
        {
            return new JsonDownloader();
        }

        private static IResponseDeserializer<TItem> DefaultDeserializer<TItem>() where TItem : IResponse
        {
            return new ResponseDeserializer<TItem>();
        }

        private static IApiUrlFormatter<TSettings> DefaultUrlFormatter<TSettings>() where TSettings : IApiRequestSettings
        {
            return new ApiUrlFormatter<TSettings>();
        }

        public static IApiRequest<TItem, TSettings> DefaultRequest<TItem, TSettings>(TSettings settings, IEnumerable<PartType> partTypes)
            where TItem : class, IResponse
            where TSettings : IApiRequestSettings
        {
            return new ApiRequest<TItem, TSettings>(settings, partTypes, ResultsPerPage, GetDefaultJsonDownloader(), DefaultDeserializer<TItem>(), DefaultUrlFormatter<TSettings>());
        }

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

        public static YoutubeChannel Channel(ChannelApiRequestSettings settings, params PartType[] partTypes)
        {
            var request = DefaultRequest<Channel, ChannelApiRequestSettings>(settings, partTypes);         
            return new YoutubeChannel(request);
        }

        public static YoutubeChannel Channel(ChannelApiRequestSettings settings)
        {
            return Channel(settings, PartType.Snippet, PartType.ContentDetails);
        }

        public static YoutubeChannels Channels(ChannelApiRequestSettings settings, params PartType[] partTypes)
        {
            var request = DefaultRequest<Channel, ChannelApiRequestSettings>(settings, partTypes);
            return new YoutubeChannels(request);
        }

        public static YoutubeChannels Channels(ChannelApiRequestSettings settings)
        {
            return Channels(settings, PartType.Snippet);
        }

        public static YoutubeChannel Channel(string id)
        {
            return Channel(new ChannelApiRequestSettings { Id = id });
        }

        public static YoutubeChannels Channels(IEnumerable<string> ids)
        {
            return Channels(new ChannelApiRequestSettings { Id = ids.Aggregate((s1, s2) => $"{s1},{s2}") });
        }

        public static YoutubeChannel ChannelFromUsername(string username)
        {
            return Channel(new ChannelApiRequestSettings { ForUsername = username });
        }

        public static YoutubePlaylistItems Uploads(this YoutubeChannel channel)
        {
            if (channel.Item.ContentDetails == null)
            {
                throw new InvalidOperationException("To get uploads first instantiate Channel with ContentDetails PartType.");
            }

            var id = channel.Item.ContentDetails.RelatedPlaylists.Uploads;
            return PlaylistItemsFromId(id);
        }

        public static YoutubePlaylists Playlists(this YoutubeChannel channel)
        {
            return PlaylistsFromChannelId(channel.Id);
        }

        #endregion

        #region PlaylistItems

        public static YoutubePlaylistItems PlaylistItems(PlaylistItemsApiRequestSettings settings, params PartType[] partTypes)
        {
            var request = DefaultRequest<PlaylistItem, PlaylistItemsApiRequestSettings>(settings, partTypes);
            return new YoutubePlaylistItems(request);
        }

        public static YoutubePlaylistItems PlaylistItems(PlaylistItemsApiRequestSettings settings)
        {
            return PlaylistItems(settings, PartType.Snippet);
        }

        public static YoutubePlaylistItems PlaylistItemsFromId(string id)
        {
            return PlaylistItems(new PlaylistItemsApiRequestSettings {  PlaylistId = id });
        }

        public static IYoutubeItem Details(this YoutubePlaylistItem playlistItem)
        {
            return playlistItem.Item.Snippet.ResourceId.ToYoutubeItem();
        }

        public static YoutubeVideos Videos(this YoutubePlaylistItems playlistItems)
        {
            return Videos(playlistItems.Select(i => i.Id));
        }

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

        public static YoutubePlaylists Playlists(PlaylistApiRequestSettings settings)
        {
            return Playlists(settings, PartType.Snippet);
        }

        public static YoutubePlaylist Playlist(string id)
        {
            return Playlist(new PlaylistApiRequestSettings { Id = id });
        }

        public static YoutubePlaylists Playlists(IEnumerable<string> ids)
        {
            return Playlists(new PlaylistApiRequestSettings { Id = ids.Aggregate((s1, s2) => $"{s1},{s2}") });
        }

        public static YoutubePlaylists PlaylistsFromChannelId(string id)
        {
            return Playlists(new PlaylistApiRequestSettings { ChannelId = id });
        }

        public static YoutubePlaylistItems Items(this YoutubePlaylist playlist)
        {
            return PlaylistItemsFromId(playlist.Id);
        }

        #endregion

        #region Search

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
            var request = search.Request.DeepClone();
            request.Settings.RegionCode = country.CountryCode;
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
