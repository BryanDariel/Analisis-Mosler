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

        int nProbabilidad = 0, nImpacto = 0; //Estos son los datos que tomaremos para calcular el total del riesgo
        private int Calculo = 0;
        string vl; //Este es el texto que debe caer dentro de Nivel

        ArrayList Riesgo = new ArrayList();

        public Mosler(){

            InitializeComponent();
        }

        private void Mosler_Load_1(object sender, EventArgs e)
        {
            Riesgo Riesgo1 = new Riesgo();
            Riesgo1.ID = 5;
            Riesgo1.Nombre = "Sismo";
            Riesgo1.Descripcion = "Perdida Informacion";
            Riesgo1.Mitigacion = "Lugar seguro";
            Riesgo1.Probabilidad = listProbabilidad.Text;
            Riesgo1.Impacto = listImpacto.Text;
            Riesgo1.Total = 10;
            Riesgo1.Nivel = "2-Riesgo bajo";
            Riesgo.Add(Riesgo1);

            Riesgo Riesgo2 = new Riesgo();
            Riesgo2.ID = 3;
            Riesgo2.Nombre = "Torbellino";
            Riesgo2.Descripcion = "Perdida Informacion";
            Riesgo2.Mitigacion = "Lugar seguro";
            Riesgo2.Probabilidad = listProbabilidad.Text;
            Riesgo2.Impacto = listImpacto.Text;
            Riesgo2.Total = 10;
            Riesgo2.Nivel = "2-Riesgo bajo";
            Riesgo.Add(Riesgo2);

            dgvMosler.DataSource = Riesgo;
        }

        private void btnAgregarRiesgo_Click(object sender, EventArgs e){

            //ErrorProvider de Nombre
            if (txtNombreRiesgo.Text == "")
            {
                errorProvider1.SetError(txtNombreRiesgo, "Debe ingresar el nombre del riesgo.");
                txtNombreRiesgo.Focus();
                return;
            }
            errorProvider1.SetError(txtNombreRiesgo, "");

            //ErrorProvider de Descripcion
            if (txtDescripcion.Text == "")
            {
                errorProvider1.SetError(txtDescripcion, "Debe ingresar una descripción del riesgo.");
                txtDescripcion.Focus();
                return;
            }
            errorProvider1.SetError(txtDescripcion, "");

            //ErrorProvider de Mitigacion
            if (txtMitigación.Text == "")
            {
                errorProvider1.SetError(txtMitigación, "Debe ingresar una mitigación del riesgo.");
                txtMitigación.Focus();
                return;
            }
            errorProvider1.SetError(txtMitigación, "");

            //Nombre de riesgo existente
            if (Existe(txtNombreRiesgo.Text))
            {
                errorProvider1.SetError(txtNombreRiesgo, "El nombre del riesgo ya ha sido registrado.");
                txtNombreRiesgo.Focus();
                return;
            }

            //Calculo
            //Probabilidad
            nProbabilidad = Convert.ToInt16(listProbabilidad.Text);

            //Impacto
            nImpacto = Convert.ToInt16(listImpacto.Text);

            Calculo = nProbabilidad * nImpacto;

            if (Calculo >= 1 && Calculo <= 5)
            {
                vl = "1-Riesgo muy bajo";
                //dgvMosler.Rows[n].Cells[7].Style.BackColor = Color.GreenYellow; //BackColor es el color de fondo, el color de adentro de la celda
                //dgvMosler.Rows[n].Cells[7].Style.ForeColor = Color.White; //ForeColor es el color de las letras
            }
            if (Calculo >= 6 && Calculo <= 10)
            {
                vl = "2-Riesgo bajo";
            }
            if (Calculo >= 11 && Calculo <= 15)
            {
                vl = "3-Riesgo normal";
                //dgvMosler.Rows[n].Cells[7].Style.BackColor = Color.Orange;
                //dgvMosler.Rows[n].Cells[7].Style.ForeColor = Color.White;
            }
            if (Calculo >= 16 && Calculo <= 20)
            {
                vl = "4-Riesgo alto";
                //dgvMosler.Rows[n].Cells[7].Style.BackColor = Color.OrangeRed;
                //dgvMosler.Rows[n].Cells[7].Style.ForeColor = Color.White;

            }
            if (Calculo >= 21 && Calculo <= 25)
            {
                vl = "5-Riesgo muy alto";
                //dgvMosler.Rows[n].Cells[7].Style.BackColor = Color.Red;
                //dgvMosler.Rows[n].Cells[7].Style.ForeColor = Color.White;
            }

            //Ayudame, papa Dio'
            Riesgo miRiesgo = new Riesgo();
            miRiesgo.Nombre = txtNombreRiesgo.Text;
            miRiesgo.Descripcion = txtDescripcion.Text;
            miRiesgo.Mitigacion = txtMitigación.Text;
            miRiesgo.Probabilidad = listProbabilidad.Text;
            miRiesgo.Impacto = listImpacto.Text;
            miRiesgo.Total = Calculo;
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
                if (Riesgo.Nombre == txtNombreRiesgo) return true;
            }
            return false;
        }

        private void Mosler_Load(object sender, EventArgs e)
        {
            Riesgo Riesgo1 = new Riesgo();
            Riesgo1.ID = 5;
            Riesgo1.Nombre = "Sismo";
            Riesgo1.Descripcion = "Perdida Informacion";
            Riesgo1.Mitigacion = "Lugar seguro";
            Riesgo1.Probabilidad = listProbabilidad.Text;
            Riesgo1.Impacto = listImpacto.Text;
            Riesgo1.Total = 10;
            Riesgo1.Nivel = "2-Riesgo bajo";
            Riesgo.Add(Riesgo1);

            Riesgo Riesgo2 = new Riesgo();
            Riesgo2.ID = 3;
            Riesgo2.Nombre = "Torbellino";
            Riesgo2.Descripcion = "Perdida Informacion";
            Riesgo2.Mitigacion = "Lugar seguro";
            Riesgo2.Probabilidad = listProbabilidad.Text;
            Riesgo2.Impacto = listImpacto.Text;
            Riesgo2.Total = 10;
            Riesgo2.Nivel = "2-Riesgo bajo";
            Riesgo.Add(Riesgo2);

            dgvMosler.DataSource = Riesgo;
        }
    }
}
