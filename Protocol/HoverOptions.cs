using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class HoverOptions : WorkDoneProgressOptions, IHoverOptions
    {
        public HoverOptions() { }
    }
}
