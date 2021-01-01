using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class RegularExpressionsClientCapabilities
    {
        public RegularExpressionsClientCapabilities() { }

		/**
		 * The engine's name.
		 */
		[DataMember(Name = "engine")]
		[JsonProperty(Required = Required.Always)]
		public string Engine { get; set; }

		/**
		 * The engine's version.
		 */
		[DataMember(Name = "version")]
		[JsonProperty(Required = Required.Default)]
		public string Version { get; set; }
    }
}
