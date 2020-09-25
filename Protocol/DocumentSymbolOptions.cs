using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class DocumentSymbolOptions : WorkDoneProgressOptions
    {
        public DocumentSymbolOptions() { }
    }
}