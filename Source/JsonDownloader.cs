using System.Net;
using YoutubeSnoop.Exceptions;

namespace YoutubeSnoop
{
    public static class JsonDownloader
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
                throw YoutubeException.FromWebException(ex);
            }
           
            
        }
    }
}