using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace LspTypes
{
	[DataContract]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum SemanticTokenModifiers
	{
		[EnumMember(Value = "declaration ")]
		Declaration = 0,

		[EnumMember(Value = "definition ")]
		Definition = 1,

		[EnumMember(Value = "readonly ")]
		Readonly = 2,

		[EnumMember(Value = "static")]
		Static = 3,

		[EnumMember(Value = "deprecated")]
		Deprecated = 4,

		[EnumMember(Value = "abstract")]
		Abstract = 5,

		[EnumMember(Value = "async")]
		Async = 6,

		[EnumMember(Value = "modification")]
		Modification = 7,

		[EnumMember(Value = "documentation")]
		Documentation = 8,

		[EnumMember(Value = "defaultLibrary")]
		DefaultLibrary = 9,
	}
}
