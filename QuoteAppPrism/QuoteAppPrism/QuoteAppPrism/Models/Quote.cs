using Newtonsoft.Json;

namespace QuoteAppPrism.Models
{
    public class Quote
    {
        public int ID { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("content")]
        public string Content { get; set; }
        [JsonProperty("link")]
        public string Link { get; set; }
        [JsonProperty("custom_meta")]
        public CustomMeta CustomMeta { get; set; }
    }
    public class CustomMeta
    {
        public string Source { get; set; }
    }
}
