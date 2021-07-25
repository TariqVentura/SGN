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
    public partial class FmrInsertarN : Form
    {
        public FmrInsertarN()
        {
            InitializeComponent();
        }
        public ControllerNotas objnotas;
        private void groupBox1_Enter(object sender, EventArgs e)
        {

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

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            Fmranking fmranking = new Fmranking();
            fmranking.Show();
        }
        //Llenado de ComboBox
        void CargarEspecialidad()
        {
            try
            {
                DataTable retornoespecialidad = ControllerNotas.ObtenerEspecialidad();
                cmbEspecialidad.DataSource = retornoespecialidad;
                cmbEspecialidad.DisplayMember = "especialidad";
                cmbEspecialidad.ValueMember = "id_especialidad";
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar las especialidades, verifique su conexión a internet y si el problema persiste consulte con el administrador.", "Error de lectura", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void CargarSeccion()
        {
            try
            {
                DataTable retornoseccion = ControllerAlumnos.FiltrarSeccion(Convert.ToInt16(cmbEspecialidad.SelectedValue));
                cmbSeccion.DataSource = retornoseccion;
                cmbSeccion.DisplayMember = "seccion";
                cmbSeccion.ValueMember = "id_seccion";
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar las Secciones, verifique su conexión a internet y si el problema persiste consulte con el administrador.", "Error de lectura", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void CargarPeriodo()
        {
            try
            {
                DataTable retornoperiodo = ControllerNotas.ObtenerPeriodo();
                cmbperiodo.DataSource = retornoperiodo;
                cmbperiodo.DisplayMember = "periodo";
                cmbperiodo.ValueMember = "id_periodo";
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar los periodos, verifique su conexión a internet y si el problema persiste consulte con el administrador.", "Error de lectura", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void CargarEstadoNotas()
        {
            try
            {
                DataTable retornoestadonotas = ControllerNotas.ObtenerEstadoNotas();
                cmbEstadoNota.DataSource = retornoestadonotas;
                cmbEstadoNota.DisplayMember = "estadoNotas";
                cmbEstadoNota.ValueMember = "id_estadoNotas";
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar los estados, verifique su conexión a internet y si el problema persiste consulte con el administrador.", "Error de lectura", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Creacion Filtros
        private void cmbEspecialidad_Leave(object sender, EventArgs e)
        {
            DataTable datoSeccion = ControllerAlumnos.FiltrarSeccion(Convert.ToInt16(cmbEspecialidad.SelectedValue));
            cmbSeccion.DataSource = datoSeccion;
            cmbSeccion.DisplayMember = "seccion";
            cmbSeccion.ValueMember = "id_seccion";
        }
       
        void CargarLista()
        {
            CargarEspecialidad();
            CargarSeccion();
            CargarPeriodo();
            CargarEstadoNotas();
        }

        private void FmrInsertarN_Load(object sender, EventArgs e)
        {
            CargarLista();
        }

        //CRUD
        //C
        //R
        void CargarGridDatos()
        {
            dgvNotas.DataSource = ControllerNotas.CargarDatosController();
        }
        private void dgvNotas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int poscicion;
            poscicion = dgvNotas.CurrentRow.Index;
            txtidNota.Text = dgvNotas[0, poscicion].Value.ToString();
            txtCarnet.Text = dgvNotas[1, poscicion].Value.ToString();
            txtPromedioT.Text = dgvNotas[2, poscicion].Value.ToString();
            txtPromedioA.Text = dgvNotas[3, poscicion].Value.ToString();

            int id_periodo = Convert.ToInt32(dgvNotas[4, poscicion].Value.ToString());
            cmbperiodo.DataSource = ControllerNotas.CargarPeriodoInnerJoinController(id_periodo);
            cmbperiodo.DisplayMember = "periodo";
            cmbperiodo.ValueMember = "id_periodo";

           
        }
        //U
        void ActualizarDatos()
        {
            ControllerNotas.id_notas = Convert.ToInt16(txtidNota.Text);
            objnotas = new ControllerNotas(txtCarnet.Text,
                                           txtPromedioA.Text,
                                           txtPromedioT.Text,
                                           Convert.ToInt16(cmbperiodo.SelectedValue),
                                           Convert.ToInt16(cmbEstadoNota.SelectedValue),
                                           Convert.ToInt16(cmbSeccion)
                                                   );
            bool respuesta = objnotas.ActualizarNotasController();
            if (respuesta == true)
            {
                MessageBox.Show("Notas actualizadas exitosamente", "Proceso completado",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Usuario no pudo ser actualizado.", "Proceso incompleto",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnActualizar_Click(object sender, EventArgs e)
        {

        }

        private void btnActulizarNotas_Click(object sender, EventArgs e)
        {

        }


        //D
    }
}
