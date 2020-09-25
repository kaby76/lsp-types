using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class TextDocumentPositionParams
    {
        public TextDocumentPositionParams() { }

        /**
         * The text document.
         */
        [DataMember(Name = "textDocument")]
        [JsonProperty(Required = Required.Always)]
        public TextDocumentIdentifier TextDocument { get; set; }

        /**
         * The position inside the text document.
         */
        [DataMember(Name = "position")]
        [JsonProperty(Required = Required.Always)]
        public Position Position { get; set; }
    }
}
