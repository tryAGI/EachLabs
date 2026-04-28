#nullable enable

namespace EachLabs
{
    public partial interface IAiModelsPredictionClient
    {
        /// <summary>
        /// Get Model Prediction<br/>
        /// Retrieve the status and results of a model prediction by its ID
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EachLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::EachLabs.Prediction> GetPredictionAsync(
            string id,
            global::EachLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}