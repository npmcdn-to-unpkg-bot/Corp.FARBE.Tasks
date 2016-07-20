using Corp.FARBE.Tasks.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Corp.FARBE.Tasks.Queries.Projections
{
    public class MusteriProjections
    {
        public static int GetMusteriCount()
        {
            using(DBAmbarEntityModel context = new DBAmbarEntityModel())
            {
                return context.Musteriler.Count();
            }
        }



    }
}