using BearyChat.Incoming;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace UnitTest
{
    public class Test
    {
        private BearyChatClient _client;

        public Test()
        {
            _client = new BearyChatClient("https://hook.bearychat.com/=bw9mn/incoming/d51dc1ae6e9da6371a1258af4bb70208");
        }

        [Fact]
        public void Send()
        {
            _client.Send("Sino程序自动发送", "所有人");
        }

        [Fact]
        public void SendWithSubTitle()
        {
            _client.Send("Sino程序自动发送", "所有人", "子标题", "子标题内容", "#ffa500");
        }
    }
}
