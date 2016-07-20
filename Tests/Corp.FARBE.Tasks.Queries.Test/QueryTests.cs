using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Corp.FARBE.Tasks.Queries.Projections;
using Corp.FARBE.Tasks.Queries.Messages;

namespace Corp.FARBE.Tasks.Queries.Test
{
    [TestClass]
    public class QueryTests
    {
        [TestMethod]
        public void Musteri_Count_More_Than_Zero()
        {
            var result = MusteriProjections.GetMusteriCount();

            Assert.IsTrue(result > 0);

        }

        [TestMethod]
        public void All_Musteri_Data_Comes_True()
        {
            var result = MusteriProjections.GetMusteriCount();

            Assert.IsTrue(result == 182);

        }

    }
}
