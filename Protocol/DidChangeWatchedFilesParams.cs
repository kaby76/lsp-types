using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class DidChangeWatchedFilesParams
    {
        public DidChangeWatchedFilesParams() { }

        /**
         * The actual file events.
         */
        [DataMember(Name = "changes")]
        [JsonProperty(Required = Required.Always)]
        public FileEvent[] Changes { get; set; }
    }
}
