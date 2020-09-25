using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class ServerCapabilities
    {
        public ServerCapabilities() { }

        /**
         * Defines how text documents are synced. Is either a detailed structure defining each notification or
         * for backwards compatibility the TextDocumentSyncKind number. If omitted it defaults to `TextDocumentSyncKind.None`.
         */
        [DataMember(Name = "textDocumentSync")]
        public SumType<TextDocumentSyncOptions, int> TextDocumentSync { get; set; }

        /**
         * The server provides completion support.
         */
        [DataMember(Name = "completionProvider")]
        public SumType<bool, CompletionOptions> CompletionProvider { get; set; }

        /**
         * The server provides hover support.
         */
        [DataMember(Name = "hoverProvider")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public SumType<bool, HoverOptions> HoverProvider { get; set; }

        /**
         * The server provides signature help support.
         */
        [DataMember(Name = "signatureHelpProvider")]
        public SignatureHelpOptions SignatureHelpProvider { get; set; }

        /**
         * The server provides go to declaration support.
         *
         * @since 3.14.0
         */
        [DataMember(Name = "declarationProvider")]
        public SumType<bool, DeclarationOptions, DeclarationRegistrationOptions> DeclarationProvider { get; set; }

        /**
         * The server provides goto definition support.
         */
        [DataMember(Name = "definitionProvider")]
        public SumType<bool, DefinitionOptions> DefinitionProvider { get; set; }

        /**
         * The server provides goto type definition support.
         *
         * @since 3.6.0
         */
        [DataMember(Name = "typeDefinitionProvider")]
        public SumType<bool, TypeDefinitionOptions, TypeDefinitionRegistrationOptions> TypeDefinitionProvider { get; set; }

        /**
         * The server provides goto implementation support.
         *
         * @since 3.6.0
         */
        [DataMember(Name = "implementationProvider")]
        public SumType<bool, ImplementationOptions, ImplementationRegistrationOptions> ImplementationProvider { get; set; }

        /**
         * The server provides find references support.
         */
        [DataMember(Name = "referencesProvider")]
        public SumType<bool, ReferenceOptions> ReferencesProvider { get; set; }

        /**
         * The server provides document highlight support.
         */
        [DataMember(Name = "documentHighlightProvider")]
        public SumType<bool, DocumentHighlightOptions> DocumentHighlightProvider { get; set; }

        /**
         * The server provides document symbol support.
         */
        [DataMember(Name = "documentSymbolProvider")]
        public SumType<bool, DocumentSymbolOptions> DocumentSymbolProvider { get; set; }

        /**
         * The server provides code actions. The `CodeActionOptions` return type is only
         * valid if the client signals code action literal support via the property
         * `textDocument.codeAction.codeActionLiteralSupport`.
         */
        [DataMember(Name = "codeActionProvider")]
//TODO        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public SumType<bool, CodeActionOptions> CodeActionProvider { get; set; }

        /**
         * The server provides code lens.
         */
        [DataMember(Name = "codeLensProvider")]
        public CodeLensOptions CodeLensProvider { get; set; }

        /**
         * The server provides document link support.
         */
        [DataMember(Name = "documentLinkProvider")]
        public DocumentLinkOptions DocumentLinkProvider { get; set; }

        /**
         * The server provides color provider support.
         *
         * @since 3.6.0
         */
        [DataMember(Name = "colorProvider")]
//TODO        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public SumType<bool, DocumentColorOptions, DocumentColorRegistrationOptions> ColorProvider { get; set; }

        /**
         * The server provides document formatting.
         */
        [DataMember(Name = "documentFormattingProvider")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public SumType<bool, DocumentFormattingOptions> DocumentFormattingProvider { get; set; }

        /**
         * The server provides document range formatting.
         */
        [DataMember(Name = "documentRangeFormattingProvider")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public SumType<bool, DocumentRangeFormattingOptions> DocumentRangeFormattingProvider { get; set; }

        /**
         * The server provides document formatting on typing.
         */
        [DataMember(Name = "documentOnTypeFormattingProvider")]
        public DocumentOnTypeFormattingOptions DocumentOnTypeFormattingProvider { get; set; }

        /**
         * The server provides rename support. RenameOptions may only be
         * specified if the client states that it supports
         * `prepareSupport` in its initial `initialize` request.
         */
        [DataMember(Name = "renameProvider")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public SumType<bool, RenameOptions> RenameProvider { get; set; }

        /**
         * The server provides folding provider support.
         *
         * @since 3.10.0
         */
        [DataMember(Name = "foldingRangeProvider")]
        public SumType<bool, FoldingRangeOptions, FoldingRangeRegistrationOptions> FoldingRangeProvider { get; set; }

        /**
         * The server provides execute command support.
         */
        [DataMember(Name = "executeCommandProvider")]
        public ExecuteCommandOptions ExecuteCommandProvider { get; set; }

        /**
         * The server provides selection range support.
         *
         * @since 3.15.0
         */
        [DataMember(Name = "selectionRangeProvider")]
        public SumType<bool, SelectionRangeOptions, SelectionRangeRegistrationOptions> SelectionRangeProvider { get; set; }
                        
        /**
         * The server provides semantic tokens support.
         *
         * @since 3.16.0
         */
        [DataMember(Name = "semanticTokensProvider")]
        public SumType<SemanticTokensOptions, SemanticTokensRegistrationOptions> SemanticTokensProvider { get; set; }

        /**
         * The server provides workspace symbol support.
         */
        [DataMember(Name = "workspaceSymbolProvider")]
        public bool WorkspaceSymbolProvider { get; set; }

        /**
         * Workspace specific server capabilities
         */
        [DataMember(Name = "workspace")]
        public _ServerCapabilities_Workspace Workspace { get; set; }
        
        /**
         * Experimental server capabilities.
         */
        [DataMember(Name = "experimental")]
        public object Experimental { get; set; }
    }
}