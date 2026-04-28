
#nullable enable

namespace EachLabs
{
    /// <summary>
    /// Current status of the prediction<br/>
    /// Example: success
    /// </summary>
    public enum PredictionStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Cancelled,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Processing,
        /// <summary>
        /// 
        /// </summary>
        Starting,
        /// <summary>
        /// 
        /// </summary>
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PredictionStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PredictionStatus value)
        {
            return value switch
            {
                PredictionStatus.Cancelled => "cancelled",
                PredictionStatus.Failed => "failed",
                PredictionStatus.Processing => "processing",
                PredictionStatus.Starting => "starting",
                PredictionStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PredictionStatus? ToEnum(string value)
        {
            return value switch
            {
                "cancelled" => PredictionStatus.Cancelled,
                "failed" => PredictionStatus.Failed,
                "processing" => PredictionStatus.Processing,
                "starting" => PredictionStatus.Starting,
                "success" => PredictionStatus.Success,
                _ => null,
            };
        }
    }
}