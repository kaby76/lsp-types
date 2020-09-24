using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class Command
    {
        public Command() { }

        /**
         * Title of the command, like `save`.
         */
        [DataMember(Name = "title")]
        [JsonProperty(Required = Required.Always)]
        public string Title { get; set; }

        /**
         * The identifier of the actual command handler.
         */
        [DataMember(Name = "command")]
        [JsonProperty(Required = Required.Always)]
        public string CommandIdentifier { get; set; }

        /**
         * Arguments that the command handler should be
         * invoked with.
         */
        [DataMember(Name = "arguments")]
        [JsonProperty(Required = Required.Default)]
        public object[] Arguments { get; set; }
    }
}
