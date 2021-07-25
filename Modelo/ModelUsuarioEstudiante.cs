using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Modelo
{
    public class ModelUsuarioEstudiante
    {
        //insercion
        public static bool AniadirUsuarioEstudiante(string UsuarioEstudiante, string contraseniaEstudiante)
        {
            bool retorno = false;
            try
            {
                MySqlCommand cmdinsert = new MySqlCommand(string.Format("insert into tb_usuarioestudiante(usuarioEstudiante, contraseniaEstudiante) values ('{0}','{1}')", UsuarioEstudiante, contraseniaEstudiante), ModelConnection.getConnect());
                retorno = Convert.ToBoolean(cmdinsert.ExecuteNonQuery());
                return retorno;
            }
            catch (Exception)
            {
                return retorno;
            }
        }
        //lectura
        public static DataTable ObtenerUsuariosAlumno()
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM tb_usuarioEstudiante" +
                    "";
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
        public static bool ActualizarUsEstudiante(int id_usuarioEstudiante, string UsuarioEstudiante, string ContraseniaEstudiante)
        {
            bool retorno;
            try
            {
                MySqlCommand cmdupdate = new MySqlCommand(string.Format("UPDATE tb_usuarioEstudiante SET usuarioEstudiante = '" + UsuarioEstudiante + "', ContraseniaEstudiante = '" + ContraseniaEstudiante + "' WHERE id_usuarioEstudiante = '" + id_usuarioEstudiante + "'"), ModelConnection.getConnect());
                retorno = Convert.ToBoolean(cmdupdate.ExecuteNonQuery());
                return retorno;
            }
            catch (Exception)
            {
                return retorno = false;
            }
        }
        //delate
        public static bool EliminarDatosUsEstudiante(int id_usuarioEstudiante, string UsuarioEstudiante, string ContraseniaEstudiante)
        {
            bool retorno;
            try
            {
                MySqlCommand cmddelet = new MySqlCommand(string.Format("delete from tb_usuarioEstudiante where id_usuarioEstudiante = '" + id_usuarioEstudiante + "' "), ModelConnection.getConnect());
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
