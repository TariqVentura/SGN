using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Modelo;
using System.Threading.Tasks;

namespace Controlador
{
    public class ControllerUsuarioAlumno
    {
        public static int id_usuarioEstudiante { get; set; }
        public string usuarioEstudiante { get; set; }
        public string contraseniaEstudiante { get; set; }

        public ControllerUsuarioAlumno(string pUsuarioEstudiante, string pContraseniaEstudiante)
        {
            usuarioEstudiante = pUsuarioEstudiante;
            contraseniaEstudiante = pContraseniaEstudiante;
        }
        //enviar
        public bool EnviarDatosControler()
        {
            return ModelUsuarioEstudiante.AniadirUsuarioEstudiante(usuarioEstudiante, contraseniaEstudiante);
        }
        //leer datos
        public static DataTable CargarUsuarioEst_controller()
        {
            return ModelUsuarioEstudiante.ObtenerUsuariosAlumno();
        }
        //actualizar datos
        public bool ActualizarDatosUsEstController()
        {
            return ModelUsuarioEstudiante.ActualizarUsEstudiante(id_usuarioEstudiante, usuarioEstudiante, contraseniaEstudiante);
        }
        //eliminar datos
        public bool EliminarDatosUsEstController()
        {
            return ModelUsuarioEstudiante.EliminarDatosUsEstudiante(id_usuarioEstudiante, usuarioEstudiante, contraseniaEstudiante);
        }
    }
}
