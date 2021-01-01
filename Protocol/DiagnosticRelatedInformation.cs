using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LspTypes
{
    /**
     * Represents a related message and source code location for a diagnostic.
     * This should be used to point to code locations that cause or are related to
     * a diagnostics, e.g when duplicating a symbol in a scope.
     */
    [DataContract]
    public class DiagnosticRelatedInformation
    {
        public DiagnosticRelatedInformation() { }

        /**
         * The location of this related diagnostic information.
         */
        [DataMember(Name = "location")]
        [JsonProperty(Required = Required.Always)]
        public Location Location { get; set; }

        /**
         * The message of this related diagnostic information.
         */
        [DataMember(Name = "message")]
        [JsonProperty(Required = Required.Always)]
        public string Message { get; set; }
    }
}
