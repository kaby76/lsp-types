using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace LspTypes
{
    /**
     * Represents information about programming constructs like variables, classes,
     * interfaces etc.
     */
    [DataContract]
    public class SymbolInformation : IEquatable<SymbolInformation>
    {
        public SymbolInformation() { }

        /**
         * The name of this symbol.
         */
        [DataMember(Name = "name")]
        public string Name { get; set; }

        /**
         * The kind of this symbol.
         */
        [DataMember(Name = "kind")]
        public SymbolKind Kind { get; set; }

        /**
         * Tags for this completion item.
         *
         * @since 3.16.0
         */
        [DataMember(Name = "tags")]
        public SymbolTag[] Tags { get; set; }

        /**
         * Indicates if this symbol is deprecated.
         *
         * @deprecated Use tags instead
         */
        [DataMember(Name = "deprecated")]
        public bool? Deprecated { get; set; }
        
        /**
         * The location of this symbol. The location's range is used by a tool
         * to reveal the location in the editor. If the symbol is selected in the
         * tool the range's start information is used to position the cursor. So
         * the range usually spans more then the actual symbol's name and does
         * normally include things like visibility modifiers.
         *
         * The range doesn't have to denote a node range in the sense of a abstract
         * syntax tree. It can therefore not be used to re-construct a hierarchy of
         * the symbols.
         */
        [DataMember(Name = "location")]
        public Location Location { get; set; }

        /**
         * The name of the symbol containing this symbol. This information is for
         * user interface purposes (e.g. to render a qualifier in the user interface
         * if necessary). It can't be used to re-infer a hierarchy for the document
         * symbols.
         */
        [DataMember(Name = "containerName")]
        public string ContainerName { get; set; }

        public override bool Equals(object obj) { return this.Equals(obj as SymbolInformation); }

        public bool Equals(SymbolInformation other)
        {
            return other != null && this.Name == other.Name && (this.Kind == other.Kind && EqualityComparer<Location>.Default.Equals(this.Location, other.Location)) && this.ContainerName == other.ContainerName;
        }

        public override int GetHashCode()
        {
            return (int)((((long)1633890234 * (long)-1521134295
                + EqualityComparer<string>.Default.GetHashCode(this.Name)) * -1521134295 
                + this.Kind.GetHashCode()) * -1521134295
                + EqualityComparer<Location>.Default.GetHashCode(this.Location)) * -1521134295 
                + EqualityComparer<string>.Default.GetHashCode(this.ContainerName);
        }
    }
}
