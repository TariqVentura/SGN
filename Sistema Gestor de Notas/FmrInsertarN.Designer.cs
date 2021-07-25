namespace Sistema_Gestor_de_Notas
{
    partial class FmrInsertarN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmrInsertarN));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnAtras = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.BtnCerrar = new System.Windows.Forms.ToolStripButton();
            this.BtnMinimizar = new System.Windows.Forms.ToolStripButton();
            this.BtnHome = new System.Windows.Forms.ToolStripButton();
            this.dgvNotas = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnActulizarNotas = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbEstadoNota = new System.Windows.Forms.ComboBox();
            this.txtidNota = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbEspecialidad = new System.Windows.Forms.ComboBox();
            this.cmbSeccion = new System.Windows.Forms.ComboBox();
            this.cmbperiodo = new System.Windows.Forms.ComboBox();
            this.txtPromedioA = new System.Windows.Forms.TextBox();
            this.txtPromedioT = new System.Windows.Forms.TextBox();
            this.txtCarnet = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotas)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.LightBlue;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnAtras,
            this.toolStripLabel1,
            this.BtnCerrar,
            this.BtnMinimizar,
            this.BtnHome});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(749, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BtnAtras
            // 
            this.BtnAtras.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnAtras.Image = ((System.Drawing.Image)(resources.GetObject("BtnAtras.Image")));
            this.BtnAtras.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnAtras.Name = "BtnAtras";
            this.BtnAtras.Size = new System.Drawing.Size(23, 22);
            this.BtnAtras.Text = "BtnAtras";
            this.BtnAtras.Click += new System.EventHandler(this.BtnAtras_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(104, 22);
            this.toolStripLabel1.Text = "Insersion de Notas";
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.BtnCerrar.BackColor = System.Drawing.Color.LightCyan;
            this.BtnCerrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCerrar.Image")));
            this.BtnCerrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(23, 22);
            this.BtnCerrar.Text = "Cerrar Programa";
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // BtnMinimizar
            // 
            this.BtnMinimizar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.BtnMinimizar.BackColor = System.Drawing.Color.LightCyan;
            this.BtnMinimizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("BtnMinimizar.Image")));
            this.BtnMinimizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnMinimizar.Name = "BtnMinimizar";
            this.BtnMinimizar.Size = new System.Drawing.Size(23, 22);
            this.BtnMinimizar.Text = "Minimizar Pestaña";
            this.BtnMinimizar.Click += new System.EventHandler(this.BtnMinimizar_Click);
            // 
            // BtnHome
            // 
            this.BtnHome.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.BtnHome.BackColor = System.Drawing.Color.LightCyan;
            this.BtnHome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnHome.Image = ((System.Drawing.Image)(resources.GetObject("BtnHome.Image")));
            this.BtnHome.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Size = new System.Drawing.Size(23, 22);
            this.BtnHome.Text = "Home";
            this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // dgvNotas
            // 
            this.dgvNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotas.Location = new System.Drawing.Point(15, 253);
            this.dgvNotas.Name = "dgvNotas";
            this.dgvNotas.Size = new System.Drawing.Size(718, 131);
            this.dgvNotas.TabIndex = 6;
            this.dgvNotas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNotas_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnActulizarNotas);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Location = new System.Drawing.Point(533, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 214);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // btnActulizarNotas
            // 
            this.btnActulizarNotas.Location = new System.Drawing.Point(17, 151);
            this.btnActulizarNotas.Name = "btnActulizarNotas";
            this.btnActulizarNotas.Size = new System.Drawing.Size(168, 39);
            this.btnActulizarNotas.TabIndex = 3;
            this.btnActulizarNotas.Text = "Actualizar Nota";
            this.btnActulizarNotas.UseVisualStyleBackColor = true;
            this.btnActulizarNotas.Click += new System.EventHandler(this.btnActulizarNotas_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "Agregar Nota";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(17, 88);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 39);
            this.button2.TabIndex = 1;
            this.button2.Text = "Eliminar Nota";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbEstadoNota);
            this.groupBox1.Controls.Add(this.txtidNota);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cmbEspecialidad);
            this.groupBox1.Controls.Add(this.cmbSeccion);
            this.groupBox1.Controls.Add(this.cmbperiodo);
            this.groupBox1.Controls.Add(this.txtPromedioA);
            this.groupBox1.Controls.Add(this.txtPromedioT);
            this.groupBox1.Controls.Add(this.txtCarnet);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(512, 214);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // cmbEstadoNota
            // 
            this.cmbEstadoNota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoNota.FormattingEnabled = true;
            this.cmbEstadoNota.Location = new System.Drawing.Point(184, 187);
            this.cmbEstadoNota.Name = "cmbEstadoNota";
            this.cmbEstadoNota.Size = new System.Drawing.Size(146, 21);
            this.cmbEstadoNota.TabIndex = 22;
            // 
            // txtidNota
            // 
            this.txtidNota.Location = new System.Drawing.Point(10, 190);
            this.txtidNota.Name = "txtidNota";
            this.txtidNota.Size = new System.Drawing.Size(146, 20);
            this.txtidNota.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(182, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Seleccione el Estado de Nota";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "id_Notas";
            // 
            // cmbEspecialidad
            // 
            this.cmbEspecialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEspecialidad.FormattingEnabled = true;
            this.cmbEspecialidad.Location = new System.Drawing.Point(346, 58);
            this.cmbEspecialidad.Name = "cmbEspecialidad";
            this.cmbEspecialidad.Size = new System.Drawing.Size(146, 21);
            this.cmbEspecialidad.TabIndex = 19;
            this.cmbEspecialidad.Leave += new System.EventHandler(this.cmbEspecialidad_Leave);
            // 
            // cmbSeccion
            // 
            this.cmbSeccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSeccion.FormattingEnabled = true;
            this.cmbSeccion.Location = new System.Drawing.Point(346, 129);
            this.cmbSeccion.Name = "cmbSeccion";
            this.cmbSeccion.Size = new System.Drawing.Size(146, 21);
            this.cmbSeccion.TabIndex = 18;
            // 
            // cmbperiodo
            // 
            this.cmbperiodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbperiodo.FormattingEnabled = true;
            this.cmbperiodo.Location = new System.Drawing.Point(184, 127);
            this.cmbperiodo.Name = "cmbperiodo";
            this.cmbperiodo.Size = new System.Drawing.Size(146, 21);
            this.cmbperiodo.TabIndex = 17;
            // 
            // txtPromedioA
            // 
            this.txtPromedioA.Location = new System.Drawing.Point(10, 129);
            this.txtPromedioA.Name = "txtPromedioA";
            this.txtPromedioA.Size = new System.Drawing.Size(146, 20);
            this.txtPromedioA.TabIndex = 16;
            // 
            // txtPromedioT
            // 
            this.txtPromedioT.Location = new System.Drawing.Point(184, 58);
            this.txtPromedioT.Name = "txtPromedioT";
            this.txtPromedioT.Size = new System.Drawing.Size(146, 20);
            this.txtPromedioT.TabIndex = 14;
            // 
            // txtCarnet
            // 
            this.txtCarnet.Location = new System.Drawing.Point(10, 58);
            this.txtCarnet.Name = "txtCarnet";
            this.txtCarnet.Size = new System.Drawing.Size(146, 20);
            this.txtCarnet.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(343, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Seleccione la Especialidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(343, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Seleccione la Seccion ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(181, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Seleccione el Periodo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "IngresarPromedio Academico";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "IngresarPromedio Tecnico";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ingresar Carnet del Estudiante";
            // 
            // FmrInsertarN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 396);
            this.Controls.Add(this.dgvNotas);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FmrInsertarN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FmrInsertarN";
            this.Load += new System.EventHandler(this.FmrInsertarN_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotas)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BtnAtras;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton BtnCerrar;
        private System.Windows.Forms.ToolStripButton BtnMinimizar;
        private System.Windows.Forms.ToolStripButton BtnHome;
        private System.Windows.Forms.DataGridView dgvNotas;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnActulizarNotas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbEstadoNota;
        private System.Windows.Forms.TextBox txtidNota;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbEspecialidad;
        private System.Windows.Forms.ComboBox cmbSeccion;
        private System.Windows.Forms.ComboBox cmbperiodo;
        private System.Windows.Forms.TextBox txtPromedioA;
        private System.Windows.Forms.TextBox txtPromedioT;
        private System.Windows.Forms.TextBox txtCarnet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}