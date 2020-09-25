using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class DocumentRangeFormattingOptions : WorkDoneProgressOptions
    {
        public DocumentRangeFormattingOptions() { }
    }
}
