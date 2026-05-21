
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace EachLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreatePredictionRequest
    {
        /// <summary>
        /// Model slug or identifier<br/>
        /// Example: flux-1-1-pro
        /// </summary>
        /// <example>flux-1-1-pro</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Deprecated. This field is ignored. Kept for backwards compatibility.<br/>
        /// Example: 0.0.1
        /// </summary>
        /// <example>0.0.1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? Version { get; set; }

        /// <summary>
        /// Input parameters for the prediction<br/>
        /// Example: {"prompt":"A beautiful sunset over the ocean with vibrant colors","aspect_ratio":"16:9"}
        /// </summary>
        /// <example>{"prompt":"A beautiful sunset over the ocean with vibrant colors","aspect_ratio":"16:9"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Input { get; set; }

        /// <summary>
        /// Optional webhook URL to receive prediction result asynchronously<br/>
        /// Example: https://your-app.com/webhook
        /// </summary>
        /// <example>https://your-app.com/webhook</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_url")]
        public string? WebhookUrl { get; set; }

        /// <summary>
        /// Optional secret used to sign webhook requests<br/>
        /// Example: your-secret-key
        /// </summary>
        /// <example>your-secret-key</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_secret")]
        public string? WebhookSecret { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePredictionRequest" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreatePredictionRequest(
            string model,
            object input,
            string? webhookUrl,
            string? webhookSecret)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
            this.WebhookUrl = webhookUrl;
            this.WebhookSecret = webhookSecret;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePredictionRequest" /> class.
        /// </summary>
        public CreatePredictionRequest()
        {
        }

    }
}