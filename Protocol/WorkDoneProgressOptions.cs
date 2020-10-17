using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class WorkDoneProgressOptions : IWorkDoneProgressOptions
    {
        public WorkDoneProgressOptions() { }

        /**
          * A human-readable string that is shown when multiple outlines trees
          * are shown for the same document.
          *
          * @since 3.16.0 - proposed state
          */
        [DataMember(Name = "label")]
        [JsonProperty(Required = Required.Default)]
        public string Label { get; set; }
        
        [DataMember(Name = "workDoneProgress")]
        [JsonProperty(Required = Required.Default)]
        public bool WorkDoneProgress { get; set; }
    }

    public interface IWorkDoneProgressOptions
    {
        bool WorkDoneProgress { get; set; }
    }
}
