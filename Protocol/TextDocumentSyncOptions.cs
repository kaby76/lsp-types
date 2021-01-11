using System.Runtime.Serialization;

namespace LspTypes
{
	[DataContract]
	public class TextDocumentSyncOptions
	{
		public TextDocumentSyncOptions() { }

		/**
         * Open and close notifications are sent to the server. If omitted open
	     * close notification should not be sent.
	     */
		[DataMember(Name = "openClose")]
		public bool? OpenClose { get; set; }

		/**
         * Change notifications are sent to the server. See
	     * TextDocumentSyncKind.None, TextDocumentSyncKind.Full and
	     * TextDocumentSyncKind.Incremental. If omitted it defaults to
	     * TextDocumentSyncKind.None.
	     */
		[DataMember(Name = "change")]
		public TextDocumentSyncKind? Change { get; set; }
		/**
		 * If present will save notifications are sent to the server. If omitted
		 * the notification should not be sent.
		 */
		[DataMember(Name = "willSave")]
		public bool? WillSave { get; set; }

		/**
		 * If present will save wait until requests are sent to the server. If
		 * omitted the request should not be sent.
		 */
		[DataMember(Name = "willSaveWaitUntil")]
		public bool? WillSaveWaitUntil { get; set; }

		/**
		 * If present save notifications are sent to the server. If omitted the
		 * notification should not be sent.
		 */
		[DataMember(Name = "save")]
		public SumType<bool, SaveOptions> Save { get; set; }
	}
}
