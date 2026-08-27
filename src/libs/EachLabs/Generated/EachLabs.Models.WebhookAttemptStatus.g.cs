
#nullable enable

namespace EachLabs
{
    /// <summary>
    /// Status of the delivery attempt<br/>
    /// Example: SUCCESS
    /// </summary>
    public enum WebhookAttemptStatus
    {
        /// <summary>
        ///
        /// </summary>
        Failed,
        /// <summary>
        ///
        /// </summary>
        Pending,
        /// <summary>
        ///
        /// </summary>
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookAttemptStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookAttemptStatus value)
        {
            return value switch
            {
                WebhookAttemptStatus.Failed => "FAILED",
                WebhookAttemptStatus.Pending => "PENDING",
                WebhookAttemptStatus.Success => "SUCCESS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookAttemptStatus? ToEnum(string value)
        {
            return value switch
            {
                "FAILED" => WebhookAttemptStatus.Failed,
                "PENDING" => WebhookAttemptStatus.Pending,
                "SUCCESS" => WebhookAttemptStatus.Success,
                _ => null,
            };
        }
    }
}