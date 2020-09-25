using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class ReferenceContext
    {
        public ReferenceContext() { }

        /**
         * Include the declaration of the current symbol.
         */
        [DataMember(Name = "includeDeclaration")]
        public bool IncludeDeclaration { get; set; }
    }
}
