using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql;

namespace OtelYönetimProjesi.Data_Access_Layer
{
    public class BaglantiAc
    {
        

        private static string connectionString = "Server=172.21.54.253;Database=25_132330049;User=25_132330049;Password=!nif.ogr49OZ";

        public static MySqlConnection baglantiGetir()
        {
            MySqlConnection baglanti = new MySqlConnection(connectionString);
            return baglanti;
        }
    }
    
}
