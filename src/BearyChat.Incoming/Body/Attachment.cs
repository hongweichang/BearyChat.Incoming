using System.Collections.Generic;

namespace BearyChat.Incoming
{
    /// <summary>
    /// 附件体
    /// </summary>
    public class Attachment
    {
        public Attachment()
        {
            Images = new List<Image>();
        }

        /// <summary>
        /// 可选，Title与Text必须有一个
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 可选，Title与Text必须有一个
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// 可选，用于控制attachment在排版时左侧的竖线分隔符颜色
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// 可选，用于在推送中推送图片
        /// </summary>
        public List<Image> Images { get; set; }
    }
}
