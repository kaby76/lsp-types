using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LspTypes
{
    /**
     * The options to register for file operations.
     *
     * @since 3.16.0
     */
    [DataContract]
    public class FileOperationRegistrationOptions
    {
        public FileOperationRegistrationOptions() { }

        /**
	     * The actual filters.
	     */
        [DataMember(Name = "filters")]
        [JsonProperty(Required = Required.Always)]
        public FileOperationFilter[] Filters { get; set; }
    }
}
