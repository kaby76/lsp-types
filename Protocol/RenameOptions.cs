using System.Runtime.Serialization;

namespace LspTypes
{
    //
    // Summary:
    //     TODO: Add documentation
    [DataContract]
    public class RenameOptions
    {
        public RenameOptions() { }

        //
        // Summary:
        //     Gets or sets a value indicating whether TODO: add documentation
        [DataMember(Name = "prepareProvider")]
        public bool PrepareProvider { get; set; }
    }
}
