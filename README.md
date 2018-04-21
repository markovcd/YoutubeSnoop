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
	var channelUploads = channel.Uploads().TakePage().ToList();
	var channelSearch = channel.Search("find some stuff").ToList();
	
The intermediate way:

	using System;
	using System.Linq;
	using YoutubeSnoop;
	using YoutubeSnoop.Api;
	using YoutubeSnoop.Enums;

	...

	var videoSettings = new VideoSettings { Id = "some video id" };
	var video = new YoutubeVideo(videoSettings, new[] { PartType.Snippet, PartType.ContentDetails });
	Console.WriteLine(video.Title);

	var commentThreadSettings = new CommentThreadSettings { VideoId = video.Id };
	var comments = new YoutubeCommentThreads(commentThreadSettings);

	var searchSettings = new SearchSettings { RelatedToVideoId = video.Id };
	var related = new YoutubeSearch(searchSettings);

	var searchSettings2 = new SearchSettings { Query = "my first search query", PublishedBefore = DateTime.Now, Order = SearchOrder.Relevance };
	var search = new YoutubeSearch(searchSettings2).Take(20).ToList();


	var channelSettings = new ChannelSettings { ForUsername = "some YouTube username" };
	var channel = new YoutubeChannel(channelSettings);

	var playlistItemSettings = new PlaylistItemSettings { PlaylistId = channel.UploadsPlaylistId };
	var channelUploads = new YoutubePlaylistItems(playlistItemSettings);

	var searchSettings3 = new SearchSettings { Query = "find some stuff", ChannelId = channel.Id };
	var channelSearch = new YoutubeSearch(searchSettings3).ToList();
	
The hard way:
