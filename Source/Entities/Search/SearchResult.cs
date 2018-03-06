using Newtonsoft.Json;
using YoutubeSnoop.Converters;
using YoutubeSnoop.Interfaces;

namespace YoutubeSnoop.Entities.Search
{
    public class SearchResult : Response
    {
        public IResource Id { get; set; }
        public Snippet Snippet { get; set; }
    }
}