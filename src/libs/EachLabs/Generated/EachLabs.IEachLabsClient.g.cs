
#nullable enable

namespace EachLabs
{
    /// <summary>
    /// Official each::labs API V1.<br/>
    /// This API provides access to our comprehensive AI model catalog and other resources.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IEachLabsClient : global::System.IDisposable
    {
        /// <summary>
        /// The HttpClient instance.
        /// </summary>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <summary>
        /// The base URL for the API.
        /// </summary>
        public System.Uri? BaseUri { get; }

        /// <summary>
        /// The authorizations to use for the requests.
        /// </summary>
        public global::System.Collections.Generic.List<global::EachLabs.EndPointAuthorization> Authorizations { get; }

        /// <summary>
        /// Gets or sets a value indicating whether the response content should be read as a string.
        /// True by default in debug builds, false otherwise.
        /// When false, successful responses are deserialized directly from the response stream for better performance.
        /// Error responses are always read as strings regardless of this setting,
        /// ensuring <see cref="ApiException.ResponseBody"/> is populated.
        /// </summary>
        public bool ReadResponseAsString { get; set; }
        /// <summary>
        /// Client-wide request defaults such as headers, query parameters, retries, and timeout.
        /// </summary>
        public global::EachLabs.AutoSDKClientOptions Options { get; }


        /// <summary>
        ///
        /// </summary>
        global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; }


        /// <summary>
        /// Endpoints for listing and retrieving AI models and other resources.
        /// </summary>
        public AiModelsClient AiModels { get; }

        /// <summary>
        /// Endpoints for managing model predictions.
        /// </summary>
        public AiModelsPredictionClient AiModelsPrediction { get; }

        /// <summary>
        /// Endpoints for retrieving webhook information and delivery history.<br/>
        /// **Note:** Currently, webhooks are only supported for Workflows V2. We are actively expanding webhook support to other services and will update this documentation as new integrations become available.
        /// </summary>
        public WebhooksClient Webhooks { get; }

    }
}