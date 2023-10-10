using Price.Models;

namespace Price.Services
{
    public class PriceService : IPriceService
    {
        public CalculatePriceResponse Calculate(CalculatePriceRequest request)
        {
            var result = new CalculatePriceResponse();

            foreach (var product in request.Products)
            {
                result.Products.Add(new ProductResponse
                {
                    Id = product.Id,
                    Title = product.Title,
                    Price = CalculatePriceWithMargin(product.NetCost, request.Margin, request.Tax)
                });
            }

            result.TotalPrice = result.Products.Sum(p => p.Price);

            return result;
        }



        private decimal CalculatePriceWithMargin(decimal netCost, decimal margin, decimal tax)
        {
            var priceWithMrgin = netCost + netCost * margin;

            return decimal.Round(priceWithMrgin / (1 - tax), 2, MidpointRounding.AwayFromZero);
        }
    }
}