using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador;

namespace Sistema_Gestor_de_Notas
{
    public partial class FmrUserEstudiante : Form
    {
        public FmrUserEstudiante()
        {
            InitializeComponent();
        }
        public ControllerUsuarioAlumno objUs;
        void limpiarCampos()
        {
            TXTusuarioestudiante.Clear();
            TXTcontraseniaestudiante.Clear();
        }
        void EnvioDatos()
        {
            string usuarioDocente, contraseniaEstudiante;
            usuarioDocente = TXTusuarioestudiante.Text;
            contraseniaEstudiante = TXTcontraseniaestudiante.Text;
            objUs = new ControllerUsuarioAlumno(usuarioDocente, contraseniaEstudiante);
            bool respuesta = objUs.EnviarDatosControler();
            if (respuesta == true)
            {
                MessageBox.Show("Usuario Agregado exitosamente.", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al intentar ingresar el usuario del estudiante", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BTNagregar_Click(object sender, EventArgs e)
        {
            EnvioDatos();
            CargarGridDatos();
            limpiarCampos();
        }
        void CargarGridDatos()
        {
            GridUsEstudiante.DataSource = ControllerUsuarioAlumno.CargarUsuarioEst_controller();
        }

        private void FmrUserEstudiante_Load(object sender, EventArgs e)
        {
            CargarGridDatos();
        }

        private void GridUsEstudiante_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int poscicion;
            poscicion = GridUsEstudiante.CurrentRow.Index;
            TXTid.Text = GridUsEstudiante[0, poscicion].Value.ToString();
            TXTusuarioestudiante.Text = GridUsEstudiante[1, poscicion].Value.ToString();
            TXTcontraseniaestudiante.Text = GridUsEstudiante[2, poscicion].Value.ToString();
        }
        void ActualizarDatos()
        {
            ControllerUsuarioAlumno.id_usuarioEstudiante = Convert.ToInt16(TXTid.Text);
            objUs = new ControllerUsuarioAlumno(TXTusuarioestudiante.Text, TXTcontraseniaestudiante.Text);
            bool respuesta = objUs.ActualizarDatosUsEstController();
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
            limpiarCampos();
        }
        void EliminarDatos()
        {
            ControllerUsuarioAlumno.id_usuarioEstudiante = Convert.ToInt16(TXTid.Text);
            objUs = new ControllerUsuarioAlumno(TXTusuarioestudiante.Text, TXTcontraseniaestudiante.Text);
            bool respuesta = objUs.EliminarDatosUsEstController();

            if (MessageBox.Show("Esta Seguro que desea eliminar el usuario " + TXTusuarioestudiante.Text + " ?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ControllerUsuarioAlumno.id_usuarioEstudiante = Convert.ToInt16(TXTid.Text);
                objUs = new ControllerUsuarioAlumno(TXTusuarioestudiante.Text, TXTcontraseniaestudiante.Text);
                objUs.EliminarDatosUsEstController();
            }
        }

        private void BTNeliminar_Click(object sender, EventArgs e)
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
            FmrUserInvitado fmranking = new FmrUserInvitado();
            fmranking.Show();
        }
    }
}
