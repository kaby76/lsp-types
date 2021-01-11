using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    /**
     * Represents a folding range. To be valid, start and end line must be bigger
     * than zero and smaller than the number of lines in the document. Clients
     * are free to ignore invalid ranges.
     */
    [DataContract]
    public class FoldingRange
    {
        public FoldingRange() { }

        /**
         * The zero-based start line of the range to fold. The folded area starts
	     * after the line's last character. To be valid, the end must be zero or
	     * larger and smaller than the number of lines in the document.
         */
        [DataMember(Name = "startLine")]
        [JsonProperty(Required = Required.Always)]
        public uint StartLine { get; set; }

        /**
         * The zero-based character offset from where the folded range starts. If
	     * not defined, defaults to the length of the start line.
         */
        [DataMember(Name = "startCharacter")]
        [JsonProperty(Required = Required.Default)]
        public uint? StartCharacter { get; set; }

        /**
         * The zero-based end line of the range to fold. The folded area ends with
	     * the line's last character. To be valid, the end must be zero or larger
	     * and smaller than the number of lines in the document.
         */
        [DataMember(Name = "endLine")]
        [JsonProperty(Required = Required.Always)]
        public uint EndLine { get; set; }

        /**
         * The zero-based character offset before the folded range ends. If not
	     * defined, defaults to the length of the end line.
         */
        [DataMember(Name = "endCharacter")]
        [JsonProperty(Required = Required.Default)]
        public uint? EndCharacter { get; set; }

        /**
         * Describes the kind of the folding range such as `comment` or `region`.
	     * The kind is used to categorize folding ranges and used by commands like
	     * 'Fold all comments'. See [FoldingRangeKind](#FoldingRangeKind) for an
	     * enumeration of standardized kinds.
         */
        [DataMember(Name = "kind")]
        [JsonProperty(Required = Required.Default)]
        public string Kind { get; set; }
    }
}
