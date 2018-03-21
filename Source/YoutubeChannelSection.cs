using System;
using System.Collections.Generic;
using YoutubeSnoop.Api;
using YoutubeSnoop.Api.Entities;
using YoutubeSnoop.Api.Entities.ChannelSections;
using YoutubeSnoop.Api.Settings;
using YoutubeSnoop.Enums;
using System.Linq;

namespace YoutubeSnoop
{
    public sealed class YoutubeChannelSection : YoutubeItem<ChannelSection, ChannelSectionApiRequestSettings>, IYoutubeItem
    {

        private ChannelSection _item;
        public ChannelSection Item => Set(ref _item);

        private string _id;
        public string Id => Set(ref _id);

        private ResourceKind _kind;
        public ResourceKind Kind => Set(ref _kind);

        private string _channelId;
        public string ChannelId => Set(ref _channelId);

        private int _position;
        public int Position => Set(ref _position);

        private ChannelSectionStyle _style;
        public ChannelSectionStyle Style => Set(ref _style);

        private string _title;
        public string Title => Set(ref _title);

        private ChannelSectionType _type;
        public ChannelSectionType Type => Set(ref _type);

        private IReadOnlyList<string> _channelIds;
        public IReadOnlyList<string> ChannelIds => Set(ref _channelIds);

        private IReadOnlyList<string> _playlistIds;
        public IReadOnlyList<string> PlaylistIds => Set(ref _playlistIds);

        public YoutubeChannelSection(IApiRequest<ChannelSection, ChannelSectionApiRequestSettings> request) : base(request) { }

        public YoutubeChannelSection(ChannelSection response) : base(response) { }

        protected override void SetProperties(ChannelSection response)
        {
            if (response == null) return;

            _item = response;
            _id = response.Id;
            _kind = response.Kind;

            if (response.Snippet != null)
            {
                _channelId = response.Snippet.ChannelId;
                _position = response.Snippet.Position.GetValueOrDefault();
                _style = response.Snippet.Style.GetValueOrDefault();
                _title = response.Snippet.Title;
                _type = response.Snippet.Type.GetValueOrDefault();
            }

            if (response.ContentDetails != null)
            {
                _channelIds = response.ContentDetails.Channels?.ToList().AsReadOnly();
                _playlistIds = response.ContentDetails.Playlists?.ToList().AsReadOnly();
            }
        }
    }
}