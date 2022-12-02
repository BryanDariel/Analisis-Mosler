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

        List<Riesgos> Riesgo = new List<Riesgos>();

        public Mosler(){

            InitializeComponent();
        }

        private void btnAgregarRiesgo_Click(object sender, EventArgs e){

            if (!ValidarNombre()) return;

            if (!ValidarOtrosCampos()) return;

            //Nombre de riesgo existente
            if (Existe(txtNombreRiesgo.Text))
            {
                errorProvider1.SetError(txtNombreRiesgo, "El nombre del riesgo ya ha sido registrado.");
                txtNombreRiesgo.Focus();
                return;
            }

            //Ayudame, papa Dio'
            Riesgos miRiesgo = new Riesgos();
            miRiesgo.Nombre = txtNombreRiesgo.Text;
            miRiesgo.Descripcion = txtDescripcion.Text;
            miRiesgo.Mitigacion = txtMitigación.Text;

            miRiesgo.Funcion = lbFuncion.Text;
            miRiesgo.Sustitucion = lbProfundidad.Text;
            miRiesgo.Profundidad = lbSustitucion.Text;
            miRiesgo.Extension = lbExtension.Text;
            miRiesgo.Agresion = lbAgresion.Text;
            miRiesgo.Vulnerabilidad = lbVulnerabilidad.Text;

            //miRiesgo.Total = ;
            //miRiesgo.Nivel = ;
            Riesgo.Add(miRiesgo);

            dgvMosler.DataSource = null;
            dgvMosler.DataSource = miRiesgo;

            //Limpiar los txt al haber colocado los datos
            txtNombreRiesgo.Clear();
            txtDescripcion.Clear();
            txtMitigación.Clear();
            lbFuncion.SelectedIndex = -1;
            lbSustitucion.SelectedIndex = -1;
        }

        private bool ValidarOtrosCampos()
        {
            //ErrorProvider de Descripcion
            if (txtDescripcion.Text == "")
            {
                errorProvider1.SetError(txtDescripcion, "Debe ingresar una descripción del riesgo.");
                txtDescripcion.Focus();
                return false;
            }
            errorProvider1.SetError(txtDescripcion, "");

            //ErrorProvider de Mitigacion
            if (txtMitigación.Text == "")
            {
                errorProvider1.SetError(txtMitigación, "Debe ingresar una mitigación del riesgo.");
                txtMitigación.Focus();
                return false;
            }
            errorProvider1.SetError(txtMitigación, "");

            //ErrorProvider de Funcion
            if (lbFuncion.SelectedIndex == -1)
            {
                errorProvider1.SetError(lbFuncion, "Debe seleccionar un numero.");
                lbFuncion.Focus();
                return false;
            }
            errorProvider1.SetError(lbFuncion, "");


            //ErrorProvider de Sustitucion
            if (lbSustitucion.SelectedIndex == -1)
            {
                errorProvider1.SetError(lbSustitucion, "Debe seleccionar un numero.");
                lbSustitucion.Focus();
                return false;
            }
            errorProvider1.SetError(lbSustitucion, "");

            //ErrorProvider de Profundidad
            if (lbProfundidad.SelectedIndex == -1)
            {
                errorProvider1.SetError(lbProfundidad, "Debe seleccionar un numero.");
                lbProfundidad.Focus();
                return false;
            }
            errorProvider1.SetError(lbProfundidad, "");

            return true;
        }

        private bool Existe(string txtNombreRiesgo)
        {
            foreach (Riesgos Riesgo in Riesgo)
            {
                if (Riesgo.Nombre == txtNombreRiesgo) return true;
            }
            return false;
        }

        private void Mosler_Load(object sender, EventArgs e)
        {
            Riesgos Riesgo1 = new Riesgos();
            Riesgo1.ID = 1;
            Riesgo1.Nombre = "Sismo";
            Riesgo1.Descripcion = "Perdida Informacion";
            Riesgo1.Mitigacion = "Lugar seguro";
            Riesgo1.Funcion = "3";
            Riesgo1.Sustitucion = "2";
            Riesgo1.Total = "6";
            Riesgo1.Nivel = "2-Riesgo bajo";
            Riesgo.Add(Riesgo1);

            Riesgos Riesgo2 = new Riesgos();
            Riesgo2.ID = 2;
            Riesgo2.Nombre = "Torbellino";
            Riesgo2.Descripcion = "Perdida Informacion";
            Riesgo2.Mitigacion = "Lugar seguro";
            Riesgo2.Funcion = "5";
            Riesgo2.Sustitucion = "2";
            Riesgo2.Total = "10";
            Riesgo2.Nivel = "2-Riesgo bajo";
            Riesgo.Add(Riesgo2);

            dgvMosler.DataSource = Riesgo;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!ValidarNombre()) return;

            Riesgos miRiesgo = GetRiesgos(txtNombreRiesgo.Text);
            if(miRiesgo == null)
            {
                errorProvider1.SetError(txtNombreRiesgo, "Riesgo no existe");
                txtNombreRiesgo.Focus();
                return;
            }
            errorProvider1.SetError(txtNombreRiesgo, "");

            txtNombreRiesgo.Text = miRiesgo.Nombre;
            txtDescripcion.Text = miRiesgo.Descripcion;
            txtMitigación.Text = miRiesgo.Mitigacion;

            lbFuncion.Text = miRiesgo.Funcion;
            lbSustitucion.Text = miRiesgo.Sustitucion;
            lbProfundidad.Text = miRiesgo.Profundidad;
            lbExtension.Text = miRiesgo.Extension;
            lbAgresion.Text = miRiesgo.Agresion;
            lbVulnerabilidad.Text = miRiesgo.Vulnerabilidad;
        }

        private bool ValidarNombre()
        {
            if (txtNombreRiesgo.Text == "")
            {
                errorProvider1.SetError(txtNombreRiesgo, "Debe ingresar el nombre del riesgo.");
                txtNombreRiesgo.Focus();
                return false;
            }
            errorProvider1.SetError(txtNombreRiesgo, "");
            return true;
        }

        private Riesgos GetRiesgos(string Nombre)
        {
            foreach (Riesgos miRiesgo in Riesgo)
            {
                if (miRiesgo.Nombre == Nombre) return miRiesgo;
            }
            return null;
        }

        private void lblModificar_Click(object sender, EventArgs e)
        {
            if (!ValidarNombre()) return;

            if (GetRiesgos(txtNombreRiesgo.Text) == null)
            {
            
            errorProvider1.SetError(txtNombreRiesgo, "Persona no existe.");
            txtNombreRiesgo.Focus();
            return;
            }
            errorProvider1.SetError(txtNombreRiesgo, "");

            if (!ValidarOtrosCampos()) return;

            foreach(Riesgos miRiesgo in Riesgo)
            {
                if (miRiesgo.Nombre == txtNombreRiesgo.Text)
                {
                    Riesgos Riesgo = new Riesgos();
                    miRiesgo.Nombre = txtNombreRiesgo.Text;
                    miRiesgo.Descripcion = txtDescripcion.Text;
                    miRiesgo.Mitigacion = txtMitigación.Text;

                    miRiesgo.Funcion = lbFuncion.Text;
                    miRiesgo.Sustitucion = lbProfundidad.Text;
                    miRiesgo.Profundidad = lbSustitucion.Text;
                    miRiesgo.Extension = lbExtension.Text;
                    miRiesgo.Agresion = lbAgresion.Text;
                    miRiesgo.Vulnerabilidad = lbVulnerabilidad.Text;
                    break;
                }
            }

            dgvMosler.DataSource = null;
            dgvMosler.DataSource = Riesgo;
        }

    }
}
