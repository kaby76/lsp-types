using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class RenameParams : TextDocumentPositionParams, IWorkDoneProgressParams
    {
        public RenameParams() { }

        /**
         * The new name of the symbol. If the given name is not valid the
         * request must return a [ResponseError](#ResponseError) with an
         * appropriate message set.
         */
        [DataMember(Name = "newName")]
        public string NewName { get; set; }

        /**
         * An optional token that a server can use to report work done progress.
         */
        [DataMember(Name = "workDoneToken")]
        [JsonProperty(Required = Required.Default, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public SumType<string, int> WorkDoneToken { get; set; }
    }
}
