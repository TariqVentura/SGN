namespace Sistema_Gestor_de_Notas
{
    partial class FmrInsertarDocente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmrInsertarDocente));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAgregarDocente = new System.Windows.Forms.Button();
            this.btnActualizarDocente = new System.Windows.Forms.Button();
            this.btnEliminarDocente = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtidDocente = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.mskCorreo = new System.Windows.Forms.MaskedTextBox();
            this.CmbEstadoDocente = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.CmbEspecialidad = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.dgvDocentes = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.BtnCerrar = new System.Windows.Forms.ToolStripButton();
            this.BtnMinimizar = new System.Windows.Forms.ToolStripButton();
            this.BtnHome = new System.Windows.Forms.ToolStripButton();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocentes)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAgregarDocente);
            this.groupBox2.Controls.Add(this.btnActualizarDocente);
            this.groupBox2.Controls.Add(this.btnEliminarDocente);
            this.groupBox2.Location = new System.Drawing.Point(804, 74);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(302, 226);
            this.groupBox2.TabIndex = 57;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mantenimientos";
            // 
            // btnAgregarDocente
            // 
            this.btnAgregarDocente.Location = new System.Drawing.Point(9, 37);
            this.btnAgregarDocente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregarDocente.Name = "btnAgregarDocente";
            this.btnAgregarDocente.Size = new System.Drawing.Size(129, 52);
            this.btnAgregarDocente.TabIndex = 49;
            this.btnAgregarDocente.Text = "Agregar";
            this.btnAgregarDocente.UseVisualStyleBackColor = true;
            this.btnAgregarDocente.Click += new System.EventHandler(this.btnAgregarDocente_Click_1);
            // 
            // btnActualizarDocente
            // 
            this.btnActualizarDocente.Location = new System.Drawing.Point(164, 35);
            this.btnActualizarDocente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnActualizarDocente.Name = "btnActualizarDocente";
            this.btnActualizarDocente.Size = new System.Drawing.Size(129, 52);
            this.btnActualizarDocente.TabIndex = 50;
            this.btnActualizarDocente.Text = "Actualizar";
            this.btnActualizarDocente.UseVisualStyleBackColor = true;
            this.btnActualizarDocente.Click += new System.EventHandler(this.btnActualizarDocente_Click_1);
            // 
            // btnEliminarDocente
            // 
            this.btnEliminarDocente.Location = new System.Drawing.Point(9, 132);
            this.btnEliminarDocente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminarDocente.Name = "btnEliminarDocente";
            this.btnEliminarDocente.Size = new System.Drawing.Size(129, 48);
            this.btnEliminarDocente.TabIndex = 51;
            this.btnEliminarDocente.Text = "Eliminar";
            this.btnEliminarDocente.UseVisualStyleBackColor = true;
            this.btnEliminarDocente.Click += new System.EventHandler(this.btnEliminarDocente_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtidDocente);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.mskCorreo);
            this.groupBox1.Controls.Add(this.CmbEstadoDocente);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.CmbEspecialidad);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtApellido);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Location = new System.Drawing.Point(18, 74);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(777, 226);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion Docente";
            // 
            // txtidDocente
            // 
            this.txtidDocente.Location = new System.Drawing.Point(540, 149);
            this.txtidDocente.Name = "txtidDocente";
            this.txtidDocente.Size = new System.Drawing.Size(211, 26);
            this.txtidDocente.TabIndex = 59;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(536, 125);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 20);
            this.label12.TabIndex = 58;
            this.label12.Text = "Id Docente";
            // 
            // mskCorreo
            // 
            this.mskCorreo.Location = new System.Drawing.Point(24, 149);
            this.mskCorreo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mskCorreo.Name = "mskCorreo";
            this.mskCorreo.Size = new System.Drawing.Size(236, 26);
            this.mskCorreo.TabIndex = 4;
            // 
            // CmbEstadoDocente
            // 
            this.CmbEstadoDocente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbEstadoDocente.FormattingEnabled = true;
            this.CmbEstadoDocente.Location = new System.Drawing.Point(300, 148);
            this.CmbEstadoDocente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CmbEstadoDocente.Name = "CmbEstadoDocente";
            this.CmbEstadoDocente.Size = new System.Drawing.Size(211, 28);
            this.CmbEstadoDocente.TabIndex = 10;
            this.CmbEstadoDocente.Click += new System.EventHandler(this.CmbEstadoDocente_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(296, 123);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(158, 20);
            this.label11.TabIndex = 57;
            this.label11.Text = "Seleccione el Estado";
            // 
            // CmbEspecialidad
            // 
            this.CmbEspecialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbEspecialidad.FormattingEnabled = true;
            this.CmbEspecialidad.Location = new System.Drawing.Point(540, 57);
            this.CmbEspecialidad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CmbEspecialidad.Name = "CmbEspecialidad";
            this.CmbEspecialidad.Size = new System.Drawing.Size(211, 28);
            this.CmbEspecialidad.TabIndex = 6;
            this.CmbEspecialidad.Click += new System.EventHandler(this.CmbEspecialidad_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(536, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(197, 20);
            this.label8.TabIndex = 48;
            this.label8.Text = "Seleccione la Especialidad";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(300, 58);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(211, 26);
            this.txtApellido.TabIndex = 2;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(294, 35);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(218, 20);
            this.label16.TabIndex = 43;
            this.label16.Text = "Ingresar Apellido del Docente";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(20, 125);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(210, 20);
            this.label17.TabIndex = 41;
            this.label17.Text = "Ingresar Correo del Docente";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(21, 58);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(211, 26);
            this.txtNombre.TabIndex = 1;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(20, 35);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(213, 20);
            this.label19.TabIndex = 37;
            this.label19.Text = "Ingresa Nombre del Docente";
            // 
            // dgvDocentes
            // 
            this.dgvDocentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocentes.Location = new System.Drawing.Point(68, 326);
            this.dgvDocentes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvDocentes.Name = "dgvDocentes";
            this.dgvDocentes.Size = new System.Drawing.Size(964, 251);
            this.dgvDocentes.TabIndex = 55;
            this.dgvDocentes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDocentes_CellClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnHome,
            this.toolStripLabel1,
            this.BtnCerrar,
            this.BtnMinimizar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1124, 31);
            this.toolStrip1.TabIndex = 58;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(168, 28);
            this.toolStripLabel1.Text = "FmrInsertarDocente";
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.BtnCerrar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnCerrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCerrar.Image")));
            this.BtnCerrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(28, 28);
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // BtnMinimizar
            // 
            this.BtnMinimizar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.BtnMinimizar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnMinimizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("BtnMinimizar.Image")));
            this.BtnMinimizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnMinimizar.Name = "BtnMinimizar";
            this.BtnMinimizar.Size = new System.Drawing.Size(28, 28);
            this.BtnMinimizar.Text = "Minimizar";
            this.BtnMinimizar.Click += new System.EventHandler(this.BtnMinimizar_Click);
            // 
            // BtnHome
            // 
            this.BtnHome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnHome.Image = ((System.Drawing.Image)(resources.GetObject("BtnHome.Image")));
            this.BtnHome.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Size = new System.Drawing.Size(28, 28);
            this.BtnHome.Text = "Home";
            this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // FmrInsertarDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1124, 609);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvDocentes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FmrInsertarDocente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FmrInsertarDocente";
            this.Load += new System.EventHandler(this.FmrInsertarDocente_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocentes)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAgregarDocente;
        private System.Windows.Forms.Button btnActualizarDocente;
        private System.Windows.Forms.Button btnEliminarDocente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtidDocente;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox mskCorreo;
        private System.Windows.Forms.ComboBox CmbEstadoDocente;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox CmbEspecialidad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DataGridView dgvDocentes;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton BtnCerrar;
        private System.Windows.Forms.ToolStripButton BtnMinimizar;
        private System.Windows.Forms.ToolStripButton BtnHome;
    }
}