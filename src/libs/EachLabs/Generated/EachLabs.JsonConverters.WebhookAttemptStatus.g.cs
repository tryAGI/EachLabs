#nullable enable

namespace EachLabs.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookAttemptStatusJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::EachLabs.WebhookAttemptStatus>
    {
        /// <inheritdoc />
        public override global::EachLabs.WebhookAttemptStatus Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::EachLabs.WebhookAttemptStatusExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::EachLabs.WebhookAttemptStatus)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::EachLabs.WebhookAttemptStatus);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::EachLabs.WebhookAttemptStatus value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::EachLabs.WebhookAttemptStatusExtensions.ToValueString(value));
        }
    }
}
