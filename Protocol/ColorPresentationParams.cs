using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    /**
     * Params for the CodeActionRequest
     */
    [DataContract]
    public class ColorPresentationParams : WorkDoneProgressParams, IPartialResultParams
    {
        public ColorPresentationParams() { }

        /**
	     * The text document.
	     */
        [DataMember(Name = "textDocument")]
        [JsonProperty(Required = Required.Always)]
        public TextDocumentIdentifier TextDocument { get; set; }

        /**
	     * The color information to request presentations for.
	     */
        [DataMember(Name = "color")]
        [JsonProperty(Required = Required.Always)]
        public Color Color { get; set; }

	    /**
	     * The range where the color would be inserted. Serves as a context.
	     */
	    [DataMember(Name = "range")]
        [JsonProperty(Required = Required.Always)]
        public Range Range { get; set; }

        [DataMember(Name = "partialResultToken")]
        [JsonProperty(Required = Required.Default, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public SumType<int, string> PartialResultToken { get; set; }
    }
}
