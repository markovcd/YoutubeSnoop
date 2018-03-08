using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Api.Entities
{
    public class Distance
    {
        public double Value { get; set; }

        public DistanceUnit Unit { get; set; }

        public override string ToString()
        {
            var u = Unit.GetDescription();

            return $"{Value:0.##}{u}";
        }
    }
}