using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class WorkDoneProgressOptions : IWorkDoneProgressOptions
    {
        public WorkDoneProgressOptions() { }

        [DataMember(Name = "workDoneProgress")]
        [JsonProperty(Required = Required.Default)]
        public bool WorkDoneProgress { get; set; }
    }

    public interface IWorkDoneProgressOptions
    {
        bool WorkDoneProgress { get; set; }
    }
}
