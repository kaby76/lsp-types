using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class DocumentFormattingRegistrationOptions : TextDocumentRegistrationOptions, IDocumentFormattingOptions
    {
        public DocumentFormattingRegistrationOptions() : base() { }

        [DataMember(Name = "workDoneProgress")]
        [JsonProperty(Required = Required.Default)]
        public bool? WorkDoneProgress { get; set; }
    }
}
