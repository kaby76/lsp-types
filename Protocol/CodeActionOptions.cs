using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class CodeActionOptions : WorkDoneProgressOptions
    {
        public CodeActionOptions() { }

        /**
         * CodeActionKinds that this server may return.
         *
         * The list of kinds may be generic, such as `CodeActionKind.Refactor`, or the server
         * may list out every specific kind they provide.
         */
        [DataMember(Name = "codeActionKinds")]
        [JsonProperty(Required = Required.Default)]
        public CodeActionKind[] CodeActionKinds { get; set; }
    }
}
