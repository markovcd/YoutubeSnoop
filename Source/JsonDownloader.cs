using System.Net;

namespace YoutubeSnoop
{
    public static class JsonDownloader
    {
        public static string Download(string url)
        {
            var http = new WebClient();
            return http.DownloadString(url); // TODO - error handling
        }
    }
}
