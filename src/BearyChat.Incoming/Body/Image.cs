using Newtonsoft.Json;

namespace BearyChat.Incoming
{
    /// <summary>
    /// 图片
    /// </summary>
    public class Image
    {
        /// <summary>
        /// Url路径
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }
    }
}
