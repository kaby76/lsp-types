using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LspTypes
{
    /*
     * Parameter for the initialize request.
     * The initialize request is sent as the first request from the
     * client to the server.
     * https://microsoft.github.io/language-server-protocol/specifications/specification-3-16/#initialize
     */
    [DataContract]
    public class ClientCapabilities
    {
        public ClientCapabilities() { }

        /**
         * Workspace specific client capabilities.
         */
        [DataMember(Name = "workspace")]
        [JsonProperty(Required = Required.Default)]
        public _ClientCapabilities_Workspace Workspace { get; set; }

        /**
         * Text document specific client capabilities.
         */
        [DataMember(Name = "textDocument")]
        [JsonProperty(Required = Required.Default)]
        public TextDocumentClientCapabilities TextDocument { get; set; }

        /**
         * Window specific client capabilities.
         */
        [DataMember(Name = "window")]
        [JsonProperty(Required = Required.Default)]
        public _ClientCapabilities_Window Window { get; set; }

        /**
         * General client capabilities.
         *
         * @since 3.16.0
         */
        [DataMember(Name = "general")]
        [JsonProperty(Required = Required.Default)]
        public _ClientCapabilities_General General { get; set; }

        /**
         * Experimental client capabilities.
         */
        [DataMember(Name = "experimental")]
        [JsonProperty(Required = Required.Default)]
        public object Experimental { get; set; }
    }
}
