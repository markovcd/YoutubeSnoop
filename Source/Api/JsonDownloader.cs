using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace YoutubeSnoop.Api
{
    /// <summary>
    /// Default downloader for JSON data from Youtube. Use this in the constructor of ApiRequest class.
    /// </summary>
    public class JsonDownloader : IJsonDownloader
    {
        public static async Task<string> DownloadAsync(string url)
        {
            using (var http = new HttpClient())
            {
                return await http.GetStringAsync(url).ConfigureAwait(false);
            }

            //try
            //{
            //    return http.DownloadString(url);
            //}
            //catch (WebException ex)
            //{
            //    throw RequestException.FromWebException(ex);
            //}
        }

        [DebuggerNonUserCode]
        Task<string> IJsonDownloader.DownloadAsync(string url)
        {
            return DownloadAsync(url);
        }
    }
}