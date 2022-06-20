namespace EShoppMarketPlace.src.ApiGateways.Web.Shopping.aggregator.Models
{
    public class OrderData
    {
        public string OrderNumber { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; }
        public decimal Total { get; set; }
        public string Description { get; set; }
        public int ZipCode { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public int CardNumber { get; set; }
        public string CardHolderName { get; set; }
        public bool IsDraft { get; set; }
        public DateTime CardExparationShort { get; set; }
        public string CardExpirationShort { get; set; }
        public string CardSecurityNumber { get; set; }
        public int CardTypeId { get; set; }
        public string Buyer { get; set; }
        public List<OrderItemData> OrderItems { get; } = new();

    }
}
