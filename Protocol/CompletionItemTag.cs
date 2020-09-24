using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public enum CompletionItemTag
    {
        /**
         * Render a completion as obsolete, usually using a strike-out.
         */
        Deprecated = 1,
    }
}
