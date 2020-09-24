using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class CodeLensOptions : WorkDoneProgressOptions
    {
        public CodeLensOptions() { }

        /**
         * Code lens has a resolve provider as well.
         */
        [DataMember(Name = "resolveProvider")]
        public bool ResolveProvider { get; set; }
    }
}
