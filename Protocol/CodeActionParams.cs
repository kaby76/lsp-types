using System.Runtime.Serialization;

namespace LspTypes
{
    /**
     * Params for the CodeActionRequest
     */
    [DataContract]
    public class CodeActionParams : WorkDoneProgressParams, PartialResultParams
    {
        public CodeActionParams() { }

        /**
         * The document in which the command was invoked.
         */
        [DataMember(Name = "textDocument")]
        public TextDocumentIdentifier TextDocument { get; set; }

        /**
         * Context carrying additional information.
         */
        [DataMember(Name = "context")]
        public CodeActionContext Context { get; set; }

        /**
         * The range for which the command was invoked.
         */
        [DataMember(Name = "range")]
        public Range Range { get; set; }
    }
}
