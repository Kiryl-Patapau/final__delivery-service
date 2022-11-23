using Newtonsoft.Json;

namespace DeliveryService.Models;

public class Item
{
    [JsonProperty(Required = Required.Always)]
    public string Name { get; set; }

    [JsonProperty(Required = Required.Always)]
    public int Quantity { get; set; }
}
