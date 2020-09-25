using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace LspTypes
{
    /**
     * Describes the content type that a client supports in various
     * result literals like `Hover`, `ParameterInfo` or `CompletionItem`.
     *
     * Please note that `MarkupKinds` must not start with a `$`. This kinds
     * are reserved for internal usage.
     */
    [DataContract]
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MarkupKind
    {
        /**
         * Plain text is supported as a content format
         */
        [EnumMember(Value = "plaintext")]
        PlainText = 0,

        /**
         * Markdown is supported as a content format
         */
        [EnumMember(Value = "markdown")]
        Markdown = 1,
    }
}
