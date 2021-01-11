using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class _SignatureHelpClientCapabilities_SignatureInformation
    {
        public _SignatureHelpClientCapabilities_SignatureInformation() { }

        /**
         * Client supports the follow content formats for the documentation
         * property. The order describes the preferred format of the client.
         */
        [DataMember(Name = "documentationFormat")]
        [JsonProperty(Required = Required.Default)]
        public MarkupKind[] DocumentationFormat { get; set; }

        /**
         * Client capabilities specific to parameter information.
         */
        [DataMember(Name = "parameterInformation")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _SignatureHelpClientCapabilities_SignatureInformation_ParameterInformation ParameterInformation { get; set; }

        /**
         * The client supports the `activeParameter` property on
		 * `SignatureInformation` literal.
         *
         * @since 3.16.0
         */
        [DataMember(Name = "activeParameterSupport")]
        [JsonProperty(Required = Required.Default)]
        public bool? ActiveParameterSupport { get; set; }
    }
}
