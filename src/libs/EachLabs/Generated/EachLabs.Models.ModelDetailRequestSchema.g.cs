
#nullable enable

namespace EachLabs
{
    /// <summary>
    /// JSON Schema for API requests to this model.<br/>
    /// Defines the structure, types, and validation rules for making requests.<br/>
    /// Example: {"type":"object","required":["prompt"],"properties":{"prompt":{"type":"string","minLength":10,"maxLength":500}}}
    /// </summary>
    public sealed partial class ModelDetailRequestSchema
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}