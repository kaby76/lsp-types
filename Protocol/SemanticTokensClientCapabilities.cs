using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class SemanticTokensClientCapabilities
    {
        public SemanticTokensClientCapabilities() { }

        /**
         * Whether implementation supports dynamic registration. If this is set to
	     * `true` the client supports the new `(TextDocumentRegistrationOptions &
	     * StaticRegistrationOptions)` return value for the corresponding server
	     * capability as well.
         */
        [DataMember(Name = "dynamicRegistration")]
        [JsonProperty(Required = Required.Default)]
        public bool? DynamicRegistration { get; set; }

        /**
         * Which requests the client supports and might send to the server
	     * depending on the server's capability. Please note that clients might not
	     * show semantic tokens or degrade some of the user experience if a range
	     * or full request is advertised by the client but not provided by the
	     * server. If for example the client capability `requests.full` and
	     * `request.range` are both set to true but the server only provides a
	     * range provider the client might not render a minimap correctly or might
	     * even decide to not show any semantic tokens at all.
         */
        [DataMember(Name = "requests")]
        [JsonProperty(Required = Required.Default)]
        public _SemanticTokensClientCapabilities_Requests Requests { get; set; }

        /**
         * The token types that the client supports.
         */
        [DataMember(Name = "tokenTypes")]
        [JsonProperty(Required = Required.Default)]
        public string[] TokenTypes { get; set; }

        /**
         * The token modifiers that the client supports.
         */
        [DataMember(Name = "tokenModifiers")]
        [JsonProperty(Required = Required.Default)]
        public string[] TokenModifiers { get; set; }

        /**
         * The formats the clients supports.
         */
        [DataMember(Name = "formats")]
        [JsonProperty(Required = Required.Default)]
        public TokenFormat[] Formats { get; set; }

        /**
         * Whether the client supports tokens that can overlap each other.
         */
        [DataMember(Name = "overlappingTokenSupport")]
        [JsonProperty(Required = Required.Default)]
        public bool? OverlappingTokenSupport { get; set; }

        /**
	     * Whether the client supports tokens that can span multiple lines.
	     */
        [DataMember(Name = "multilineTokenSupport")]
        [JsonProperty(Required = Required.Default)]
        public bool? MultilineTokenSupport { get; set; }
    }
}
