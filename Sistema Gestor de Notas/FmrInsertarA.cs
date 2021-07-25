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
    public partial class FmrInsertarA : Form
    {
        public FmrInsertarA()
        {
            InitializeComponent();
        }

        public ControllerAlumnos objalumnos;

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
            FmrInsertarDocente fmranking = new FmrInsertarDocente();
            fmranking.Show();
        }

        void LimpiarCampos()
        {
            txtNombre.Clear();
            TxtApellido.Clear();
            MskCarnet.Clear();
            MskCorreo.Clear();
            TxtIDAlumno.Clear();
            TxtIDAlumno.Visible = false;
            lblIdAlumno.Visible = false;
        }

        //Inicia Inserion Alumnos
        //Llenado de ComboBox
        void CargarNivel()
        {
            try
            {
                DataTable retornonivel = ControllerAlumnos.ObtenerNivel();
                CmbNivel.DataSource = retornonivel;
                CmbNivel.DisplayMember = "nivel";
                CmbNivel.ValueMember = "id_nivel";
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar los niveles, verifique su conexión a internet y si el problema persiste consulte con el administrador.", "Error de lectura", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void CargarEspecialidad()
        {
            try
            {
                DataTable retornoespecialidad = ControllerAlumnos.FiltrarEspecialidad(Convert.ToInt32(CmbNivel.SelectedValue));
                CmbEspecialidad.DataSource = retornoespecialidad;
                CmbEspecialidad.DisplayMember = "especialidad";
                CmbEspecialidad.ValueMember = "id_especialidad";
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar las especialidades, verifique su conexión a internet y si el problema persiste consulte con el administrador.", "Error de lectura", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void CargarGrupo()
        {
            try
            {
                DataTable retornogrupo = ControllerAlumnos.FiltrarGrupo(Convert.ToInt32(CmbEspecialidad.SelectedValue));
                CmbGrupo.DataSource = retornogrupo;
                CmbGrupo.DisplayMember = "grupo";
                CmbGrupo.ValueMember = "id_grupo";
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar los grupos, verifique su conexión a internet y si el problema persiste consulte con el administrador.", "Error de lectura", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void CargarSeccion()
        {
            try
            {
                DataTable retornoseccion = ControllerAlumnos.FiltrarSeccion(Convert.ToInt32(CmbGrupo.SelectedValue));
                CmbSeccion.DataSource = retornoseccion;
                CmbSeccion.DisplayMember = "seccion";
                CmbSeccion.ValueMember = "id_seccion";
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
                DataTable retornoperiodo = ControllerAlumnos.ObtenerPeriodo();
                cmbPeriodo.DataSource = retornoperiodo;
                cmbPeriodo.DisplayMember = "periodo";
                cmbPeriodo.ValueMember = "id_periodo";
            }
            catch (Exception)

            {
                MessageBox.Show("Error al cargar los periodos, verifique su conexión a internet y si el problema persiste consulte con el administrador.", "Error de lectura", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void CargarNotas()
        {
            try
            {
                DataTable retornotas = ControllerAlumnos.FiltrarNotas(Convert.ToInt32(CmbSeccion.SelectedValue));
                cmbNota.DataSource = retornotas;
                cmbNota.DisplayMember = "notas";
                cmbNota.ValueMember = "id_notas";
            }
            catch (Exception)

            {
                MessageBox.Show("Error al cargar las notas, verifique su conexión a internet y si el problema persiste consulte con el administrador.", "Error de lectura", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void CargarEstadoEstudiante()
        {
            try
            {
                DataTable retornoestadoestudiante = ControllerAlumnos.ObtenerEstadoEstudiante();
                CmbEstado.DataSource = retornoestadoestudiante;
                CmbEstado.DisplayMember = "estado_estudiante";
                CmbEstado.ValueMember = "id_estado_estudiante";
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar los estados, verifique su conexión a internet y si el problema persiste consulte con el administrador.", "Error de lectura", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Creacion del Filtros
        private void CmbNivel_Leave(object sender, EventArgs e)
        {
            DataTable datosEspecialidad = ControllerAlumnos.FiltrarEspecialidad(Convert.ToInt32(CmbNivel.SelectedValue));
            CmbEspecialidad.DataSource = datosEspecialidad;
            CmbEspecialidad.DisplayMember = "especialidad";
            CmbEspecialidad.ValueMember = "id_especialidad";
        }
        private void CmbEspecialidad_Leave(object sender, EventArgs e)
        {
            DataTable datosGrupo = ControllerAlumnos.FiltrarGrupo(Convert.ToInt32(CmbEspecialidad.SelectedValue));
            CmbGrupo.DataSource = datosGrupo;
            CmbGrupo.DisplayMember = "grupo";
            CmbGrupo.ValueMember = "id_grupo";
        }
        private void CmbGrupo_Leave(object sender, EventArgs e)
        {
            DataTable datoSeccion = ControllerAlumnos.FiltrarSeccion(Convert.ToInt32(CmbGrupo.SelectedValue));
            CmbSeccion.DataSource = datoSeccion;
            CmbSeccion.DisplayMember = "seccion";
            CmbSeccion.ValueMember = "id_seccion";
        }
        private void CmbSeccion_Leave(object sender, EventArgs e)
        {
            DataTable datoNotas = ControllerAlumnos.FiltrarNotas(Convert.ToInt32(CmbSeccion.SelectedValue));
            cmbNota.DataSource = datoNotas;
            cmbNota.DisplayMember = "notas";
            cmbNota.ValueMember = "id_notas";
        }
        //Fin de los Filtros
        void CargarLista()
        {
            CargarPeriodo();
            CargarNotas();
            CargarNivel();
            CargarEspecialidad();
            CargarGrupo();
            CargarSeccion();            
            CargarEstadoEstudiante();
        }

        private void FmrInsertarA_Load(object sender, EventArgs e)
        {
            CargarGridDatos();
            CargarLista();
        }
        //CRUD 
        //C
        void EnvioDatos()
        {
            string nombre_estudiante, apellido_estudiante, correo_estudiante, carnet_estudiante;
            int id_nivel, id_especialidad, id_grupo, id_seccion, id_periodo, id_notas, id_estado_estudiante;
            nombre_estudiante = txtNombre.Text;
            apellido_estudiante = TxtApellido.Text;
            correo_estudiante = MskCorreo.Text;
            carnet_estudiante = MskCarnet.Text;
            id_nivel = Convert.ToInt32(CmbNivel.SelectedValue);
            id_especialidad = Convert.ToInt32(CmbEspecialidad.SelectedValue);
            id_grupo = Convert.ToInt32(CmbGrupo.SelectedValue);
            id_seccion = Convert.ToInt32(CmbSeccion.SelectedValue);
            id_periodo = Convert.ToInt32(cmbPeriodo.SelectedValue);
            id_notas = Convert.ToInt32(cmbNota.SelectedValue);
            id_estado_estudiante = Convert.ToInt32(CmbEstado.SelectedValue);
            objalumnos = new ControllerAlumnos(nombre_estudiante, apellido_estudiante, correo_estudiante, carnet_estudiante, id_nivel, id_especialidad, id_grupo, id_seccion, id_periodo, id_notas, id_estado_estudiante);
            bool respuesta = objalumnos.EnviarDatosController();
            if (respuesta == true)
            {
                MessageBox.Show("Alumno ingresado exitosamente.", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ocurrio un error al intentar ingresar el alumno, favor verifique los datos.", "Registro incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            EnvioDatos();
            CargarGridDatos();
            LimpiarCampos();
        }
        //R
        void CargarGridDatos()
        {
            dgvAlumnos.DataSource = ControllerAlumnos.CargarDatosController();
        }
        private void dgvAlumnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtIDAlumno.Visible = true;
            lblIdAlumno.Visible = true;
            int poscicion;
            poscicion = dgvAlumnos.CurrentRow.Index;
            TxtIDAlumno.Text = dgvAlumnos[0, poscicion].Value.ToString();
            txtNombre.Text = dgvAlumnos[1, poscicion].Value.ToString();
            TxtApellido.Text = dgvAlumnos[2, poscicion].Value.ToString();
            MskCorreo.Text = dgvAlumnos[3, poscicion].Value.ToString();
            MskCarnet.Text = dgvAlumnos[4, poscicion].Value.ToString();

            int id_nivel = Convert.ToInt32(dgvAlumnos[5, poscicion].Value.ToString());
            CmbNivel.DataSource = ControllerAlumnos.CargarNivelInnerJoinController(id_nivel);
            CmbNivel.DisplayMember = "nivel";
            CmbNivel.ValueMember = "id_nivel";

            int id_especialidad = Convert.ToInt32(dgvAlumnos[6, poscicion].Value.ToString());
            CmbEspecialidad.DataSource = ControllerAlumnos.CargarEspecialidadInnerJoinController(id_especialidad);
            CmbEspecialidad.DisplayMember = "especialidad";
            CmbEspecialidad.ValueMember = "id_especialidad";

            int id_grupo = Convert.ToInt32(dgvAlumnos[7, poscicion].Value.ToString());
            CmbGrupo.DataSource = ControllerAlumnos.CargarGrupoInnerJoinController(id_grupo);
            CmbGrupo.DisplayMember = "grupo";
            CmbGrupo.ValueMember = "id_grupo";

            int id_seccion = Convert.ToInt32(dgvAlumnos[8, poscicion].Value.ToString());
            CmbSeccion.DataSource = ControllerAlumnos.CargarSeccionInnerJoinController(id_seccion);
            CmbSeccion.DisplayMember = "seccion";
            CmbSeccion.ValueMember = "id_seccion";

            int id_periodo = Convert.ToInt32(dgvAlumnos[9, poscicion].Value.ToString());
            cmbPeriodo.DataSource = ControllerAlumnos.CargarPeriodoInnerJoinController(id_periodo);
            cmbPeriodo.DisplayMember = "periodo";
            cmbPeriodo.ValueMember = "id_periodo";

            int id_notas = Convert.ToInt32(dgvAlumnos[10, poscicion].Value.ToString());
            cmbNota.DataSource = ControllerAlumnos.CargarNotasInnerJoinController(id_notas);
            cmbNota.DisplayMember = "notas";
            cmbNota.ValueMember = "id_notas";

            int id_estado = Convert.ToInt32(dgvAlumnos[11, poscicion].Value.ToString());
            CmbEstado.DataSource = ControllerAlumnos.CargarEstadoInnerJoinController(id_estado);
            CmbEstado.DisplayMember = "estado_estudiante";
            CmbEstado.ValueMember = "id_estado_estudiante";
        }

        private void CmbNivel_Click(object sender, EventArgs e)
        {
            CargarNivel();
        }
        private void CmbEspecialidad_Click(object sender, EventArgs e)
        {
            CargarEspecialidad();
        }
        private void CmbGrupo_Click(object sender, EventArgs e)
        {
            CargarGrupo();
        }
        private void CmbSeccion_Click(object sender, EventArgs e)
        {
            CargarSeccion();
        }
        private void cmbPeriodo_Click(object sender, EventArgs e)
        {
            CargarPeriodo();
        }
        private void cmbNota_Click(object sender, EventArgs e)
        {
            CargarNotas();
        }
        private void CmbEstado_Click(object sender, EventArgs e)
        {
            CargarEstadoEstudiante();
        }
        //U
        void ActualizarDatos()
        {
            ControllerAlumnos.id_estudiante = Convert.ToInt32(TxtIDAlumno.Text);
            objalumnos = new ControllerAlumnos(txtNombre.Text, TxtApellido.Text, MskCorreo.Text, MskCarnet.Text, Convert.ToInt32(CmbNivel.SelectedValue), Convert.ToInt32(CmbEspecialidad.SelectedValue), Convert.ToInt32(CmbGrupo.SelectedValue), Convert.ToInt32(CmbSeccion.SelectedValue), Convert.ToInt32(cmbPeriodo.SelectedValue), Convert.ToInt32(cmbNota.SelectedValue), Convert.ToInt32(CmbEstado.SelectedValue));
            bool respuesta = objalumnos.ActualizarDatosController();
            if (respuesta == true)
            {
                MessageBox.Show("Alumno actualizado exitosamente", "Proceso completado",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Alumno no pudo ser actualizado.", "Proceso incompleto",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarDatos();
            CargarGridDatos();
            CargarLista();
        }
        //R
        void EliminarDatos()
        {
            if (MessageBox.Show("Esta Seguro que desea eliminar al Alumno " + txtNombre.Text + TxtApellido.Text + " ?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                objalumnos.EliminarDatosController(Convert.ToInt32(TxtIDAlumno.Text));
            }
        }
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            EliminarDatos();
            CargarGridDatos();
            LimpiarCampos();
        }
    }
}
