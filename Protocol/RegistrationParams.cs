using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class RegistrationParams
    {
        public RegistrationParams() { }

        [DataMember(Name = "registrations")]
        public Registration[] Registrations { get; set; }
    }
}
