using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LspTypes
{
    /**
     * A pattern to describe in which file operation requests or notifications
     * the server is interested in.
     *
     * @since 3.16.0
     */
    [DataContract]
    public class FileOperationPattern
    {
        public FileOperationPattern() { }

		/**
		 * The glob pattern to match. Glob patterns can have the following syntax:
		 * - `*` to match one or more characters in a path segment
		 * - `?` to match on one character in a path segment
		 * - `**` to match any number of path segments, including none
		 * - `{}` to group conditions (e.g. `**​/*.{ts,js}` matches all TypeScript
		 *   and JavaScript files)
		 * - `[]` to declare a range of characters to match in a path segment
		 *   (e.g., `example.[0-9]` to match on `example.0`, `example.1`, …)
		 * - `[!...]` to negate a range of characters to match in a path segment
		 *   (e.g., `example.[!0-9]` to match on `example.a`, `example.b`, but
		 *   not `example.0`)
		 */
		[DataMember(Name = "glob")]
		[JsonProperty(Required = Required.Always)]
		public string Glob { get; set; }

		/**
		 * Whether to match files or folders with this pattern.
		 *
		 * Matches both if undefined.
		 */
		[DataMember(Name = "matches")]
		[JsonProperty(Required = Required.Default)]
		public FileOperationPatternKind Matches { get; set; }

		/**
		 * Additional options used during matching.
		 */
		[DataMember(Name = "options")]
		[JsonProperty(Required = Required.Default)]
		public FileOperationPatternOptions Options { get; set; }
    }
}
