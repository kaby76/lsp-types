using System.Runtime.Serialization;

namespace LspTypes
{
    /**
     * A document highlight kind.
     */
    [DataContract]
    public enum DocumentHighlightKind
    {
        /**
         * A textual occurrence.
         */
        Text = 1,

        /**
         * Read-access of a symbol, like reading a variable.
         */
        Read = 2,

        /**
         * Write-access of a symbol, like writing to a variable.
         */
        Write = 3
    }
}
