using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class DocumentLinkRegistrationOptions : TextDocumentRegistrationOptions, DocumentLinkOptions
    {
        public DocumentLinkRegistrationOptions() { }
    }
}
