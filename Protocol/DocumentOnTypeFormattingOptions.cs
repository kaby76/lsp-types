using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    public interface IDocumentOnTypeFormattingOptions
    {
        string FirstTriggerCharacter { get; set; }
        string[] MoreTriggerCharacter { get; set; }
    }

    [DataContract]
    public class DocumentOnTypeFormattingOptions
    {
        public DocumentOnTypeFormattingOptions() { }

        /**
         * A character on which formatting should be triggered, like `}`.
         */
        [DataMember(Name = "firstTriggerCharacter")]
        [JsonProperty(Required = Required.Always)]
        public string FirstTriggerCharacter { get; set; }

        /**
         * More trigger characters.
         */
        [DataMember(Name = "moreTriggerCharacter")]
        [JsonProperty(Required = Required.Default)]
        public string[] MoreTriggerCharacter { get; set; }
    }
}
