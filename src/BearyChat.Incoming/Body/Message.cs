using Newtonsoft.Json;
using System.Collections.Generic;

namespace BearyChat.Incoming
{
    /// <summary>
    /// 消息主体
    /// </summary>
    public class Message
    {
        public Message()
        {
        }

        /// <summary>
        /// 必填
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; set; }

        /// <summary>
        /// 可选字段，用于控制消息提醒的内容显示
        /// </summary>
        [JsonProperty("notification",NullValueHandling = NullValueHandling.Ignore)]
        public string Notification { get; set; }

        /// <summary>
        /// 可选字段，用于控制text是否解析为MarkDown，默认为True
        /// </summary>
        [JsonProperty("markdown", NullValueHandling = NullValueHandling.Ignore)]
        public bool MarkDown { get; set; } = true;

        /// <summary>
        /// 可选字段，频道名称
        /// </summary>
        [JsonProperty("channel", NullValueHandling = NullValueHandling.Ignore)]
        public string Channel { get; set; }

        /// <summary>
        /// 可选字段，一系列附件
        /// </summary>
        [JsonProperty("attachments", NullValueHandling = NullValueHandling.Ignore)]
        public List<Attachment> Attachments { get; set; }
    }
}
