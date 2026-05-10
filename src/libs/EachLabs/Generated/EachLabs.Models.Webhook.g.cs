
#nullable enable

namespace EachLabs
{
    /// <summary>
    /// Webhook information without attempts
    /// </summary>
    public sealed partial class Webhook
    {
        /// <summary>
        /// Execution identifier for tracking<br/>
        /// Example: abc123-def456-ghi789
        /// </summary>
        /// <example>abc123-def456-ghi789</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("execution_id")]
        public string? ExecutionId { get; set; }

        /// <summary>
        /// Target URL for webhook delivery<br/>
        /// Example: https://api.example.com/webhook
        /// </summary>
        /// <example>https://api.example.com/webhook</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Original request payload<br/>
        /// Example: {"event":"prediction.completed"}
        /// </summary>
        /// <example>{"event":"prediction.completed"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("request")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Request { get; set; }

        /// <summary>
        /// Headers included in the webhook request<br/>
        /// Example: {"Content-Type":"application/json"}
        /// </summary>
        /// <example>{"Content-Type":"application/json"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? Headers { get; set; }

        /// <summary>
        /// Service that triggered the webhook<br/>
        /// Example: api-gateway
        /// </summary>
        /// <example>api-gateway</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Source { get; set; }

        /// <summary>
        /// When the webhook was created<br/>
        /// Example: 2025-12-14T10:30:00Z
        /// </summary>
        /// <example>2025-12-14T10:30:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Webhook" /> class.
        /// </summary>
        /// <param name="url">
        /// Target URL for webhook delivery<br/>
        /// Example: https://api.example.com/webhook
        /// </param>
        /// <param name="request">
        /// Original request payload<br/>
        /// Example: {"event":"prediction.completed"}
        /// </param>
        /// <param name="source">
        /// Service that triggered the webhook<br/>
        /// Example: api-gateway
        /// </param>
        /// <param name="createdAt">
        /// When the webhook was created<br/>
        /// Example: 2025-12-14T10:30:00Z
        /// </param>
        /// <param name="executionId">
        /// Execution identifier for tracking<br/>
        /// Example: abc123-def456-ghi789
        /// </param>
        /// <param name="headers">
        /// Headers included in the webhook request<br/>
        /// Example: {"Content-Type":"application/json"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Webhook(
            string url,
            string request,
            string source,
            global::System.DateTime createdAt,
            string? executionId,
            global::System.Collections.Generic.Dictionary<string, string>? headers)
        {
            this.ExecutionId = executionId;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Request = request ?? throw new global::System.ArgumentNullException(nameof(request));
            this.Headers = headers;
            this.Source = source ?? throw new global::System.ArgumentNullException(nameof(source));
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Webhook" /> class.
        /// </summary>
        public Webhook()
        {
        }

    }
}