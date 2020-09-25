using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class SelectionRangeRegistrationOptions : SelectionRangeOptions, ITextDocumentRegistrationOptions, IStaticRegistrationOptions
    {
        public SelectionRangeRegistrationOptions() { }

        /**
         * A document selector to identify the scope of the registration. If set to null
         * the document selector provided on the client side will be used.
         */
        [DataMember(Name = "documentSelector")]
        [JsonProperty(Required = Required.Always)]
        public DocumentFilter[] documentSelector { get; set; }

        /**
        * The id used to register the request. The id can be used to deregister
        * the request again. See also Registration#id.
        */
        [DataMember(Name = "id")]
        [JsonProperty(Required = Required.Default)]
        public string Id { get; set; }
    }
}