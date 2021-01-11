using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class LinkedEditingRangeParams : TextDocumentPositionParams, IWorkDoneProgressParams
    {
        public LinkedEditingRangeParams() { }

        [DataMember(Name = "workDoneToken")]
        [JsonProperty(Required = Required.Default, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public SumType<string, int> WorkDoneToken { get; set; }
    }
}
