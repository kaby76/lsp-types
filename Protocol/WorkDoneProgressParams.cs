using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class WorkDoneProgressParams : IWorkDoneProgressParams
    {
        public WorkDoneProgressParams() { }

        /**
         * An optional token that a server can use to report work done progress.
         */
        [DataMember(Name = "workDoneToken")]
        [JsonProperty(Required = Required.Default, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public SumType<string, int> WorkDoneToken { get; set; }
    }

    public interface IWorkDoneProgressParams
    {
        SumType<string, int> WorkDoneToken { get; set; }
    }
}
