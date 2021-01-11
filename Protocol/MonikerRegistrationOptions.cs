using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class MonikerRegistrationOptions : TextDocumentRegistrationOptions, IMonikerOptions
    {
        public MonikerRegistrationOptions() : base() { }

        [DataMember(Name = "workDoneProgress")]
        [JsonProperty(Required = Required.Default)]
        public bool? WorkDoneProgress { get; set; }
    }
}
