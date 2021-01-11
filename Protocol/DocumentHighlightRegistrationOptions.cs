using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class DocumentHighlightRegistrationOptions : TextDocumentRegistrationOptions, IDocumentHighlightOptions
    {
        public DocumentHighlightRegistrationOptions() : base() { }

        [DataMember(Name = "workDoneProgress")]
        [JsonProperty(Required = Required.Default)]
        public bool? WorkDoneProgress { get; set; }
    }
}
