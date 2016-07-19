using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Corp.FARBE.Tasks.Data;
using Corp.FARBE.Tasks.Domain;
using Corp.FARBE.Tasks.Mocks;
using System.Linq;

namespace Corp.FARBE.Tasks.Data.Test
{
    [TestClass]
    public class MusteriTest
    {
        [TestMethod]
        public void Musteri_CanBe_Saved()
        {
            using (DBAmbarDataContext context = new DBAmbarDataContext())
            {
                Musteri_Table musteri = DomainMocksFactory.CreateMusteri();
                context.Musteri_Tables.InsertOnSubmit(musteri);

                context.SubmitChanges();
            }

            using (DBAmbarDataContext context = new DBAmbarDataContext())
            {

                var result = context.ExecuteQuery<Musteri_Table>("select * from dbo.Musteri_Table where Musteri_Name = {0}", DomainMocksFactory.MUSTERI_NAME);
                Musteri_Table musteri = result.FirstOrDefault();
                Assert.AreEqual(musteri.Musteri_Name,DomainMocksFactory.MUSTERI_NAME);
            }
        }


        [TestMethod]
        public void Musteri_CanBe_Modified()
        {
            using (DBAmbarDataContext context = new DBAmbarDataContext())
            {
                Musteri_Table musteri = DomainMocksFactory.CreateMusteri();
                context.Musteri_Tables.InsertOnSubmit(musteri);

                context.SubmitChanges();
            }

            using (DBAmbarDataContext context = new DBAmbarDataContext())
            {
                var result = context.Musteri_Tables.Where(x => x.Musteri_Name == DomainMocksFactory.MUSTERI_NAME);
                Musteri_Table musteri = result.FirstOrDefault();
                musteri.Musteri_Name = "Modified";
                context.SubmitChanges();
            }

            using (DBAmbarDataContext context = new DBAmbarDataContext())
            {
                var result = context.Musteri_Tables.Where(x => x.Musteri_Name == "Modified");
                Musteri_Table musteri = result.FirstOrDefault();
                Assert.IsTrue(musteri.Musteri_Name == "Modified");
            }
        }

        [TestMethod]
        public void Musteri_CanBe_Deleted()
        {
            using (DBAmbarDataContext context = new DBAmbarDataContext())
            {
                Musteri_Table musteri = DomainMocksFactory.CreateMusteri();
                context.Musteri_Tables.InsertOnSubmit(musteri);

                context.SubmitChanges();
            }

            using (DBAmbarDataContext context = new DBAmbarDataContext())
            {
                var result = context.Musteri_Tables.Where(x => x.Musteri_Name == DomainMocksFactory.MUSTERI_NAME);
                Musteri_Table musteri = result.FirstOrDefault();
                context.Musteri_Tables.DeleteOnSubmit(musteri);
                context.SubmitChanges();
            }

            using (DBAmbarDataContext context = new DBAmbarDataContext())
            {
                var result = context.Musteri_Tables.Where(x => x.Musteri_Name == DomainMocksFactory.MUSTERI_NAME);
                Musteri_Table musteri = result.FirstOrDefault();
                Assert.IsNull(musteri);
            }
        }

    }
}
