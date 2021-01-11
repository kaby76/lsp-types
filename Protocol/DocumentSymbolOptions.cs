using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class DocumentSymbolOptions : WorkDoneProgressOptions
    {
        public DocumentSymbolOptions() : base() { }

        /**
		 * A human-readable string that is shown when multiple outlines trees
		 * are shown for the same document.
		 *
		 * @since 3.16.0
		 */
        [DataMember(Name = "label")]
        [JsonProperty(Required = Required.Default)]
        public string Label { get; set; }
    }

    public interface IDocumentSymbolOptions : IWorkDoneProgressOptions
    {
        string Label { get; set; }
    }
}