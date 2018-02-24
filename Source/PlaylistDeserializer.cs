using Newtonsoft.Json;
using System.Net;
using System.Threading.Tasks;

namespace YoutubePlaylistSnoop
{
    static class PlaylistDeserializer
    {
        private const string _apiKey = "AIzaSyAHVb6LDoO5aARmDlUe9PIeU_U1et1bWd8"; // project Api key, do not touch!
        private const string _apiUrl = "https://www.googleapis.com/youtube/v3/playlistItems?part=snippet&playlistId={0}&key={1}&pageToken={2}&maxResults={3}";

        private static string FormatApiUrl(string playlistId, string pageToken, int maxResults = 20)
        {
            return string.Format(_apiUrl, playlistId, _apiKey, pageToken, maxResults);
        }

        public static string GetData(string playlistId, string pageToken = "", int maxResults = 20)
        {
            var http = new WebClient();
            return http.DownloadString(FormatApiUrl(playlistId, pageToken, maxResults));
        }

        public static async Task<string> GetDataAsync(string playlistId, string pageToken = "", int maxResults = 20)
        {
            var http = new WebClient();
            return await http.DownloadStringTaskAsync(FormatApiUrl(playlistId, pageToken, maxResults));
        }

        public static Entities.Playlist Deserialize(string playlistId, string pageToken = "", int maxResults = 20)
        {
            return JsonConvert.DeserializeObject<Entities.Playlist>(GetData(playlistId, pageToken, maxResults));
        }

        public static async Task<Entities.Playlist> DeserializeAsync(string playlistId, string pageToken = "", int maxResults = 20)
        {
            return JsonConvert.DeserializeObject<Entities.Playlist>(await GetDataAsync(playlistId, pageToken, maxResults));
        }
    }
}
