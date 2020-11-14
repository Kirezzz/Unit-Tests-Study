using System;
using Business;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace MyBusiness.Tests
{
    [TestClass]
    public class SerialPortParserTests
    {
        public void ParsePort_COM1_Returns1()
        {
            int result = SerialPortParser.ParsePort("COM1");
            Assert.That(result, Is.EqualTo(1));

            //older style
            //Asserts.AreEqual(1, result);
        }
    }
}
