namespace YoutubeSnoop.Api.Entities.Activities
{
    public class Activity : Response
    {      
        public string Id { get; set; } 
        public Snippet Snippet { get; set; }
        public ContentDetails ContentDetails { get; set; }
    }
}