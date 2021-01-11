using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace LspTypes
{
    /**
     * A pattern kind describing if a glob pattern matches a file a folder or
     * both.
     *
     * @since 3.16.0
     */
    [DataContract]
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FileOperationPatternKind
    {
        /**
	     * The pattern matches a file only.
	     */
        [EnumMember(Value = "file")]
        File = 0,

        /**
         * The pattern matches a folder only.
         */
        [EnumMember(Value = "folder")]
        Folder = 1,
    }
}
