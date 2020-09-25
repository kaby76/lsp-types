using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class DocumentRangeFormattingParams : WorkDoneProgressParams
    {
        public DocumentRangeFormattingParams() { }

        /**
         * The document to format.
         */
        [DataMember(Name = "textDocument")]
        [JsonProperty(Required = Required.Always)]
        public TextDocumentIdentifier TextDocument { get; set; }

        /**
         * The range to format
         */
        [DataMember(Name = "range")]
        [JsonProperty(Required = Required.Always)]
        public Range Range { get; set; }

        /**
         * The format options
         */
        [DataMember(Name = "options")]
        [JsonProperty(Required = Required.Always)]
        public FormattingOptions Options { get; set; }
    }
}
