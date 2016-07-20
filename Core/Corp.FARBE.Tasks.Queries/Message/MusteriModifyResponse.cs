using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Corp.FARBE.Tasks.Queries.Messages
{
    [DataContract]
    public class MusteriModifyResponse
    {
        [DataMember]
        public IEnumerable<MusteriListItem> Items { get; set; }

        [DataMember]
        public int TotalRecords { get; set; }
    }
}