using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class SelectionRange
    {
        public SelectionRange() { }

        /**
         * The [range](#Range) of this selection range.
         */
        [DataMember(Name = "range")]
        [JsonProperty(Required = Required.Always)]
        public Range Range { get; set; }

        /**
         * The parent selection range containing this range. Therefore
	     * `parent.range` must contain `this.range`.
         */
        [DataMember(Name = "parent")]
        [JsonProperty(Required = Required.Default)]
        public SelectionRange Parent { get; set; }
    }
}
