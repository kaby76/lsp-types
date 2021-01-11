using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class CallHierarchyPrepareParams : TextDocumentPositionParams, IWorkDoneProgressParams
    {
        public CallHierarchyPrepareParams() { }

        [DataMember(Name = "workDoneToken")]
        [JsonProperty(Required = Required.Default, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public SumType<string, int> WorkDoneToken { get; set; }

    }
}
