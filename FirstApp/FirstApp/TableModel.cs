using Newtonsoft.Json;

namespace FirstApp
{
    class TableModel
    {
        [JsonProperty(PropertyName = "Id")]
        public string ID { get; set; }

        
    }
}
