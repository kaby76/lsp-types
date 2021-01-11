using Newtonsoft.Json;
using System;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace LspTypes
{
    public class ParameterInformationConverter : JsonConverter
    {
        public ParameterInformationConverter() { }

        public override bool CanWrite
        {
            get
            {
                return false;
            }
        }

        public override bool CanConvert(Type objectType)
        {
            return true;
        }
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            JToken jtoken1 = JToken.Load(reader);
            JProperty jproperty1 = ((JObject)jtoken1).Property("label");
            JProperty jproperty2 = ((JObject)jtoken1).Property("documentation");
            ParameterInformation parameterInformation = new ParameterInformation();
            if (jproperty1 != null)
            {
                JToken jtoken2 = jproperty1.Value;
                if (jtoken2 is JArray jarray)
                {
                    Tuple<uint, uint> tuple = new Tuple<uint, uint>((uint)Extensions.Value<uint>((IEnumerable<JToken>)jarray[0]), (uint)Extensions.Value<int>((IEnumerable<JToken>)jarray[1]));
                    parameterInformation.Label = new SumType<string, Tuple<uint, uint>>(tuple);
                }
                else
                    parameterInformation.Label = (SumType<string, Tuple<uint, uint>>)jtoken2.ToObject<SumType<string, Tuple<uint, uint>>>();
            }
            if (jproperty2 != null)
            {
                JToken jtoken2 = jproperty2.Value;
                parameterInformation.Documentation = (SumType<string, MarkupContent>)jtoken2.ToObject<SumType<string, MarkupContent>>();
            }
            return (object)parameterInformation;
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
