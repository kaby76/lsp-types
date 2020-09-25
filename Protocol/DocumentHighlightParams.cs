using System;
using System.Runtime.Serialization;

namespace LspTypes
{
    public class DocumentHighlightParams : TextDocumentPositionParams, WorkDoneProgressParams, PartialResultParams
    {
        public DocumentHighlightParams() { }
    }
}
