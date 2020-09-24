using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LspTypes
{
    /**
     * Options to create a file.
     */
    [DataContract]
    public class CreateFileOptions
    {
        public CreateFileOptions() { }

        /**
         * Overwrite existing file. Overwrite wins over `ignoreIfExists`
         */
        [DataMember(Name = "overwrite")]
        [JsonProperty(Required = Required.Default)]
        public bool Overwrite { get; set; }

        /**
         * Ignore if exists.
         */
        [DataMember(Name = "ignoreIfExists")]
        [JsonProperty(Required = Required.Default)]
        public bool IgnoreIfExists { get; set; }
    }
}
