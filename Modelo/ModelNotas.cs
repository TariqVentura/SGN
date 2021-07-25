using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Modelo
{
    public class ModelNotas
    {
        //Llenado de ComboBox
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
                string query = "SELECT * FROM tbseccion WHERE id_especialidad = ?param1";
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
        public static DataTable CargarEstadoNotas()
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM tbestadoNotas";
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

        //InnerJoin
        public static DataTable CargarEspecialidadInner(int id)
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM tbespecialidad WHERE id_especialidad = ?param1";
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
        public static DataTable CargarSeccionInner(int id)
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM tbseccion WHERE id_seccion" +
                    " = ?param1";
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
        public static DataTable CargarPeriodoInner(int id)
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM tbperiodo WHERE id_periodo" +
                    " = ?param1";
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
        public static DataTable CargarEstadoNotasInner(int id)
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM tbestadoNotas WHERE id_estadoNotas = ?param1";
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

        //CRUD
        //C
        //R
        public static DataTable ObtenerListaNotas()
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
        //U
        public static bool Actualizarnotas(int id_notas, string notas, string promedioT, string promedioA, int id_periodo, int id_estadoNotas, int id_seccion)
        {
            bool retorno;
            try
            {
                MySqlCommand cmdupdate = new MySqlCommand(string.Format("UPDATE tbnotas SET notas = '" + notas + "', promedioT = '" + promedioT + "', promedioA = '" + promedioA + "', id_periodo = '" + id_periodo + "', id_estadoNotas = '" + id_estadoNotas + "', id_seccion = '" + id_seccion + "' WHERE id_notas = '" + id_notas + "'"), ModelConnection.getConnect());
                retorno = Convert.ToBoolean(cmdupdate.ExecuteNonQuery());
                return retorno;
            }
            catch (Exception)
            {
                return retorno = false;
            }
        }
        //D
    }
}
