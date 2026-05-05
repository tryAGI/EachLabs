#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace EachLabs
{
    public partial interface IAiModelsPredictionClient
    {
        /// <summary>
        /// Create Model Prediction<br/>
        /// Create a new prediction for a specific model
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EachLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::EachLabs.CreatePredictionResponse> CreatePredictionAsync(

            global::EachLabs.CreatePredictionRequest request,
            global::EachLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Model Prediction<br/>
        /// Create a new prediction for a specific model
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EachLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::EachLabs.AutoSDKHttpResponse<global::EachLabs.CreatePredictionResponse>> CreatePredictionAsResponseAsync(

            global::EachLabs.CreatePredictionRequest request,
            global::EachLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Model Prediction<br/>
        /// Create a new prediction for a specific model
        /// </summary>
        /// <param name="model">
        /// Model slug or identifier<br/>
        /// Example: flux-1-1-pro
        /// </param>
        /// <param name="input">
        /// Input parameters for the prediction<br/>
        /// Example: {"prompt":"A beautiful sunset over the ocean with vibrant colors","aspect_ratio":"16:9"}
        /// </param>
        /// <param name="webhookUrl">
        /// Optional webhook URL to receive prediction result asynchronously<br/>
        /// Example: https://your-app.com/webhook
        /// </param>
        /// <param name="webhookSecret">
        /// Optional secret used to sign webhook requests<br/>
        /// Example: your-secret-key
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::EachLabs.CreatePredictionResponse> CreatePredictionAsync(
            string model,
            object input,
            string? webhookUrl = default,
            string? webhookSecret = default,
            global::EachLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}