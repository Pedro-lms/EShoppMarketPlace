namespace EShoppMarketPlace.src.ApiGateways.Web.Shopping.aggregator.Models
{
    public class CartDataItem
    {
        public string Id { get; set; }
        public int PorductId { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal OldUnitPrice { get; set; }
        public int Quantity { get; set; }
        public string PictureUrl { get; set; }
    }
}
