#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace EachLabs
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct WebhookWithAttempts : global::System.IEquatable<WebhookWithAttempts>
    {
        /// <summary>
        /// Webhook information without attempts
        /// </summary>
#if NET6_0_OR_GREATER
        public global::EachLabs.Webhook? Webhook { get; init; }
#else
        public global::EachLabs.Webhook? Webhook { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Webhook))]
#endif
        public bool IsWebhook => Webhook != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickWebhook(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::EachLabs.Webhook? value)
        {
            value = Webhook;
            return IsWebhook;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::EachLabs.WebhookWithAttemptsVariant2? WebhookWithAttemptsVariant2 { get; init; }
#else
        public global::EachLabs.WebhookWithAttemptsVariant2? WebhookWithAttemptsVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebhookWithAttemptsVariant2))]
#endif
        public bool IsWebhookWithAttemptsVariant2 => WebhookWithAttemptsVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickWebhookWithAttemptsVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::EachLabs.WebhookWithAttemptsVariant2? value)
        {
            value = WebhookWithAttemptsVariant2;
            return IsWebhookWithAttemptsVariant2;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WebhookWithAttempts(global::EachLabs.Webhook value) => new WebhookWithAttempts((global::EachLabs.Webhook?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::EachLabs.Webhook?(WebhookWithAttempts @this) => @this.Webhook;

        /// <summary>
        /// 
        /// </summary>
        public WebhookWithAttempts(global::EachLabs.Webhook? value)
        {
            Webhook = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static WebhookWithAttempts FromWebhook(global::EachLabs.Webhook? value) => new WebhookWithAttempts(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WebhookWithAttempts(global::EachLabs.WebhookWithAttemptsVariant2 value) => new WebhookWithAttempts((global::EachLabs.WebhookWithAttemptsVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::EachLabs.WebhookWithAttemptsVariant2?(WebhookWithAttempts @this) => @this.WebhookWithAttemptsVariant2;

        /// <summary>
        /// 
        /// </summary>
        public WebhookWithAttempts(global::EachLabs.WebhookWithAttemptsVariant2? value)
        {
            WebhookWithAttemptsVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static WebhookWithAttempts FromWebhookWithAttemptsVariant2(global::EachLabs.WebhookWithAttemptsVariant2? value) => new WebhookWithAttempts(value);

        /// <summary>
        /// 
        /// </summary>
        public WebhookWithAttempts(
            global::EachLabs.Webhook? webhook,
            global::EachLabs.WebhookWithAttemptsVariant2? webhookWithAttemptsVariant2
            )
        {
            Webhook = webhook;
            WebhookWithAttemptsVariant2 = webhookWithAttemptsVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            WebhookWithAttemptsVariant2 as object ??
            Webhook as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Webhook?.ToString() ??
            WebhookWithAttemptsVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsWebhook && IsWebhookWithAttemptsVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::EachLabs.Webhook, TResult>? webhook = null,
            global::System.Func<global::EachLabs.WebhookWithAttemptsVariant2, TResult>? webhookWithAttemptsVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsWebhook && webhook != null)
            {
                return webhook(Webhook!);
            }
            else if (IsWebhookWithAttemptsVariant2 && webhookWithAttemptsVariant2 != null)
            {
                return webhookWithAttemptsVariant2(WebhookWithAttemptsVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::EachLabs.Webhook>? webhook = null,

            global::System.Action<global::EachLabs.WebhookWithAttemptsVariant2>? webhookWithAttemptsVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsWebhook)
            {
                webhook?.Invoke(Webhook!);
            }
            else if (IsWebhookWithAttemptsVariant2)
            {
                webhookWithAttemptsVariant2?.Invoke(WebhookWithAttemptsVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::EachLabs.Webhook>? webhook = null,
            global::System.Action<global::EachLabs.WebhookWithAttemptsVariant2>? webhookWithAttemptsVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsWebhook)
            {
                webhook?.Invoke(Webhook!);
            }
            else if (IsWebhookWithAttemptsVariant2)
            {
                webhookWithAttemptsVariant2?.Invoke(WebhookWithAttemptsVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Webhook,
                typeof(global::EachLabs.Webhook),
                WebhookWithAttemptsVariant2,
                typeof(global::EachLabs.WebhookWithAttemptsVariant2),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(WebhookWithAttempts other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::EachLabs.Webhook?>.Default.Equals(Webhook, other.Webhook) &&
                global::System.Collections.Generic.EqualityComparer<global::EachLabs.WebhookWithAttemptsVariant2?>.Default.Equals(WebhookWithAttemptsVariant2, other.WebhookWithAttemptsVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(WebhookWithAttempts obj1, WebhookWithAttempts obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<WebhookWithAttempts>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(WebhookWithAttempts obj1, WebhookWithAttempts obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is WebhookWithAttempts o && Equals(o);
        }
    }
}
