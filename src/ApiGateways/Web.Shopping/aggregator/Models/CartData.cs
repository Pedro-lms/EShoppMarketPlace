namespace EShoppMarketPlace.src.ApiGateways.Web.Shopping.aggregator.Models
{
    public class CartData
    {
        public string BuyerId { get; set; }

        public List<CartDataItem> Items { get; set; } = new();

        public CartData()
        {
        }

        public CartData(string buyerId)
        {
            BuyerId = buyerId;
        }
    }
}
