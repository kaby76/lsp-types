using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LspTypes
{
    /**
     * Rename file options
     */
    [DataContract]
    public class RenameFileOptions
    {
        public RenameFileOptions() { }

        /**
         * Overwrite target if existing. Overwrite wins over `ignoreIfExists`
         */
        [DataMember(Name = "overwrite")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? Overwrite { get; set; }

        /**
         * Ignores if target exists.
         */
        [DataMember(Name = "ignoreIfExists")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? IgnoreIfExists { get; set; }
    }
}
