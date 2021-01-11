using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class ReferenceOptions : WorkDoneProgressOptions
    {
        public ReferenceOptions() { }
    }

    public interface IReferenceOptions : IWorkDoneProgressOptions
    {
    }
}