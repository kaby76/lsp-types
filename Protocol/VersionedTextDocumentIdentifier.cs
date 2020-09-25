using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class VersionedTextDocumentIdentifier : TextDocumentIdentifier
    {
        public VersionedTextDocumentIdentifier() { }

        /**
         * The version number of this document. If a versioned text document identifier
         * is sent from the server to the client and the file is not open in the editor
         * (the server has not received an open notification before) the server can send
         * `null` to indicate that the version is known and the content on disk is the
         * master (as speced with document content ownership).
         *
         * The version number of a document will increase after each change, including
         * undo/redo. The number doesn't need to be consecutive.
         */
        [DataMember(Name = "version")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? Version { get; set; }
    }
}
