using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class SignatureHelpRegistrationOptions : TextDocumentRegistrationOptions
    {
        public SignatureHelpRegistrationOptions() { }
    }
}
