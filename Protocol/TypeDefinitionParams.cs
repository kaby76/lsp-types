using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class TypeDefinitionParams : TextDocumentPositionParams, IWorkDoneProgressParams, IPartialResultParams
    {
        public TypeDefinitionParams() : base() { }

        [DataMember(Name = "workDoneToken")]
        [JsonProperty(Required = Required.Default, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public SumType<string, int> WorkDoneToken { get; set; }

        [DataMember(Name = "partialResultToken")]
        [JsonProperty(Required = Required.Default, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public SumType<int, string> PartialResultToken { get; set; }
    }
}
