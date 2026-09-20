using System.Text.Json.Serialization;

namespace finance_app_blazor.Models
{
    public partial class FiftyTwoWeek
    {
        [JsonPropertyName("low")]
        public string? Low { get; set; }

        [JsonPropertyName("high")]
        public string? High { get; set; }

        [JsonPropertyName("low_change")]
        public string? LowChange { get; set; }

        [JsonPropertyName("high_change")]
        public string? HighChange { get; set; }

        [JsonPropertyName("low_change_percent")]
        public string? LowChangePercent { get; set; }

        [JsonPropertyName("high_change_percent")]
        public string? HighChangePercent { get; set; }

        [JsonPropertyName("range")]
        public string? Range { get; set; }
    }
}
