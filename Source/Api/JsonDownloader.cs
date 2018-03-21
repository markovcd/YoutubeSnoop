using System.Net;
using YoutubeSnoop.Api.Exceptions;

namespace YoutubeSnoop.Api
{
    public class JsonDownloader : IJsonDownloader
    {
        public static string Download(string url)
        {
            var http = new WebClient();
            try
            {
                return http.DownloadString(url);
            }
            catch (WebException ex)
            {
                throw ApiException.FromWebException(ex);
            }
        }

        string IJsonDownloader.Download(string url)
        {
            return Download(url);
        }
    }
}