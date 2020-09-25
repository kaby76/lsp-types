using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class ShowMessageParams
    {
        public ShowMessageParams() { }

        /**
         * The message type. See {@link MessageType}.
         */
        [DataMember(Name = "type")]
        public MessageType MessageType { get; set; }

        /**
         * The actual message.
         */
        [DataMember(Name = "message")]
        public string Message { get; set; }
    }
}
