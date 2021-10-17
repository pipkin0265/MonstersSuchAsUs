using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;

namespace Engine
{
   public class DataAccess
    {
        public List<Item> GetItems(int id, string name, string description)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Engine.Properties.Settings.DerekMonstersSuchAsUsConnectionString")))
            {
                
                var output = connection.Query<Item>("dbo.Items").ToList();
                return output;
            }
        }
    }
}
