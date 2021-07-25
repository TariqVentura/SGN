using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using Modelo;

namespace Controlador
{
    public class ControllerUserInvitado
    {
        public static int IDusuarioInvitado { get; set; }
        static string usuario { get; set; }
        static string password { get; set; }
        static string correo { get; set; }

        public ControllerUserInvitado(string pusuario, string ppassword, string pcorreo)
        {
            usuario = pusuario;
            password = ppassword;
            correo = pcorreo;
        }

        //envio datos
        public bool EnviarDatosControler()
        {
            return ModelUsuarioInvitado.AñadirInvitado(usuario, password, correo);

        }
        //lectura
        public static DataTable CargarUsuariosController()
        {
            return ModelUsuarioInvitado.ObtenerUsuariosInvitados();
        }
        //actualizacion
        public bool ActualizarDatos()
        {
            return ModelUsuarioInvitado.ActualizarUsuarios(IDusuarioInvitado, usuario, password, correo);
        }
        //eliminacion
        public bool EliminarDatos()
        {
            return ModelUsuarioInvitado.EliminrUsusarios(IDusuarioInvitado, usuario, password, correo);
        }
    }
}
