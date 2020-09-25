using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class TextDocumentChangeRegistrationOptions : TextDocumentRegistrationOptions
    {
        public TextDocumentChangeRegistrationOptions() { }

        /**
         * How documents are synced to the server. See TextDocumentSyncKind.Full
         * and TextDocumentSyncKind.Incremental.
         */
        [DataMember(Name = "syncKind")]
        public TextDocumentSyncKind SyncKind { get; set; }
    }
}
