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
        
        public YoutubeVideos(VideoApiRequestSettings settings, int resultsPerPage = 20)
        {
            Request = new ApiRequest<Video, VideoApiRequestSettings>(settings, resultsPerPage);
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