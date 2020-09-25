using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class DocumentLinkOptions : WorkDoneProgressOptions
    {
        public DocumentLinkOptions() { }

        /**
         * Document links have a resolve provider as well.
         */
        [DataMember(Name = "resolveProvider")]
        [JsonProperty(Required = Required.Default)]
        public bool ResolveProvider { get; set; }
    }
}
