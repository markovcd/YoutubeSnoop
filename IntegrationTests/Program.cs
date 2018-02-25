using System;
using System.Linq;
using YoutubeSnoop;
using YoutubeSnoop.ApiRequests;
using YoutubeSnoop.ApiRequests.Settings;

namespace IntegrationTests
{
    class Program
    {
        static void Main(string[] args)
        {
            var ps = new PlaylistApiRequestSettings();
            ps.PlaylistId = "PLg-NWZjrm22usa_eVDKCADwbJ29JYOrDI";
            var p = new PlaylistApiRequest(ps);
            var pr = p.Response;
            var l = p.ToList();

            var vs = new VideoApiRequestSettings();
            vs.Id = "6vpOHq8bkzA";
            var v = new VideoApiRequest(vs);
            var vr = v.Response;

            var ss = new SearchApiRequestSettings();
            ss.Query = "markovcd playlist";
            var s = new SearchApiRequest(ss);
            var sr = s.Response;
        }
    }
}
