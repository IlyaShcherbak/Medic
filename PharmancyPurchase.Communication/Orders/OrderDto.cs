﻿namespace PharmancyPurchase.Communication.Orders
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class OrderDto
    {
        public OrderDto()
        {
            this.OrderDtails = new HashSet<OrderDetailDto>();
        }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("itemsAvailable")]
        public int ItemsAvailable { get; set; }

        [JsonProperty("price")]
        public double Price { get; set; }

        [JsonProperty("vendor")]
        public string Vendor { get; set; }

        [JsonProperty("needToOrderCount")]
        public int NeedToOrderCount { get; set; }

        [JsonProperty("orderDtails")]
        public ICollection<OrderDetailDto> OrderDtails { get; set; }
    }
}