using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LspTypes
{
    [DataContract]
    public class WorkDoneProgressCreateParams
    {
        public WorkDoneProgressCreateParams() { }

        /**
	     * The token to be used to report progress.
	     */
        [DataMember(Name = "token")]
        [JsonProperty(Required = Required.Always)]
        public SumType<int, string> Token { get; set; }
    }
}
