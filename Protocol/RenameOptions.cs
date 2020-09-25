using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class RenameOptions : WorkDoneProgressOptions
    {
        public RenameOptions() { }

        /**
         * Renames should be checked and tested before being executed.
         */
        [DataMember(Name = "prepareProvider")]
        public bool PrepareProvider { get; set; }
    }
}
