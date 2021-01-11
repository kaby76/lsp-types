using System.Runtime.Serialization;

namespace LspTypes
{
    /**
     * How a signature help was triggered.
     *
     * @since 3.15.0
     */
    [DataContract]
    public enum SignatureHelpTriggerKind
    {
        /**
         * Signature help was invoked manually by the user or by a command.
         */
        Invoked = 1,

        /**
         * Signature help was triggered by a trigger character.
         */
        TriggerCharacter = 2,

        /**
         * Signature help was triggered by the cursor moving or by the document
	     * content changing.
         */
        ContentChange = 3,
    }
}
