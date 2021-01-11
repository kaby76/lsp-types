using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class SemanticTokensParams : WorkDoneProgressParams, IPartialResultParams
    {
        public SemanticTokensParams() : base() { }

        /**
	     * The text document.
	     */
        [DataMember(Name = "textDocument")]
        [JsonProperty(Required = Required.Default)]
        public TextDocumentIdentifier TextDocument { get; set; }

        [DataMember(Name = "partialResultToken")]
        [JsonProperty(Required = Required.Default, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public SumType<int, string> PartialResultToken { get; set; }
    }
}
