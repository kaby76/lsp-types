using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class DidCloseTextDocumentParams
    {
        public DidCloseTextDocumentParams() { }

        /**
         * The document that was closed.
         */
        [DataMember(Name = "textDocument")]
        [JsonProperty(Required = Required.Always)]
        public TextDocumentIdentifier TextDocument { get; set; }
    }
}
