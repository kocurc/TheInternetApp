namespace TheInternetApp.Utilities
{
    /// <summary>
    /// </summary>
    /// <typeparam name="T">Type of async request response from REST library.</typeparam>
    public interface IRestApiExecutor<T>
    {
        public string? StatusCode { get; }
        public string? ResponseStatus { get; }
        public string? ContentType { get; }
        Task<T> ExecuteAsyncGetMethod(string uri);
    }
}
