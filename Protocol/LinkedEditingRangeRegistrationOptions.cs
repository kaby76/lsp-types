using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class LinkedEditingRangeRegistrationOptions : TextDocumentRegistrationOptions, ILinkedEditingRangeOptions, IStaticRegistrationOptions
    {
        public LinkedEditingRangeRegistrationOptions() { }

        [DataMember(Name = "workDoneProgress")]
        [JsonProperty(Required = Required.Default)]
        public bool? WorkDoneProgress { get; set; }

        [DataMember(Name = "id")]
        [JsonProperty(Required = Required.Default)]
        public string Id { get; set; }
    }
}
