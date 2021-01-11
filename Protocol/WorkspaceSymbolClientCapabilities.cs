using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LspTypes
{
    [DataContract]
    public class WorkspaceSymbolClientCapabilities
    {
        public WorkspaceSymbolClientCapabilities() { }

        /**
         * Symbol request supports dynamic registration.
         */
        [DataMember(Name = "dynamicRegistration")]
        [JsonProperty(Required = Required.Default)]
        public bool? DynamicRegistration { get; set; }

        /**
         * Specific capabilities for the `SymbolKind` in the `workspace/symbol`
	     * request.
	     */
        [DataMember(Name = "symbolKind")]
        [JsonProperty(Required = Required.Default)]
        public _WorkspaceSymbolClientCapabilities_SymbolKind SymbolKind { get; set; }

        /**
         * The client supports tags on `SymbolInformation`.
         * Clients supporting tags have to handle unknown tags gracefully.
         *
         * @since 3.16.0
         */
        [DataMember(Name = "tagSupport")]
        [JsonProperty(Required = Required.Default)]
        public _WorkspaceSymbolClientCapabilities_TagSupport TagSupport { get; set; }
    }
}