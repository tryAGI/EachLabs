
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace EachLabs
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::EachLabs.JsonConverters.PredictionStatusJsonConverter),

            typeof(global::EachLabs.JsonConverters.PredictionStatusNullableJsonConverter),

            typeof(global::EachLabs.JsonConverters.WebhookAttemptStatusJsonConverter),

            typeof(global::EachLabs.JsonConverters.WebhookAttemptStatusNullableJsonConverter),

            typeof(global::EachLabs.JsonConverters.WebhookWithAttemptsJsonConverter),

            typeof(global::EachLabs.JsonConverters.OneOfJsonConverter<string, byte[], object>),

            typeof(global::EachLabs.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EachLabs.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EachLabs.Model))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EachLabs.ModelDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EachLabs.Error))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EachLabs.CreatePredictionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EachLabs.CreatePredictionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EachLabs.Prediction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EachLabs.PredictionStatus), TypeInfoPropertyName = "PredictionStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EachLabs.OneOf<string, byte[], object>), TypeInfoPropertyName = "OneOfStringByteArrayObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EachLabs.PredictionMetrics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EachLabs.PredictionUrls))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EachLabs.Webhook))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EachLabs.WebhookWithAttempts), TypeInfoPropertyName = "WebhookWithAttempts2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EachLabs.WebhookWithAttemptsVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::EachLabs.WebhookAttempt>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EachLabs.WebhookAttempt))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EachLabs.WebhookAttemptStatus), TypeInfoPropertyName = "WebhookAttemptStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EachLabs.ListWebhooksResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::EachLabs.Webhook>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::EachLabs.Model>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::EachLabs.WebhookAttempt>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::EachLabs.Webhook>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::EachLabs.Model>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}