
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace EachLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Model
    {
        /// <summary>
        /// Example: Nano Banana Pro Edit
        /// </summary>
        /// <example>Nano Banana Pro Edit</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Example: nano-banana-pro-edit
        /// </summary>
        /// <example>nano-banana-pro-edit</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        public string? Slug { get; set; }

        /// <summary>
        /// Deprecated. Always returns "0.0.1". Will be removed in a future version.<br/>
        /// Example: 0.0.1
        /// </summary>
        /// <example>0.0.1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? Version { get; set; }

        /// <summary>
        /// Example: array
        /// </summary>
        /// <example>array</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_type")]
        public string? OutputType { get; set; }

        /// <summary>
        /// JSON Schema for API requests to this model.<br/>
        /// Defines the structure, types, and validation rules for making requests.<br/>
        /// Example: {"type":"object","required":["prompt"],"properties":{"prompt":{"type":"string","minLength":10,"maxLength":500},"num_images":{"type":"integer","minimum":1,"maximum":4,"default":1}}}
        /// </summary>
        /// <example>{"type":"object","required":["prompt"],"properties":{"prompt":{"type":"string","minLength":10,"maxLength":500},"num_images":{"type":"integer","minimum":1,"maximum":4,"default":1}}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_schema")]
        public object? RequestSchema { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Model" /> class.
        /// </summary>
        /// <param name="title">
        /// Example: Nano Banana Pro Edit
        /// </param>
        /// <param name="slug">
        /// Example: nano-banana-pro-edit
        /// </param>
        /// <param name="outputType">
        /// Example: array
        /// </param>
        /// <param name="requestSchema">
        /// JSON Schema for API requests to this model.<br/>
        /// Defines the structure, types, and validation rules for making requests.<br/>
        /// Example: {"type":"object","required":["prompt"],"properties":{"prompt":{"type":"string","minLength":10,"maxLength":500},"num_images":{"type":"integer","minimum":1,"maximum":4,"default":1}}}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Model(
            string? title,
            string? slug,
            string? outputType,
            object? requestSchema)
        {
            this.Title = title;
            this.Slug = slug;
            this.OutputType = outputType;
            this.RequestSchema = requestSchema;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Model" /> class.
        /// </summary>
        public Model()
        {
        }
    }
}