using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;

namespace YoutubeSnoop.Api
{
    /// <summary>
    /// Default downloader for JSON data from Youtube. Use this in the constructor of ApiRequest class.
    /// </summary>
    public class JsonDownloader : IJsonDownloader
    {
        [DebuggerNonUserCode]
        public static async Task<string> DownloadAsync(string url)
        {
            using (var http = new HttpClient())
            {
                var response = await http.GetAsync(url).ConfigureAwait(false);

                var json = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

                if (!response.IsSuccessStatusCode) throw RequestException.FromJson(json);

                return json;
            }
        }

        [DebuggerNonUserCode]
        Task<string> IJsonDownloader.DownloadAsync(string url)
        {
            return DownloadAsync(url);
        }
    }
}