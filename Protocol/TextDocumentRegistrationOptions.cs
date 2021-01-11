using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    public interface ITextDocumentRegistrationOptions
    {
        DocumentFilter[] DocumentSelector { get; set; }
    }

    [DataContract]
    public class TextDocumentRegistrationOptions : ITextDocumentRegistrationOptions
    {
        public TextDocumentRegistrationOptions() { }

        /**
         * A document selector to identify the scope of the registration. If set to
	     * null the document selector provided on the client side will be used.
         */
        [DataMember(Name = "documentSelector")]
        [JsonProperty(Required = Required.Always)]
        public DocumentFilter[] DocumentSelector { get; set; }
    }
}
