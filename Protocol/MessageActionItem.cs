using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class MessageActionItem
    {
        public MessageActionItem() { }

        /**
         * A short title like 'Retry', 'Open Log' etc.
         */
        [DataMember(Name = "title")]
        public string Title { get; set; }
    }
}
