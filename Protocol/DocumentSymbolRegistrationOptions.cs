using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class DocumentSymbolRegistrationOptions : TextDocumentRegistrationOptions, IDocumentSymbolOptions
    {
        public DocumentSymbolRegistrationOptions() : base() { }

        [DataMember(Name = "label")]
        [JsonProperty(Required = Required.Default)]
        public string Label { get; set; }

        [DataMember(Name = "workDoneProgress")]
        [JsonProperty(Required = Required.Default)]
        public bool? WorkDoneProgress { get; set; }
    }
}
