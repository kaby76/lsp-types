using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
	[DataContract]
	public class CodeActionClientCapabilities
	{
		public CodeActionClientCapabilities() { }

		/**
         * Whether code action supports dynamic registration.
         */
		[DataMember(Name = "dynamicRegistration")]
		[JsonProperty(Required = Required.Default)]
		public bool DynamicRegistration { get; set; }

		/**
         * The client supports code action literals as a valid
         * response of the `textDocument/codeAction` request.
         *
         * @since 3.8.0
         */
		[DataMember(Name = "codeActionLiteralSupport")]
		[JsonProperty(Required = Required.Default)]
		public _CodeActionClientCapabilities_CodeActionLiteralSupport CodeActionLiteralSupport { get; set; }

		/**
         * Whether code action supports the `isPreferred` property.
         * @since 3.15.0
         */
		[DataMember(Name = "isPreferredSupport")]
		[JsonProperty(Required = Required.Default)]
		public bool? IsPreferredSupport { get; set; }

		/**
		 * Whether code action supports the `disabled` property.
		 *
	     * @since 3.16.0
		 */
		[DataMember(Name = "disabledSupport")]
		[JsonProperty(Required = Required.Default)]
		public bool? DisabledSupport { get; set; }

		/**
		 * Whether code action supports the `data` property which is
		 * preserved between a `textDocument/codeAction` and a
		 * `codeAction/resolve` request.
		 *
		 * @since 3.16.0
		 */
		[DataMember(Name = "dataSupport")]
		[JsonProperty(Required = Required.Default)]
		public bool? DataSupport { get; set; }

		/**
		 * Whether the client supports resolving additional code action
		 * properties via a separate `codeAction/resolve` request.
		 *
		 * @since 3.16.0
		 */
		[DataMember(Name = "resolveSupport")]
		[JsonProperty(Required = Required.Default)]
		public _CodeActionClientCapabilities_ResolveSupport ResolveSupport { get; set; }

		/**
		 * Whether the client honors the change annotations in
		 * text edits and resource operations returned via the
		 * `CodeAction#edit` property by for example presenting
		 * the workspace edit in the user interface and asking
		 * for confirmation.
		 *
		 * @since 3.16.0
		 */
		[DataMember(Name = "honorsChangeAnnotations")]
		[JsonProperty(Required = Required.Default)]
		public bool? HonorsChangeAnnotations { get; set; }
	}
}