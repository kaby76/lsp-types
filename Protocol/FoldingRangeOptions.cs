using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    public interface IFoldingRangeOptions : IWorkDoneProgressOptions
    {
    }

    [DataContract]
    public class FoldingRangeOptions : WorkDoneProgressOptions
    {
        public FoldingRangeOptions() { }
    }
}