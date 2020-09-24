using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LspTypes
{
    /*
     * Response result for WorkspaceEdit.
     * The workspace/applyEdit request is sent from the server to the
     * client to modify resource on the client side.
     * https://microsoft.github.io/language-server-protocol/specifications/specification-3-16/#workspace_applyEdit
     */
    [DataContract]
    public class ApplyWorkspaceEditResponse
    {
        public ApplyWorkspaceEditResponse() { }

        /**
         * Indicates whether the edit was applied or not.
         */
        [DataMember(Name = "applied")]
        [JsonProperty(Required = Required.Always)]
        public bool Applied { get; set; }

        /**
         * An optional textual description for why the edit was not applied.
         * This may be used may be used by the server for diagnostic
         * logging or to provide a suitable error for a request that
         * triggered the edit.
         */
        [DataMember(Name = "failureReason")]
        [JsonProperty(Required = Required.Default)]
        public string FailureReason { get; set; }
    }
}
