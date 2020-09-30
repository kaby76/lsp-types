# lsp-types
This project is a C# library for
client or server [Language Server Protocol (LSP)](https://langserver.org/)
applications, which implements the messages types in the protocol.
It is based on [Newtonsoft.Json](https://www.nuget.org/packages/Newtonsoft.Json/)
and [StreamJsonRpc](https://www.nuget.org/packages/StreamJsonRpc/),
and modeled from [Microsoft.VisualStudio.LanguageServer.Protocol](https://www.nuget.org/packages/Microsoft.VisualStudio.LanguageServer.Protocol/).
The reason I wrote this is because
I found that Microsoft's library is geared too closely to the
LSP client for Visual Studio 2019. It is missing major pieces and can't
be used with other clients, such as Visual Studio Code, if you want to
implement newer features of the protocol,
such as semantic highlighting. (Using TextMate regular expressions to
highlight the tokens in a file is far to primitive in my opinion.)
While the types defined
in this library are not mechanically
scraped from the LSP Spec, I have
hand-checked every class and interface to try
to faithfully implement LSP protocol version 3.16 in the spec.
It currently uses Newtonsoft.Json
and StreamJsonRpc, but I am considering porting it over to the newer
[System.Text.Json](https://www.nuget.org/packages/System.Text.Json/).
This library is used by [Antlrvsix](https://github.com/kaby76/AntlrVSIX),
but could easily be
adapted elsewhere. I made it public because this took me a solid week
(7 days/12 hour days) to code this up. It was painful, and hopefully
I can spare some of the pain for other developers.

## Installation

[NuGet Package](https://www.nuget.org/packages/LspTypes/) is available.
All versions currently only target the proposed [3.16 Specification](https://microsoft.github.io/language-server-protocol/specifications/specification-3-16/).
Run the following command in [NuGet Package Manager Console](https://docs.microsoft.com/nuget/tools/package-manager-console).

```
PM> Install-Package LanguageServerProtocol
```

Or, you can simply add the following to your .csproj file.

	<ItemGroup>
		<PackageReference Include="LspTypes" Version="0.0.3" />
	</ItemGroup>

# Release notes

* Versions 0.0.1 to 0.0.3 are initial revisions to pull all the types of the LSP protocol from Antlrvsix
into this library, then bring the types of the protocol up to that listed in the 3.16 spec. The library
has been linked and run against Antlrvsix.

# Roadmap of future releases

* Scrape the types directly from the [online spec](https://microsoft.github.io/language-server-protocol/specifications/specification-current/).
* Create a parallel version using [System.Text.Json](https://www.nuget.org/packages/System.Text.Json/) and compare speeds.
 
