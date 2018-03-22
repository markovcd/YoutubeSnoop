# YoutubeSnoop
Lightweight .NET library to pull data from YouTube. It deals only with list request and only those that don't need authentication. Supports lazy loading paginated results. It has three layers of abstraction and three different ways of using the api.

The easy way:
	
	using System;
	using System.Linq;
	using YoutubeSnoop;
	using YoutubeSnoop.Fluent;

	...

	var video = Youtube.Video("some video id").RequestAllParts(); // receive all info about a specific Video
	Console.WriteLine(video.Title);
	
	var comments = video.Comments(); // get comments under a vid
	var related = video.RelatedVideos();
	
	var search = Youtube.Search("my first search query").PublishedBefore(DateTime.Now).OrderByRelevance().Take(20).ToList();
	
	var channel = Youtube.Channel().ForUsername("some YouTube username");
	var channelUploads = channel.Uploads().Take(20).ToList();
	var channelSearch = channel.Search("find some stuff").ToList();
	
The intermediate way:
