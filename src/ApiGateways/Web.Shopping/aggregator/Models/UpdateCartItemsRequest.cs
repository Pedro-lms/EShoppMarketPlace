namespace EShoppMarketPlace.src.ApiGateways.Web.Shopping.aggregator.Models
{
    public class UpdateCartItemsRequest
    {
        public string ShoppingCartId { get; set; }
        public ICollection<UpdateCartItemData> Updates { get; set; }
        public UpdateCartItemsRequest() => Updates = new List<UpdateCartItemData>();
    }
}
