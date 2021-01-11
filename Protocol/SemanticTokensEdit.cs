using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class SemanticTokensEdit
    {
        public SemanticTokensEdit() { }

        /**
	     * The start offset of the edit.
	     */
        [DataMember(Name = "start")]
        [JsonProperty(Required = Required.Always)]
        public uint Start { get; set; }

        /**
	     * The count of elements to remove.
	     */
        [DataMember(Name = "deleteCount")]
        [JsonProperty(Required = Required.Always)]
        public uint DeleteCount { get; set; }

        /**
	     * The elements to insert.
	     */
	    [DataMember(Name = "data")]
        [JsonProperty(Required = Required.Default)]
        public uint[] Data { get; set; }
    }
}
