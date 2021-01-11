using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class SemanticTokensPartialResult
    {
        public SemanticTokensPartialResult() { }

        [DataMember(Name = "data")]
        [JsonProperty(Required = Required.Default)]
        public uint[] Data { get; set; }
    }
}
