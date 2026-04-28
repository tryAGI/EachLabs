
#nullable enable

namespace EachLabs
{
    /// <summary>
    /// Performance and cost metrics
    /// </summary>
    public sealed partial class PredictionMetrics
    {
        /// <summary>
        /// Time taken for prediction in seconds<br/>
        /// Example: 12.5
        /// </summary>
        /// <example>12.5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("predict_time")]
        public double? PredictTime { get; set; }

        /// <summary>
        /// Cost of the prediction in USD<br/>
        /// Example: 0.05
        /// </summary>
        /// <example>0.05</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost")]
        public double? Cost { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PredictionMetrics" /> class.
        /// </summary>
        /// <param name="predictTime">
        /// Time taken for prediction in seconds<br/>
        /// Example: 12.5
        /// </param>
        /// <param name="cost">
        /// Cost of the prediction in USD<br/>
        /// Example: 0.05
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PredictionMetrics(
            double? predictTime,
            double? cost)
        {
            this.PredictTime = predictTime;
            this.Cost = cost;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PredictionMetrics" /> class.
        /// </summary>
        public PredictionMetrics()
        {
        }
    }
}