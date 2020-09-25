using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class TextDocumentSaveRegistrationOptions : TextDocumentRegistrationOptions
    {
        public TextDocumentSaveRegistrationOptions() { }

        /**
         * The client is supposed to include the content on save.
         */
        [DataMember(Name = "includeText")]
        public bool IncludeText { get; set; }
    }
}
