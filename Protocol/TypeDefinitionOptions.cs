using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    public interface ITypeDefinitionOptions : IWorkDoneProgressOptions
    {
    }

    [DataContract]
    public class TypeDefinitionOptions : WorkDoneProgressOptions, ITypeDefinitionOptions
    {
        public TypeDefinitionOptions() { }
    }
}