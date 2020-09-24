using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public enum SymbolTag
    {
        /**
         * Render a symbol as obsolete, usually using a strike-out.
         */
        Deprecated = 1,
    }
}