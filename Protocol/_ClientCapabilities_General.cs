using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LspTypes
{
    [DataContract]
    public class _ClientCapabilities_General
    {
        public _ClientCapabilities_General() { }

		/**
		 * Client capabilities specific to regular expressions.
		 *
		 * @since 3.16.0
		 */
		[DataMember(Name = "regularExpressions")]
		[JsonProperty(Required = Required.Default)]
		public RegularExpressionsClientCapabilities RegularExpressions { get; set; }

		/**
		 * Client capabilities specific to the client's markdown parser.
		 *
		 * @since 3.16.0
		 */
		[DataMember(Name = "markdown")]
		[JsonProperty(Required = Required.Default)]
		public MarkdownClientCapabilities Markdown { get; set; }
    }
}