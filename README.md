# lsp-types
This project is a C# library for
server [Language Server Protocol (LSP)](https://langserver.org/)
applications. It is based on [Newtonsoft.Json](https://www.nuget.org/packages/Newtonsoft.Json/)
and [StreamJsonRpc](https://www.nuget.org/packages/StreamJsonRpc/),
and modeled from [Microsoft.VisualStudio.LanguageServer.Protocol](https://www.nuget.org/packages/Microsoft.VisualStudio.LanguageServer.Protocol/).
I found that Microsoft's library is geared too closely to the
LSP client for Visual Studio 2019. It is missing major pieces and can't
be used effectively with other clients, such as Visual Studio Code. While the types defined
in this library are not scraped from the LSP Spec, I have
hand-checked every class and interface to make sure that it tries
to faithfully implement LSP version 3.16. While it currently uses Newtonsoft.Json
and StreamJsonRpc, I am considering porting it over to the newer
[System.Text.Json](https://www.nuget.org/packages/System.Text.Json/).

## Installation

[NuGet Package](https://www.nuget.org/packages/LspTypes/) is available.
All versions currently only target the proposed [3.16 Specification](https://microsoft.github.io/language-server-protocol/specifications/specification-3-16/).
Run the following command in [NuGet Package Manager Console](https://docs.microsoft.com/nuget/tools/package-manager-console).

```
PM> Install-Package LanguageServerProtocol
```

Or, you can simply add the following to your .csproj file.

	<ItemGroup>
		<PackageReference Include="LspTypes" Version="0.0.2" />
	</ItemGroup>
