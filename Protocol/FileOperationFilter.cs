using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LspTypes
{
    /**
     * A filter to describe in which file operation requests or notifications
     * the server is interested in.
     *
     * @since 3.16.0
     */
    [DataContract]
    public class FileOperationFilter
    {
        public FileOperationFilter() { }

        /**
	     * A Uri like `file` or `untitled`.
	     */
        [DataMember(Name = "scheme")]
        [JsonProperty(Required = Required.Default)]
        public string Scheme { get; set; }

        /**
	     * The actual file operation pattern.
	     */
        [DataMember(Name = "pattern")]
        [JsonProperty(Required = Required.Always)]
        public FileOperationPattern Pattern { get; set; }
    }
}
