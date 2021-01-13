
import * as vscode from 'vscode';
import * as vscodelc from 'vscode-languageclient/node';


namespace SwitchSourceHeaderRequest
{
    export const type = new vscodelc.RequestType<vscodelc.TextDocumentIdentifier, string|undefined,
          void, void>('textDocument/switchSourceHeader');
}

class FileStatus
{
    private statuses = new Map<string, any>();
    private readonly statusBarItem =
        vscode.window.createStatusBarItem(vscode.StatusBarAlignment.Left, 10);

    onFileUpdated(fileStatus: any)
    {
        const filePath = vscode.Uri.parse(fileStatus.uri);
        this.statuses.set(filePath.fsPath, fileStatus);
        this.updateStatus();
    }

    updateStatus()
    {
        const path = vscode.window.activeTextEditor.document.fileName;
        const status = this.statuses.get(path);
        if (!status)
        {
            this.statusBarItem.hide();
            return;
        }
        this.statusBarItem.text = `lsptypestest: ` + status.state;
        this.statusBarItem.show();
    }

    clear()
    {
        this.statuses.clear();
        this.statusBarItem.hide();
    }

    dispose()
    {
        this.statusBarItem.dispose();
    }
}

let client: vscodelc.LanguageClient;

export function activate(context: vscode.ExtensionContext)
{
    var fn = __dirname + '/../Server/net5.0/Server.exe';
    const server: vscodelc.Executable =
    {
        command: fn,
        args: [],
        options: { shell: false, detached: false }
    };

    const serverOptions: vscodelc.ServerOptions = server;

    let clientOptions: vscodelc.LanguageClientOptions =
    {
        // Register the server for plain text documents
        documentSelector: [
            {scheme: 'file', language: 'txt'},
        ]
    };

    client = new vscodelc.LanguageClient('LSP server example', serverOptions, clientOptions);
    
    client.registerProposedFeatures();
    
    console.log('LSP server example is now active!');
    client.start();
}

export function deactivate(): Thenable<void> | undefined
{
    if (!client)
    {
        return undefined;
    }
    return client.stop();
}
