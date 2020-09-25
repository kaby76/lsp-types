using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    public interface IImplementationOptions : IWorkDoneProgressOptions
    { }

    [DataContract]
    public class ImplementationOptions : WorkDoneProgressOptions, IImplementationOptions
    {
    }
}