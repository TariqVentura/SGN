﻿namespace Sistema_Gestor_de_Notas
{
    partial class FmrUserEstudiante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmrUserEstudiante));
            this.TXTid = new System.Windows.Forms.TextBox();
            this.GridUsEstudiante = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TXTcontraseniaestudiante = new System.Windows.Forms.TextBox();
            this.TXTusuarioestudiante = new System.Windows.Forms.TextBox();
            this.BTNeliminar = new System.Windows.Forms.Button();
            this.BTNactualizar = new System.Windows.Forms.Button();
            this.BTNagregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.BtnCerrar = new System.Windows.Forms.ToolStripButton();
            this.BtnMinimizar = new System.Windows.Forms.ToolStripButton();
            this.BtnHome = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.GridUsEstudiante)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TXTid
            // 
            this.TXTid.Location = new System.Drawing.Point(301, 215);
            this.TXTid.Name = "TXTid";
            this.TXTid.Size = new System.Drawing.Size(120, 20);
            this.TXTid.TabIndex = 21;
            // 
            // GridUsEstudiante
            // 
            this.GridUsEstudiante.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridUsEstudiante.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridUsEstudiante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridUsEstudiante.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.GridUsEstudiante.Location = new System.Drawing.Point(59, 281);
            this.GridUsEstudiante.Name = "GridUsEstudiante";
            this.GridUsEstudiante.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.GridUsEstudiante.Size = new System.Drawing.Size(499, 125);
            this.GridUsEstudiante.TabIndex = 20;
            this.GridUsEstudiante.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridUsEstudiante_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Contraseña:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Usuario:";
            // 
            // TXTcontraseniaestudiante
            // 
            this.TXTcontraseniaestudiante.Location = new System.Drawing.Point(59, 215);
            this.TXTcontraseniaestudiante.Name = "TXTcontraseniaestudiante";
            this.TXTcontraseniaestudiante.Size = new System.Drawing.Size(165, 20);
            this.TXTcontraseniaestudiante.TabIndex = 17;
            // 
            // TXTusuarioestudiante
            // 
            this.TXTusuarioestudiante.Location = new System.Drawing.Point(59, 138);
            this.TXTusuarioestudiante.Name = "TXTusuarioestudiante";
            this.TXTusuarioestudiante.Size = new System.Drawing.Size(165, 20);
            this.TXTusuarioestudiante.TabIndex = 16;
            // 
            // BTNeliminar
            // 
            this.BTNeliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BTNeliminar.Location = new System.Drawing.Point(465, 204);
            this.BTNeliminar.Name = "BTNeliminar";
            this.BTNeliminar.Size = new System.Drawing.Size(93, 31);
            this.BTNeliminar.TabIndex = 15;
            this.BTNeliminar.Text = "Eliminar";
            this.BTNeliminar.UseVisualStyleBackColor = true;
            this.BTNeliminar.Click += new System.EventHandler(this.BTNeliminar_Click);
            // 
            // BTNactualizar
            // 
            this.BTNactualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BTNactualizar.Location = new System.Drawing.Point(460, 113);
            this.BTNactualizar.Name = "BTNactualizar";
            this.BTNactualizar.Size = new System.Drawing.Size(98, 31);
            this.BTNactualizar.TabIndex = 14;
            this.BTNactualizar.Text = "Actualizar";
            this.BTNactualizar.UseVisualStyleBackColor = true;
            this.BTNactualizar.Click += new System.EventHandler(this.BTNactualizar_Click);
            // 
            // BTNagregar
            // 
            this.BTNagregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BTNagregar.Location = new System.Drawing.Point(301, 113);
            this.BTNagregar.Name = "BTNagregar";
            this.BTNagregar.Size = new System.Drawing.Size(92, 34);
            this.BTNagregar.TabIndex = 13;
            this.BTNagregar.Text = "Agregar";
            this.BTNagregar.UseVisualStyleBackColor = true;
            this.BTNagregar.Click += new System.EventHandler(this.BTNagregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = " Usuario Estudiante";
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
            this.toolStrip1.Size = new System.Drawing.Size(591, 25);
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
            this.toolStripLabel1.Size = new System.Drawing.Size(113, 22);
            this.toolStripLabel1.Text = "Registara Estudiante";
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
            // FmrUserEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 427);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.TXTid);
            this.Controls.Add(this.GridUsEstudiante);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TXTcontraseniaestudiante);
            this.Controls.Add(this.TXTusuarioestudiante);
            this.Controls.Add(this.BTNeliminar);
            this.Controls.Add(this.BTNactualizar);
            this.Controls.Add(this.BTNagregar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FmrUserEstudiante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FmrUserEstudiante";
            this.Load += new System.EventHandler(this.FmrUserEstudiante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridUsEstudiante)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXTid;
        private System.Windows.Forms.DataGridView GridUsEstudiante;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXTcontraseniaestudiante;
        private System.Windows.Forms.TextBox TXTusuarioestudiante;
        private System.Windows.Forms.Button BTNeliminar;
        private System.Windows.Forms.Button BTNactualizar;
        private System.Windows.Forms.Button BTNagregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton BtnCerrar;
        private System.Windows.Forms.ToolStripButton BtnMinimizar;
        private System.Windows.Forms.ToolStripButton BtnHome;
    }
}