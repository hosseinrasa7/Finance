﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DataActivity.Repositories
{
    public class AccGroupRepository : IRepository
    {
        
        public string TableName { get { return "AccGroup"; } }


        public int Delete(int id)
        {
            var result = 0;
            string command = string.Format("Delete {0} where Id ={1} ",TableName,id.ToString());
            using (SqlCommand sqlCommand = new SqlCommand(command, new SqlConnection(Connection.ConnectionString)) )
            {
               result = sqlCommand.ExecuteNonQuery();
            }
            return result;
        }

        public int Save(object accGroup)
        {

            using (var db = new FinanceDBEntities())
            {
                db.AccGroups.Add((AccGroup)accGroup);
                db.SaveChanges();
            }
            return 0;
        }

        public object SelectAll()
        {
            List<AccGroup> accGroups = new List<AccGroup>();
            using (var db = new FinanceDBEntities())
            {
                accGroups = db.AccGroups.ToList();
                

            }
            return accGroups;
        }

        public int SelectByField(List<object> Fields)
        {
            throw new NotImplementedException();
        }

        public int SelectById(int id)
        {
            throw new NotImplementedException();
        }

        public int Update(int id)
        {
            throw new NotImplementedException();
        }
    }
}
