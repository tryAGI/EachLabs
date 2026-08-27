
#nullable enable

namespace EachLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class Prediction
    {
        /// <summary>
        /// Unique prediction identifier<br/>
        /// Example: abc123-def456-ghi789
        /// </summary>
        /// <example>abc123-def456-ghi789</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Input parameters used for the prediction<br/>
        /// Example: {"prompt":"A beautiful sunset over the ocean with vibrant colors","aspect_ratio":"16:9"}
        /// </summary>
        /// <example>{"prompt":"A beautiful sunset over the ocean with vibrant colors","aspect_ratio":"16:9"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        public object? Input { get; set; }

        /// <summary>
        /// Current status of the prediction<br/>
        /// Example: success
        /// </summary>
        /// <example>success</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::EachLabs.JsonConverters.PredictionStatusJsonConverter))]
        public global::EachLabs.PredictionStatus? Status { get; set; }

        /// <summary>
        /// Prediction output (type varies based on model)<br/>
        /// Example: https://storage.example.com/predictions/abc123/image.jpg
        /// </summary>
        /// <example>https://storage.example.com/predictions/abc123/image.jpg</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::EachLabs.JsonConverters.OneOfJsonConverter<string, byte[], object>))]
        public global::EachLabs.OneOf<string, byte[], object>? Output { get; set; }

        /// <summary>
        /// Execution logs from the prediction<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        /// <example>openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("logs")]
        public string? Logs { get; set; }

        /// <summary>
        /// Performance and cost metrics
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metrics")]
        public global::EachLabs.PredictionMetrics? Metrics { get; set; }

        /// <summary>
        /// Related API endpoints
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("urls")]
        public global::EachLabs.PredictionUrls? Urls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Prediction" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique prediction identifier<br/>
        /// Example: abc123-def456-ghi789
        /// </param>
        /// <param name="input">
        /// Input parameters used for the prediction<br/>
        /// Example: {"prompt":"A beautiful sunset over the ocean with vibrant colors","aspect_ratio":"16:9"}
        /// </param>
        /// <param name="status">
        /// Current status of the prediction<br/>
        /// Example: success
        /// </param>
        /// <param name="output">
        /// Prediction output (type varies based on model)<br/>
        /// Example: https://storage.example.com/predictions/abc123/image.jpg
        /// </param>
        /// <param name="logs">
        /// Execution logs from the prediction<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="metrics">
        /// Performance and cost metrics
        /// </param>
        /// <param name="urls">
        /// Related API endpoints
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Prediction(
            string? id,
            object? input,
            global::EachLabs.PredictionStatus? status,
            global::EachLabs.OneOf<string, byte[], object>? output,
            string? logs,
            global::EachLabs.PredictionMetrics? metrics,
            global::EachLabs.PredictionUrls? urls)
        {
            this.Id = id;
            this.Input = input;
            this.Status = status;
            this.Output = output;
            this.Logs = logs;
            this.Metrics = metrics;
            this.Urls = urls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Prediction" /> class.
        /// </summary>
        public Prediction()
        {
        }

    }
}