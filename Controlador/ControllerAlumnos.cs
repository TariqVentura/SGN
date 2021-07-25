using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Modelo;

namespace Controlador
{
    public class ControllerAlumnos
    {
        //Inicia Insersion Alumnos
        //Llenar ComboBox
        public static DataTable ObtenerNivel()
        {
            return ModelAlumno.CargarNivel();
        }
        public static DataTable ObtenerEspecialidad()
        {
            return ModelAlumno.CargarEspecialidad();
        }
        public static DataTable FiltrarEspecialidad(int idesp)
        {
            return ModelAlumno.CargarFiltroEspecialidad(idesp);
        }
        public static DataTable ObtenerGrupo()
        {
            return ModelAlumno.CargarGrupo();
        }
        public static DataTable FiltrarGrupo(int idgru)
        {
            return ModelAlumno.CargarFiltroGrupo(idgru);
        }
        public static DataTable ObtenerSeccion()
        {
            return ModelAlumno.CargarSeccion();
        }
        public static DataTable FiltrarSeccion(int idsec)
        {
            return ModelAlumno.CargarFiltroSeccion(idsec);
        }
        public static DataTable ObtenerPeriodo()
        {
            return ModelAlumno.CargarPeriodo();
        }
        public static DataTable ObtenerNotas()
        {
            return ModelAlumno.CargarNotas();
        }
        public static DataTable FiltrarNotas(int idnot)
        {
            return ModelAlumno.CargarFiltroNotas(idnot);
        }
        public static DataTable ObtenerEstadoEstudiante()
        {
            return ModelAlumno.CargarEstadoEstudiante();
        }

        public static DataTable CargarNivelInnerJoinController(int id)
        {
            return ModelAlumno.CargarNivelInner(id);
        }
        public static DataTable CargarEspecialidadInnerJoinController(int id)
        {
            return ModelAlumno.CargarEspecialidadInner(id);
        }
        public static DataTable CargarGrupoInnerJoinController(int id)
        {
            return ModelAlumno.CargarGrupoInner(id);
        }
        public static DataTable CargarSeccionInnerJoinController(int id)
        {
            return ModelAlumno.CargarSeccionInner(id);
        }
        public static DataTable CargarPeriodoInnerJoinController(int id)
        {
            return ModelAlumno.CargarPeriodoInner(id);
        }
        public static DataTable CargarNotasInnerJoinController(int id)
        {
            return ModelAlumno.CargarNotasInner(id);
        }
        public static DataTable CargarEstadoInnerJoinController(int id)
        {
            return ModelAlumno.CargarEstadoInner(id);
        }

        public static  int id_estudiante { get; set; }
        public string nombre_estudiante { get; set; }
        public string apellido_estudiante { get; set; }
        public string correo_estudiante { get; set; }
        public string carnet_estudiante { get; set; }
        public int id_nivel { get; set; }
        public int id_especialidad { get; set; }
        public int id_grupo { get; set; }
        public  int id_seccion { get; set; }
        public int id_periodo { get; set; }
        public int id_notas { get; set; }
        public int id_estado_estudiante { get; set; }

        //Constructor
        public ControllerAlumnos(string pnombre_estudiante, string papellido_estudiante, string pcorreo_estudiante, string pcarnet_estudiante, int pid_nivel, int pid_especialidad, int pid_grupo, int pid_seccion, int pid_periodo, int pid_notas, int pid_estado_estudiante)
        {
            nombre_estudiante = pnombre_estudiante;
            apellido_estudiante = papellido_estudiante;
            correo_estudiante = pcorreo_estudiante;
            carnet_estudiante = pcarnet_estudiante;
            id_nivel = pid_nivel;
            id_especialidad = pid_especialidad;
            id_grupo = pid_grupo;
            id_seccion = pid_seccion;
            id_periodo = pid_periodo;
            id_notas = pid_notas;
            id_estado_estudiante = pid_estado_estudiante;
        }

        //CRUD
        //C
        public bool EnviarDatosController()
        {
            return ModelAlumno.RegistrarAlumno(nombre_estudiante, apellido_estudiante, correo_estudiante, carnet_estudiante, id_nivel, id_especialidad, id_grupo, id_seccion, id_periodo, id_notas, id_estado_estudiante);
        }
        //R
        public static DataTable CargarDatosController()
        {
            return ModelAlumno.ObtenerListaAlumnos();
        }
        //U
        public bool ActualizarDatosController()
        {
            return ModelAlumno.ActualizarAlumnos(id_estudiante ,nombre_estudiante, apellido_estudiante, correo_estudiante, carnet_estudiante, id_nivel, id_especialidad, id_grupo, id_seccion, id_periodo, id_notas, id_estado_estudiante);
        }
        //R
        public bool EliminarDatosController(int id)
        {
            return ModelAlumno.EliminarDatosAlumno(id);
        }
    }
}
