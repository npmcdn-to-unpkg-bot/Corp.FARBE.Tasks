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

        public static Musteri CreateMusteri()
        {
            return Musteri.Create(MUSTERI_NAME, GOREV, USERNAME, CHANGE_DATE, MODIFIED_PERSON);
        }
    }
}