namespace EShoppMarketPlace.src.ApiGateways.Web.Shopping.aggregator.Models
{
    public class UpdateCartRequestItemData
    {
        public string Id { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
