using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
	[DataContract]
	public class SetTraceParams
	{
		public SetTraceParams() { }

		/**
		 * The new value that should be assigned to the trace setting.
		 */
		[DataMember(Name = "value")]
		public TraceValue Value { get; set; }
	}
}
