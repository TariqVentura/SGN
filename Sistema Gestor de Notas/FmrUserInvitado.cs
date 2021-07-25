using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using Controlador;

namespace Sistema_Gestor_de_Notas
{
    public partial class FmrUserInvitado : Form
    {
        public FmrUserInvitado()
        {
            InitializeComponent();
        }
        public ControllerUserInvitado objinvitado;
        void LimpiarCampos()
        {
            txtCorreo.Clear();
            TXTid.Clear();
            TXTusuariodocente.Clear();
            TXTcontraseniadocente.Clear();
        }
        void EnvioDatos()
        {
            string usuario, password, correo;
            usuario = TXTusuariodocente.Text;
            password = TXTcontraseniadocente.Text;
            correo = txtCorreo.Text;
            objinvitado = new ControllerUserInvitado(usuario, password, correo);
            bool respuesta = objinvitado.EnviarDatosControler();
            if (respuesta == true)
            {
                MessageBox.Show("Usuario Agregado exitosamente.", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ocurrio un error al intentar ingresar el usuario del docente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BTNagregar_Click(object sender, EventArgs e)
        {
            EnvioDatos();
            CargarGridDatos();
            LimpiarCampos();
        }
        void CargarGridDatos()
        {
            GridUsDocente.DataSource = ControllerUserInvitado.CargarUsuariosController();
        }

        private void FmrUserInvitado_Load(object sender, EventArgs e)
        {
            CargarGridDatos();
        }

        private void GridUsDocente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int posicicon;
            posicicon = GridUsDocente.CurrentRow.Index;
            TXTid.Text = GridUsDocente[0, posicicon].Value.ToString();
            TXTusuariodocente.Text = GridUsDocente[1, posicicon].Value.ToString();
            TXTcontraseniadocente.Text = GridUsDocente[2, posicicon].Value.ToString();
            txtCorreo.Text = GridUsDocente[3, posicicon].Value.ToString();
        }
        void ActualizarDatos()
        {
            ControllerUserInvitado.IDusuarioInvitado = Convert.ToInt16(TXTid.Text);
            objinvitado = new ControllerUserInvitado(TXTusuariodocente.Text, TXTcontraseniadocente.Text, txtCorreo.Text);
            bool respuesta = objinvitado.ActualizarDatos();
            if (respuesta == true)
            {
                MessageBox.Show("Usuario actualizado exitosamente", "Proceso completado",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
               MessageBox.Show("Usuario no pudo ser actualizado.", "Proceso incompleto",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTNactualizar_Click(object sender, EventArgs e)
        {
            ActualizarDatos();
            CargarGridDatos();
            LimpiarCampos();
        }

        void EliminarDatos()
        {
            ControllerUserInvitado.IDusuarioInvitado = Convert.ToInt16(TXTid.Text);
            objinvitado = new ControllerUserInvitado(TXTusuariodocente.Text, TXTcontraseniadocente.Text, txtCorreo.Text);
            bool respuesta = objinvitado.EliminarDatos();
            if (MessageBox.Show("Esta Seguro que desea eliminar el usuario " + TXTusuariodocente.Text + " ?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ControllerUsuarioDocente.id_usuarioDocente = Convert.ToInt16(TXTid.Text);
                objinvitado = new ControllerUserInvitado (TXTusuariodocente.Text, TXTcontraseniadocente.Text, txtCorreo.Text);
                objinvitado.EliminarDatos();
            }
        }

        private void BTNeleiminar_Click(object sender, EventArgs e)
        {
            EliminarDatos();
            CargarGridDatos();
            LimpiarCampos();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta Seguro que desea cerrar el programa?", "confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Fmranking fmranking = new Fmranking();
            fmranking.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            FmrInsertarA fmranking = new FmrInsertarA();
            fmranking.Show();
        }
    }
}
