using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    /**
     * MarkedString can be used to render human readable text. It is either a markdown string
     * or a code-block that provides a language and a code snippet. The language identifier
     * is semantically equal to the optional language identifier in fenced code blocks in GitHub
     * issues. See https://help.github.com/articles/creating-and-highlighting-code-blocks/#syntax-highlighting
     *
     * The pair of a language and a value is an equivalent to markdown:
     * ```${language}
     * ${value}
     * ```
     *
     * Note that markdown strings will be sanitized - that means html will be escaped.
     * @deprecated use MarkupContent instead.
     */
    [DataContract]
    public class MarkedString
    {
        public MarkedString() { }

        [DataMember(Name = "language")]
        [JsonProperty(Required = Required.Always)]
        public string Language { get; set; }
        //
        // Summary:
        //     Gets or sets the code.
        [DataMember(Name = "value")]
        [JsonProperty(Required = Required.Always)]
        public string Value { get; set; }
    }
}
