using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class SignatureHelpParams : TextDocumentPositionParams, IWorkDoneProgressParams
    {
        public SignatureHelpParams() { }

        /**
         * The signature help context. This is only available if the client
	     * specifies to send this using the client capability
	     * `textDocument.signatureHelp.contextSupport === true`
         *
         * @since 3.15.0
         */
        [DataMember(Name = "context")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public SignatureHelpContext Context { get; set; }

        /**
         * An optional token that a server can use to report work done progress.
         */
        [DataMember(Name = "workDoneToken")]
        [JsonProperty(Required = Required.Default, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public SumType<string, int> WorkDoneToken { get; set; }
    }
}
