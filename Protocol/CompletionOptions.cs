using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    /**
     * Completion options.
     */
    [DataContract]
    public class CompletionOptions : WorkDoneProgressOptions
    {
        public CompletionOptions() { }

        /**
         * Most tools trigger completion request automatically without explicitly requesting
         * it using a keyboard shortcut (e.g. Ctrl+Space). Typically they do so when the user
         * starts to type an identifier. For example if the user types `c` in a JavaScript file
         * code complete will automatically pop up present `console` besides others as a
         * completion item. Characters that make up identifiers don't need to be listed here.
         *
         * If code complete should automatically be trigger on characters not being valid inside
         * an identifier (for example `.` in JavaScript) list them in `triggerCharacters`.
         */
        [DataMember(Name = "triggerCharacters")]
        public string[] TriggerCharacters { get; set; }

        /**
         * The list of all possible characters that commit a completion. This field can be used
         * if clients don't support individual commit characters per completion item. See
         * `ClientCapabilities.textDocument.completion.completionItem.commitCharactersSupport`.
         *
         * If a server provides both `allCommitCharacters` and commit characters on an individual
         * completion item the ones on the completion item win.
         *
         * @since 3.2.0
         */
        [DataMember(Name = "allCommitCharacters")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string[] AllCommitCharacters { get; set; }

        /**
         * The server provides support to resolve additional
         * information for a completion item.
         */
        [DataMember(Name = "resolveProvider")]
        public bool ResolveProvider { get; set; }
    }
}
