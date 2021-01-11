using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class DocumentFormattingOptions : WorkDoneProgressOptions, IDocumentFormattingOptions
    {
        public DocumentFormattingOptions() { }
    }

    public interface IDocumentFormattingOptions : IWorkDoneProgressOptions
    {
    }
}
