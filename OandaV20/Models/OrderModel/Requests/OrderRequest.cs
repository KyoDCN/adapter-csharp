using Newtonsoft.Json;
using OandaV20.Models.OrderModel.Definitions;
using System;

namespace OandaV20.Models.OrderModel.Requests
{
    internal class ParseAsStringConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType != typeof(string);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override void WriteJson(JsonWriter writer, object o, JsonSerializer serializer)
        {
            dynamic value = o;
            if ((string)value == null)
            {
                serializer.Serialize(writer, null);
                return;
            }

            serializer.Serialize(writer, (string)value);
            return;
        }
    }

    public abstract class OrderRequest
    {
        [JsonConverter(typeof(ParseAsStringConverter))]
        public OrderType Type { get; set; }
    }
}
