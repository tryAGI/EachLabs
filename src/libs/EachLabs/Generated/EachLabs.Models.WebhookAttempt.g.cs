
#nullable enable

namespace EachLabs
{
    /// <summary>
    /// Individual webhook delivery attempt
    /// </summary>
    public sealed partial class WebhookAttempt
    {
        /// <summary>
        /// Status of the delivery attempt<br/>
        /// Example: SUCCESS
        /// </summary>
        /// <example>SUCCESS</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::EachLabs.JsonConverters.WebhookAttemptStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::EachLabs.WebhookAttemptStatus Status { get; set; }

        /// <summary>
        /// HTTP status code from target URL<br/>
        /// Example: 200
        /// </summary>
        /// <example>200</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status_code")]
        public int? StatusCode { get; set; }

        /// <summary>
        /// Response body from target URL<br/>
        /// Example: {"received":true}
        /// </summary>
        /// <example>{"received":true}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("response")]
        public string? Response { get; set; }

        /// <summary>
        /// Error message if delivery failed<br/>
        /// Example: connection timeout
        /// </summary>
        /// <example>connection timeout</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// When the attempt was made<br/>
        /// Example: 2025-12-14T10:30:05Z
        /// </summary>
        /// <example>2025-12-14T10:30:05Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookAttempt" /> class.
        /// </summary>
        /// <param name="status">
        /// Status of the delivery attempt<br/>
        /// Example: SUCCESS
        /// </param>
        /// <param name="createdAt">
        /// When the attempt was made<br/>
        /// Example: 2025-12-14T10:30:05Z
        /// </param>
        /// <param name="statusCode">
        /// HTTP status code from target URL<br/>
        /// Example: 200
        /// </param>
        /// <param name="response">
        /// Response body from target URL<br/>
        /// Example: {"received":true}
        /// </param>
        /// <param name="errorMessage">
        /// Error message if delivery failed<br/>
        /// Example: connection timeout
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookAttempt(
            global::EachLabs.WebhookAttemptStatus status,
            global::System.DateTime createdAt,
            int? statusCode,
            string? response,
            string? errorMessage)
        {
            this.Status = status;
            this.StatusCode = statusCode;
            this.Response = response;
            this.ErrorMessage = errorMessage;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookAttempt" /> class.
        /// </summary>
        public WebhookAttempt()
        {
        }
    }
}