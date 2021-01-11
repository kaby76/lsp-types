using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace LspTypes
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MonikerKind
    {
		/**
		 * The moniker represent a symbol that is imported into a project
		 */
		[EnumMember(Value = "import")]
		Import = 0,

		/**
		 * The moniker represents a symbol that is exported from a project
		 */
		[EnumMember(Value = "export")]
		Export = 1,

		/**
		 * The moniker represents a symbol that is local to a project (e.g. a local
		 * variable of a function, a class not visible outside the project, ...)
		 */
		[EnumMember(Value = "local")]
		Local = 2,
	}
}
