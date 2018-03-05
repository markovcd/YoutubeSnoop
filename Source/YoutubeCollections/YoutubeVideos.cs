using System.Collections;
using System.Collections.Generic;
using System.Linq;
using YoutubeSnoop.Entities.Videos;
using YoutubeSnoop.Interfaces;
using YoutubeSnoop.Settings;

namespace YoutubeSnoop
{
    public class YoutubeVideos : IYoutubeCollection<YoutubeVideo>
    {
        public IApiRequest<Video> Request { get; }
               
        public YoutubeVideos(IApiRequest<Video> request)
        {
            Request = request;
        }

        public IEnumerator<YoutubeVideo> GetEnumerator()
        {
            return Request.Items.Select(i => new YoutubeVideo(i)).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}