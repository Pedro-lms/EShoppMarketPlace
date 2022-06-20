﻿namespace EShoppMarketPlace.src.ApiGateways.Web.Shopping.aggregator.Models
{
    public class CatalogItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string PictureUrl { get; set; }
    }
}
