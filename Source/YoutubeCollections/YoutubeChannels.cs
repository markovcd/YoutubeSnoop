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
        public IApiRequest<Channel> Request { get; }
        
        public YoutubeChannels(IApiRequest<Channel> request)
        {
            Request = request;
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