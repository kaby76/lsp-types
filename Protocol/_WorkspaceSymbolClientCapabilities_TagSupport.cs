using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LspTypes
{
    [DataContract]
    public class _WorkspaceSymbolClientCapabilities_TagSupport
    {
        public _WorkspaceSymbolClientCapabilities_TagSupport() { }

        /**
		 * The tags supported by the client.
		 */
        [DataMember(Name = "valueSet")]
        [JsonProperty(Required = Required.Default)]
        public SymbolTag[] ValueSet { get; set; }
    }
}