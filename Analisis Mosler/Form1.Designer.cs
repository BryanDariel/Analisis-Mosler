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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mosler));
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbGuardarArchivo = new System.Windows.Forms.ToolStripButton();
            this.tsbCargarArchivo = new System.Windows.Forms.ToolStripButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMosler)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMosler
            // 
            this.dgvMosler.AllowUserToAddRows = false;
            this.dgvMosler.AllowUserToDeleteRows = false;
            this.dgvMosler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMosler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMosler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMosler.Location = new System.Drawing.Point(4, 229);
            this.dgvMosler.Name = "dgvMosler";
            this.dgvMosler.ReadOnly = true;
            this.dgvMosler.Size = new System.Drawing.Size(600, 194);
            this.dgvMosler.TabIndex = 0;
            // 
            // lblNombreRiesgo
            // 
            this.lblNombreRiesgo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombreRiesgo.AutoSize = true;
            this.lblNombreRiesgo.Location = new System.Drawing.Point(12, 38);
            this.lblNombreRiesgo.Name = "lblNombreRiesgo";
            this.lblNombreRiesgo.Size = new System.Drawing.Size(97, 13);
            this.lblNombreRiesgo.TabIndex = 1;
            this.lblNombreRiesgo.Text = "Nombre del Riesgo";
            // 
            // txtNombreRiesgo
            // 
            this.txtNombreRiesgo.Location = new System.Drawing.Point(15, 54);
            this.txtNombreRiesgo.Name = "txtNombreRiesgo";
            this.txtNombreRiesgo.Size = new System.Drawing.Size(167, 20);
            this.txtNombreRiesgo.TabIndex = 2;
            // 
            // btnAgregarRiesgo
            // 
            this.btnAgregarRiesgo.Location = new System.Drawing.Point(409, 132);
            this.btnAgregarRiesgo.Name = "btnAgregarRiesgo";
            this.btnAgregarRiesgo.Size = new System.Drawing.Size(93, 38);
            this.btnAgregarRiesgo.TabIndex = 3;
            this.btnAgregarRiesgo.Text = "Agregar";
            this.btnAgregarRiesgo.UseVisualStyleBackColor = true;
            this.btnAgregarRiesgo.Click += new System.EventHandler(this.btnAgregarRiesgo_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(409, 176);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(93, 38);
            this.btnBorrar.TabIndex = 4;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(216, 54);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(155, 38);
            this.txtDescripcion.TabIndex = 6;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(213, 38);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 5;
            this.lblDescripcion.Text = "Descripción";
            // 
            // txtMitigación
            // 
            this.txtMitigación.Location = new System.Drawing.Point(409, 54);
            this.txtMitigación.Multiline = true;
            this.txtMitigación.Name = "txtMitigación";
            this.txtMitigación.Size = new System.Drawing.Size(178, 38);
            this.txtMitigación.TabIndex = 8;
            // 
            // lblMitigación
            // 
            this.lblMitigación.AutoSize = true;
            this.lblMitigación.Location = new System.Drawing.Point(406, 38);
            this.lblMitigación.Name = "lblMitigación";
            this.lblMitigación.Size = new System.Drawing.Size(55, 13);
            this.lblMitigación.TabIndex = 7;
            this.lblMitigación.Text = "Mitigación";
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
            this.listProbabilidad.Location = new System.Drawing.Point(15, 148);
            this.listProbabilidad.Name = "listProbabilidad";
            this.listProbabilidad.Size = new System.Drawing.Size(120, 69);
            this.listProbabilidad.TabIndex = 9;
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
            this.listImpacto.Location = new System.Drawing.Point(217, 148);
            this.listImpacto.Name = "listImpacto";
            this.listImpacto.Size = new System.Drawing.Size(120, 69);
            this.listImpacto.TabIndex = 10;
            // 
            // lblProbabilidad
            // 
            this.lblProbabilidad.AutoSize = true;
            this.lblProbabilidad.Location = new System.Drawing.Point(12, 132);
            this.lblProbabilidad.Name = "lblProbabilidad";
            this.lblProbabilidad.Size = new System.Drawing.Size(65, 13);
            this.lblProbabilidad.TabIndex = 11;
            this.lblProbabilidad.Text = "Probabilidad";
            // 
            // lblImpacto
            // 
            this.lblImpacto.AutoSize = true;
            this.lblImpacto.Location = new System.Drawing.Point(214, 132);
            this.lblImpacto.Name = "lblImpacto";
            this.lblImpacto.Size = new System.Drawing.Size(45, 13);
            this.lblImpacto.TabIndex = 12;
            this.lblImpacto.Text = "Impacto";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbGuardarArchivo,
            this.tsbCargarArchivo});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(616, 25);
            this.toolStrip1.TabIndex = 13;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbGuardarArchivo
            // 
            this.tsbGuardarArchivo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbGuardarArchivo.Image = ((System.Drawing.Image)(resources.GetObject("tsbGuardarArchivo.Image")));
            this.tsbGuardarArchivo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGuardarArchivo.Name = "tsbGuardarArchivo";
            this.tsbGuardarArchivo.Size = new System.Drawing.Size(23, 22);
            this.tsbGuardarArchivo.Text = "toolStripButton1";
            // 
            // tsbCargarArchivo
            // 
            this.tsbCargarArchivo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCargarArchivo.Image = ((System.Drawing.Image)(resources.GetObject("tsbCargarArchivo.Image")));
            this.tsbCargarArchivo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCargarArchivo.Name = "tsbCargarArchivo";
            this.tsbCargarArchivo.Size = new System.Drawing.Size(23, 22);
            this.tsbCargarArchivo.Text = "toolStripButton2";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Mosler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 435);
            this.Controls.Add(this.toolStrip1);
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
            this.Load += new System.EventHandler(this.Mosler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMosler)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
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
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbGuardarArchivo;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolStripButton tsbCargarArchivo;
    }
}

