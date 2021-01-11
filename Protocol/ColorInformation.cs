using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class ColorInformation
    {
        public ColorInformation() { }

		/**
		 * The range in the document where this color appears.
		 */
		[DataMember(Name = "range")]
		[JsonProperty(Required = Required.Always)]
		public Range Range { get; set; }

		/**
		 * The actual color value for this color range.
		 */
		[DataMember(Name = "color")]
		[JsonProperty(Required = Required.Always)]
		public Color Color { get; set; }
    }
}
