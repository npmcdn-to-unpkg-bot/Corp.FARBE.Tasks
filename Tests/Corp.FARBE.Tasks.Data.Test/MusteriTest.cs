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
            using (DatabaseContext context = new DatabaseContext())
            {
                Musteri musteri = DomainMocksFactory.CreateMusteri();
                context.Musteriler.Add(musteri);

                context.SaveChanges();
            }

            using (DatabaseContext context = new DatabaseContext())
            {
                var result = context.Musteriler.Where(x => x.Musteri_Name == DomainMocksFactory.MUSTERI_NAME);
                Musteri musteri = result.FirstOrDefault();
                Assert.IsNotNull(musteri);
            }
        }


        [TestMethod]
        public void Musteri_CanBe_Modified()
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                Musteri musteri = DomainMocksFactory.CreateMusteri();
                context.Musteriler.Add(musteri);

                context.SaveChanges();
            }

            using (DatabaseContext context = new DatabaseContext())
            {
                var result = context.Musteriler.Where(x => x.Musteri_Name == DomainMocksFactory.MUSTERI_NAME);
                Musteri musteri = result.FirstOrDefault();
                musteri.ModifyName("Modified");
                context.SaveChanges();
            }

            using (DatabaseContext context = new DatabaseContext())
            {
                var result = context.Musteriler.Where(x => x.Musteri_Name == "Modified");
                Musteri musteri = result.FirstOrDefault();
                Assert.IsTrue(musteri.Musteri_Name == "Modified");
            }
        }

        [TestMethod]
        public void Musteri_CanBe_Deleted()
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                Musteri musteri = DomainMocksFactory.CreateMusteri();
                context.Musteriler.Add(musteri);

                context.SaveChanges();
            }

            using (DatabaseContext context = new DatabaseContext())
            {
                var result = context.Musteriler.Where(x => x.Musteri_Name == DomainMocksFactory.MUSTERI_NAME);
                Musteri musteri = result.FirstOrDefault();
                context.Musteriler.Remove(musteri);
                context.SaveChanges();
            }

            using (DatabaseContext context = new DatabaseContext())
            {
                Musteri musteri = context.Musteriler.FirstOrDefault();
                Assert.IsNull(musteri);
            }
        }

    }
}
