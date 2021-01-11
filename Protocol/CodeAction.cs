using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    /**
     * A code action represents a change that can be performed in code, e.g. to fix
     * a problem or to refactor code.
     *
     * A CodeAction must set either `edit` and/or a `command`. If both are supplied,
     * the `edit` is applied first, then the `command` is executed.
     */
    [DataContract]
    public class CodeAction
    {
        public CodeAction() { }

        /**
         * A short, human-readable, title for this code action.
         */
        [DataMember(Name = "title")]
        [JsonProperty(Required = Required.Always)]
        public string Title { get; set; }

        /**
         * The kind of the code action.
         *
         * Used to filter code actions.
         */
        [DataMember(Name = "kind")]
        [JsonProperty(Required = Required.Default)]
        public CodeActionKind? Kind { get; set; }

        /**
         * The diagnostics that this code action resolves.
         */
        [DataMember(Name = "diagnostics")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Diagnostic[] Diagnostics { get; set; }

        /**
         * Marks this as a preferred action. Preferred actions are used by the
	     * `auto fix` command and can be targeted by keybindings.
         *
         * A quick fix should be marked preferred if it properly addresses the
	     * underlying error. A refactoring should be marked preferred if it is the
	     * most reasonable choice of actions to take.
         *
         * @since 3.15.0
         */
        [DataMember(Name = "isPreferred")]
        [JsonProperty(Required = Required.Default)]
        public bool? IsPreferred { get; set; }
        /**
         * Marks that the code action cannot currently be applied.
         *
         * Clients should follow the following guidelines regarding disabled code
         * actions:
         *
         * - Disabled code actions are not shown in automatic lightbulbs code
         *   action menus.
         *
         * - Disabled actions are shown as faded out in the code action menu when
         *   the user request a more specific type of code action, such as
         *   refactorings.
         *
         * - If the user has a keybinding that auto applies a code action and only
         *   a disabled code actions are returned, the client should show the user
         *   an error message with `reason` in the editor.
         *
         * @since 3.16.0
         */
        [DataMember(Name = "disabled")]
        [JsonProperty(Required = Required.Default)]
        public _CodeAction_Disabled Disabled { get; set; }

        /**
         * The workspace edit this code action performs.
         */
        [DataMember(Name = "edit")]
        [JsonProperty(Required = Required.Default)]
        public WorkspaceEdit Edit { get; set; }

        /**
         * A command this code action executes. If a code action
         * provides an edit and a command, first the edit is
         * executed and then the command.
         */
        [DataMember(Name = "command")]
        [JsonProperty(Required = Required.Default)]
        public Command Command { get; set; }
        /**
          * A data entry field that is preserved on a code action between
          * a `textDocument/codeAction` and a `codeAction/resolve` request.
          *
          * @since 3.16.0
          */
        [DataMember(Name = "data")]
        [JsonProperty(Required = Required.Default)]
        public object Data { get; set; }
    }
}
