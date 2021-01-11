namespace LspTypes
{
    public class CallHierarchyOptions : WorkDoneProgressOptions
    {
        public CallHierarchyOptions() : base() { }
    }

    public interface ICallHierarchyOptions : IWorkDoneProgressOptions
    {
    }
}