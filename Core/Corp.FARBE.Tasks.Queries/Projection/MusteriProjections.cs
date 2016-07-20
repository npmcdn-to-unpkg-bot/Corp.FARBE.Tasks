using Corp.FARBE.Tasks.Data;
using Corp.FARBE.Tasks.Queries.Messages;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
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
        
        public static MusteriLoadResponse GetAllMusteri()
        {
            using (DBAmbarEntityModel context = new DBAmbarEntityModel())
            {

                MusteriLoadResponse response = new MusteriLoadResponse();

#if DEBUG
                context.Database.Log = delegate (string s)
                {
                    Debug.WriteLine(s);
                };

#endif
                // #01 fetch all users for combo box i a list.
                var result = context.Musteriler;
                
                result.Distinct().Select(x => x.User_name);
                IList userList = result.ToList();

                // #02 get all musteriler with their tasks, and assign users in to the object.
                result.GroupBy(x => x.User_name);
                result.Distinct();
                result.Max(x => x.Change_Date);
                var items = result.Select(x => new MusteriListItem
                {
                    Musteri_ID = x.Musteri_ID,
                    Musteri_Name = x.Musteri_Name,
                    AllUsers = userList,
                    musteri_Tasks = new MusteriTasksItem
                    {
                        User_name = x.User_name,
                        Gorev = x.Gorev
                    }
                });

                response.Items = items.ToList();
                response.TotalRecords = result.Count();

                return response;
            }
        }
        
    }
}