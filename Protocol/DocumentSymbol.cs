using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    /**
     * Represents programming constructs like variables, classes, interfaces etc. that appear in a document. Document symbols can be
     * hierarchical and they have two ranges: one that encloses its definition and one that points to its most interesting range,
     * e.g. the range of an identifier.
     */
    [DataContract]
    public class DocumentSymbol
    {
        public DocumentSymbol() { }

        /**
         * The name of this symbol. Will be displayed in the user interface and therefore must not be
         * an empty string or a string only consisting of white spaces.
         */
        [DataMember(IsRequired = true, Name = "name")]
        [JsonProperty(Required = Required.Always)]
        public string Name { get; set; }

        /**
         * More detail for this symbol, e.g the signature of a function.
         */
        [DataMember(Name = "detail")]
        [JsonProperty(Required = Required.Default)]
        public string Detail { get; set; }

        /**
         * The kind of this symbol.
         */
        [DataMember(Name = "kind")]
        [JsonProperty(Required = Required.Always)]
        public SymbolKind Kind { get; set; }

        /**
         * Tags for this completion item.
         *
         * @since 3.16.0
         */
        [DataMember(Name = "tags")]
        [JsonProperty(Required = Required.Default)]
        public SymbolTag Tags { get; set; }

        /**
         * Indicates if this symbol is deprecated.
         *
         * @deprecated Use tags instead
         */
        [DataMember(Name = "deprecated")]
        [JsonProperty(Required = Required.Default)]
        public bool? Deprecated { get; set; }

        /**
         * The range enclosing this symbol not including leading/trailing whitespace but everything else
         * like comments. This information is typically used to determine if the clients cursor is
         * inside the symbol to reveal in the symbol in the UI.
         */
        [DataMember(Name = "range")]
        [JsonProperty(Required = Required.Always)]
        public Range Range { get; set; }

        /**
         * The range that should be selected and revealed when this symbol is being picked, e.g the name of a function.
         * Must be contained by the `range`.
         */
        [DataMember(Name = "selectionRange")]
        [JsonProperty(Required = Required.Always)]
        public Range SelectionRange { get; set; }

        /**
         * Children of this symbol, e.g. properties of a class.
         */
        [DataMember(Name = "children")]
        [JsonProperty(Required = Required.Default)]
        public DocumentSymbol[] Children { get; set; }
    }
}
