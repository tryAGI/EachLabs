#nullable enable

namespace EachLabs
{
    public partial interface IWebhooksClient
    {
        /// <summary>
        /// Get webhook by execution ID<br/>
        /// Retrieve details of a specific webhook including delivery attempts by execution ID
        /// </summary>
        /// <param name="executionId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EachLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::EachLabs.WebhookWithAttempts> GetWebhookAsync(
            string executionId,
            global::EachLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}