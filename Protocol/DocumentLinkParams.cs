using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class DocumentLinkParams : WorkDoneProgressParams, PartialResultParams
    {
        public DocumentLinkParams() { }

        /**
         * The document to provide document links for.
         */
        [DataMember(Name = "textDocument")]
        [JsonProperty(Required = Required.Always)]
        public TextDocumentIdentifier TextDocument { get; set; }
    }
}
