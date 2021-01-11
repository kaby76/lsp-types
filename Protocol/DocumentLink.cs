using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    /**
     * A document link is a range in a text document that links to an internal or
     * external resource, like another text document or a web site.
     */
    [DataContract]
    public class DocumentLink
    {
        public DocumentLink() { }

        /**
         * The range this link applies to.
         */
        [DataMember(Name = "range")]
        [JsonProperty(Required = Required.Always)]
        public Range Range { get; set; }

        /**
         * The uri this link points to. If missing a resolve request is sent later.
         */
        [DataMember(Name = "target")]
        [JsonProperty(Required = Required.Default)]
        public string Target { get; set; }

        /**
         * The tooltip text when you hover over this link.
         *
         * If a tooltip is provided, is will be displayed in a string that includes
	     * instructions on how to trigger the link, such as `{0} (ctrl + click)`.
	     * The specific instructions vary depending on OS, user settings, and
	     * localization.
	     *
         * @since 3.15.0
         */
        [DataMember(Name = "tooltip")]
        [JsonProperty(Required = Required.Default)]
        public string Tooltip { get; set; }

        /**
         * A data entry field that is preserved on a document link between a
         * DocumentLinkRequest and a DocumentLinkResolveRequest.
         */
        [DataMember(Name = "data")]
        [JsonProperty(Required = Required.Default)]
        public object Data { get; set; }
    }
}
