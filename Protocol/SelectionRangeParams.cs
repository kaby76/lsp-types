using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class SelectionRangeParams : WorkDoneProgressParams, IPartialResultParams
    {
        public SelectionRangeParams() : base() { }

		/**
		 * The text document.
		 */
		[DataMember(Name = "textDocument")]
		[JsonProperty(Required = Required.Default, DefaultValueHandling = DefaultValueHandling.Ignore)]
		public TextDocumentIdentifier TextDocument { get; set; }

		/**
		 * The positions inside the text document.
		 */
		[DataMember(Name = "positions")]
		[JsonProperty(Required = Required.Default, DefaultValueHandling = DefaultValueHandling.Ignore)]
		public Position[] Positions { get; set; }

        [DataMember(Name = "partialResultToken")]
		[JsonProperty(Required = Required.Default, DefaultValueHandling = DefaultValueHandling.Ignore)]
		public SumType<int, string> PartialResultToken { get; set; }
	}
}
