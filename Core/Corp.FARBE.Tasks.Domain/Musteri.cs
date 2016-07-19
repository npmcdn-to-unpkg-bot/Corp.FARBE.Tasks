using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Corp.FARBE.Tasks.Domain
{
    public class Musteri
    {
        [Key]
        public int Musteri_ID { get; private set; }

        public string Musteri_Name { get; private set; }

        public string Gorev { get; private set; }

        public string User_name { get; private set; }

        public DateTime Change_Date { get; private set; }

        public string Modified_Person { get; private set; }

        public static Musteri Create(string Musteri_Name, string Gorev, string User_name, DateTime Change_Date, string Modified_Person)
        {
            var musteri = new Musteri
            {
                Musteri_Name= Musteri_Name,
                Gorev= Gorev,
                User_name= User_name,
                Change_Date= Change_Date,
                Modified_Person= Modified_Person
            };


            return musteri;
        }

        public void ModifyName(string name)
        {
            if (this.Musteri_Name != name)
            {
                this.Musteri_Name = name;
            }
        }


    }
}