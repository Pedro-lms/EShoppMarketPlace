using System.ComponentModel.DataAnnotations;

namespace EShoppMarketPlace.src.Web.WebMVC.DTOs
{
    public record OrderDTO
    {
        [Required]
        public string OrderNumber { get; init; }
    }
}
