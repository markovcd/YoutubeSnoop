using System;

namespace YoutubeSnoop.Attributes
{
	[AttributeUsage(AttributeTargets.Property, Inherited = true, AllowMultiple = false)]
	sealed class ApiRequestIgnoreAttribute : Attribute { }
}
