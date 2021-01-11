using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class PrepareRenameParams : TextDocumentPositionParams
    {
        public PrepareRenameParams() : base() { }
    }
}
