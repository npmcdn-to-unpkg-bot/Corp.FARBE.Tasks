using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Corp.FARBE.Tasks.Queries.Messages
{
    [DataContract]
    public class MusteriModifyRequest
    {
        [DataMember]
        public int Musteri_ID { get; set; }

        [DataMember]
        public string Musteri_Name { get; set; }

        [DataMember]
        public string User_name { get; set; }

        [DataMember]
        public int Take { get; set; }

        [DataMember]
        public int Skip { get; set; }
    }
}