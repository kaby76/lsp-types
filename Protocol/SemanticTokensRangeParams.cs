using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class SemanticTokensRangeParams : WorkDoneProgressParams, IPartialResultParams
    {
        public SemanticTokensRangeParams() : base() { }

        /**
	     * The text document.
	     */
        [DataMember(Name = "textDocument")]
        [JsonProperty(Required = Required.Default, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public TextDocumentIdentifier TextDocument { get; set; }

        /**
         * The range the semantic tokens are requested for.
         */
        [DataMember(Name = "range")]
        [JsonProperty(Required = Required.Default, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Range Range { get; set; }

        [DataMember(Name = "partialResultToken")]
        [JsonProperty(Required = Required.Default, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public SumType<int, string> PartialResultToken { get; set; }
    }
}
