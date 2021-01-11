using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class SemanticTokensRegistrationOptions : TextDocumentRegistrationOptions, ISemanticTokensOptions, IStaticRegistrationOptions
    {
        [DataMember(Name = "legend")]
        public SemanticTokensLegend Legend { get; set; }

        [DataMember(Name = "range")]
        public SumType<bool, object> Range { get; set; }

        [DataMember(Name = "full")]
        public SumType<bool, object> Full { get; set; }

        [DataMember(Name = "id")]
        [JsonProperty(Required = Required.Default)]
        public string Id { get; set; }

        [DataMember(Name = "workDoneProgress")]
        [JsonProperty(Required = Required.Default)]
        public bool? WorkDoneProgress { get; set; }
    }
}
