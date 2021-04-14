﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Work
{
    public class CurrencyPair
    {
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; }
        [JsonPropertyName("priceChange")]
        public string PriceChange { get; set; }
        [JsonPropertyName("priceChangePercent")]
        public string PriceChangePercent { get; set; }
        [JsonPropertyName("weightedAvgPrice")]
        public string WeightedAvgPrice { get; set; }
        [JsonPropertyName("prevClosePrice")]
        public string PrevClosePrice { get; set; }
        [JsonPropertyName("lastPrice")]
        public string LastPrice { get; set; }
        [JsonPropertyName("lastQty")]
        public string LastQty { get; set; }
        [JsonPropertyName("bidPrice")]
        public string BidPrice { get; set; }
        [JsonPropertyName("bidQty")]
        public string BidQty { get; set; }
        [JsonPropertyName("askPrice")]
        public string AskPrice { get; set; }
        [JsonPropertyName("askQty")]
        public string AskQty { get; set; }
        [JsonPropertyName("openPrice")]
        public string OpenPrice { get; set; }
        [JsonPropertyName("highPrice")]
        public string HighPrice { get; set; }
        [JsonPropertyName("lowPrice")]
        public string LowPrice { get; set; }
        [JsonPropertyName("volume")]
        public string Volume { get; set; }
        [JsonPropertyName("quoteVolume")]
        public string QuoteVolume { get; set; }
        [JsonPropertyName("openTime")]
        public long OpenTime { get; set; }
        [JsonPropertyName("closeTime")]
        public long CloseTime { get; set; }
        [JsonPropertyName("firstId")]
        public int FirstId { get; set; }
        [JsonPropertyName("lastId")]
        public int LastId { get; set; }
        [JsonPropertyName("count")]
        public int Count { get; set; }
        

    }
}
