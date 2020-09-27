using Newtonsoft.Json;
using System;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class PublishDiagnosticParams
    {
        public PublishDiagnosticParams() { }

        /**
	     * The URI for which diagnostic information is reported.
	     */
        [DataMember(Name = "uri")]
        [JsonProperty(Required = Required.Always)]
        public string Uri { get; set; }

        /**
	     * Optional the version number of the document the diagnostics are published for.
	     *
	     * @since 3.15.0
	     */
        [DataMember(Name = "version")]
        [JsonProperty(Required = Required.Default)]
        public int Version { get; set; }


        /**
	     * An array of diagnostic information items.
	     */
        [DataMember(Name = "diagnostics")]
        [JsonProperty(Required = Required.Always)]
        public Diagnostic[] Diagnostics { get; set; }

    }
}
