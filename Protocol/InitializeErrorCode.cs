using System.Runtime.Serialization;

namespace LspTypes
{
    /**
     * Known error codes for an `InitializeError`;
     */
    [DataContract]
    public enum InitializeErrorCode
    {
        /**
         * If the protocol version provided by the client can't be handled by the server.
         * @deprecated This initialize error got replaced by client capabilities. There is
         * no version handshake in version 3.0x
         */
        UnknownProtocolVersion = 1
    }
}
