using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class CallHierarchyIncomingCallsParams : WorkDoneProgressParams, IPartialResultParams
    {
        public CallHierarchyIncomingCallsParams() : base() { }

        [DataMember(Name = "item")]
        [JsonProperty(Required = Required.Default)]
        public CallHierarchyItem Item { get; set; }

        [DataMember(Name = "partialResultToken")]
        [JsonProperty(Required = Required.Default, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public SumType<int, string> PartialResultToken { get; set; }
    }
}
