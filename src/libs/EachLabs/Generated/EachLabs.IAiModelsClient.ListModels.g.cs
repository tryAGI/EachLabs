#nullable enable

namespace EachLabs
{
    public partial interface IAiModelsClient
    {
        /// <summary>
        /// List AI models<br/>
        /// Retrieve a paginated list of AI models with optional filters
        /// </summary>
        /// <param name="name"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EachLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::EachLabs.Model>> ListModelsAsync(
            string? name = default,
            int? limit = default,
            int? offset = default,
            global::EachLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List AI models<br/>
        /// Retrieve a paginated list of AI models with optional filters
        /// </summary>
        /// <param name="name"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EachLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::EachLabs.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::EachLabs.Model>>> ListModelsAsResponseAsync(
            string? name = default,
            int? limit = default,
            int? offset = default,
            global::EachLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}