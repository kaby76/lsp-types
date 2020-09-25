using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class DocumentLinkRegistrationOptions : TextDocumentRegistrationOptions, IDocumentLinkOptions
    {
        public DocumentLinkRegistrationOptions() { }

        /**
         * Document links have a resolve provider as well.
         */
        [DataMember(Name = "resolveProvider")]
        [JsonProperty(Required = Required.Default)]
        public bool ResolveProvider { get; set; }
    }
}
