using Price.Models;

namespace Price.Services
{
    public interface IPriceService
    {
        CalculatePriceResponse Calculate(CalculatePriceRequest request);
    }
}