namespace LspTypes
{
    internal interface ISignatureHelpOptions
    {
        string[] TriggerCharacters { get; set; }
        string[] RetriggerCharacters { get; set; }
    }
}