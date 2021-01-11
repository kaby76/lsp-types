using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class _CodeAction_Disabled
    {
        public _CodeAction_Disabled() { }

        /**
		 * Human readable description of why the code action is currently
		 * disabled.
		 *
		 * This is displayed in the code actions UI.
		 */
        [DataMember(Name = "reason")]
        [JsonProperty(Required = Required.Default)]
        public string Reason { get; set; }
    }
}