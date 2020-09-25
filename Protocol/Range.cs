using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class Range : IEquatable<Range>
    {
        public Range() { }

        /**
         * The range's start position.
         */
        [DataMember(Name = "start")]
        public Position Start { get; set; }

        /**
         * The range's end position.
         */
        [DataMember(Name = "end")]
        public Position End { get; set; }

        public override bool Equals(object obj) { return this.Equals(obj as Range); }

        public bool Equals(Range other) { return other != null && EqualityComparer<Position>.Default.Equals(this.Start, other.Start) && EqualityComparer<Position>.Default.Equals(this.End, other.End); }

        public override int GetHashCode()
        {
            return (int)((long)-1676728671 * (long)-1521134295 + EqualityComparer<Position>.Default.GetHashCode(this.Start)) * -1521134295 + EqualityComparer<Position>.Default.GetHashCode(this.End);
        }
    }
}
