using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Analisis_Mosler{

    public partial class Mosler : Form {

        ArrayList Riesgo = new ArrayList();

        public Mosler(){

            InitializeComponent();
        }

        private void Mosler_Load(object sender, EventArgs e)
        {
            Riesgo Riesgo1 = new Riesgo();
            Riesgo1.ID = 5;
            Riesgo1.NombreRiesgo = "Sismo";
            Riesgo1.DescripcionRiesgo = "Perdida Informacion";
            Riesgo1.Mitigacion = "Lugar seguro";
            Riesgo1.Probabilidad = 2;
            Riesgo1.Impacto = 5;
            Riesgo1.Total = 10;
            Riesgo1.Nivel = "2-Riesgo bajo";
            Riesgo.Add(Riesgo1);

            Riesgo Riesgo2 = new Riesgo();
            Riesgo2.ID = 3;
            Riesgo2.NombreRiesgo = "Torbellino";
            Riesgo2.DescripcionRiesgo = "Perdida Informacion";
            Riesgo2.Mitigacion = "Lugar seguro";
            Riesgo2.Probabilidad = 2;
            Riesgo2.Impacto = 5;
            Riesgo2.Total = 10;
            Riesgo2.Nivel = "2-Riesgo bajo";
            Riesgo.Add(Riesgo2);

            dgvMosler.DataSource = Riesgo;
        }

        private void btnAgregarRiesgo_Click(object sender, EventArgs e){

            
            if (txtNombreRiesgo.Text == "")
            {
                errorProvider1.SetError(txtNombreRiesgo, "Debe ingresar el nombre del riesgo.");
                txtNombreRiesgo.Focus();
                return;
            }
            errorProvider1.SetError(txtNombreRiesgo, "");

            if (Existe(txtNombreRiesgo.Text))
            {
                errorProvider1.SetError(txtNombreRiesgo, "El nombre del riesgo ya ha sido registrado.");
                txtNombreRiesgo.Focus();
                return;
            }

            if (txtDescripcion.Text == "")
            {
                errorProvider1.SetError(txtDescripcion, "Debe ingresar una descripción del riesgo.");
                txtDescripcion.Focus();
                return;
            }
            errorProvider1.SetError(txtDescripcion, "");

            if (txtMitigación.Text == "")
            {
                errorProvider1.SetError(txtMitigación, "Debe ingresar una mitigación del riesgo.");
                txtMitigación.Focus();
                return;
            }
            errorProvider1.SetError(txtMitigación, "");

            Riesgo miRiesgo = new Riesgo();
            miRiesgo.NombreRiesgo = txtNombreRiesgo.Text;
            miRiesgo.DescripcionRiesgo = txtDescripcion.Text;
            miRiesgo.Mitigacion = txtMitigación.Text;
            miRiesgo.Probabilidad = lblProbabilidad.TabIndex;
            //miRiesgo.Impacto =
            //miRiesgo.Total = 
            //miRiesgo.Nivel = 
            Riesgo.Add(miRiesgo);

            dgvMosler.DataSource = null;
            dgvMosler.DataSource = miRiesgo;

            //Limpiar los txt al haber colocado los datos
            txtNombreRiesgo.Clear();
            txtDescripcion.Clear();
            txtMitigación.Clear();
        }

        private bool Existe(string txtNombreRiesgo)
        {
            foreach (Riesgo Riesgo in Riesgo)
            {
                if(Riesgo.NombreRiesgo == txtNombreRiesgo) return true;
            }
            return false;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (n != -1){

                dgvMosler.Rows.RemoveAt(n);
            }
        }
    }
}
