namespace YoutubeSnoop.Api.Entities
{
    public class Location
    {
        /// <summary>
        /// Latitude in degrees.
        /// </summary>
        public double? Latitude { get; set; }

        /// <summary>
        /// Longitude in degrees.
        /// </summary>
        public double? Longitude { get; set; }

        /// <summary>
        /// Altitude above the reference ellipsoid, in meters.
        /// </summary>
        public double? Altitude { get; set; }

        public override string ToString()
        {
            return $"({Latitude:0.#####},{Longitude:0.#####})";
        }
    }
}