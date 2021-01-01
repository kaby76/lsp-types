using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class _ServerCapabilities_Workspace
    {
        public _ServerCapabilities_Workspace() { }

        /**
         * The server supports workspace folder.
         *
         * @since 3.6.0
         */
        [DataMember(Name = "workspaceFolders")]
        public WorkspaceFoldersServerCapabilities WorkspaceFolders { get; set; }

        [DataMember(Name = "fileOperations")]
        public _ServerCapabilities_Workspace_FileOperations FileOperations { get; set; }
        
    }
}
