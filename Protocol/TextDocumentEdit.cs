using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class TextDocumentEdit
    {
        public TextDocumentEdit() { }

        /**
         * The text document to change.
         */
        [DataMember(Name = "textDocument")]
        [JsonProperty(Required = Required.Always)]
        public OptionalVersionedTextDocumentIdentifier TextDocument { get; set; }

        /**
         * The edits to be applied.
      	 *
	     * @since 3.16.0 - support for AnnotatedTextEdit. This is guarded by the
	     * client capability `workspace.workspaceEdit.changeAnnotationSupport`
         */
        [DataMember(Name = "edits")]
        [JsonProperty(Required = Required.Always)]
        public SumType<TextEdit,AnnotatedTextEdit>[] Edits { get; set; }
    }
}
