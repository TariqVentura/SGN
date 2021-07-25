using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Modelo;

namespace Controlador
{
    public class ControllerUsuarioDocente
    {
        public static int id_usuarioDocente { get; set; }
        public string usuarioDocente { get; set; }
        public string contraseniaDocente { get; set; }

        //constructor
        public ControllerUsuarioDocente(string pUsuarioDocente, string pContraseniaDocente)
        {
            usuarioDocente = pUsuarioDocente;
            contraseniaDocente = pContraseniaDocente;
        }
        //envio datos
        public bool EnviarDatosControler()
        {
            return ModelUsuarioDocente.AniadirUsuarioDocente(usuarioDocente, contraseniaDocente);
        }
        //leer datos
        public static DataTable CargarUsuarioDoc_controller()
        {
            return ModelUsuarioDocente.ObtenerUsuariosDocente();
        }
        //actualizar datos
        public bool ActualizarDatosUsDocController()
        {
            return ModelUsuarioDocente.ActualizarUsDoc(id_usuarioDocente, usuarioDocente, contraseniaDocente);
        }
        //eliminar datos
        public bool EliminarDatosUsDocController()
        {
            return ModelUsuarioDocente.EliminarDatosUsDoc(id_usuarioDocente, usuarioDocente, contraseniaDocente);
        }
    }
}
