using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    /**
     * The result of a hover request.
     */
    [DataContract]
    public class Hover
    {
        public Hover() { }

        /**
         * The hover's content
         */
        [DataMember(Name = "contents")]
        [JsonProperty(Required = Required.Always, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public SumType<string, MarkedString, MarkedString[], MarkupContent> Contents { get; set; }

        /**
         * An optional range is a range inside a text document
         * that is used to visualize a hover, e.g. by changing the background color.
         */
        [DataMember(Name = "range")]
        [JsonProperty(Required = Required.Default)]
        public Range Range { get; set; }
    }
}
