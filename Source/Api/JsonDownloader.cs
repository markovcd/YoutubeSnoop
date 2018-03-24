using System.Net;

namespace YoutubeSnoop.Api
{
    /// <summary>
    /// Default downloader for JSON data from Youtube. Use this in the constructor of ApiRequest class.
    /// </summary>
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
                throw RequestException.FromWebException(ex);
            }
        }

        string IJsonDownloader.Download(string url)
        {
            return Download(url);
        }
    }
}