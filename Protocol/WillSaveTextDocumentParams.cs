using System.Runtime.Serialization;

namespace LspTypes
{
    /**
     * The parameters send in a will save text document notification.
     */
    [DataContract]
    public class WillSaveTextDocumentParams
    {
        public WillSaveTextDocumentParams() { }

        /**
         * The document that will be saved.
         */
        [DataMember(Name = "textDocument")]
        public TextDocumentIdentifier TextDocument { get; set; }

        /**
         * The 'TextDocumentSaveReason'.
         */
        [DataMember(Name = "reason")]
        public TextDocumentSaveReason Reason { get; set; }
    }
}
