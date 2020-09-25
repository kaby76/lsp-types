using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace LspTypes
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TraceValue
    {
        [EnumMember(Value = "off")]
        Off = 0,

        [EnumMember(Value = "message")]
        Messages = 1,

        [EnumMember(Value = "verbose")]
        Verbose = 2,
    }
}
