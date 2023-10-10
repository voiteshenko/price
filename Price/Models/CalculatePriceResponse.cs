namespace Price.Models
{
    public class CalculatePriceResponse
    {
        public List<ProductResponse> Products { get; set; }

        public decimal TotalPrice { get; set; }

        public CalculatePriceResponse()
        {
            Products = new List<ProductResponse>();
        }
    }

    public class ProductResponse
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public decimal Price { get; set; }
    }
}