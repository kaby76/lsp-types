using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    public interface IDocumentLinkOptions
    {
        bool? ResolveProvider { get; set; }
    }

    [DataContract]
    public class DocumentLinkOptions : WorkDoneProgressOptions, IDocumentLinkOptions
    {
        public DocumentLinkOptions() { }

        /**
         * Document links have a resolve provider as well.
         */
        [DataMember(Name = "resolveProvider")]
        [JsonProperty(Required = Required.Default)]
        public bool? ResolveProvider { get; set; }
    }
}
