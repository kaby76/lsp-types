using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class DocumentSymbolParams : WorkDoneProgressParams, PartialResultParams
    {
        public DocumentSymbolParams() { }

        /**
         * The text document.
         */
        [DataMember(Name = "textDocument")]
        [JsonProperty(Required = Required.Always)]
        public TextDocumentIdentifier TextDocument { get; set; }
    }
}
