using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class RenameRegistrationOptions : TextDocumentRegistrationOptions, IRenameOptions
    {
        public RenameRegistrationOptions() : base() { }

        [DataMember(Name = "prepareProvider")]
        [JsonProperty(Required = Required.Default)]
        public bool? PrepareProvider { get; set; }

        [DataMember(Name = "workDoneProgress")]
        [JsonProperty(Required = Required.Default)]
        public bool? WorkDoneProgress { get; set; }
    }
}
