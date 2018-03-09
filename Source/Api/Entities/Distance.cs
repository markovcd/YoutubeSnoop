using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Api.Entities
{
    public class Distance
    {
        /// <summary>
        /// 
        /// </summary>
        public double Value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DistanceUnit Unit { get; set; }

        public override string ToString()
        {
            var u = Unit.GetDescription();

            return $"{Value:0.##}{u}";
        }
    }
}