using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class DocumentFormattingOptions : WorkDoneProgressOptions 
    {
        public DocumentFormattingOptions() { }
    }
}
