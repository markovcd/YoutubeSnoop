using System;
using YoutubeSnoop.Interfaces;

namespace YoutubeSnoop.Attributes
{
	[AttributeUsage(AttributeTargets.Property, Inherited = true, AllowMultiple = false)]
	public sealed class ApiRequestConverterAttribute : Attribute
	{
		public IApiRequestConverter Converter { get; }

		public ApiRequestConverterAttribute(Type converterType)
		{
			Converter = (IApiRequestConverter)Activator.CreateInstance(converterType);
		}
	}
}
