using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LspTypes
{
    /**
     * The parameters sent in notifications/requests for user-initiated deletes
     * of files.
     *
     * @since 3.16.0
     */
    [DataContract]
    public class DeleteFilesParams
    {
        public DeleteFilesParams() { }

        /**
	     * An array of all files/folders deleted in this operation.
	     */
        [DataMember(Name = "files")]
        [JsonProperty(Required = Required.Always)]
        public FileDelete[] Files { get; set; }
    }
}
