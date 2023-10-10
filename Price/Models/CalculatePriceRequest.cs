using System.Text.Json.Serialization;

namespace Price.Models
{
    public class CalculatePriceRequest
    {
        public IEnumerable<ProductRequest> Products { get; set; }

        public decimal Tax { get; set; }

        public decimal Margin { get; set; }
    }

    public class ProductRequest
    {
        public int Id { get; set; }

        public string Title { get; set; }

        [JsonPropertyName("net_cost")]
        public decimal NetCost { get; set; }
    }
}