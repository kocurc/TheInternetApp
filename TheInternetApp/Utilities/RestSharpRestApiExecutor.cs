using RestSharp;

namespace TheInternetApp.Utilities
{
    public class RestSharpRestApiExecutor : IRestApiExecutor<RestResponse>
    {
        private RestClient _restClient;

        public RestSharpRestApiExecutor()
        {
            _restClient = new RestClient();
        }

        public string? StatusCode { get; private set; }
        public string? ResponseStatus { get; private set; }
        public string? ContentType { get; private set; }

        public async Task<RestResponse> ExecuteAsyncGetMethod(string uri)
        {
            if (uri == null)
            {
                throw new ArgumentNullException(nameof(uri));
            }

            RestRequest restRequest = new RestRequest(uri, Method.Get);
            var restResponse = await _restClient.ExecuteAsync(restRequest);

            StatusCode = restResponse.StatusCode.ToString();
            ResponseStatus = restResponse.ResponseStatus.ToString();
            ContentType = restResponse.ContentType;

            return restResponse;
        }
    }
}
