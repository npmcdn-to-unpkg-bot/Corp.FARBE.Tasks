using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Corp.FARBE.Tasks.Queries.Messages
{
    [DataContract]
    public class MusteriListItem
    {
        [DataMember]
        public int Musteri_ID { get; set; }

        [DataMember]
        public string Musteri_Name { get; set; }

        [DataMember]
        public MusteriTasksItem musteri_Tasks { get; set; }

        [DataMember]
        public IList AllUsers { get; set; }
    }


    [DataContract]
    public class MusteriTasksItem
    {
        [DataMember]
        public string Gorev { get; set; }

        [DataMember]
        public string User_name { get; set; }
    }

    [DataContract]
    public class MusteriDetailList
    {
        [DataMember]
        public int Musteri_ID { get; set; }

        [DataMember]
        public string Musteri_Name { get; set; }

        [DataMember]
        public string Gorev { get; set; }

        [DataMember]
        public string User_name { get; set; }
        [DataMember]
        public DateTime? Change_Date { get; set; }

        [DataMember]
        public string Modified_Person { get; set; }
    }
}