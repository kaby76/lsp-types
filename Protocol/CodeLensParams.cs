using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class CodeLensParams : WorkDoneProgressParams, IPartialResultParams
    {
        public CodeLensParams() { }

        /**
         * The document to request code lens for.
         */
        [DataMember(Name = "textDocument")]
        public TextDocumentIdentifier TextDocument { get; set; }

        /**
         * An optional token that a server can use to report partial results (e.g. streaming) to
         * the client.
         */
        [DataMember(Name = "partialResultToken")]
        [JsonProperty(Required = Required.Default)]
        public SumType<int, string> PartialResultToken { get; set; }
    }
}
