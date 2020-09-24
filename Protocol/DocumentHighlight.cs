using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    /**
     * A document highlight is a range inside a text document which deserves
     * special attention. Usually a document highlight is visualized by changing
     * the background color of its range.
     *
     */
    [DataContract]
    public class DocumentHighlight
    {
        public DocumentHighlight() { }

        /**
         * The range this highlight applies to.
         */
        [DataMember(Name = "range")]
        [JsonProperty(Required = Required.Always)]
        public Range Range { get; set; }

        /**
         * The highlight kind, default is DocumentHighlightKind.Text.
         */
        [DataMember(Name = "kind")]
        [JsonProperty(Required = Required.Default)]
        public DocumentHighlightKind Kind { get; set; }
    }
}
