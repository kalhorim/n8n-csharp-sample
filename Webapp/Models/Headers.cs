using Newtonsoft.Json;

namespace Webapp.Models
{
    public class Headers
    {

        public string Host { get; set; }
        [JsonProperty(propertyName: "Request-Id")]
        public string RequestId { get; set; }
        [JsonProperty(propertyName: "transfer-encoding")]
        public string TransferEncoding { get; set; }
    }
}