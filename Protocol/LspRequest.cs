namespace LspTypes
{
    public class LspRequest<TIn, TOut>
    {
        public LspRequest(string name) { Name = name; }

        public string Name { get; }
    }
}
