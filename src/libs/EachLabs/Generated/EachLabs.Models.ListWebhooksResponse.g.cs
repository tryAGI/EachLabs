
#nullable enable

namespace EachLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListWebhooksResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhooks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::EachLabs.Webhook> Webhooks { get; set; }

        /// <summary>
        /// Applied limit<br/>
        /// Example: 50
        /// </summary>
        /// <example>50</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Limit { get; set; }

        /// <summary>
        /// Applied offset<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("offset")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Offset { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListWebhooksResponse" /> class.
        /// </summary>
        /// <param name="webhooks"></param>
        /// <param name="limit">
        /// Applied limit<br/>
        /// Example: 50
        /// </param>
        /// <param name="offset">
        /// Applied offset<br/>
        /// Example: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListWebhooksResponse(
            global::System.Collections.Generic.IList<global::EachLabs.Webhook> webhooks,
            int limit,
            int offset)
        {
            this.Webhooks = webhooks ?? throw new global::System.ArgumentNullException(nameof(webhooks));
            this.Limit = limit;
            this.Offset = offset;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListWebhooksResponse" /> class.
        /// </summary>
        public ListWebhooksResponse()
        {
        }

    }
}