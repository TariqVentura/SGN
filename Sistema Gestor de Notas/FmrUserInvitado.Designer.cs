namespace Sistema_Gestor_de_Notas
{
    partial class FmrUserInvitado
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmrUserInvitado));
            this.TXTid = new System.Windows.Forms.TextBox();
            this.GridUsDocente = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TXTcontraseniadocente = new System.Windows.Forms.TextBox();
            this.TXTusuariodocente = new System.Windows.Forms.TextBox();
            this.BTNeleiminar = new System.Windows.Forms.Button();
            this.BTNactualizar = new System.Windows.Forms.Button();
            this.BTNagregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Correo = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.BtnCerrar = new System.Windows.Forms.ToolStripButton();
            this.BtnMinimizar = new System.Windows.Forms.ToolStripButton();
            this.BtnHome = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.GridUsDocente)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TXTid
            // 
            this.TXTid.Location = new System.Drawing.Point(36, 51);
            this.TXTid.Name = "TXTid";
            this.TXTid.Size = new System.Drawing.Size(120, 20);
            this.TXTid.TabIndex = 21;
            // 
            // GridUsDocente
            // 
            this.GridUsDocente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridUsDocente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GridUsDocente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridUsDocente.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.GridUsDocente.Location = new System.Drawing.Point(309, 95);
            this.GridUsDocente.Name = "GridUsDocente";
            this.GridUsDocente.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.GridUsDocente.Size = new System.Drawing.Size(388, 150);
            this.GridUsDocente.TabIndex = 20;
            this.GridUsDocente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridUsDocente_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(100, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(100, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Nombre de usuario";
            // 
            // TXTcontraseniadocente
            // 
            this.TXTcontraseniadocente.Location = new System.Drawing.Point(103, 165);
            this.TXTcontraseniadocente.Name = "TXTcontraseniadocente";
            this.TXTcontraseniadocente.Size = new System.Drawing.Size(120, 20);
            this.TXTcontraseniadocente.TabIndex = 17;
            // 
            // TXTusuariodocente
            // 
            this.TXTusuariodocente.Location = new System.Drawing.Point(103, 114);
            this.TXTusuariodocente.Name = "TXTusuariodocente";
            this.TXTusuariodocente.Size = new System.Drawing.Size(120, 20);
            this.TXTusuariodocente.TabIndex = 16;
            // 
            // BTNeleiminar
            // 
            this.BTNeleiminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BTNeleiminar.Location = new System.Drawing.Point(492, 261);
            this.BTNeleiminar.Name = "BTNeleiminar";
            this.BTNeleiminar.Size = new System.Drawing.Size(92, 50);
            this.BTNeleiminar.TabIndex = 15;
            this.BTNeleiminar.Text = "eliminar";
            this.BTNeleiminar.UseVisualStyleBackColor = true;
            this.BTNeleiminar.Click += new System.EventHandler(this.BTNeleiminar_Click);
            // 
            // BTNactualizar
            // 
            this.BTNactualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BTNactualizar.Location = new System.Drawing.Point(309, 261);
            this.BTNactualizar.Name = "BTNactualizar";
            this.BTNactualizar.Size = new System.Drawing.Size(92, 50);
            this.BTNactualizar.TabIndex = 14;
            this.BTNactualizar.Text = "actualizar";
            this.BTNactualizar.UseVisualStyleBackColor = true;
            this.BTNactualizar.Click += new System.EventHandler(this.BTNactualizar_Click);
            // 
            // BTNagregar
            // 
            this.BTNagregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BTNagregar.Location = new System.Drawing.Point(84, 261);
            this.BTNagregar.Name = "BTNagregar";
            this.BTNagregar.Size = new System.Drawing.Size(92, 50);
            this.BTNagregar.TabIndex = 13;
            this.BTNagregar.Text = "agregar";
            this.BTNagregar.UseVisualStyleBackColor = true;
            this.BTNagregar.Click += new System.EventHandler(this.BTNagregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(223, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Registrar Usuario Invitado";
            // 
            // Correo
            // 
            this.Correo.AutoSize = true;
            this.Correo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Correo.Location = new System.Drawing.Point(100, 199);
            this.Correo.Name = "Correo";
            this.Correo.Size = new System.Drawing.Size(55, 16);
            this.Correo.TabIndex = 22;
            this.Correo.Text = "Correo";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(103, 218);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(120, 20);
            this.txtCorreo.TabIndex = 23;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton4,
            this.toolStripLabel1,
            this.BtnCerrar,
            this.BtnMinimizar,
            this.BtnHome});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(733, 25);
            this.toolStrip1.TabIndex = 40;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "toolStripButton4";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(121, 22);
            this.toolStripLabel1.Text = "Insersion de Alumnos";
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
            this.BtnCerrar.Text = "Cerrar Pestaña";
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
            this.BtnMinimizar.Text = "Minimizar";
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
            // FmrUserInvitado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 357);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.Correo);
            this.Controls.Add(this.TXTid);
            this.Controls.Add(this.GridUsDocente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TXTcontraseniadocente);
            this.Controls.Add(this.TXTusuariodocente);
            this.Controls.Add(this.BTNeleiminar);
            this.Controls.Add(this.BTNactualizar);
            this.Controls.Add(this.BTNagregar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FmrUserInvitado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FmrUserInvitado";
            this.Load += new System.EventHandler(this.FmrUserInvitado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridUsDocente)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXTid;
        private System.Windows.Forms.DataGridView GridUsDocente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXTcontraseniadocente;
        private System.Windows.Forms.TextBox TXTusuariodocente;
        private System.Windows.Forms.Button BTNeleiminar;
        private System.Windows.Forms.Button BTNactualizar;
        private System.Windows.Forms.Button BTNagregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Correo;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton BtnCerrar;
        private System.Windows.Forms.ToolStripButton BtnMinimizar;
        private System.Windows.Forms.ToolStripButton BtnHome;
    }
}