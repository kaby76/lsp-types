using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LspTypes
{
    [DataContract]
    public class WorkspaceSymbolOptions : WorkDoneProgressOptions
    {
        public WorkspaceSymbolOptions() { }
    }
}