using Newtonsoft.Json;
using System;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class CompletionParams : TextDocumentPositionParams, WorkDoneProgressParams, PartialResultParams
    {
        public CompletionParams() { }

        /**
         * The completion context. This is only available if the client specifies
         * to send this using `ClientCapabilities.textDocument.completion.contextSupport === true`
         */
        [DataMember(Name = "context")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public CompletionContext Context { get; set; }

        [DataMember(Name = "partialResultToken", IsRequired = false)]
        public IProgress<SumType<CompletionItem[], CompletionList>?> PartialResultToken { get; set; }
    }
}
