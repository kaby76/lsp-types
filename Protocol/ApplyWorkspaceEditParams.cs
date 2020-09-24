using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LspTypes
{
    /*
     * Parameter for WorkspaceEdit.
     * The workspace/applyEdit request is sent from the server to the
     * client to modify resource on the client side.
     * https://microsoft.github.io/language-server-protocol/specifications/specification-3-16/#workspace_applyEdit
     */
    [DataContract]
    public class ApplyWorkspaceEditParams
    {
        public ApplyWorkspaceEditParams() { }

        /**
         * An optional label of the workspace edit. This label is
         * presented in the user interface for example on an undo
         * stack to undo the workspace edit.
         */
        [DataMember(Name = "label")]
        [JsonProperty(Required = Required.Default)]
        public string Label { get; set; }

        /**
         * The edits to apply.
         */
        [DataMember(Name = "edit")]
        [JsonProperty(Required = Required.Always)]
        public WorkspaceEdit Edit { get; set; }
    }
}
