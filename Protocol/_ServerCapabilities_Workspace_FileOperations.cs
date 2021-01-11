using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
	[DataContract]
	public class _ServerCapabilities_Workspace_FileOperations
    {
		public _ServerCapabilities_Workspace_FileOperations() { }

		/**
		 * The server is interested in receiving didCreateFiles
		 * notifications.
	 	 */
		[DataMember(Name = "didCreate")]
		[JsonProperty(Required = Required.Default)]
		public FileOperationRegistrationOptions DidCreate { get; set; }

		/**
		 * The server is interested in receiving willCreateFiles requests.
		 */
		[DataMember(Name = "willCreate")]
		[JsonProperty(Required = Required.Default)]
		public FileOperationRegistrationOptions WillCreate { get; set; }

		/**
		 * The server is interested in receiving didRenameFiles
		 * notifications.
		 */
		[DataMember(Name = "didRename")]
		[JsonProperty(Required = Required.Default)]
		public FileOperationRegistrationOptions DidRename { get; set; }

		/**
		 * The server is interested in receiving willRenameFiles requests.
		 */
		[DataMember(Name = "willRename")]
		[JsonProperty(Required = Required.Default)]
		public FileOperationRegistrationOptions WillRename { get; set; }

		/**
		 * The server is interested in receiving didDeleteFiles file
		 * notifications.
		 */
		[DataMember(Name = "didDelete")]
		[JsonProperty(Required = Required.Default)]
		public FileOperationRegistrationOptions DidDelete { get; set; }

		/**
		 * The server is interested in receiving willDeleteFiles file
		 * requests.
		 */
		[DataMember(Name = "willDelete")]
		[JsonProperty(Required = Required.Default)]
		public FileOperationRegistrationOptions WillDelete { get; set; }
    }
}