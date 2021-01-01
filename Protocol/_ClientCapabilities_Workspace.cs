using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LspTypes
{
    [DataContract]
    public class _ClientCapabilities_Workspace
    {
        public _ClientCapabilities_Workspace() { }

        /**
         * The client supports applying batch edits
         * to the workspace by supporting the request
         * 'workspace/applyEdit'
         */
        [DataMember(Name = "applyEdit")]
        [JsonProperty(Required = Required.Default)]
        public bool ApplyEdit { get; set; }

        /**
         * Capabilities specific to `WorkspaceEdit`s
         */
        [DataMember(Name = "workspaceEdit")]
        [JsonProperty(Required = Required.Default)]
        public WorkspaceEditClientCapabilities WorkspaceEdit { get; set; }

        /**
         * Capabilities specific to the `workspace/didChangeConfiguration`
		 * notification.
         */
        [DataMember(Name = "didChangeConfiguration")]
        [JsonProperty(Required = Required.Default)]
        public DidChangeConfigurationClientCapabilities DidChangeConfiguration { get; set; }

        /**
         * Capabilities specific to the `workspace/didChangeWatchedFiles`
		 * notification.
		 */
        [DataMember(Name = "didChangeWatchedFiles")]
        [JsonProperty(Required = Required.Default)]
        public DidChangeWatchedFilesClientCapabilities DidChangeWatchedFiles { get; set; }

        /**
         * Capabilities specific to the `workspace/symbol` request.
         */
        [DataMember(Name = "symbol")]
        [JsonProperty(Required = Required.Default)]
        public WorkspaceSymbolClientCapabilities Symbol { get; set; }

        /**
         * Capabilities specific to the `workspace/executeCommand` request.
         */
        [DataMember(Name = "executeCommand")]
        [JsonProperty(Required = Required.Default)]
        public ExecuteCommandClientCapabilities ExecuteCommand { get; set; }

        /**
         * The client has support for workspace folders.
         *
         * @since 3.6.0
         */
        [DataMember(Name = "workspaceFolders")]
        [JsonProperty(Required = Required.Default)]
        public bool WorkspaceFolders { get; set; }

        /**
         * The client supports `workspace/configuration` requests.
         *
         * @since 3.6.0
         */
        [DataMember(Name = "configuration")]
        [JsonProperty(Required = Required.Default)]
        public bool Configuration { get; set; }

        /**
         * Capabilities specific to the semantic token requests scoped to the
         * workspace.
         *
         * @since 3.16.0
         */
        [DataMember(Name = "semanticTokens")]
        [JsonProperty(Required = Required.Default)]
        public SemanticTokensWorkspaceClientCapabilities SemanticTokens { get; set; }

        /**
		 * Capabilities specific to the code lens requests scoped to the
		 * workspace.
		 *
		 * @since 3.16.0
		 */
        [DataMember(Name = "codeLens")]
        [JsonProperty(Required = Required.Default)]
        public CodeLensWorkspaceClientCapabilities CodeLens { get; set; }

        /**
		 * The client has support for file requests/notifications.
		 *
		 * @since 3.16.0
		 */
        [DataMember(Name = "fileOperations")]
        [JsonProperty(Required = Required.Default)]
        public _ClientCapabilities_Workspace_FileOperations fileOperations { get; set; }

    }
}