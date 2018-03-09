namespace YoutubeSnoop.Api.Entities
{
    public class Location
    {
        /// <summary>
        /// 
        /// </summary>
        public double? Latitude { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double? Longitude { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double? Altitude { get; set; }

        public override string ToString()
        {
            return $"({Latitude:0.#####},{Longitude:0.#####})";
        }
    }
}