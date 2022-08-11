using System;
using System.Text;
using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using Xunit;

namespace SocialNetwork.Tests
{
    public class MessageTests
    {
        [Fact]
        public void MessageThrowExceptionsTest()
        {
            var messageService = new MessageService();
            MessageSendingData messageSendingData = new MessageSendingData();

            // проверка сообщения на null
            Assert.Throws<ArgumentNullException>(() => messageService.SendMessage(messageSendingData));

            for (int i = 0; i < 5000; i++)
                messageSendingData.Content += "Ха";

            //проверка сообщения на длину
            Assert.Throws<ArgumentOutOfRangeException>(() => messageService.SendMessage(messageSendingData));
        }
    }
}
