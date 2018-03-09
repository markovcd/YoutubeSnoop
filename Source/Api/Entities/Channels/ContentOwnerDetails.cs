namespace YoutubeSnoop.Api.Entities.Channels
{
    public class ContentOwnerDetails
    {
        /// <summary>
        /// The ID of the content owner linked to the channel.
        /// </summary>
        public string ContentOwner { get; set; }

        /// <summary>
        /// The date and time of when the channel was linked to the content owner. 
        /// </summary>
        public string TimeLinked { get; set; }
    }
}