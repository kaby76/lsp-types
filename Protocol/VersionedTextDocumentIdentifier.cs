using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class VersionedTextDocumentIdentifier : TextDocumentIdentifier
    {
        public VersionedTextDocumentIdentifier() { }

        /**
         * The version number of this document.
	     *
	     * The version number of a document will increase after each change,
	     * including undo/redo. The number doesn't need to be consecutive.
         */
        [DataMember(Name = "version")]
        [JsonProperty(Required = Required.Always)]
        public int Version { get; set; }
    }
}
