using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class SelectionRangeOptions : WorkDoneProgressOptions
    {
        public SelectionRangeOptions() { }
    }
}