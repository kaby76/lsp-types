using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LspTypes
{
    [DataContract]
    public class SignatureHelpRegistrationOptions : TextDocumentRegistrationOptions, ISignatureHelpOptions, IWorkDoneProgressOptions
    {
        public SignatureHelpRegistrationOptions() { }

        [DataMember(Name = "triggerCharacters")]
        public string[] TriggerCharacters { get; set; }

        [DataMember(Name = "retriggerCharacters")]
        public string[] RetriggerCharacters { get; set; }

        [DataMember(Name = "workDoneProgress")]
        [JsonProperty(Required = Required.Default)]
        public bool? WorkDoneProgress { get; set; }
    }
}
