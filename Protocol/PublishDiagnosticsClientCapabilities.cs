using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LspTypes
{
    [DataContract]
    public class PublishDiagnosticsClientCapabilities
    {
        public PublishDiagnosticsClientCapabilities() { }

        /**
         * Whether the clients accepts diagnostics with related information.
         */
        [DataMember(Name = "relatedInformation")]
        [JsonProperty(Required = Required.Default)]
        public bool? RelatedInformation { get; set; }

        /**
         * Client supports the tag property to provide meta data about a diagnostic.
         * Clients supporting tags have to handle unknown tags gracefully.
         *
         * @since 3.15.0
         */
        [DataMember(Name = "tagSupport")]
        [JsonProperty(Required = Required.Default, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public _PublishDiagnosticsClientCapabilities_TagSupport TagSupport { get; set; }

        /**
         * Whether the client interprets the version property of the
         * `textDocument/publishDiagnostics` notification's parameter.
         *
         * @since 3.15.0
         */
        [DataMember(Name = "versionSupport")]
        [JsonProperty(Required = Required.Default)]
        public bool? VersionSupport { get; set; }

        /**
	     * Client supports a codeDescription property
         *
	     * @since 3.16.0
	     */
        [DataMember(Name = "codeDescriptionSupport")]
        [JsonProperty(Required = Required.Default)]
        public bool? CodeDescriptionSupport { get; set; }

        /**
	     * Whether code action supports the `data` property which is
	     * preserved between a `textDocument/publishDiagnostics` and
	     * `textDocument/codeAction` request.
	     *
	     * @since 3.16.0
	     */
        [DataMember(Name = "dataSupport")]
        [JsonProperty(Required = Required.Default)]
        public bool? DataSupport { get; set; }
    }
}