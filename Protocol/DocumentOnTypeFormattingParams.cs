using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class DocumentOnTypeFormattingParams : TextDocumentPositionParams
    {
        public DocumentOnTypeFormattingParams() { }

        /**
         * The character that has been typed.
         */
        [DataMember(Name = "ch")]
        [JsonProperty(Required = Required.Always)]
        public string Character { get; set; }

        /**
         * The format options.
         */
        [DataMember(Name = "options")]
        [JsonProperty(Required = Required.Always)]
        public FormattingOptions Options { get; set; }
    }
}
