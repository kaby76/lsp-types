using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class DidOpenTextDocumentParams
    {
        public DidOpenTextDocumentParams() { }

        /**
         * The document that was opened.
         */
        [DataMember(Name = "textDocument")]
        [JsonProperty(Required = Required.Always)]
        public TextDocumentItem TextDocument { get; set; }
    }
}
