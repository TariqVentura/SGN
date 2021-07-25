using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Modelo
{
    public class ModelUsuarioInvitado
    {
        //insercion
        public static bool AñadirInvitado(string usuario, string passworod, string correo)
        {
            bool retorno = false;
            try
            {
                MySqlCommand cmdinsert = new MySqlCommand(string.Format("insert into tbusuarioInvitado(usuario, password, correo) values ('{0}','{1}','{2}')", usuario, passworod, correo
), ModelConnection.getConnect());
                retorno = Convert.ToBoolean(cmdinsert.ExecuteNonQuery());
                return retorno;
            }
            catch (Exception)
            {
                return retorno;
            }
        }
        //lectura
        public static DataTable ObtenerUsuariosInvitados()
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM tbusuarioInvitado";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), ModelConnection.getConnect());
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdselect);
                data = new DataTable();
                adp.Fill(data);
                return data;
            }
            catch (Exception)
            {
                return data = null;
            }
        }
        //actualizacion
        public static bool ActualizarUsuarios(int IDusuarioInvitado, string usuario, string password, string correo)
        {
            bool retorno;
            try
            {
                MySqlCommand cmdupdate = new MySqlCommand(string.Format("UPDATE tbusuarioInvitado SET usuario = '" + usuario + "', password = '" + password + "', correo = '" + correo + "' WHERE IDusuarioInvitado = '" + IDusuarioInvitado + "'"), ModelConnection.getConnect());
                retorno = Convert.ToBoolean(cmdupdate.ExecuteNonQuery());
                return retorno;
            }
            catch (Exception)
            {
                return retorno = false;
            }
        }
        //delete
        public static bool EliminrUsusarios(int IDusuarioInvitado, string usuario, string password, string correo)
        {
            bool retorno;
            try
            {
                MySqlCommand cmddelet = new MySqlCommand(string.Format("delete from tbusuarioInvitado where IDusuarioInvitado = '" + IDusuarioInvitado + "' "), ModelConnection.getConnect());
                retorno = Convert.ToBoolean(cmddelet.ExecuteNonQuery());
                return retorno;
            }
            catch (Exception)
            {
                return retorno = false;
            }
        }
    }
}
