using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CMKitchenStock.Shared
{
    public class StockItem
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("quantity")]
        public int Quantity { get; set; }
        [JsonProperty("nextRefillDate")]
        public DateTime? NextRefillDate { get; set; }
    }
}
