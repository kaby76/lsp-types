using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class InitializeError
    {
        public InitializeError() { }

        /**
         * Indicates whether the client execute the following retry logic:
         * (1) show the message provided by the ResponseError to the user
         * (2) user selects retry or cancel
         * (3) if user selected retry the initialize method is sent again.
         */
        [DataMember(Name = "retry")]
        public bool Retry { get; set; }
    }
}
