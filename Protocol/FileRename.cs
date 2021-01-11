using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LspTypes
{
    /**
     * Represents information on a file/folder rename.
     *
     * @since 3.16.0
     */
    [DataContract]
    public class FileRename
    {
        public FileRename() { }

        /**
	     * A file:// URI for the original location of the file/folder being renamed.
	     */
        [DataMember(Name = "oldUri")]
        [JsonProperty(Required = Required.Always)]
        public string OldUri { get; set; }

        /**
	     * A file:// URI for the new location of the file/folder being renamed.
	     */
        [DataMember(Name = "newUri")]
        [JsonProperty(Required = Required.Always)]
        public string NewUri { get; set; }
    }
}
