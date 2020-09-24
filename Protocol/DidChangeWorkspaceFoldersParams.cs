using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class DidChangeWorkspaceFoldersParams
    {
        public DidChangeWorkspaceFoldersParams() { }

        /**
         * The actual workspace folder change event.
         */
        [DataMember(Name = "event")]
        [JsonProperty(Required = Required.Always)]
        public WorkspaceFoldersChangeEvent Event { get; set; }
    }
}
