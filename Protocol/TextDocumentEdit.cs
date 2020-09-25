using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class TextDocumentEdit
    {
        public TextDocumentEdit() { }

        /**
         * The text document to change.
         */
        [DataMember(Name = "textDocument")]
        [JsonProperty(Required = Required.Always)]
        public VersionedTextDocumentIdentifier TextDocument { get; set; }

        /**
         * The edits to be applied.
         */
        [DataMember(Name = "edits")]
        [JsonProperty(Required = Required.Always)]
        public TextEdit[] Edits { get; set; }
    }
}
