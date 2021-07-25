using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Modelo;

namespace Controlador
{
    public class ControllerNotas
    {
        //Llenado de ComboBox
        public static DataTable ObtenerEspecialidad()
        {
            return ModelNotas
.CargarEspecialidad();
        }
        public static DataTable ObtenerSeccion()
        {
            return ModelNotas.CargarSeccion();
        }
        public static DataTable FiltrarSeccion(int idsec)
        {
            return ModelNotas.CargarFiltroSeccion(idsec);
        }
        public static DataTable ObtenerPeriodo()
        {
            return ModelNotas.CargarPeriodo();
        }
        public static DataTable ObtenerEstadoNotas()
        {
            return ModelNotas.CargarEstadoNotas();
        }

        //InnerJoin
        public static DataTable CargarEspecialidadInnerJoinController(int id)
        {
            return ModelAlumno.CargarEspecialidadInner(id);
        }
        public static DataTable CargarSeccionInnerJoinController(int id)
        {
            return ModelNotas
.CargarSeccionInner(id);
        }
        public static DataTable CargarPeriodoInnerJoinController(int id)
        {
            return ModelNotas
.CargarPeriodoInner(id);
        }
        public static DataTable CargarEstadoNotasInnerJoinController(int id)
        {
            return ModelNotas.CargarEstadoNotasInner(id);
        }

        public static int id_notas { get; set; }
        public string notas { get; set; }
        public string promedioT { get; set; }
        public string promedioA { get; set; }
        public int id_periodo { get; set; }
        public int id_estadoNotas { get; set; }
        public int id_seccion { get; set; }

        public ControllerNotas(string pnotas, string ppromedioT, string ppromedioA, int pid_periodo, int pid_estadoNotas, int pid_seccion)
        {
            notas = pnotas;
            promedioT = ppromedioT;
            promedioA = ppromedioA;
            id_periodo = pid_periodo;
            id_estadoNotas = pid_estadoNotas;
            id_seccion = pid_seccion;
        }

        //CRUD
        //C
        //R
        public static DataTable CargarDatosController()
        {
            return ModelNotas.ObtenerListaNotas();
        }
        //U
        public bool ActualizarNotasController()
        {
            return ModelNotas.Actualizarnotas(id_notas, notas, promedioT, promedioA, id_periodo, id_estadoNotas, id_seccion);
        }
        //D
    }
}
