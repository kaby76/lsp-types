using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
	/**
	 * Additional information that describes document changes.
	 *
	 * @since 3.16.0
	 */
	[DataContract]
	public class ChangeAnnotation
	{
		/**
		 * A human-readable string describing the actual change. The string
		 * is rendered prominent in the user interface.
		 */
		[DataMember(Name = "label")]
		[JsonProperty(Required = Required.Always)]
		public string Label { get; set; }

		/**
		 * A flag which indicates that user confirmation is needed
		 * before applying the change.
		 */
		[DataMember(Name = "needsConfirmation")]
		[JsonProperty(Required = Required.Default)]
		public bool NeedsConfirmation { get; set; }

		/**
		 * A human-readable string which is rendered less prominent in
		 * the user interface.
		 */
		[DataMember(Name = "description")]
		[JsonProperty(Required = Required.Default)]
		public string Description { get; set; }
	}
}
