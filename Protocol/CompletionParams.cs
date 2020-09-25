using Newtonsoft.Json;
using System;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class CompletionParams : TextDocumentPositionParams, IWorkDoneProgressParams, IPartialResultParams
    {
        public CompletionParams() { }

        /**
         * The completion context. This is only available if the client specifies
         * to send this using `ClientCapabilities.textDocument.completion.contextSupport === true`
         */
        [DataMember(Name = "context")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public CompletionContext Context { get; set; }

        /**
         * An optional token that a server can use to report work done progress.
         */
        [DataMember(Name = "workDoneToken")]
        [JsonProperty(Required = Required.Default, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public SumType<string, int> WorkDoneToken { get; set; }
        
        /**
         * An optional token that a server can use to report partial results (e.g. streaming) to
         * the client.
         */
        [DataMember(Name = "partialResultToken")]
        [JsonProperty(Required = Required.Default, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public SumType<int, string> PartialResultToken { get; set; }
    }
}
