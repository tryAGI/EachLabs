
#nullable enable

namespace EachLabs
{
    /// <summary>
    /// Related API endpoints
    /// </summary>
    public sealed partial class PredictionUrls
    {
        /// <summary>
        /// URL to cancel the prediction<br/>
        /// Example: https://api.eachlabs.ai/v1/prediction/abc123-def456-ghi789/cancel
        /// </summary>
        /// <example>https://api.eachlabs.ai/v1/prediction/abc123-def456-ghi789/cancel</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("cancel")]
        public string? Cancel { get; set; }

        /// <summary>
        /// URL to get the prediction<br/>
        /// Example: https://api.eachlabs.ai/v1/prediction/abc123-def456-ghi789
        /// </summary>
        /// <example>https://api.eachlabs.ai/v1/prediction/abc123-def456-ghi789</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("get")]
        public string? Get { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PredictionUrls" /> class.
        /// </summary>
        /// <param name="cancel">
        /// URL to cancel the prediction<br/>
        /// Example: https://api.eachlabs.ai/v1/prediction/abc123-def456-ghi789/cancel
        /// </param>
        /// <param name="get">
        /// URL to get the prediction<br/>
        /// Example: https://api.eachlabs.ai/v1/prediction/abc123-def456-ghi789
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PredictionUrls(
            string? cancel,
            string? get)
        {
            this.Cancel = cancel;
            this.Get = get;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PredictionUrls" /> class.
        /// </summary>
        public PredictionUrls()
        {
        }

    }
}