using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class DefinitionOptions : WorkDoneProgressOptions, ITextDocumentRegistrationOptions, IStaticRegistrationOptions
    {
        public DefinitionOptions() { }

        [DataMember(Name = "documentSelector")]
        [JsonProperty(Required = Required.Always)]
        public DocumentFilter[] DocumentSelector { get; set; }

        [DataMember(Name = "id")]
        [JsonProperty(Required = Required.Default)]
        public string Id { get; set; }
    }
}