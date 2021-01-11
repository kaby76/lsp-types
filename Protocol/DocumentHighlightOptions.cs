using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class DocumentHighlightOptions : WorkDoneProgressOptions
    {
        public DocumentHighlightOptions() { }
    }

    public interface IDocumentHighlightOptions : IWorkDoneProgressOptions
    {
    }

}