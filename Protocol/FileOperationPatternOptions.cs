using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LspTypes
{
    [DataContract]
    public class FileOperationPatternOptions
    {
        public FileOperationPatternOptions() { }

        /**
          * The pattern should be matched ignoring casing.
          */
        [DataMember(Name = "ignoreCase")]
        [JsonProperty(Required = Required.Default)]
        public bool? IgnoreCase { get; set; }
    }
}
