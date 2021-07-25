using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Modelo
{
    public class ModelUsuarioDocente
    {
        //insercion
        public static bool AniadirUsuarioDocente(string UsuarioDocente, string ContraseniaDocente)
        {
            bool retorno = false;
            try
            {
                MySqlCommand cmdinsert = new MySqlCommand(string.Format("insert into tb_usuariodocente(usuarioDocente, ContraseniaDocente) values ('{0}','{1}')", UsuarioDocente, ContraseniaDocente), ModelConnection.getConnect());
                retorno = Convert.ToBoolean(cmdinsert.ExecuteNonQuery());
                return retorno;
            }
            catch (Exception)
            {
                return retorno;
            }
        }
        //lectura
        public static DataTable ObtenerUsuariosDocente()
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM tb_usuariodocente";
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
        public static bool ActualizarUsDoc(int id_usuarioDocente, string UsuarioDocente, string ContraseniaDocente)
        {
            bool retorno;
            try
            {
                MySqlCommand cmdupdate = new MySqlCommand(string.Format("UPDATE tb_usuariodocente SET usuarioDocente = '" + UsuarioDocente + "', ContraseniaDocente = '" + ContraseniaDocente + "' WHERE id_usuarioDocente = '" + id_usuarioDocente + "'"), ModelConnection.getConnect());
                retorno = Convert.ToBoolean(cmdupdate.ExecuteNonQuery());
                return retorno;
            }
            catch (Exception)
            {
                return retorno = false;
            }
        }
        //delate
        public static bool EliminarDatosUsDoc(int id_usuarioDocente, string UsuarioDocente, string ContraseniaDocente)
        {
            bool retorno;
            try
            {
                MySqlCommand cmddelet = new MySqlCommand(string.Format("delete from tb_usuariodocente where id_usuarioDocente = '" + id_usuarioDocente + "' "), ModelConnection.getConnect());
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
