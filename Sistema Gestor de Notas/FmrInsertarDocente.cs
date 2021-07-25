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
    public partial class FmrInsertarDocente : Form
    {
        public FmrInsertarDocente()
        {
            InitializeComponent();
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

        public ControllerDocentes objdocentes;

        void CargarEspecialidad()
        {
            try
            {
                DataTable retornotipodoc = ControllerDocentes.ObtenerEspecialidad();
                CmbEspecialidad.DataSource = retornotipodoc;
                CmbEspecialidad.DisplayMember = "especialidad";
                CmbEspecialidad.ValueMember = "id_especialidad";
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar la especialidad, verifique su conexión a internet y si el problema persiste consulte con el administrador.", "Error de lectura", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void CargarEstadoDocente()
        {
            try
            {
                DataTable retornotipodoc = ControllerDocentes.ObtenerEstadoDocente();
                CmbEstadoDocente.DataSource = retornotipodoc;
                CmbEstadoDocente.DisplayMember = "estado_docente";
                CmbEstadoDocente.ValueMember = "id_estado_docente";
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar la especialidad, verifique su conexión a internet y si el problema persiste consulte con el administrador.", "Error de lectura", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void CargarListas()
        {
            CargarEstadoDocente();
            CargarEspecialidad();
        }

        void LimpiarCampos()
        {
            txtApellido.Clear();
            txtNombre.Clear();
            txtidDocente.Clear();
            mskCorreo.Clear();
        }

        private void FmrInsertarDocente_Load(object sender, EventArgs e)
        {
            CargarListas();
            CargarGridDatos();
        }
        private void CmbEspecialidad_Click(object sender, EventArgs e)
        {
            CargarEspecialidad();
        }

        private void CmbEstadoDocente_Click(object sender, EventArgs e)
        {
            CargarEstadoDocente();
        }
        void CargarGridDatos()
        {
            dgvDocentes.DataSource = ControllerDocentes.CargarDocentes_Controller();
        }
        private void dgvDocentes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int posicion;
            posicion = dgvDocentes.CurrentRow.Index;
            txtidDocente.Text = dgvDocentes[0, posicion].Value.ToString();
            txtNombre.Text = dgvDocentes[1, posicion].Value.ToString();
            txtApellido.Text = dgvDocentes[2, posicion].Value.ToString();
            mskCorreo.Text = dgvDocentes[3, posicion].Value.ToString();

            int id_especialidad = Convert.ToInt32(dgvDocentes[4, posicion].Value.ToString());
            CmbEspecialidad.DataSource = ControllerDocentes.CargarEspecialidadInnerJoin_Controller(id_especialidad);
            CmbEspecialidad.DisplayMember = "especialidad";
            CmbEspecialidad.ValueMember = "id_especialidad";

            int id_estado_docente = Convert.ToInt32(dgvDocentes[5, posicion].Value.ToString());
            CmbEstadoDocente.DataSource = ControllerDocentes.CargarEstadoDocenteInnerJoin_Controller(id_estado_docente);
            CmbEstadoDocente.DisplayMember = "estado_docente";
            CmbEstadoDocente.ValueMember = "id_estado_docente";
        }
        void EnvioDatos()
        {
            //DECLARANDO VARIABLES
            string nombres, apellido, correo_docente;
            int id_especialidad, id_estado_docente;
            nombres = txtNombre.Text;
            apellido = txtApellido.Text;
            correo_docente = mskCorreo.Text;
            id_especialidad = Convert.ToInt32(CmbEspecialidad.SelectedValue);
            id_estado_docente = Convert.ToInt32(CmbEstadoDocente.SelectedValue);
            //ENVIANDO DATOS
            objdocentes = new ControllerDocentes(nombres, apellido, correo_docente, id_especialidad, id_estado_docente);
            bool respuesta = objdocentes.EnviarDatosController();
            if (respuesta == true)
            {
                MessageBox.Show("Usuario ingresado exitosamente.", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ocurrio un error al intentar ingresar el usuario, favor verifique los datos.", "Registro incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ActualizarDatos()
        {
            ControllerDocentes.id_docente = Convert.ToInt16(txtidDocente.Text);
            objdocentes = new ControllerDocentes(txtNombre.Text, txtApellido.Text, mskCorreo.Text, Convert.ToInt32(CmbEspecialidad.SelectedValue), Convert.ToInt32(CmbEstadoDocente.SelectedValue));
            bool respuesta = objdocentes.ActualizardocenteController();
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
        void EliminarDatos()
        {
            ControllerDocentes.id_docente = Convert.ToInt16(txtidDocente.Text);
            if (MessageBox.Show("¿estas seguro que desea eliminar a " + txtNombre.Text + " ? ", "Comfirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ControllerDocentes.EliminarDatosController();
            }
        }
        private void btnActualizarDocente_Click_1(object sender, EventArgs e)
        {
            ActualizarDatos();
            CargarGridDatos();
            CargarListas();
        }

        private void btnEliminarDocente_Click_1(object sender, EventArgs e)
        {
            EliminarDatos();
            CargarGridDatos();
            LimpiarCampos();
        }

        private void btnAgregarDocente_Click_1(object sender, EventArgs e)
        {
            EnvioDatos();
            CargarGridDatos();
            LimpiarCampos();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FmrUserDocente fmruserdocente = new FmrUserDocente();
            fmruserdocente.Show();
        }
    }
}
