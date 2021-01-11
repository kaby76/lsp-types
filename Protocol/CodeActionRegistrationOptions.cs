using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class CodeActionRegistrationOptions : TextDocumentRegistrationOptions, ICodeActionOptions
    {
        public CodeActionRegistrationOptions() { }

        [DataMember(Name = "codeActionKinds")]
        [JsonProperty(Required = Required.Default)]
        public CodeActionKind[] CodeActionKinds { get; set; }

        [DataMember(Name = "resolveProvider")]
        [JsonProperty(Required = Required.Default)]
        public bool? WorkDoneProgress { get; set; }
    }
}
