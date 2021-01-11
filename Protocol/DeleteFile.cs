using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LspTypes
{
    /**
     * Delete file operation
     */
    [DataContract]
    public class DeleteFile
    {
        public DeleteFile() { }

        /**
         * A delete
         */
        // Must always be 'delete'.
        [DataMember(Name = "kind")]
        [JsonProperty(Required = Required.Always)]
        public string Kind { get; set; }

        /**
         * The file to delete.
         */
        [DataMember(Name = "uri")]
        [JsonProperty(Required = Required.Always)]
        public string Uri { get; set; }

        /**
         * Delete options.
         */
        [DataMember(Name = "options")]
        [JsonProperty(Required = Required.Default)]
        public DeleteFileOptions Options { get; set; }

        /**
         * An optional annotation identifer describing the operation.
         *
         * @since 3.16.0
         */
        [DataMember(Name = "annotationId")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string AnnotationId { get; set; }
    }
}
