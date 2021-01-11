using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class SemanticTokensDeltaPartialResult
    {
        public SemanticTokensDeltaPartialResult() { }

        [DataMember(Name = "edits")]
        [JsonProperty(Required = Required.Default)]
        public SemanticTokensEdit[] Edits { get; set; }
    }
}
