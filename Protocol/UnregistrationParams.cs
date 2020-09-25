using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class UnregistrationParams
    {
        public UnregistrationParams() { }

        // This should correctly be named `unregistrations`. However changing this
        // is a breaking change and needs to wait until we deliver a 4.x version
        // of the specification.
        [DataMember(Name = "unregistrations")]
        public Unregistration[] Unregistrations { get; set; }
    }
}
