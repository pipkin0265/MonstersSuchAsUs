using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SQLite;
using System.Data;
using Dapper;

namespace Engine
{
    public class SqliteDataAccess
    { public static void BuildWorld()
        {
            LoadItems();
            GetTreasure();
            GetWeapon();
        }
        public static List<Item> LoadItems()
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConncectionString()))
            {

                var output = conn.Query<Item>("select * from Items", new DynamicParameters());
                return output.ToList();
            }
        }
        public List<Item> SaveItems(Item item)
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConncectionString()))
            {
                conn.Execute("", item);
                var output = conn.Query<Item>("select * from Items", new DynamicParameters());
                return output.ToList();
            }
        }

        public static List<Item> GetTreasure()
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConncectionString()))
            {

                var output = conn.Query<Item>("select * from Treasure", new DynamicParameters());
                return output.ToList();
            }
        }

        public List<Item> SaveTreasure(Item Treasure)
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConncectionString()))
            {
                conn.Execute("", Treasure);
                var output = conn.Query<Item>("select * from Treasure", new DynamicParameters());
                return output.ToList();
            }
        }

        public static List<Weapon> GetWeapon()
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConncectionString()))
            {

                var output = conn.Query<Weapon>("select * from Weapons", new DynamicParameters());
                return output.ToList();
            }
        }
        public static List<Potion> GetPotions()
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConncectionString()))
            {

                var output = conn.Query<Potion>("select * from Weapons", new DynamicParameters());
                return output.ToList();
            }
        }
        public static string LoadConncectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
