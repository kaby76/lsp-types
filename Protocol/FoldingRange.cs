using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    /**
     * Represents a folding range.
     */
    [DataContract]
    public class FoldingRange
    {
        public FoldingRange() { }

        /**
         * The zero-based line number from where the folded range starts.
         */
        [DataMember(Name = "startLine")]
        [JsonProperty(Required = Required.Always)]
        public int StartLine { get; set; }

        /**
         * The zero-based character offset from where the folded range starts. If not defined, defaults to the length of the start line.
         */
        [DataMember(Name = "startCharacter")]
        [JsonProperty(Required = Required.Default)]
        public int? StartCharacter { get; set; }

        /**
         * The zero-based line number where the folded range ends.
         */
        [DataMember(Name = "endLine")]
        [JsonProperty(Required = Required.Always)]
        public int EndLine { get; set; }

        /**
         * The zero-based character offset before the folded range ends. If not defined, defaults to the length of the end line.
         */
        [DataMember(Name = "endCharacter")]
        [JsonProperty(Required = Required.Default)]
        public int? EndCharacter { get; set; }

        /**
         * Describes the kind of the folding range such as `comment` or `region`. The kind
         * is used to categorize folding ranges and used by commands like 'Fold all comments'. See
         * [FoldingRangeKind](#FoldingRangeKind) for an enumeration of standardized kinds.
         */
        [DataMember(Name = "kind")]
        [JsonProperty(Required = Required.Default)]
        public string Kind { get; set; }
    }
}
