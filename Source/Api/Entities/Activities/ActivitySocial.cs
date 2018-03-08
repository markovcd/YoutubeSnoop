namespace YoutubeSnoop.Api.Entities.Activities
{
    public class ActivitySocial : ActivityItem
    {
        public string Type { get; set; }
        public string Author { get; set; }
        public string ReferenceUrl { get; set; }
        public string ImageUrl { get; set; }
    }
}