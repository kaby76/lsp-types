using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    /**
     * Client capabilities for the show document request.
     *
     * @since 3.16.0
     */
    [DataContract]
    public class ShowDocumentClientCapabilities
    {
        public ShowDocumentClientCapabilities() { }

        /**
	     * The client has support for the show document
	     * request.
	     */
        [DataMember(Name = "support")]
        [JsonProperty(Required = Required.Always)]
        public bool Support { get; set; }
    }
}
