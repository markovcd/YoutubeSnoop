using System.Threading.Tasks;

namespace YoutubeSnoop.Api
{
    public interface IJsonDownloader
    {
        Task<string> DownloadAsync(string url);
    }
}