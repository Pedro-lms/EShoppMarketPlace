using System.ComponentModel.DataAnnotations;

namespace EShoppMarketPlace.src.Web.WebMVC.DTOs
{
    public class CartDTO
    {
        public string OrderNumber { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; }
        [Required]
        public decimal Total { get; set; }
        public string Description { get; set; }
        [Required]
        public int ZipCode { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Region { get; set; }
        [Required]
        public int CardNumber { get; set; }
        [Required]
        public string CardHolderName { get; set; }
        public bool IsDraft { get; set; }
        [Required]
        public DateTime CardExparationShort { get; set; }
        [Required]
        public string CardExpirationShort { get; set; }
        [Required]
        public string CardSecurityNumber { get; set; }
        [Required]
        public int CardTypeId { get; set; }
        public string Buyer { get; set; }
        [Required]
        public Guid RequestId { get; set; }
    }
}
