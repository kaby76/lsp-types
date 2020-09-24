using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class CompletionRegistrationOptions : TextDocumentRegistrationOptions, CompletionOptions
    {
        public CompletionRegistrationOptions() { }
    }
}
