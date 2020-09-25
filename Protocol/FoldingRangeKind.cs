using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace LspTypes
{
    /**
     * Enum of known range kinds
     */
    [DataContract]
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FoldingRangeKind
    {
        /**
         * Folding range for a comment
         */
        [EnumMember(Value = "comment")]
        Comment = 0,

        /**
         * Folding range for a imports or includes
         */
        [EnumMember(Value = "imports")]
        Imports = 1,

        /**
         * Folding range for a region (e.g. `#region`)
         */
        [EnumMember(Value = "region")]
        Region = 2
    }
}
