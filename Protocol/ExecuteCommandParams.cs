using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class ExecuteCommandParams : WorkDoneProgressParams 
    {
        public ExecuteCommandParams() { }

        /**
         * The identifier of the actual command handler.
         */
        [DataMember(Name = "command")]
        [JsonProperty(Required = Required.Always)]
        public string Command { get; set; }

        /**
         * Arguments that the command should be invoked with.
         */
        [DataMember(Name = "arguments")]
        [JsonProperty(Required = Required.Default)]
        public object[] Arguments { get; set; }
    }
}
