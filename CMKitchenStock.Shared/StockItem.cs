using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Text;
using CMKitchenStock.Shared.CustomValidations;

namespace CMKitchenStock.Shared
{
    public class StockItem
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("name")]
        [Required]
        public string? Name { get; set; }

        [JsonProperty("quantity")]
        [Range(0, 100)]
        public int Quantity { get; set; }

        [JsonProperty("nextRefillDate")]
        [FutureDate]
        public DateTime? NextRefillDate { get; set; }
    }
}
