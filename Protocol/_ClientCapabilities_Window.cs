using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LspTypes
{
	[DataContract]
	public class _ClientCapabilities_Window
	{
		public _ClientCapabilities_Window() { }

		/**
         * Whether client supports handling progress notifications. If set
		 * servers are allowed to report in `workDoneProgress` property in the
		 * request specific server capabilities.
		 * 
         * @Since 3.15.0
         */
		[DataMember(Name = "workDoneProgress")]
		[JsonProperty(Required = Required.Default)]
		public bool? WorkDoneProgress { get; set; }

		/**
	     * Capabilities specific to the showMessage request
		 *
		 * @since 3.16.0
		 */
		[DataMember(Name = "showMessage")]
		[JsonProperty(Required = Required.Default)]
		public ShowMessageRequestClientCapabilities ShowMessage { get; set; }

		/**
		 * Client capabilities for the show document request.
		 *
		 * @since 3.16.0
		 */
		[DataMember(Name = "showDocument")]
		[JsonProperty(Required = Required.Default)]
		public ShowDocumentClientCapabilities ShowDocument { get; set; }
	}
}
