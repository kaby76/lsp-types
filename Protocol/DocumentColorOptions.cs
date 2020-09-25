using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    public interface IDocumentColorOptions : IWorkDoneProgressOptions
    { }

    [DataContract]
    public class DocumentColorOptions : WorkDoneProgressOptions, IDocumentColorOptions
    {
        public DocumentColorOptions() { }
    }
}