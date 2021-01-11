using System.Runtime.Serialization;

namespace LspTypes
{
    /**
     * Symbol tags are extra annotations that tweak the rendering of a symbol.
     *
     * @since 3.16
     */
    [DataContract]
    public enum SymbolTag
    {
        /**
         * Render a symbol as obsolete, usually using a strike-out.
         */
        Deprecated = 1,
    }
}