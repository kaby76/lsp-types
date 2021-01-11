using System.Runtime.Serialization;

namespace LspTypes
{
    /**
     * An event describing a change to a text document. If range and rangeLength are
     * omitted the new text is considered to be the full content of the document.
     */
    [DataContract]
    public class TextDocumentContentChangeEvent
    {
        public TextDocumentContentChangeEvent() { }

        /**
         * The range of the document that changed.
         */
        [DataMember(Name = "range")]
        public Range Range { get; set; }

        /**
         * The optional length of the range that got replaced.
         *
         * @deprecated use range instead.
         */
        [DataMember(Name = "rangeLength")]
        public uint? RangeLength { get; set; }

        /**
         * The new text for the provided range.
         */
        // (or document)
        [DataMember(Name = "text")]
        public string Text { get; set; }
    }
}
