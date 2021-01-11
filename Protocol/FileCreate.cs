using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LspTypes
{
    /**
     * Represents information on a file/folder create.
     *
     * @since 3.16.0
     */
    [DataContract]
    public class FileCreate
    {
        public FileCreate() { }

        /**
	     * A file:// URI for the location of the file/folder being created.
	     */
        [DataMember(Name = "uri")]
        [JsonProperty(Required = Required.Default)]
        public string Uri { get; set; }
    }
}
