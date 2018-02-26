namespace YoutubeSnoop
{
    //public class YoutubeVideo
    //{
    //    private const string _youtubeUrl = @"https://www.youtube.com/watch?v={0}";

    //    public YoutubeVideo(string id) : this(new VideoApiRequestSettings { Id = id }) { }

    //    public YoutubeVideo(VideoApiRequestSettings settings) : this(GetSnippet(settings))
    //    {
    //        Settings = settings;
    //    }

    //    internal YoutubeVideo(VideoSnippet snippet)
    //    {
    //        VideoId = (snippet.ResourceId as VideoResourceId)?.VideoId;
    //        PublishedAt = snippet.PublishedAt;
    //        ChannelId = snippet.ChannelId;
    //        Title = snippet.Title;
    //        Description = snippet.Description;
    //        ChannelTitle = snippet.ChannelTitle;
    //        Thumbnails = snippet.Thumbnails?.ToDictionary(kv => kv.Key, kv => kv.Value.Url);
    //    }

    //    public VideoApiRequestSettings Settings { get; }
    //    public string ChannelId { get; }
    //    public string ChannelTitle { get; }
    //    public string Description { get; }
    //    public DateTime PublishedAt { get; }
    //    public IDictionary<string, string> Thumbnails { get; }
    //    public string Title { get; }
    //    public string Url => string.Format(_youtubeUrl, VideoId);
    //    public string VideoId { get; }

    //    private static Snippet GetSnippet(VideoApiRequestSettings settings)
    //    {
    //        var api = new VideoApiRequest(settings);
    //        return api.Response.Items.First().Snippet;
    //    }
    //}
}