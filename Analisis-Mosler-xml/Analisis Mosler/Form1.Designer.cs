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
            this.lblFuncion = new System.Windows.Forms.Label();
            this.lblProfundidad = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbGuardarArchivo = new System.Windows.Forms.ToolStripButton();
            this.tsbCargarArchivo = new System.Windows.Forms.ToolStripButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbFuncion = new System.Windows.Forms.ListBox();
            this.lbProfundidad = new System.Windows.Forms.ListBox();
            this.lbSustitucion = new System.Windows.Forms.ListBox();
            this.lblSustitucion = new System.Windows.Forms.Label();
            this.lbExtension = new System.Windows.Forms.ListBox();
            this.lblExtension = new System.Windows.Forms.Label();
            this.lbAgresion = new System.Windows.Forms.ListBox();
            this.lblAgresion = new System.Windows.Forms.Label();
            this.lbVulnerabilidad = new System.Windows.Forms.ListBox();
            this.lblVulnerabilidad = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblModificar = new System.Windows.Forms.Button();
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
            this.dgvMosler.Location = new System.Drawing.Point(4, 213);
            this.dgvMosler.Name = "dgvMosler";
            this.dgvMosler.ReadOnly = true;
            this.dgvMosler.Size = new System.Drawing.Size(689, 210);
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
            this.btnAgregarRiesgo.Location = new System.Drawing.Point(535, 122);
            this.btnAgregarRiesgo.Name = "btnAgregarRiesgo";
            this.btnAgregarRiesgo.Size = new System.Drawing.Size(67, 38);
            this.btnAgregarRiesgo.TabIndex = 3;
            this.btnAgregarRiesgo.Text = "Agregar";
            this.btnAgregarRiesgo.UseVisualStyleBackColor = true;
            this.btnAgregarRiesgo.Click += new System.EventHandler(this.btnAgregarRiesgo_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(535, 169);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(67, 38);
            this.btnBorrar.TabIndex = 4;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(216, 54);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(164, 38);
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
            this.txtMitigación.Size = new System.Drawing.Size(193, 38);
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
            // lblFuncion
            // 
            this.lblFuncion.AutoSize = true;
            this.lblFuncion.Location = new System.Drawing.Point(9, 119);
            this.lblFuncion.Name = "lblFuncion";
            this.lblFuncion.Size = new System.Drawing.Size(45, 13);
            this.lblFuncion.TabIndex = 11;
            this.lblFuncion.Text = "Funcion";
            // 
            // lblProfundidad
            // 
            this.lblProfundidad.AutoSize = true;
            this.lblProfundidad.Location = new System.Drawing.Point(185, 119);
            this.lblProfundidad.Name = "lblProfundidad";
            this.lblProfundidad.Size = new System.Drawing.Size(64, 13);
            this.lblProfundidad.TabIndex = 12;
            this.lblProfundidad.Text = "Profundidad";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbGuardarArchivo,
            this.tsbCargarArchivo});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(705, 25);
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
            // lbFuncion
            // 
            this.lbFuncion.FormattingEnabled = true;
            this.lbFuncion.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.lbFuncion.Location = new System.Drawing.Point(12, 135);
            this.lbFuncion.Name = "lbFuncion";
            this.lbFuncion.Size = new System.Drawing.Size(62, 69);
            this.lbFuncion.TabIndex = 14;
            // 
            // lbProfundidad
            // 
            this.lbProfundidad.FormattingEnabled = true;
            this.lbProfundidad.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.lbProfundidad.Location = new System.Drawing.Point(188, 135);
            this.lbProfundidad.Name = "lbProfundidad";
            this.lbProfundidad.Size = new System.Drawing.Size(62, 69);
            this.lbProfundidad.TabIndex = 15;
            // 
            // lbSustitucion
            // 
            this.lbSustitucion.FormattingEnabled = true;
            this.lbSustitucion.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.lbSustitucion.Location = new System.Drawing.Point(98, 135);
            this.lbSustitucion.Name = "lbSustitucion";
            this.lbSustitucion.Size = new System.Drawing.Size(62, 69);
            this.lbSustitucion.TabIndex = 17;
            // 
            // lblSustitucion
            // 
            this.lblSustitucion.AutoSize = true;
            this.lblSustitucion.Location = new System.Drawing.Point(95, 119);
            this.lblSustitucion.Name = "lblSustitucion";
            this.lblSustitucion.Size = new System.Drawing.Size(59, 13);
            this.lblSustitucion.TabIndex = 16;
            this.lblSustitucion.Text = "Sustitucion";
            // 
            // lbExtension
            // 
            this.lbExtension.FormattingEnabled = true;
            this.lbExtension.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.lbExtension.Location = new System.Drawing.Point(271, 135);
            this.lbExtension.Name = "lbExtension";
            this.lbExtension.Size = new System.Drawing.Size(62, 69);
            this.lbExtension.TabIndex = 19;
            // 
            // lblExtension
            // 
            this.lblExtension.AutoSize = true;
            this.lblExtension.Location = new System.Drawing.Point(268, 119);
            this.lblExtension.Name = "lblExtension";
            this.lblExtension.Size = new System.Drawing.Size(53, 13);
            this.lblExtension.TabIndex = 18;
            this.lblExtension.Text = "Extension";
            // 
            // lbAgresion
            // 
            this.lbAgresion.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lbAgresion.FormattingEnabled = true;
            this.lbAgresion.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.lbAgresion.Location = new System.Drawing.Point(354, 138);
            this.lbAgresion.Name = "lbAgresion";
            this.lbAgresion.Size = new System.Drawing.Size(62, 69);
            this.lbAgresion.TabIndex = 21;
            // 
            // lblAgresion
            // 
            this.lblAgresion.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblAgresion.AutoSize = true;
            this.lblAgresion.Location = new System.Drawing.Point(351, 122);
            this.lblAgresion.Name = "lblAgresion";
            this.lblAgresion.Size = new System.Drawing.Size(48, 13);
            this.lblAgresion.TabIndex = 20;
            this.lblAgresion.Text = "Agresion";
            // 
            // lbVulnerabilidad
            // 
            this.lbVulnerabilidad.FormattingEnabled = true;
            this.lbVulnerabilidad.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.lbVulnerabilidad.Location = new System.Drawing.Point(442, 138);
            this.lbVulnerabilidad.Name = "lbVulnerabilidad";
            this.lbVulnerabilidad.Size = new System.Drawing.Size(62, 69);
            this.lbVulnerabilidad.TabIndex = 23;
            // 
            // lblVulnerabilidad
            // 
            this.lblVulnerabilidad.AutoSize = true;
            this.lblVulnerabilidad.Location = new System.Drawing.Point(439, 122);
            this.lblVulnerabilidad.Name = "lblVulnerabilidad";
            this.lblVulnerabilidad.Size = new System.Drawing.Size(73, 13);
            this.lblVulnerabilidad.TabIndex = 22;
            this.lblVulnerabilidad.Text = "Vulnerabilidad";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(620, 122);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(67, 38);
            this.btnBuscar.TabIndex = 24;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblModificar
            // 
            this.lblModificar.Location = new System.Drawing.Point(620, 169);
            this.lblModificar.Name = "lblModificar";
            this.lblModificar.Size = new System.Drawing.Size(67, 38);
            this.lblModificar.TabIndex = 25;
            this.lblModificar.Text = "Modificar";
            this.lblModificar.UseVisualStyleBackColor = true;
            this.lblModificar.Click += new System.EventHandler(this.lblModificar_Click);
            // 
            // Mosler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 435);
            this.Controls.Add(this.lblModificar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lbVulnerabilidad);
            this.Controls.Add(this.lblVulnerabilidad);
            this.Controls.Add(this.lbAgresion);
            this.Controls.Add(this.lblAgresion);
            this.Controls.Add(this.lbExtension);
            this.Controls.Add(this.lblExtension);
            this.Controls.Add(this.lbSustitucion);
            this.Controls.Add(this.lblSustitucion);
            this.Controls.Add(this.lbProfundidad);
            this.Controls.Add(this.lbFuncion);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lblProfundidad);
            this.Controls.Add(this.lblFuncion);
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
            this.Text = "Analisis de Mosler";
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
        private System.Windows.Forms.Label lblFuncion;
        private System.Windows.Forms.Label lblProfundidad;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbGuardarArchivo;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolStripButton tsbCargarArchivo;
        private System.Windows.Forms.ListBox lbProfundidad;
        private System.Windows.Forms.ListBox lbFuncion;
        private System.Windows.Forms.ListBox lbSustitucion;
        private System.Windows.Forms.Label lblSustitucion;
        private System.Windows.Forms.ListBox lbVulnerabilidad;
        private System.Windows.Forms.Label lblVulnerabilidad;
        private System.Windows.Forms.ListBox lbAgresion;
        private System.Windows.Forms.Label lblAgresion;
        private System.Windows.Forms.ListBox lbExtension;
        private System.Windows.Forms.Label lblExtension;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button lblModificar;
    }
}

