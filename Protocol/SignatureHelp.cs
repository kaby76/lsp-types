using System.Runtime.Serialization;

namespace LspTypes
{
    /**
     * Signature help represents the signature of something
     * callable. There can be multiple signature but only one
     * active and only one active parameter.
     */
    [DataContract]
    public class SignatureHelp
    {
        public SignatureHelp() { }

        /**
         * One or more signatures. If no signatures are available the signature help
         * request should return `null`.
         */
        [DataMember(Name = "signatures")]
        public SignatureInformation[] Signatures { get; set; }

        /**
         * The active signature. If omitted or the value lies outside the
         * range of `signatures` the value defaults to zero or is ignore if
         * the `SignatureHelp` as no signatures.
         *
         * Whenever possible implementors should make an active decision about
         * the active signature and shouldn't rely on a default value.
         *
         * In future version of the protocol this property might become
         * mandatory to better express this.
         */
        [DataMember(Name = "activeSignature")]
        public uint? ActiveSignature { get; set; }

        /**
         * The active parameter of the active signature. If omitted or the value
         * lies outside the range of `signatures[activeSignature].parameters`
         * defaults to 0 if the active signature has parameters. If
         * the active signature has no parameters it is ignored.
         * In future version of the protocol this property might become
         * mandatory to better express the active parameter if the
         * active signature does have any.
         */
        [DataMember(Name = "activeParameter")]
        public uint? ActiveParameter { get; set; }
    }
}
