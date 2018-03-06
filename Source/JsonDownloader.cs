using System.Net;
using YoutubeSnoop.Exceptions;
using YoutubeSnoop.Interfaces;

namespace YoutubeSnoop
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
                throw YoutubeException.FromWebException(ex);
            }  
        }

        string IJsonDownloader.Download(string url)
        {
            return Download(url);
        }
    }
}