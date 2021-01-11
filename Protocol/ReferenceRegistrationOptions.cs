using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class ReferenceRegistrationOptions : TextDocumentRegistrationOptions, IReferenceOptions
    {
        public ReferenceRegistrationOptions() : base() { }

        [DataMember(Name = "workDoneProgress")]
        [JsonProperty(Required = Required.Default)]
        public bool? WorkDoneProgress { get; set; }
    }
}
