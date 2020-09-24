using System.Runtime.Serialization;

namespace LspTypes
{
    /**
     * Describe options to be used when registering for file system change events.
     */
    [DataContract]
    public class DidChangeWatchedFilesRegistrationOptions
    {
        public DidChangeWatchedFilesRegistrationOptions() { }

        /**
         * The watchers to register.
         */
        [DataMember(Name = "watchers")]
        [JsonProperty(Required = Required.Always)]
        public FileSystemWatcher[] Watchers { get; set; }
    }
}
