using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Corp.FARBE.Tasks.Domain
{
    public class Musteri_Table
    {
        [Key]
        public int Musteri_ID { get; set; }

        [StringLength(250)]
        public string Musteri_Name { get; set; }

        [StringLength(100)]
        public string Gorev { get; set; }

        [StringLength(200)]
        public string User_name { get; set; }

        public DateTime? Change_Date { get; set; }

        [StringLength(200)]
        public string Modified_Person { get; set; }

        public static Musteri_Table Create(string Musteri_Name, string Gorev, string User_name, DateTime Change_Date, string Modified_Person)
        {
            var musteri = new Musteri_Table
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