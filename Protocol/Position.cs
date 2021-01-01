using System;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class Position : IEquatable<Position>
    {
        public Position() { }

        public Position(uint line, uint character) : base()
        {
            this.Line = line;
            this.Character = character;
        }

        /**
         * Line position in a document (zero-based).
         */
        [DataMember(Name = "line")]
        public uint Line { get; set; }

        /**
         * Character offset on a line in a document (zero-based). Assuming that the line is
         * represented as a string, the `character` value represents the gap between the
         * `character` and `character + 1`.
         *
         * If the character value is greater than the line length it defaults back to the
         * line length.
         */
        [DataMember(Name = "character")]
        public uint Character { get; set; }

        public override bool Equals(object obj)
        {
            return this.Equals(obj as Position);
        }

        public bool Equals(Position other)
        {
            return other != (Position)null && this.Line == other.Line && this.Character == other.Character;
        }

        public override int GetHashCode()
        {
            return (int)this.Line ^ (int)this.Character;
        }

        public static bool operator ==(Position firstPosition, Position secondPosition)
        {
            if ((object)firstPosition == null && (object)secondPosition == null)
                return true;
            return ((object)firstPosition != null || (object)secondPosition == null) && ((object)firstPosition == null || (object)secondPosition != null) && firstPosition.Equals(secondPosition);
        }

        public static bool operator !=(Position firstPosition, Position secondPosition)
        {
            return !(firstPosition == secondPosition);
        }
    }
}
