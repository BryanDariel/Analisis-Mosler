namespace Analisis_Mosler
{
    partial class Mosler
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
            this.dgvMosler = new System.Windows.Forms.DataGridView();
            this.lblNombreRiesgo = new System.Windows.Forms.Label();
            this.txtNombreRiesgo = new System.Windows.Forms.TextBox();
            this.btnAgregarRiesgo = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtMitigación = new System.Windows.Forms.TextBox();
            this.lblMitigación = new System.Windows.Forms.Label();
            this.listProbabilidad = new System.Windows.Forms.ListBox();
            this.listImpacto = new System.Windows.Forms.ListBox();
            this.lblProbabilidad = new System.Windows.Forms.Label();
            this.lblImpacto = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Probabilidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Impacto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mitigacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMosler)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMosler
            // 
            this.dgvMosler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMosler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.Desc,
            this.Probabilidad,
            this.Impacto,
            this.Mitigacion,
            this.Total,
            this.Nivel});
            this.dgvMosler.Location = new System.Drawing.Point(4, 199);
            this.dgvMosler.Name = "dgvMosler";
            this.dgvMosler.Size = new System.Drawing.Size(840, 226);
            this.dgvMosler.TabIndex = 0;
            this.dgvMosler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMosler_CellContentClick);
            // 
            // lblNombreRiesgo
            // 
            this.lblNombreRiesgo.AutoSize = true;
            this.lblNombreRiesgo.Location = new System.Drawing.Point(12, 18);
            this.lblNombreRiesgo.Name = "lblNombreRiesgo";
            this.lblNombreRiesgo.Size = new System.Drawing.Size(97, 13);
            this.lblNombreRiesgo.TabIndex = 1;
            this.lblNombreRiesgo.Text = "Nombre del Riesgo";
            this.lblNombreRiesgo.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNombreRiesgo
            // 
            this.txtNombreRiesgo.Location = new System.Drawing.Point(15, 34);
            this.txtNombreRiesgo.Name = "txtNombreRiesgo";
            this.txtNombreRiesgo.Size = new System.Drawing.Size(167, 20);
            this.txtNombreRiesgo.TabIndex = 2;
            this.txtNombreRiesgo.TextChanged += new System.EventHandler(this.txtNombreRiesgo_TextChanged);
            // 
            // btnAgregarRiesgo
            // 
            this.btnAgregarRiesgo.Location = new System.Drawing.Point(597, 18);
            this.btnAgregarRiesgo.Name = "btnAgregarRiesgo";
            this.btnAgregarRiesgo.Size = new System.Drawing.Size(93, 38);
            this.btnAgregarRiesgo.TabIndex = 3;
            this.btnAgregarRiesgo.Text = "Agregar";
            this.btnAgregarRiesgo.UseVisualStyleBackColor = true;
            this.btnAgregarRiesgo.Click += new System.EventHandler(this.btnAgregarRiesgo_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(597, 64);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(93, 38);
            this.btnBorrar.TabIndex = 4;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(217, 34);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(155, 38);
            this.txtDescripcion.TabIndex = 6;
            this.txtDescripcion.TextChanged += new System.EventHandler(this.txtDescripcion_TextChanged);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(214, 18);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 5;
            this.lblDescripcion.Text = "Descripción";
            this.lblDescripcion.Click += new System.EventHandler(this.lblDescripcion_Click);
            // 
            // txtMitigación
            // 
            this.txtMitigación.Location = new System.Drawing.Point(407, 34);
            this.txtMitigación.Multiline = true;
            this.txtMitigación.Name = "txtMitigación";
            this.txtMitigación.Size = new System.Drawing.Size(155, 38);
            this.txtMitigación.TabIndex = 8;
            // 
            // lblMitigación
            // 
            this.lblMitigación.AutoSize = true;
            this.lblMitigación.Location = new System.Drawing.Point(404, 18);
            this.lblMitigación.Name = "lblMitigación";
            this.lblMitigación.Size = new System.Drawing.Size(55, 13);
            this.lblMitigación.TabIndex = 7;
            this.lblMitigación.Text = "Mitigación";
            this.lblMitigación.Click += new System.EventHandler(this.lblMitigación_Click);
            // 
            // listProbabilidad
            // 
            this.listProbabilidad.FormattingEnabled = true;
            this.listProbabilidad.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.listProbabilidad.Location = new System.Drawing.Point(15, 105);
            this.listProbabilidad.Name = "listProbabilidad";
            this.listProbabilidad.Size = new System.Drawing.Size(120, 69);
            this.listProbabilidad.TabIndex = 9;
            this.listProbabilidad.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listImpacto
            // 
            this.listImpacto.FormattingEnabled = true;
            this.listImpacto.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.listImpacto.Location = new System.Drawing.Point(217, 105);
            this.listImpacto.Name = "listImpacto";
            this.listImpacto.Size = new System.Drawing.Size(120, 69);
            this.listImpacto.TabIndex = 10;
            this.listImpacto.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // lblProbabilidad
            // 
            this.lblProbabilidad.AutoSize = true;
            this.lblProbabilidad.Location = new System.Drawing.Point(12, 89);
            this.lblProbabilidad.Name = "lblProbabilidad";
            this.lblProbabilidad.Size = new System.Drawing.Size(65, 13);
            this.lblProbabilidad.TabIndex = 11;
            this.lblProbabilidad.Text = "Probabilidad";
            // 
            // lblImpacto
            // 
            this.lblImpacto.AutoSize = true;
            this.lblImpacto.Location = new System.Drawing.Point(214, 89);
            this.lblImpacto.Name = "lblImpacto";
            this.lblImpacto.Size = new System.Drawing.Size(45, 13);
            this.lblImpacto.TabIndex = 12;
            this.lblImpacto.Text = "Impacto";
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Desc
            // 
            this.Desc.HeaderText = "Descripcion";
            this.Desc.Name = "Desc";
            // 
            // Probabilidad
            // 
            this.Probabilidad.HeaderText = "Probabilidad";
            this.Probabilidad.Name = "Probabilidad";
            // 
            // Impacto
            // 
            this.Impacto.HeaderText = "Impacto";
            this.Impacto.Name = "Impacto";
            // 
            // Mitigacion
            // 
            this.Mitigacion.HeaderText = "Mitigacion";
            this.Mitigacion.Name = "Mitigacion";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // Nivel
            // 
            this.Nivel.HeaderText = "Nivel";
            this.Nivel.Name = "Nivel";
            // 
            // Mosler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 436);
            this.Controls.Add(this.lblImpacto);
            this.Controls.Add(this.lblProbabilidad);
            this.Controls.Add(this.listImpacto);
            this.Controls.Add(this.listProbabilidad);
            this.Controls.Add(this.txtMitigación);
            this.Controls.Add(this.lblMitigación);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnAgregarRiesgo);
            this.Controls.Add(this.txtNombreRiesgo);
            this.Controls.Add(this.lblNombreRiesgo);
            this.Controls.Add(this.dgvMosler);
            this.Name = "Mosler";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMosler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMosler;
        private System.Windows.Forms.Label lblNombreRiesgo;
        private System.Windows.Forms.TextBox txtNombreRiesgo;
        private System.Windows.Forms.Button btnAgregarRiesgo;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtMitigación;
        private System.Windows.Forms.Label lblMitigación;
        private System.Windows.Forms.ListBox listProbabilidad;
        private System.Windows.Forms.ListBox listImpacto;
        private System.Windows.Forms.Label lblProbabilidad;
        private System.Windows.Forms.Label lblImpacto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Probabilidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Impacto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mitigacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nivel;
    }
}

