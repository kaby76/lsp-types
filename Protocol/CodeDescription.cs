using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    /**
     * Structure to capture a description for an error code.
     *
     * @since 3.16.0
     */
    [DataContract]
    public class CodeDescription
    {
        public CodeDescription() { }

        /**
	     * An URI to open with more information about the diagnostic error.
	     */
        [DataMember(Name = "href")]
        [JsonProperty(Required = Required.Always)]
        public string Href { get; set; }
    }
}
