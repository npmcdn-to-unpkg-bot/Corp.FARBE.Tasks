using Corp.FARBE.Tasks.Data;
using Corp.FARBE.Tasks.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Corp.FARBE.Tasks.Mocks
{
    public class DomainMocksFactory
    {
        public const string MUSTERI_NAME ="MY CUSTOMER" ;
        public const string GOREV = "MT ASSISTANT";
        public const string USERNAME = "MY USERNAME";
        public static DateTime CHANGE_DATE = new DateTime(2016, 1, 1);
        public const string MODIFIED_PERSON = "MY DOMAIN PERSON";

        public static Musteri_Table CreateMusteri()
        {
            Musteri_Table musteri = new Musteri_Table();
            musteri.Musteri_Name = MUSTERI_NAME;
            musteri.User_name = USERNAME;
            musteri.Change_Date = CHANGE_DATE;
            musteri.Gorev = GOREV;
            musteri.Modified_Person = MODIFIED_PERSON;
            return musteri;
        }
    }
}