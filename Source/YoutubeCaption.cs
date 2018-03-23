using System;
using System.Collections.Generic;
using YoutubeSnoop.Api;
using YoutubeSnoop.Api.Entities.Captions;
using YoutubeSnoop.Api.Settings;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop
{
    public sealed class YoutubeCaption : YoutubeItem<Caption, CaptionApiRequestSettings>, IYoutubeItem
    {
        private string _id;
        public string Id => Set(ref _id);

        private ResourceKind _kind;
        public ResourceKind Kind => Set(ref _kind);

        private AudioTrackType _audioTrackType;
        public AudioTrackType AudioTrackType => Set(ref _audioTrackType);

        private bool _isAutoSynced;
        public bool IsAutoSynced => Set(ref _isAutoSynced);

        private bool _isCc;
        public bool ISCc => Set(ref _isCc);

        private bool _isEasyReader;
        public bool IsEasyReader => Set(ref _isEasyReader);

        private bool _isLarge;
        public bool IsLarge => Set(ref _isLarge);

        private string _language;
        public string Language => Set(ref _language);

        private DateTime _lastUpdated;
        public DateTime LastUpdated => Set(ref _lastUpdated);

        private string _name;
        public string Name => Set(ref _name);

        private CaptionType _type;
        public CaptionType Type => Set(ref _type);

        private string _videoId;
        public string VideoId => Set(ref _videoId);

        public YoutubeCaption(IApiRequest<Caption, CaptionApiRequestSettings> request) : base(request)
        {
        }

        public YoutubeCaption(Caption response) : base(response)
        {
        }

        public YoutubeCaption(CaptionApiRequestSettings settings = null, IEnumerable<PartType> partTypes = null) : base(settings, partTypes)
        {
        }

        protected override void SetProperties(Caption response)
        {
            if (response == null) return;

            _id = response.Id;
            _kind = response.Kind;

            if (response.Snippet == null) return;

            _audioTrackType = response.Snippet.AudioTrackType.GetValueOrDefault();
            _isAutoSynced = response.Snippet.IsAutoSynced.GetValueOrDefault();
            _isCc = response.Snippet.IsCC.GetValueOrDefault();
            _isEasyReader = response.Snippet.IsEasyReader.GetValueOrDefault();
            _isLarge = response.Snippet.IsLarge.GetValueOrDefault();
            _language = response.Snippet.Language;
            _lastUpdated = response.Snippet.LastUpdated.GetValueOrDefault();
            _name = response.Snippet.Name;
            _type = response.Snippet.TrackKind.GetValueOrDefault();
            _videoId = response.Snippet.VideoId;
        }
    }
}