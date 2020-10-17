using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class Diagnostic
    {
        public Diagnostic() { }

        /**
         * The range at which the message applies.
         */
        [DataMember(Name = "range")]
        [JsonProperty(Required = Required.Always)]
        public Range Range { get; set; }

        /**
         * The diagnostic's severity. Can be omitted. If omitted it is up to the
         * client to interpret diagnostics as error, warning, info or hint.
         */
        [DataMember(Name = "severity")]
        [JsonProperty(Required = Required.Default)]
        public DiagnosticSeverity Severity { get; set; }

        /**
         * The diagnostic's code, which might appear in the user interface.
         */
        [DataMember(Name = "code")]
        [JsonProperty(Required = Required.Default, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public SumType<string, int> Code { get; set; }

        /**
	 * An optional property to describe the error code.
	 *
	 * @since 3.16.0 - proposed state
	 */
        [DataMember(Name = "codeDescription")]
        [JsonProperty(Required = Required.Default)]
        public CodeDescription CodeDescription { get; set; }

        /**
         * A human-readable string describing the source of this
         * diagnostic, e.g. 'typescript' or 'super lint'.
         */
        [DataMember(Name = "source")]
        [JsonProperty(Required = Required.Default)]
        public string Source { get; set; }

        /**
         * The diagnostic's message.
         */
        [DataMember(Name = "message")]
        [JsonProperty(Required = Required.Always)]
        public string Message { get; set; }

        /**
         * Additional metadata about the diagnostic.
         *
         * @since 3.15.0
         */
        [DataMember(Name = "tags")]
        [JsonProperty(Required = Required.Default)]
        public DiagnosticTag[] Tags { get; set; }

        /**
         * An array of related diagnostic information, e.g. when symbol-names within
         * a scope collide all definitions can be marked via this property.
         */
        [DataMember(Name = "relatedInformation")]
        [JsonProperty(Required = Required.Default)]
        public DiagnosticRelatedInformation[] RelatedInformation { get; set; }
    }
}
