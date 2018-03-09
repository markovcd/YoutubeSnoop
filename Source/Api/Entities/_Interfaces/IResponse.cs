using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Api.Entities
{
    public interface IResponse
    {
        /// <summary>
        /// 
        /// </summary>
        string Etag { get; }
        ResourceKind Kind { get; }
    }
}