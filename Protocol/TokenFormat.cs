using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TokenFormat
    {
        [EnumMember(Value = "relative")]
        Relative = 0,
    }
}