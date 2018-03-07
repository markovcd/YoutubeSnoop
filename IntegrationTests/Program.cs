using System;
using YoutubeSnoop.Fluent;

namespace IntegrationTests
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //var l = Youtube.Search("test")
            //               .RequestPart(PartType.Snippet)
                           
            //               .Type(ResourceKind.Playlist)
            //               .OrderBy(SearchOrder.Title)
            //               .Take(20)
            //               .Select(i => $"{i.PublishedAt}: {i.Title}").ToList();
            var ch=Youtube.Channel().ForUsername("markovcd");
            var title = ch.Title;
            Console.WriteLine(title);
        }
    }
}