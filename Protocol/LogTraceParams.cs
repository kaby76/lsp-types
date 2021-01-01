using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class LogTraceParams
    {
        public LogTraceParams() { }

		/**
		 * The message to be logged.
		 */
		[DataMember(Name = "message")]
		public string Message { get; set; }

		/**
		 * Additional information that can be computed if the `trace` configuration
		 * is set to `'verbose'`
		 */
		[DataMember(Name = "verbose")]
		public string Verbose { get; set; }
	}
}
