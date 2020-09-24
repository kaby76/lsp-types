using System.Runtime.Serialization;

namespace LspTypes
{
    /**
     * Contains additional information about the context in which a completion request is triggered.
     */
    [DataContract]
    public class CompletionContext
    {
        public CompletionContext() { }

        /**
         * How the completion was triggered.
         */
        [DataMember(Name = "triggerKind")]
        public CompletionTriggerKind TriggerKind { get; set; }

        /**
         * The trigger character (a single character) that has trigger code complete.
         * Is undefined if `triggerKind !== CompletionTriggerKind.TriggerCharacter`
         */
        [DataMember(Name = "triggerCharacter")]
        public string TriggerCharacter { get; set; }
    }
}
