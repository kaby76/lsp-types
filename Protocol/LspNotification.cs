using System;
using System.Collections.Generic;
using System.Text;

namespace LspTypes
{
    public class LspNotification<TIn>
    {
        public LspNotification(string name) { Name = name; }

        public string Name { get; }
    }
}
