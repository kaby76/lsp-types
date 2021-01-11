using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class Color
    {
		/**
		 * The red component of this color in the range [0-1].
		 */
		[DataMember(Name = "red")]
		[JsonProperty(Required = Required.Always)]
		public float Red { get; set; }

		/**
		 * The green component of this color in the range [0-1].
		 */
		[DataMember(Name = "green")]
		[JsonProperty(Required = Required.Always)]
		public float Green { get; set; }

		/**
		 * The blue component of this color in the range [0-1].
		 */
		[DataMember(Name = "blue")]
		[JsonProperty(Required = Required.Always)]
		public float Blue { get; set; }

		/**
		 * The alpha component of this color in the range [0-1].
		 */
		[DataMember(Name = "alpha")]
		[JsonProperty(Required = Required.Always)]
		public float Alpha { get; set; }
    }
}
