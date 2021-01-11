using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace LspTypes
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum UniquenessLevel
    {
        /**
	     * The moniker is only unique inside a document
	     */
        [EnumMember(Value = "document")]
        Document = 0,

        /**
         * The moniker is unique inside a project for which a dump got created
         */
        [EnumMember(Value = "project ")]
        Project = 1,

        /**
	     * The moniker is unique inside the group to which a project belongs
	     */
        [EnumMember(Value = "group ")]
        Group = 2,

        /**
	     * The moniker is unique inside the moniker scheme.
	     */
        [EnumMember(Value = "scheme ")]
        Scheme = 3,

        /**
	     * The moniker is globally unique
	     */
        [EnumMember(Value = "global ")]
        Global = 4,
    }
}
