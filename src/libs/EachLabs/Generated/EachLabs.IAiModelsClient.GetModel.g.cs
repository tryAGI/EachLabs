#nullable enable

namespace EachLabs
{
    public partial interface IAiModelsClient
    {
        /// <summary>
        /// Get model details<br/>
        /// Retrieve detailed information about a specific model by slug
        /// </summary>
        /// <param name="slug"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EachLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::EachLabs.ModelDetail> GetModelAsync(
            string slug,
            global::EachLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get model details<br/>
        /// Retrieve detailed information about a specific model by slug
        /// </summary>
        /// <param name="slug"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EachLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::EachLabs.AutoSDKHttpResponse<global::EachLabs.ModelDetail>> GetModelAsResponseAsync(
            string slug,
            global::EachLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}