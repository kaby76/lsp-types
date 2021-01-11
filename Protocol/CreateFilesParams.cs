using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LspTypes
{
    /**
     * The parameters sent in notifications/requests for user-initiated creation
     * of files.
     *
     * @since 3.16.0
     */
    [DataContract]
    public class CreateFilesParams
    {
        public CreateFilesParams() { }

        /**
	     * An array of all files/folders created in this operation.
	     */
        [DataMember(Name = "files")]
        [JsonProperty(Required = Required.Default)]
        public FileCreate[] Files { get; set; }
    }
}
