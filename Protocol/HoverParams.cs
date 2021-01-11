using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class HoverParams : TextDocumentPositionParams, IWorkDoneProgressParams
    {
        public HoverParams() : base() { }

        [DataMember(Name = "workDoneToken")]
        [JsonProperty(Required = Required.Default)]
        public SumType<string, int> WorkDoneToken { get; set; }
    }
}
