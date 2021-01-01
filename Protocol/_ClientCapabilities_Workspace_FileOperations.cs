using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LspTypes
{
    [DataContract]
    public class _ClientCapabilities_Workspace_FileOperations
    {
        public _ClientCapabilities_Workspace_FileOperations() { }

		/**
		 * Whether the client supports dynamic registration for file
		 * requests/notifications.
		 */
		[DataMember(Name = "dynamicRegistration")]
		[JsonProperty(Required = Required.Default)]
		public bool? DynamicRegistration { get; set; }

		/**
		 * The client has support for sending didCreateFiles notifications.
		 */
		[DataMember(Name = "didCreate")]
		[JsonProperty(Required = Required.Default)]
		public bool? DidCreate { get; set; }

		/**
		 * The client has support for sending willCreateFiles requests.
		 */
		[DataMember(Name = "willCreate")]
		[JsonProperty(Required = Required.Default)]
		public bool? WillCreate { get; set; }

		/**
		 * The client has support for sending didRenameFiles notifications.
		 */
		[DataMember(Name = "didRename")]
		[JsonProperty(Required = Required.Default)]
		public bool? DidRename { get; set; }

		/**
	 	 * The client has support for sending willRenameFiles requests.
		 */
		[DataMember(Name = "willRename")]
		[JsonProperty(Required = Required.Default)]
		public bool? WillRename { get; set; }

		/**
		 * The client has support for sending didDeleteFiles notifications.
		 */
		[DataMember(Name = "didDelete")]
		[JsonProperty(Required = Required.Default)]
		public bool? DidDelete { get; set; }

		/**
		 * The client has support for sending willDeleteFiles requests.
		 */
		[DataMember(Name = "willDelete")]
		[JsonProperty(Required = Required.Default)]
		public bool? WillDelete { get; set; }
    }
}