using Newtonsoft.Json;

namespace OandaV20.Models.OrderModel.RequestsJSON
{
    public abstract class OrderRequest
    {
        [JsonProperty(Required = Required.Always)]
        public string Type { get; set; }
    }
}
