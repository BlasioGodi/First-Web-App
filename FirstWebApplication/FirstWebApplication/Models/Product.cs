﻿using System.Text.Json;
using System.Text.Json.Serialization;

namespace FirstWebApplication.Models
{
    public class Product
    {
        public string Id { get; set; }
        [JsonPropertyName("img")]
        public string Image{ get; set; }
        public string Weight { get; set; }
        public string Cost { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int[] Ratings { get; set; }

        public override string ToString() =>JsonSerializer.Serialize<Product>(this);
    }
}
