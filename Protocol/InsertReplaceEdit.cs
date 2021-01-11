using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    /**
     * A special text edit to provide an insert and a replace operation.
     *
     * @since 3.16.0
     */
    [DataContract]
    public class InsertReplaceEdit
    {
        public InsertReplaceEdit() { }

        /**
	     * The string to be inserted.
	     */
        [DataMember(Name = "newText")]
        [JsonProperty(Required = Required.Always)]
        public string NewText { get; set; }

        /**
	     * The range if the insert is requested
	     */
        [DataMember(Name = "insert")]
        [JsonProperty(Required = Required.Always)]
        public Range Insert { get; set; }

        /**
	     * The range if the replace is requested.
	     */
        [DataMember(Name = "replace")]
        [JsonProperty(Required = Required.Always)]
        public Range Replace { get; set; }
    }
}
