using System.Collections;
using System.Collections.Generic;
using System.Linq;
using YoutubeSnoop.Entities.Channels;
using YoutubeSnoop.Enums;
using YoutubeSnoop.Interfaces;
using YoutubeSnoop.Settings;

namespace YoutubeSnoop
{
    public class YoutubeChannels : IYoutubeCollection<YoutubeChannel>
    {
        public ApiRequest<Channel, ChannelApiRequestSettings> Request { get; }
 
        public YoutubeChannels(ChannelApiRequestSettings settings, int resultsPerPage = 20)
        {
            Request = new ApiRequest<Channel, ChannelApiRequestSettings>(settings, new[] { PartType.Snippet, PartType.ContentDetails }, resultsPerPage);
        }            

        public IEnumerator<YoutubeChannel> GetEnumerator()
        {
            return Request.Items.Select(i => new YoutubeChannel(i)).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}