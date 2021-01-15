# lsp-types

[![Build](https://github.com/kaby76/lsp-types/workflows/.NET/badge.svg)](https://github.com/kaby76/lsp-types/actions?query=workflow%3A.NET)

This project is a C# library for
client and server [Language Server Protocol (LSP)](https://langserver.org/)
applications. It implements all the messages types in the protocol so that the
developer can focus on implementing the application instead of the boilerplate
code needed to convert an LSP message into C# data types.
It is based on [Newtonsoft.Json](https://www.nuget.org/packages/Newtonsoft.Json/)
and [StreamJsonRpc](https://www.nuget.org/packages/StreamJsonRpc/),
and modeled after [Microsoft.VisualStudio.LanguageServer.Protocol](https://www.nuget.org/packages/Microsoft.VisualStudio.LanguageServer.Protocol/).
Type checking is performed by the StreamJsonRpc and
Newtonsoft.Json libraries for manditory or illegal values of fields of the class. Several
examples are provided to demonstrate a server application.

I wrote this library because
[Microsoft's LSP types library](https://www.nuget.org/packages/Microsoft.VisualStudio.LanguageServer.Protocol/)
is geared too closely to the
LSP client for Visual Studio 2019. It is missing many major features and it is years behind the spec.
However, the most important feature missing is semantic highlighting, which is
a basic feature users expect in any editor extension.
Microsoft recommendeds the antiquated [TextMate](https://docs.microsoft.com/en-us/visualstudio/extensibility/adding-an-lsp-extension?view=vs-2019#textmate-grammar-files) system, which is a errible implementation for several reasons:
TextMate expressions are regular expressions, which do not take into account the context-free nature
of virtually all programming languages; it duplicates the functionality in the client the parsing and
symbol table construction that
is performed by the server; the regular expressions in TextMate are difficult to understand.

## Installation

[NuGet Package](https://www.nuget.org/packages/LspTypes/) is available.
The version on the package reflects the version
targeted, e.g., version v3.16.6 targets version [3.16 of the Specification](https://microsoft.github.io/language-server-protocol/specifications/specification-3-16/).
I currently only support 3.16, but it should be backward 
compatible with older implementations of the spec. 
Run the following command in [NuGet Package Manager Console](https://docs.microsoft.com/nuget/tools/package-manager-console).

```
PM> Install-Package LanguageServerProtocol
```

Or, you can simply add the following to your .csproj file.

	<ItemGroup>
		<PackageReference Include="LspTypes" Version="3.16.6" />
	</ItemGroup>

## Example

To demonstrate this library in an implementation, I provide a simple [LSP server](https://github.com/kaby76/lsp-types/tree/master/Sample/Server)
that connects to a [VSCode client](https://github.com/kaby76/lsp-types/tree/master/Sample/VsCode).
See the [instructions](https://github.com/kaby76/lsp-types/blob/master/Sample/VsCode/README.md)
on how to run it.

The first message received by an LSP server is the [Initialize Request](https://microsoft.github.io/language-server-protocol/specifications/specification-3-16/#initialize). The server
requires an implementation for the remote procedure call, which is
[a method in the server](https://github.com/kaby76/lsp-types/blob/e02a7b14057a04587e31f0aef80b5843553418a6/Sample/Server/Program.cs#L91)
attributed with `[JsonRpcMethod(Methods.InitializeName)]`.
The function of the method is to construct a 
[InitializeResult](https://github.com/kaby76/lsp-types/blob/e02a7b14057a04587e31f0aef80b5843553418a6/Sample/Server/Program.cs#L171)
response data type, with properties of the [ServerCapabilities](https://github.com/kaby76/lsp-types/blob/e02a7b14057a04587e31f0aef80b5843553418a6/Sample/Server/Program.cs#L103)
initialized to values the server intends to support.
The `capabilities` field is mandatory as
stated in the spec, [attributed so](https://github.com/kaby76/lsp-types/blob/92432dad9f0ba6f21b71d2f75c5d4f12a08d33dd/Protocol/InitializeResult.cs#L15),
named with a lowercase name and [attributed with the correct name](https://github.com/kaby76/lsp-types/blob/92432dad9f0ba6f21b71d2f75c5d4f12a08d33dd/Protocol/InitializeResult.cs#L14).

# Release notes

* Version 3.16.6 (12 Jan 2021) -- All types brought up to date to spec 3.16,
which was officially released 14 Dec 2020. This version was scraped by
hand using first diffing between 1 Oct 2020 and the beginning of January.
I then went through every damn type to verify that all types and properties are
specified. The library is now built using Github Actions.
There is still no testing of the library other than my LSP server in Antlrvsix.
[Issue #2](https://github.com/kaby76/lsp-types/issues/2)
is a request to provide examples; [issue #4](https://github.com/kaby76/lsp-types/issues/4)
is a request for testing.

* Version 3.16.5 (17 Oct 2020) -- First functional, realistic version
of the library. 

* Version 0.0.4 corrects the mandatory property of field Capabilities of the class InitilizeResult.

* Versions 0.0.1 to 0.0.3 are initial revisions to pull all the types of the LSP protocol from Antlrvsix
into this library, then bring the types of the protocol up to that listed in the 3.16 spec. The library
has been linked and run against Antlrvsix.

# Roadmap of future releases

* Scrape the types directly from the [online spec](https://microsoft.github.io/language-server-protocol/specifications/specification-current/).
* Create a parallel version using [System.Text.Json](https://www.nuget.org/packages/System.Text.Json/) and compare speeds.
 
