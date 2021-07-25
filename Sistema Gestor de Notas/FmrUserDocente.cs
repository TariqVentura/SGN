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
    public partial class FmrUserDocente : Form
    {
        public FmrUserDocente()
        {
            InitializeComponent();
        }
        ControllerUsuarioDocente objUsDoc;
        void limpiarCampos()
        {
            TXTusuariodocente.Clear();
            TXTcontraseniadocente.Clear();
        }
        void EnvioDatos()
        {
            ControllerUsuarioDocente objUs;
            string usuarioDocente, contraseniaDocente;
            usuarioDocente = TXTusuariodocente.Text;
            contraseniaDocente = TXTcontraseniadocente.Text;
            objUs = new ControllerUsuarioDocente(usuarioDocente, contraseniaDocente);
            bool respuesta = objUs.EnviarDatosControler();
            if (respuesta == true)
            {
                MessageBox.Show("Usuario Agregado exitosamente.", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ocurrio un error al intentar ingresar el usuario del docente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void CargarGridDatos()
        {
            GridUsDocente.DataSource = ControllerUsuarioDocente.CargarUsuarioDoc_controller();
        }

        private void FmrUserDocente_Load(object sender, EventArgs e)
        {
            CargarGridDatos();
        }

        private void BTNagregar_Click(object sender, EventArgs e)
        {
            EnvioDatos();
            limpiarCampos();
            CargarGridDatos();
        }

        private void GridUsDocente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int poscicion;
            poscicion = GridUsDocente.CurrentRow.Index;
            TXTid.Text = GridUsDocente[0, poscicion].Value.ToString();
            TXTusuariodocente.Text = GridUsDocente[1, poscicion].Value.ToString();
            TXTcontraseniadocente.Text = GridUsDocente[2, poscicion].Value.ToString();
        }

        void ActualizarDatos()
        {
            ControllerUsuarioDocente.id_usuarioDocente = Convert.ToInt16(TXTid.Text);
            objUsDoc = new ControllerUsuarioDocente(TXTusuariodocente.Text, TXTcontraseniadocente.Text);
            bool respuesta = objUsDoc.ActualizarDatosUsDocController();
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
        //eliminar datos
        void EliminarDatos()
        {
            ControllerUsuarioDocente.id_usuarioDocente = Convert.ToInt16(TXTid.Text);
            objUsDoc = new ControllerUsuarioDocente(TXTusuariodocente.Text, TXTcontraseniadocente.Text);
            bool respuesta = objUsDoc.EliminarDatosUsDocController();

            if (MessageBox.Show("Esta Seguro que desea eliminar el usuario " + TXTusuariodocente.Text + " ?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ControllerUsuarioDocente.id_usuarioDocente = Convert.ToInt16(TXTid.Text);
                objUsDoc = new ControllerUsuarioDocente(TXTusuariodocente.Text, TXTcontraseniadocente.Text);
                objUsDoc.EliminarDatosUsDocController();
            }
        }

        private void BTNactualizar_Click(object sender, EventArgs e)
        {
            ActualizarDatos();
            CargarGridDatos();
            limpiarCampos();
        }

        private void BTNeleiminar_Click(object sender, EventArgs e)
        {
            EliminarDatos();
            limpiarCampos();
            CargarGridDatos();
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
            FmrUserEstudiante fmranking = new FmrUserEstudiante();
            fmranking.Show();
        }
    }
}
