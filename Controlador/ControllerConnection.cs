using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Controlador
{
    public class ControllerConnection
    {
        public static MySqlConnection ControllerGetConnection()
        {
            return Modelo.ModelConnection.getConnect();
        }
    }
}
