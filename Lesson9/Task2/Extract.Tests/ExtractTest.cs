using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace URLExtract.Tests
{
    [TestClass]
    public class ExtractTest
    {
        [TestMethod]
        public void ExtractsProtocol_site3_wwwOnlinerBy()
        {
            //arrange
            string x = "https://www.onliner.by/";
            string expected = "www.onliner.by";

            //act
            Extract c = new Extract();
            string actual = Extract.ExtractsProtocol(c);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
