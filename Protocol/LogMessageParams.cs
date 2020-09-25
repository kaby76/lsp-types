using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class LogMessageParams
    {
        public LogMessageParams() { }

        /**
         * The message type. See {@link MessageType}
         */
        [DataMember(Name = "type")]
        public MessageType MessageType { get; set; }

        /**
         * The actual message
         */
        [DataMember(Name = "message")]
        public string Message { get; set; }
    }
}
