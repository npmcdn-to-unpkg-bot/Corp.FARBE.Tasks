namespace Corp.FARBE.Tasks.Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using Corp.FARBE.Tasks.Domain;

    public partial class DBAmbarEntityModel : DbContext
    {
        public DBAmbarEntityModel()
            : base("name=DBAmbarEntityModel")
        {
        }

        public virtual DbSet<Musteri_Table> Musteriler { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Musteri_Table>()
                .Property(e => e.Musteri_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Musteri_Table>()
                .Property(e => e.Gorev)
                .IsUnicode(false);

            modelBuilder.Entity<Musteri_Table>()
                .Property(e => e.User_name)
                .IsUnicode(false);

            modelBuilder.Entity<Musteri_Table>()
                .Property(e => e.Modified_Person)
                .IsUnicode(false);
        }
    }
}
