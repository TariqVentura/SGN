using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Modelo
{
    public class ModelAlumno
    {      
        //Llenado de combobox
        public static DataTable CargarNivel()
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM tbnivel";
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
        public static DataTable CargarFiltroEspecialidad(int id)
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM tbespecialidad WHERE id_nivel = ?param1";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), ModelConnection.getConnect());
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
        public static DataTable CargarGrupo()
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM tbgrupo";
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
        public static DataTable CargarFiltroGrupo(int id)
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM tbgrupo WHERE id_especialidad = ?param1";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), ModelConnection.getConnect());
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
        public static DataTable CargarSeccion()
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM tbseccion";
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
        public static DataTable CargarFiltroSeccion(int id)
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM tbseccion WHERE id_grupo = ?param1";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), ModelConnection.getConnect());
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
        public static DataTable CargarPeriodo()
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM tbperiodo";
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
        public static DataTable CargarNotas()
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM tbnotas";
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
        public static DataTable CargarFiltroNotas(int id)
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM tbnotas WHERE id_seccion = ?param1";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), ModelConnection.getConnect());
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
        public static DataTable CargarEstadoEstudiante()
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM tbestado_estudiante";
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
        public static DataTable CargarNivelInner(int id)
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM tbnivel WHERE id_nivel = ?param1";
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
        public static DataTable CargarGrupoInner(int id)
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM tbgrupo WHERE id_grupo" +
                    " = ?param1";
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
        public static DataTable CargarSeccionInner(int id)
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM tbseccion WHERE id_seccion" +
                    " = ?param1";
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
        public static DataTable CargarPeriodoInner(int id)
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM tbperiodo WHERE id_periodo" +
                    " = ?param1";
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
        public static DataTable CargarNotasInner(int id)
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM tbnotas WHERE id_notas" + " = ?param1";
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
        public static DataTable CargarEstadoInner(int id)
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM tbestado_estudiante WHERE id_estado_estudiante = ?param1";
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

        //Inicio de C
        public static bool RegistrarAlumno(string nombre_estudiante, string apellido_estudiante, string correo_estudiante, string carnet_estudiante, int id_nivel, int id_especialidad, int id_grupo, int id_seccion, int id_periodo, int id_notas, int id_estado_estudiante)
        {
            bool retorno = false;
            try
            {
                MySqlCommand cmdinsert = new MySqlCommand(string.Format("insert into tbestudiante(nombre_estudiante, apellido_estudiante, correo_estudiante, carnet_estudiante, id_nivel, id_especialidad, id_grupo, id_seccion, id_periodo, id_notas, id_estado_estudiante) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}', '{9}', '{10}')", nombre_estudiante, apellido_estudiante, correo_estudiante, carnet_estudiante, id_nivel, id_especialidad, id_grupo, id_seccion, id_periodo, id_notas, id_estado_estudiante), ModelConnection.getConnect());
                retorno = Convert.ToBoolean(cmdinsert.ExecuteNonQuery());
                return retorno;
            }
            catch (Exception)
            {
                return retorno;
            }
        }
        //Fin de C
        //Inicio de R
        public static DataTable ObtenerListaAlumnos()
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM tbestudiante";
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
        //Fin de R
        //Inicio de U
        public static bool ActualizarAlumnos(int pid_estudiante, string pnombre_estudiante, string papellido_estudiante, string pcorreo_estudiante, string pcarnet_estudiante, int pid_nivel, int pid_especialidad, int pid_grupo, int pid_seccion, int pid_periodo, int pid_notas, int pid_estado_estudiante)
        {
            bool retorno = false;
            try
            {
                MySqlCommand cmdupdate = new MySqlCommand(string.Format("UPDATE tbestudiante SET nombre_estudiante = '" + pnombre_estudiante + "', apellido_estudiante = '" + papellido_estudiante + "', correo_estudiante = '" + pcorreo_estudiante + "', carnet_estudiante = '" + pcarnet_estudiante + "', id_nivel = '" + pid_nivel + "', id_especialidad = '" + pid_especialidad + "', id_grupo = '" + pid_grupo + "', id_seccion = '" + pid_seccion + "', id_periodo = '" + pid_periodo + "', id_notas = '" + pid_notas + "', id_estado_estudiante = '" + pid_estado_estudiante + "' WHERE id_estudiante = '" + pid_estudiante + "'"), ModelConnection.getConnect());
                retorno = Convert.ToBoolean(cmdupdate.ExecuteNonQuery());
                return retorno;
            }
            catch (Exception)
            {
                return retorno = false;
            }
        }
        //Fin de U
        //Inicio de D
        public static bool EliminarDatosAlumno(int id)
        {
            bool retorno;
            try
            {
                MySqlCommand cmddelet = new MySqlCommand(string.Format("delete from tbestudiante where id_estudiante = '" + id + "' "), ModelConnection.getConnect());
                retorno = Convert.ToBoolean(cmddelet.ExecuteNonQuery());
                return retorno;
            }
            catch (Exception)
            {
                return retorno = false;
            }
        }
        //Fin de D

    }  
}
