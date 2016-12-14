using BearyChat.Incoming;
using Xunit;

namespace UnitTest
{
    public class Test
    {
        private BearyChatClient _client;

        public Test()
        {
            _client = new BearyChatClient("");
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
