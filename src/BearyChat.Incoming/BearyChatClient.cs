using System;
using System.Net.Http;
using Newtonsoft.Json;

namespace BearyChat.Incoming
{
    public class BearyChatClient
    {
        private HttpClient _httpClient { get; set; }

        /// <summary>
        /// 请求的WebHook路径
        /// </summary>
        public string Url { get; set; }

        public BearyChatClient(string url)
        {
            Url = url;
            _httpClient = new HttpClient();
            _httpClient.Timeout = TimeSpan.FromSeconds(2);
        }

        /// <summary>
        /// 发送消息
        /// </summary>
        public void Send(Message msg)
        {
            var content = new StringContent(JsonConvert.SerializeObject(msg));
            content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            _httpClient.PostAsync(Url, content).Wait();
        }
    }
}
