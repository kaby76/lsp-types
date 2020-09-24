using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class CodeLensParams : WorkDoneProgressParams, PartialResultParams
    {
        public CodeLensParams() { }

        /**
         * The document to request code lens for.
         */
        [DataMember(Name = "textDocument")]
        public TextDocumentIdentifier TextDocument { get; set; }
    }
}
