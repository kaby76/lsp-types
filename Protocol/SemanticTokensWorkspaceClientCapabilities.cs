using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class SemanticTokensWorkspaceClientCapabilities
    {
        public SemanticTokensWorkspaceClientCapabilities() { }

		/**
		 * Whether the client implementation supports a refresh request sent from
		 * the server to the client.
		 *
		 * Note that this event is global and will force the client to refresh all
		 * semantic tokens currently shown. It should be used with absolute care
		 * and is useful for situation where a server for example detect a project
		 * wide change that requires such a calculation.
		 */
		[DataMember(Name = "refreshSupport")]
		[JsonProperty(Required = Required.Default)]
		public bool? RefreshSupport { get; set; }
    }
}
