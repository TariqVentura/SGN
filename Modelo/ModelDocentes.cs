using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Modelo
{
    public class ModelDocentes
    {
        public static DataTable CargarEspecialidad()
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM tbespecialidad";
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

        public static DataTable CargarEstadoDocente()
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM tbestado_docente";
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

        public static bool RegistrarDocente(string nombres, string apellidos, string correo_docente, int id_especialidad, int id_estado_docente)
        {
            bool retorno = false;
            try
            {
                MySqlCommand cmdinsert = new MySqlCommand(string.Format("INSERT INTO tbdocente(nombre_docente, apellido_docente, correo_docente, id_especialidad, id_estado_docente) VALUES('{0}','{1}','{2}','{3}','{4}')", nombres, apellidos, correo_docente, id_especialidad, id_estado_docente), ModelConnection.getConnect());
                retorno = Convert.ToBoolean(cmdinsert.ExecuteNonQuery());
                return retorno;
            }
            catch (Exception)
            {
                return retorno;
            }
        }
        public static DataTable ObtenerListaDocentes()
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM tbdocente";
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
        public static DataTable CargarEspecialidadInner(int id)
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM tbespecialidad WHERE id_especialidad = ?param1";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), ModelConnection.getConnect());
                //Asignando valor al parametro param1
                cmdselect.Parameters.Add(new MySqlParameter("param1", id));
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
        public static DataTable CargarEstadoDocenteInner(int id)
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM tbestado_docente WHERE id_estado_docente = ?param1";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), ModelConnection.getConnect());
                //Asignando valor al parametro param1
                cmdselect.Parameters.Add(new MySqlParameter("param1", id));
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


        public static bool Actualizardocente(int pid_docente, string pnombres, string papellidos, string pcorreo_docente, int pid_especialidad, int pid_estado_docente)
        {
            bool retorno = false;
            try
            {
                MySqlCommand cmdupdate = new MySqlCommand(string.Format("UPDATE tbdocente SET nombre_docente = '" + pnombres + "', apellido_docente = '" + papellidos + "', correo_docente = '" + pcorreo_docente + "', id_especialidad = '" + pid_especialidad + "', id_estado_docente = '" + pid_estado_docente + "' WHERE id_docente = '" + pid_docente + "'"), ModelConnection.getConnect());
                retorno = Convert.ToBoolean(cmdupdate.ExecuteNonQuery());
                return retorno;
            }
            catch (Exception)
            {
                return retorno = false;
            }
        }

        public static bool Eliminardocente(int id)
        {
            bool retorno;
            try
            {
                MySqlCommand cmddel = new MySqlCommand(string.Format("DELETE FROM tbdocente WHERE id_docente = '" + id + "' "), ModelConnection.getConnect());
                retorno = Convert.ToBoolean(cmddel.ExecuteNonQuery());
                return retorno;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
