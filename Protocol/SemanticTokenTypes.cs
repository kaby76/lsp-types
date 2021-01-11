using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace LspTypes
{
	[DataContract]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum SemanticTokenTypes
	{
		[EnumMember(Value = "namespace")]
		Namespace = 0,

		/**
		 * Represents a generic type. Acts as a fallback for types which
		 * can't be mapped to a specific type like class or enum.
		 */
		[EnumMember(Value = "type")]
		Type = 1,

		[EnumMember(Value = "class")]
		Class = 2,

		[EnumMember(Value = "enum")]
		Enum = 3,

		[EnumMember(Value = "interface")]
		Interface = 4,

		[EnumMember(Value = "struct")]
		Struct = 5,

		[EnumMember(Value = "typeParameter")]
		TypeParameter = 6,

		[EnumMember(Value = "parameter")]
		Parameter = 7,

		[EnumMember(Value = "variable")]
		Variable = 8,

		[EnumMember(Value = "property")]
		Property = 9,

		[EnumMember(Value = "enumMember")]
		EnumMember = 10,

		[EnumMember(Value = "event")]
		Event = 11,

		[EnumMember(Value = "function")]
		Function = 12,

		[EnumMember(Value = "method")]
		Method = 13,

		[EnumMember(Value = "macro")]
		Macro = 14,

		[EnumMember(Value = "keyword")]
		Keyword = 15,

		[EnumMember(Value = "modifier")]
		Modifier = 16,

		[EnumMember(Value = "comment")]
		Comment = 17,

		[EnumMember(Value = "string")]
		String = 18,

		[EnumMember(Value = "number")]
		Number = 19,

		[EnumMember(Value = "regexp")]
		Regexp = 20,

		[EnumMember(Value = "operator")]
		Operator = 21,
	}
}
