using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Modelo
{
    public class ModelConnection
    {
        public static MySqlConnection getConnect()
        {
            MySqlConnection retorno;
            string server, database, user, password, puerto;
            server = "127.0.0.1";
            database = "dbexpo";
            user = "root";
            password = "";
            try
            {
                retorno = new MySqlConnection("server = " + server +
                                              "; database = " + database +
                                              "; uid = " + user +
                                              "; pwd = " + password);
                retorno.Open();
                return retorno;
            }
            catch (Exception)
            {
                return retorno = null;
            }
        }
    }
}
