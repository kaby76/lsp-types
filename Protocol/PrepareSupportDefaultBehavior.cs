using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public enum PrepareSupportDefaultBehavior
    {
		/**
		 * The client's default behavior is to select the identifier
		 * according the to language's syntax rule.
		 */
		Identifier = 1,
	}
}
