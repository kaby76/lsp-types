using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class CodeLensRegistrationOptions : TextDocumentRegistrationOptions, CodeLensOptions
    {
        public CodeLensRegistrationOptions() { }
    }
}
