namespace EShoppMarketPlace.src.ApiGateways.Web.Shopping.aggregator.Infrastructure
{
    public static class API
    {
        public static class Purchase
        {
            public static string AddItemToCart(string baseUri) => $"{baseUri}/cart/items";
            public static string UpdateItemToCart(string baseUri) => $"{baseUri}/cart/items";
            public static string GetOrderDraft(string baseUri, string cartId) => $"{baseUri}/order/draft/{cartId}";
        }
        
        public static class Cart
        {
            public static string GetCart(string baseUri, string cartId) => $"{baseUri}/{cartId}";
            public static string UpdateCart(string baseUri) => baseUri;
            public static string CheckoutCart (string baseUri) => $"{baseUri}/checkout";
            public static string CleanCart(string baseUri, string cartId) => $"{baseUri}/{cartId}";
        }

        public static class Order
        {
            public static string GetOrder(string baseUri, string orderId)
            {
                return $"{baseUri}/{orderId}";
            }

            public static string GetAllMyOrders(string baseUri)
            {
                return baseUri;
            }

            public static string AddNewOrder(string baseUri)
            {
                return $"{baseUri}/new";
            }

            public static string CancelOrder(string baseUri)
            {
                return $"{baseUri}/cancel";
            }

            public static string ShipOrder(string baseUri)
            {
                return $"{baseUri}/ship";
            }
        }

        public static class Catalog
        {
            public static string GetAllCatalogItems(string baseUri, int page, int take, int? brand, int? type)
            {
                var filterQs = "";
                if (type.HasValue)
                {
                    var brandQs = (brand.HasValue) ? brand.Value.ToString() : string.Empty;
                    filterQs = $"/type/{type.Value}/brand/{brandQs}";
                }
                else if (brand.HasValue)
                {
                    var brandQs = (brand.HasValue) ? brand.Value.ToString() : string.Empty;
                    filterQs = $"/type/all/brand/{brandQs}";
                }
                else
                {
                    filterQs = string.Empty;
                }
                return $"{baseUri}items{filterQs}?pageIndex={page}&pageSize={take}";
            }

            public static string GetAllBrends(string baseUri)
            {
                return $"{baseUri}catalogBrands";
            }

            public static string GetAllTypes(string baseUri)
            {
                return $"{baseUri}catalogTypes";
            }
        }
    }
     
}
