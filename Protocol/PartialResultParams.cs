﻿using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    public interface IPartialResultParams
    {
        SumType<int, string> PartialResultToken { get; set; }
    }

    [DataContract]
    public class PartialResultParams : IPartialResultParams
    {
        public PartialResultParams() { }

        /**
         * An optional token that a server can use to report partial results (e.g.
	     * streaming) to the client.
         */
        [DataMember(Name = "partialResultToken")]
        [JsonProperty(Required = Required.Default, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public SumType<int, string> PartialResultToken { get; set; }
    }
}
