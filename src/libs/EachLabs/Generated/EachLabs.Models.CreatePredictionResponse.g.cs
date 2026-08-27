
#nullable enable

namespace EachLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreatePredictionResponse
    {
        /// <summary>
        /// Status of the prediction creation request<br/>
        /// Example: success
        /// </summary>
        /// <example>success</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Human-readable message about the prediction creation<br/>
        /// Example: Prediction created successfully
        /// </summary>
        /// <example>Prediction created successfully</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Unique prediction identifier<br/>
        /// Example: abc123-def456-ghi789
        /// </summary>
        /// <example>abc123-def456-ghi789</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("predictionID")]
        public string? PredictionID { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePredictionResponse" /> class.
        /// </summary>
        /// <param name="status">
        /// Status of the prediction creation request<br/>
        /// Example: success
        /// </param>
        /// <param name="message">
        /// Human-readable message about the prediction creation<br/>
        /// Example: Prediction created successfully
        /// </param>
        /// <param name="predictionID">
        /// Unique prediction identifier<br/>
        /// Example: abc123-def456-ghi789
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreatePredictionResponse(
            string? status,
            string? message,
            string? predictionID)
        {
            this.Status = status;
            this.Message = message;
            this.PredictionID = predictionID;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePredictionResponse" /> class.
        /// </summary>
        public CreatePredictionResponse()
        {
        }

    }
}