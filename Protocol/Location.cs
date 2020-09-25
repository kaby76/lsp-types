using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class Location : IEquatable<Location>
    {
        public Location() { }

        [DataMember(Name = "uri")]
        [JsonProperty(Required = Required.Always)]
        public string Uri { get; set; }

        [DataMember(Name = "range")]
        public Range Range { get; set; }

        public override bool Equals(object obj) { return this.Equals(obj as Location); }
        public bool Equals(Location other) { return other != null && this.Uri != null && (other.Uri != null && this.Uri.Equals((object)other.Uri)) && EqualityComparer<Range>.Default.Equals(this.Range, other.Range); }
        public override int GetHashCode()
        {
            return (int)((long)1486144663 * (long)-1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Uri)) * -1521134295 + EqualityComparer<Range>.Default.GetHashCode(this.Range);
        }
    }
}
