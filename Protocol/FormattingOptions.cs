using Newtonsoft.Json;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace LspTypes
{
    /**
     * Value-object describing what options formatting should use.
     */
    [DataContract]
    public class FormattingOptions
    {
        public FormattingOptions() { }

        /**
         * Size of a tab in spaces.
         */
        [DataMember(Name = "tabSize")]
        [JsonProperty(Required = Required.Always)]
        public uint TabSize { get; set; }

        /**
         * Prefer spaces over tabs.
         */
        [DataMember(Name = "insertSpaces")]
        [JsonProperty(Required = Required.Always)]
        public bool InsertSpaces { get; set; }

        /**
         * Trim trailing whitespace on a line.
         *
         * @since 3.15.0
         */
        [DataMember(Name = "trimTrailingWhitespace")]
        [JsonProperty(Required = Required.Default)]
        public bool? TrimTrailingWhitespace { get; set; }

        /**
         * Insert a newline character at the end of the file if one does not exist.
         *
         * @since 3.15.0
         */
        [DataMember(Name = "insertFinalNewline")]
        [JsonProperty(Required = Required.Default)]
        public bool? InsertFinalNewline { get; set; }

        /**
         * Trim all newlines after the final newline at the end of the file.
         *
         * @since 3.15.0
         */
        [DataMember(Name = "trimFinalNewlines")]
        [JsonProperty(Required = Required.Default)]
        public bool? TrimFinalNewlines { get; set; }

        /**
         * Signature for further properties.
         */
        [JsonExtensionData]
        [JsonProperty(Required = Required.Default)]
        public Dictionary<string, SumType<bool, int, string>> OtherOptions { get; set; }
    }
}
