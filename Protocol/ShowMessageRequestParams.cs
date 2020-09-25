using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class ShowMessageRequestParams
    {
        public ShowMessageRequestParams() { }

        /**
         * The message type. See {@link MessageType}
         */
        [DataMember(Name = "type")]
        public int Type { get; set; }

        /**
         * The actual message
         */
        [DataMember(Name = "message")]
        public string Message { get; set; }
        
        /**
         * The message action items to present.
         */
        [DataMember(Name = "actions")]
        public MessageActionItem[] Actions { get; set; }
    }
}
