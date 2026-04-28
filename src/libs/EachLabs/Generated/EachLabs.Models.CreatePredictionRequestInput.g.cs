
#nullable enable

namespace EachLabs
{
    /// <summary>
    /// Input parameters for the prediction<br/>
    /// Example: {"prompt":"A beautiful sunset over the ocean with vibrant colors","aspect_ratio":"16:9"}
    /// </summary>
    public sealed partial class CreatePredictionRequestInput
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}