using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Corp.FARBE.Tasks.Domain;
using Corp.FARBE.Tasks.Mocks;

namespace Corp.FARBE.Tasks.Domain.Test
{
    [TestClass]
    public class MusteriTests
    {
        private Musteri_Table mockMusteri;

        [TestInitialize]
        public void TestInitialize()
        {
            mockMusteri = DomainMocksFactory.CreateMusteri();
        }

        [TestMethod]
        public void House_MustHave_Name_And_Description()
        {
            Assert.IsTrue(mockMusteri.Musteri_Name == DomainMocksFactory.MUSTERI_NAME);
            Assert.IsTrue(mockMusteri.User_name == DomainMocksFactory.USERNAME);
            Assert.IsTrue(mockMusteri.Change_Date == DomainMocksFactory.CHANGE_DATE);
            Assert.IsTrue(mockMusteri.Modified_Person == DomainMocksFactory.MODIFIED_PERSON);
        }
    }
}
