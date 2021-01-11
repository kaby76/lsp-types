using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class RenameClientCapabilities
    {
        public RenameClientCapabilities() { }

        /**
         * Whether rename supports dynamic registration.
         */
        [DataMember(Name = "dynamicRegistration")]
        [JsonProperty(Required = Required.Default)]
        public bool? DynamicRegistration { get; set; }

        /**
         * Client supports testing for validity of rename operations
         * before execution.
         *
         * @since version 3.12.0
         */
        [DataMember(Name = "prepareSupport")]
        [JsonProperty(Required = Required.Default)]
        public bool? PrepareSupport { get; set; }

        /**
         * Client supports the default behavior result
	     * (`{ defaultBehavior: boolean }`).
	     *
	     * The value indicates the default behavior used by the
	     * client.
	     *
         * @since version 3.16.0
         */
        [DataMember(Name = "prepareSupportDefaultBehavior")]
        [JsonProperty(Required = Required.Default)]
        public PrepareSupportDefaultBehavior? PrepareSupportDefaultBehavior { get; set; }

        /**
         * Whether th client honors the change annotations in
         * text edits and resource operations returned via the
         * rename request's workspace edit by for example presenting
         * the workspace edit in the user interface and asking
         * for confirmation.
         *
         * @since 3.16.0
         */
        [DataMember(Name = "honorsChangeAnnotations")]
        [JsonProperty(Required = Required.Default)]
        public bool? HonorsChangeAnnotations { get; set; }
    }
}
