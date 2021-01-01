using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class ShowMessageRequestClientCapabilities
    {
        public ShowMessageRequestClientCapabilities() { }

        /**
	     * Capabilities specific to the `MessageActionItem` type.
	     */
        [DataMember(Name = "messageActionItem")]
        [JsonProperty(Required = Required.Default)]
        public _ShowMessageRequestClientCapabilities_MessageActionItem AnnotationId { get; set; }

    }
}
