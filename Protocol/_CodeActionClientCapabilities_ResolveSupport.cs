using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class _CodeActionClientCapabilities_ResolveSupport
    {
        public _CodeActionClientCapabilities_ResolveSupport() { }

        /**
		 * The properties that a client can resolve lazily.
		*/
        [DataMember(Name = "properties")]
        [JsonProperty(Required = Required.Default)]
        public string[] Properties { get; set; }
    }
}