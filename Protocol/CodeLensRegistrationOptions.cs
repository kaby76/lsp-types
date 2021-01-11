using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class CodeLensRegistrationOptions : TextDocumentRegistrationOptions, ICodeLensOptions
    {
        public CodeLensRegistrationOptions() { }

        /**
         * Code lens has a resolve provider as well.
         */
        [DataMember(Name = "resolveProvider")]
        public bool? ResolveProvider { get; set; }

        [DataMember(Name = "workDoneProgress")]
        [JsonProperty(Required = Required.Default)]
        public bool? WorkDoneProgress { get; set; }
    }
}
