using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Moq;
using CustomerCommLib;

namespace CustomerComm.Tests
{
    [TestFixture]
    public class CustomerCommTests
    {
        Mock<IMailSender> iMailSenderMock;
        [OneTimeSetUp]
        public void Initialize()
        {
             iMailSenderMock = new Mock<IMailSender>();
        }
        [Test]
        [TestCase()]
        public void SendMailToCustomer_Test()
        {
           
            iMailSenderMock.Setup(obj => obj.SendMail(It.IsAny<string>(), It.IsAny<string>())).Returns(true);
            var mailSender = iMailSenderMock.Object;
            var customercom = new CustomerCommunication(mailSender);

            var result = customercom.SendMailToCustomer();
            Assert.That(result, Is.True);
        }
    }
}
