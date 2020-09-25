using System.Runtime.Serialization;

namespace LspTypes
{
    /**
     * General parameters to unregister a capability.
     */
    [DataContract]
    public class Unregistration
    {
        public Unregistration() { }

        /**
         * The id used to unregister the request or notification. Usually an id
         * provided during the register request.
         */
        [DataMember(Name = "id")]
        public string Id { get; set; }

        /**
         * The method / capability to unregister for.
         */
        [DataMember(Name = "method")]
        public string Method { get; set; }
    }
}
