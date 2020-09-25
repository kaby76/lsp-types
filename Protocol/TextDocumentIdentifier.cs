using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LspTypes
{
    [DataContract]
    public class TextDocumentIdentifier
    {
        public TextDocumentIdentifier() { }

        /**
         * The text document's URI.
         */
        [DataMember(Name = "uri")]
        [JsonProperty(Required = Required.Always)]
        public string Uri { get; set; }
    }
}
