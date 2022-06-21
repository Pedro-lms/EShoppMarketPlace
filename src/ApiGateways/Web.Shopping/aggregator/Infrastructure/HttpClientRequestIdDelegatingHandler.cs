namespace EShoppMarketPlace.src.ApiGateways.Web.Shopping.aggregator.Infrastructure
{
    public class HttpClientRequestIdDelegatingHandler : DelegatingHandler
    {
        public HttpClientRequestIdDelegatingHandler()
        {
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            if (request.Method == HttpMethod.Post || request.Method == HttpMethod.Put)
            {
                !request.Headers.Contains("x-request-id") ? request.Headers.Add(("x-request-id"), Guid.NewGuid().ToString());
            }
            return await base.SendAsync(request, cancellationToken);
        }
    }
}
