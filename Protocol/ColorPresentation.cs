using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
	[DataContract]
	public class ColorPresentation
	{
		public ColorPresentation() { }

		/**
		 * The label of this color presentation. It will be shown on the color
	     * picker header. By default this is also the text that is inserted when
		 * selecting this color presentation.
		 */
		[DataMember(Name = "label")]
		[JsonProperty(Required = Required.Always)]
		public string Label { get; set; }

		/**
		 * An [edit](#TextEdit) which is applied to a document when selecting
		 * this presentation for the color.  When `falsy` the
		 * [label](#ColorPresentation.label) is used.
		 */
		[DataMember(Name = "textEdit")]
		[JsonProperty(Required = Required.Always)]
		public TextEdit TextEdit { get; set; }

		/**
		 * An optional array of additional [text edits](#TextEdit) that are applied
		 * when selecting this color presentation. Edits must not overlap with the
		 * main [edit](#ColorPresentation.textEdit) nor with themselves.
		 */
		[DataMember(Name = "additionalTextEdits")]
		[JsonProperty(Required = Required.Default)]
		public TextEdit[] AdditionalTextEdits { get; set; }
	}
}
