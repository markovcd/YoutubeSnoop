using YoutubeSnoop.Interfaces;

namespace YoutubeSnoop.Entities
{
    public class TitleDescription : ITitleDescription
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }
}