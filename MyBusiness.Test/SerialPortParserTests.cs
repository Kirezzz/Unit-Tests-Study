using Business;
using NUnit.Framework;

namespace MyBusiness.Test
{
    [TestFixture]
    public class SerialPortParserTests
    {   [Test]
        public void ParsePort_COM1_Returns1()
        {
            int result = SerialPortParser.ParsePort("COM1");
            Assert.That(result, Is.EqualTo(1));

            //older style
            //Asserts.AreEqual(1, result);
        }
    }
}