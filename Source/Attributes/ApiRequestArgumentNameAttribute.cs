using System;

namespace YoutubeSnoop.Attributes
{
    [AttributeUsage(AttributeTargets.Property, Inherited = true, AllowMultiple = false)]
    sealed class ApiRequestArgumentNameAttribute : Attribute
    { 
        public string Name { get; set; }

        public ApiRequestArgumentNameAttribute(string name)
        {
            Name = name;
        }
    }
}
