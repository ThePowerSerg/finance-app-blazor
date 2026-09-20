using System.Text.Json.Serialization;

namespace finance_app_blazor.Models
{
    public class Quote
    {
        [JsonPropertyName("symbol")]
        public string? Symbol { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("exchange")]
        public string? Exchange { get; set; }

        [JsonPropertyName("mic_code")]
        public string? MicCode { get; set; }

        [JsonPropertyName("currency")]
        public string? Currency { get; set; }

        [JsonPropertyName("datetime")]
        public DateTimeOffset Datetime { get; set; }

        [JsonPropertyName("timestamp")]
        public long Timestamp { get; set; }

        [JsonPropertyName("last_quote_at")]
        public long LastQuoteAt { get; set; }

        [JsonPropertyName("open")]
        public string? Open { get; set; }

        [JsonPropertyName("high")]
        public string? High { get; set; }

        [JsonPropertyName("low")]
        public string? Low { get; set; }

        [JsonPropertyName("close")]
        public string? Close { get; set; }

        [JsonPropertyName("volume")]
        // [JsonConverter(typeof(ParseStringConverter))]
        public long Volume { get; set; }

        [JsonPropertyName("previous_close")]
        public string? PreviousClose { get; set; }

        [JsonPropertyName("change")]
        public string? Change { get; set; }

        [JsonPropertyName("percent_change")]
        public string? PercentChange { get; set; }

        [JsonPropertyName("average_volume")]
        // [JsonConverter(typeof(ParseStringConverter))]
        public long AverageVolume { get; set; }

        [JsonPropertyName("rolling_1d_change")]
        public string? Rolling1DChange { get; set; }

        [JsonPropertyName("rolling_7d_change")]
        public string? Rolling7DChange { get; set; }

        [JsonPropertyName("rolling_change")]
        public string? RollingChange { get; set; }

        [JsonPropertyName("is_market_open")]
        public bool IsMarketOpen { get; set; }

        [JsonPropertyName("fifty_two_week")]
        public FiftyTwoWeek? FiftyTwoWeek { get; set; }

        [JsonPropertyName("extended_change")]
        public string? ExtendedChange { get; set; }

        [JsonPropertyName("extended_percent_change")]
        public string? ExtendedPercentChange { get; set; }

        [JsonPropertyName("extended_price")]
        public string? ExtendedPrice { get; set; }

        [JsonPropertyName("extended_timestamp")]
        public long ExtendedTimestamp { get; set; }
    }
}
