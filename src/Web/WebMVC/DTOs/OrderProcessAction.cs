namespace EShoppMarketPlace.src.Web.WebMVC.DTOs
{
    public class OrderProcessAction
    {
        public string Code { get; set; }
        public string Name { get; set; }

        public static OrderProcessAction Ship = new OrderProcessAction(nameof(Ship).ToUpperInvariant(), "Ship");

        public OrderProcessAction(string code, string name)
        {
            Code = code;
            Name = name;
        }
    }
}
