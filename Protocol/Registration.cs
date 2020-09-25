using System.Runtime.Serialization;

namespace LspTypes
{
    /**
     * General parameters to register for a capability.
     */
    [DataContract]
    public class Registration
    {
        public Registration() { }

        /**
         * The id used to register the request. The id can be used to deregister
         * the request again.
         */
        [DataMember(Name = "id")]
        public string Id { get; set; }

        /**
         * The method / capability to register for.
         */
        [DataMember(Name = "method")]
        public string Method { get; set; }

        /**
         * Options necessary for the registration.
         */
        [DataMember(Name = "registerOptions")]
        public object RegisterOptions { get; set; }
    }
}
