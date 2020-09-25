using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class ExecuteCommandOptions : WorkDoneProgressOptions
    {
        public ExecuteCommandOptions() { }

        /**
         * The commands to be executed on the server
         */
        [DataMember(Name = "commands")]
        [JsonProperty(Required = Required.Default)]
        public string[] Commands { get; set; }
    }
}
