using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class DocumentSymbolParams : WorkDoneProgressParams, IPartialResultParams
    {
        public DocumentSymbolParams() { }

        /**
         * The text document.
         */
        [DataMember(Name = "textDocument")]
        [JsonProperty(Required = Required.Always)]
        public TextDocumentIdentifier TextDocument { get; set; }

        /**
         * An optional token that a server can use to report partial results (e.g. streaming) to
         * the client.
         */
        [DataMember(Name = "partialResultToken")]
        [JsonProperty(Required = Required.Default)]
        public SumType<int, string> PartialResultToken { get; set; }
    }
}
