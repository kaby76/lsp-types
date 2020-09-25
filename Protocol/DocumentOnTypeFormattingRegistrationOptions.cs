using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class DocumentOnTypeFormattingRegistrationOptions : TextDocumentRegistrationOptions, DocumentOnTypeFormattingOptions
    {
        public DocumentOnTypeFormattingRegistrationOptions() { }
    }
}
