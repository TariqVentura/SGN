﻿namespace Sistema_Gestor_de_Notas
{
    partial class FmrUserDocente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmrUserDocente));
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
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
            this.TXTid.Location = new System.Drawing.Point(13, 47);
            this.TXTid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXTid.Name = "TXTid";
            this.TXTid.Size = new System.Drawing.Size(178, 26);
            this.TXTid.TabIndex = 21;
            this.TXTid.TextChanged += new System.EventHandler(this.TXTid_TextChanged);
            // 
            // GridUsDocente
            // 
            this.GridUsDocente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridUsDocente.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridUsDocente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridUsDocente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridUsDocente.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.GridUsDocente.Location = new System.Drawing.Point(42, 542);
            this.GridUsDocente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GridUsDocente.Name = "GridUsDocente";
            this.GridUsDocente.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.GridUsDocente.Size = new System.Drawing.Size(611, 115);
            this.GridUsDocente.TabIndex = 20;
            this.GridUsDocente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridUsDocente_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(173, 291);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "Contraseña:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(173, 167);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "Usuario:";
            // 
            // TXTcontraseniadocente
            // 
            this.TXTcontraseniadocente.Location = new System.Drawing.Point(178, 330);
            this.TXTcontraseniadocente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXTcontraseniadocente.Name = "TXTcontraseniadocente";
            this.TXTcontraseniadocente.Size = new System.Drawing.Size(178, 26);
            this.TXTcontraseniadocente.TabIndex = 17;
            // 
            // TXTusuariodocente
            // 
            this.TXTusuariodocente.Location = new System.Drawing.Point(178, 197);
            this.TXTusuariodocente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXTusuariodocente.Name = "TXTusuariodocente";
            this.TXTusuariodocente.Size = new System.Drawing.Size(178, 26);
            this.TXTusuariodocente.TabIndex = 16;
            // 
            // BTNeleiminar
            // 
            this.BTNeleiminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BTNeleiminar.Location = new System.Drawing.Point(437, 467);
            this.BTNeleiminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTNeleiminar.Name = "BTNeleiminar";
            this.BTNeleiminar.Size = new System.Drawing.Size(138, 49);
            this.BTNeleiminar.TabIndex = 15;
            this.BTNeleiminar.Text = "Eliminar";
            this.BTNeleiminar.UseVisualStyleBackColor = true;
            this.BTNeleiminar.Click += new System.EventHandler(this.BTNeleiminar_Click);
            // 
            // BTNactualizar
            // 
            this.BTNactualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BTNactualizar.Location = new System.Drawing.Point(252, 467);
            this.BTNactualizar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTNactualizar.Name = "BTNactualizar";
            this.BTNactualizar.Size = new System.Drawing.Size(138, 51);
            this.BTNactualizar.TabIndex = 14;
            this.BTNactualizar.Text = "Actualizar";
            this.BTNactualizar.UseVisualStyleBackColor = true;
            this.BTNactualizar.Click += new System.EventHandler(this.BTNactualizar_Click);
            // 
            // BTNagregar
            // 
            this.BTNagregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BTNagregar.Location = new System.Drawing.Point(77, 469);
            this.BTNagregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTNagregar.Name = "BTNagregar";
            this.BTNagregar.Size = new System.Drawing.Size(138, 49);
            this.BTNagregar.TabIndex = 13;
            this.BTNagregar.Text = "Agregar";
            this.BTNagregar.UseVisualStyleBackColor = true;
            this.BTNagregar.Click += new System.EventHandler(this.BTNagregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(228, 87);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 33);
            this.label1.TabIndex = 12;
            this.label1.Text = "Usuario Docente";
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
            this.toolStrip1.Size = new System.Drawing.Size(707, 31);
            this.toolStrip1.TabIndex = 40;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(152, 28);
            this.toolStripLabel1.Text = "Registrar Docente";
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
            this.BtnCerrar.Text = "Cerrar Pestaña";
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
            this.BtnHome.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnHome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnHome.Image = ((System.Drawing.Image)(resources.GetObject("BtnHome.Image")));
            this.BtnHome.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Size = new System.Drawing.Size(28, 28);
            this.BtnHome.Text = "Home";
            this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // FmrUserDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(707, 711);
            this.Controls.Add(this.toolStrip1);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FmrUserDocente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Docente";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.FmrUserDocente_Load);
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
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton BtnCerrar;
        private System.Windows.Forms.ToolStripButton BtnMinimizar;
        private System.Windows.Forms.ToolStripButton BtnHome;
    }
}