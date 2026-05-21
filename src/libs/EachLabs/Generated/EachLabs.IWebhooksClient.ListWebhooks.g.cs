#nullable enable

namespace EachLabs
{
    public partial interface IWebhooksClient
    {
        /// <summary>
        /// List webhooks<br/>
        /// Retrieve a paginated list of webhooks for the authenticated organization
        /// </summary>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EachLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::EachLabs.ListWebhooksResponse> ListWebhooksAsync(
            int? limit = default,
            int? offset = default,
            global::EachLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List webhooks<br/>
        /// Retrieve a paginated list of webhooks for the authenticated organization
        /// </summary>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EachLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::EachLabs.AutoSDKHttpResponse<global::EachLabs.ListWebhooksResponse>> ListWebhooksAsResponseAsync(
            int? limit = default,
            int? offset = default,
            global::EachLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}