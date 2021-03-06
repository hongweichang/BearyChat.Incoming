﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BearyChat.Incoming
{
    /// <summary>
    /// 扩展方法
    /// </summary>
    public static class BearyChatClientExtension
    {
        /// <summary>
        /// 发送消息
        /// </summary>
        /// <param name="text">发送的消息</param>
        /// <param name="channel">接收的频道名称</param>
        public static void Send(this BearyChatClient self,string text,string channel)
        {
            if (string.IsNullOrEmpty(text))
                throw new ArgumentNullException(nameof(text));
            if (string.IsNullOrEmpty(channel))
                throw new ArgumentNullException(nameof(channel));

            var msg = new Message
            {
                Text = text,
                Channel = channel
            };
            self.Send(msg);
        }

        public static void Send(this BearyChatClient self,string text,string channel,string subTitle,string subText,string color)
        {
            if (string.IsNullOrEmpty(text))
                throw new ArgumentNullException(nameof(text));
            if (string.IsNullOrEmpty(channel))
                throw new ArgumentNullException(nameof(channel));
            if (string.IsNullOrEmpty(subTitle))
                throw new ArgumentNullException(nameof(subTitle));

            var msg = new Message
            {
                Text = text,
                Channel = channel,
                Attachments = new List<Attachment>
                {
                    new Attachment
                    {
                        Title = subTitle,
                        Text = subText,
                        Color = color
                    }
                }
            };
            self.Send(msg);
        }
    }
}
