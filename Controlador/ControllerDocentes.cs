using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Modelo;

namespace Controlador
{
    public class ControllerDocentes
    {
        public static DataTable ObtenerEspecialidad()
        {
            return ModelDocentes.CargarEspecialidad();
        }

        public static DataTable ObtenerEstadoDocente()
        {
            return ModelDocentes.CargarEstadoDocente();
        }

        public static DataTable CargarEspecialidadInnerJoin_Controller(int id)
        {
            return ModelDocentes.CargarEspecialidadInner(id);
        }

        public static DataTable CargarEstadoDocenteInnerJoin_Controller(int id)
        {
            return ModelDocentes.CargarEstadoDocenteInner(id);
        }

        public static int id_docente { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string correo_docente { get; set; }
        public int id_especialidad { get; set; }
        public int id_estado_docente { get; set; }

        //CONSTRUCTOR
        public ControllerDocentes(string pnombre, string papellidos, string pcorreo, int pidespecialidad, int pidestadoDocente)
        {
            nombres = pnombre;
            apellidos = papellidos;
            correo_docente = pcorreo;
            id_especialidad = pidespecialidad;
            id_estado_docente = pidestadoDocente;

        }

        //CRUD
        /// <summary>
        /// INSERCIÓN DE DATOS
        /// </summary>
        /// <returns></returns>
        public bool EnviarDatosController()
        {
            return ModelDocentes.RegistrarDocente(nombres, apellidos, correo_docente, id_especialidad, id_estado_docente);
        }

        /// <summary>
        /// LECTURA DE DATOS
        /// </summary>
        /// <returns></returns>
        public static DataTable CargarDocentes_Controller()
        {
            return ModelDocentes.ObtenerListaDocentes();
        }

        /// <summary>
        /// ACTUALIZAR DATOS
        /// </summary>
        /// <returns></returns>
        public bool ActualizardocenteController()
        {
            return ModelDocentes.Actualizardocente(id_docente, nombres, apellidos, correo_docente, id_especialidad, id_estado_docente);
        }

        public static bool EliminarDatosController()
        {
            return ModelDocentes.Eliminardocente(id_docente);
        }
    }
}
