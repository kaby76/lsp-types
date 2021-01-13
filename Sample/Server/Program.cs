using LspTypes;
using Newtonsoft.Json.Linq;
using StreamJsonRpc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Server
{
    class Program
    {
        private static void Main(string[] args) => MainAsync(args).Wait();

        //static void Main(string[] args)
        //{
        //    Program program = new Program();
        //    program.MainAsync(args).GetAwaiter().GetResult();
        //}

        private static async Task MainAsync(string[] args)
        {
            System.IO.Stream stdin = Console.OpenStandardInput();
            System.IO.Stream stdout = Console.OpenStandardOutput();
            stdin = new Tee(stdin, new Dup("editor"), Tee.StreamOwnership.OwnNone);
            stdout = new Tee(stdout, new Dup("server"), Tee.StreamOwnership.OwnNone);
            var languageServer = new LSPServer(stdout, stdin);
            await Task.Delay(-1);
        }
    }

    class LSPServer : INotifyPropertyChanged, IDisposable
    {
        private readonly JsonRpc rpc;
        private readonly ManualResetEvent disconnectEvent = new ManualResetEvent(false);
        private Dictionary<string, DiagnosticSeverity> diagnostics;
        public event PropertyChangedEventHandler PropertyChanged;
        public event EventHandler Disconnected;
        private bool isDisposed;
        
        public LSPServer(Stream sender, Stream reader)
        {
            rpc = JsonRpc.Attach(sender, reader, this);
            rpc.Disconnected += OnRpcDisconnected;
        }
        private void OnRpcDisconnected(object sender, JsonRpcDisconnectedEventArgs e)
        {
            Exit();
        }
        private void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (isDisposed) return;
            if (disposing)
            {
                // free managed resources
                disconnectEvent.Dispose();
            }
            isDisposed = true;
        }
        public void WaitForExit()
        {
            disconnectEvent.WaitOne();
        }
        ~LSPServer()
        {
            // Finalizer calls Dispose(false)
            Dispose(false);
        }
        public void Exit()
        {
            disconnectEvent.Set();
            Disconnected?.Invoke(this, new EventArgs());
            System.Environment.Exit(0);
        }

        private static readonly object _object = new object();
        private readonly bool trace = true;

        [JsonRpcMethod(Methods.InitializeName)]
        public object Initialize(JToken arg)
        {
            lock (_object)
            {
                if (trace)
                {
                    System.Console.Error.WriteLine("<-- Initialize");
                    System.Console.Error.WriteLine(arg.ToString());
                }

                var init_params = arg.ToObject<InitializeParams>();

                ServerCapabilities capabilities = new ServerCapabilities
                {
                    TextDocumentSync = new TextDocumentSyncOptions
                    {
                        OpenClose = true,
                        Change = TextDocumentSyncKind.Incremental,
                        Save = new SaveOptions
                        {
                            IncludeText = true
                        }
                    },

                    CompletionProvider = null,

                    HoverProvider = true,

                    SignatureHelpProvider = null,

                    DefinitionProvider = true,

                    TypeDefinitionProvider = false,

                    ImplementationProvider = false,

                    ReferencesProvider = true,

                    DocumentHighlightProvider = true,

                    DocumentSymbolProvider = true,

                    CodeLensProvider = null,

                    DocumentLinkProvider = null,

                    DocumentFormattingProvider = true,

                    DocumentRangeFormattingProvider = false,

                    RenameProvider = true,

                    FoldingRangeProvider = new SumType<bool, FoldingRangeOptions, FoldingRangeRegistrationOptions>(false),

                    ExecuteCommandProvider = null,

                    WorkspaceSymbolProvider = false,

                    SemanticTokensProvider = new SemanticTokensOptions()
                    {
                        Full = true,
                        Range = false,
                        Legend = new SemanticTokensLegend()
                        {
                            tokenTypes = new string[] {
                                "class",
                                "variable",
                                "enum",
                                "comment",
                                "string",
                                "keyword",
                            },
                            tokenModifiers = new string[] {
                                "declaration",
                                "documentation",
                            }
                        }
                    },
                };

                InitializeResult result = new InitializeResult
                {
                    Capabilities = capabilities
                };
                string json = Newtonsoft.Json.JsonConvert.SerializeObject(result);
                if (trace)
                {
                    System.Console.Error.WriteLine("--> " + json);
                }
                return result;
            }
        }

        [JsonRpcMethod(Methods.InitializedName)]
        public void InitializedName(JToken arg)
        {
            lock (_object)
            {
                try
                {
                    if (trace)
                    {
                        System.Console.Error.WriteLine("<-- Initialized");
                        System.Console.Error.WriteLine(arg.ToString());
                    }
                }
                catch (Exception)
                { }
            }
        }

        [JsonRpcMethod(Methods.ShutdownName)]
        public JToken ShutdownName()
        {
            lock (_object)
            {
                try
                {
                    if (trace)
                    {
                        System.Console.Error.WriteLine("<-- Shutdown");
                    }
                }
                catch (Exception)
                { }
                return null;
            }
        }

        [JsonRpcMethod(Methods.ExitName)]
        public void ExitName()
        {
            lock (_object)
            {
                try
                {
                    if (trace)
                    {
                        System.Console.Error.WriteLine("<-- Exit");
                    }
                    Exit();
                }
                catch (Exception)
                { }
            }
        }
    }
}
