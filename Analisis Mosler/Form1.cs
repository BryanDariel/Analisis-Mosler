using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Analisis_Mosler
{
    public partial class Mosler : Form {

        //Variables

        private int n = 0; //Este es el numero de renglones
        int nProbabilidad = 0, nImpacto = 0; //Estos son los datos que tomaremos una formula para sacar el total del riesgo
        int Calculo = 0;
        string vl; //Este es el texto que debe caer dentro de Nivel
        int id = 0;

        public Mosler(){

            InitializeComponent();
        }

        private void btnAgregarRiesgo_Click(object sender, EventArgs e){

            //Funcion de añadir nuevo renglon

            int n = dgvMosler.Rows.Add();

            //ID del riesgo

            for(id = 0; id <= n; id++)
            {
                dgvMosler.Rows[n].Cells[0].Value = id + 1;
            }

            //Para el total, debemos convertir los valores de las ListBox a numeros para luego hacer las operaciones
            //Probabilidad
            nProbabilidad = Convert.ToInt16(listProbabilidad.Text);

            //Impacto
            nImpacto = Convert.ToInt16(listImpacto.Text);

            //Prueba
            //Con los pocos numeros numeros que tenemos ahora, vamos a tomar una multiplicación de ejemplo y los colocaremos en "Total"
            //El valor minimo es 1 y el maximo es 25, asi que vamos a tomar 5 numeros para cada Nivel de riesgo
            //A cada nivel de dificultad le asignaremos un color para identificar qué tan grave es sin leer el texto

            Calculo = nProbabilidad * nImpacto;

            if (Calculo >= 1 && Calculo <= 5)
            {
                vl = "1-Riesgo muy bajo";
                dgvMosler.Rows[n].Cells[7].Style.BackColor = Color.GreenYellow;
                dgvMosler.Rows[n].Cells[7].Style.ForeColor = Color.White;
            }
            if (Calculo >= 6 && Calculo <= 10)
            {
                vl = "2-Riesgo bajo";
                dgvMosler.Rows[n].Cells[7].Style.BackColor = Color.Green;
                dgvMosler.Rows[n].Cells[7].Style.ForeColor = Color.White;
            }
            if (Calculo >= 11 && Calculo <= 15)
            {
                vl = "3-Riesgo normal";
                dgvMosler.Rows[n].Cells[7].Style.BackColor = Color.Orange;
                dgvMosler.Rows[n].Cells[7].Style.ForeColor = Color.White;
            }
            if (Calculo >= 16 && Calculo <= 20)
            {
                vl = "4-Riesgo alto";
                dgvMosler.Rows[n].Cells[7].Style.BackColor = Color.OrangeRed;
                dgvMosler.Rows[n].Cells[7].Style.ForeColor = Color.White;

            }
            if (Calculo >= 21 && Calculo <= 25)
            {
                vl = "5-Riesgo muy alto";
                dgvMosler.Rows[n].Cells[7].Style.BackColor = Color.Red;
                dgvMosler.Rows[n].Cells[7].Style.ForeColor = Color.White;
            }

            //Colocamos la informacion

            dgvMosler.Rows[n].Cells[1].Value = txtNombreRiesgo.Text;
            dgvMosler.Rows[n].Cells[2].Value = txtDescripcion.Text;
            dgvMosler.Rows[n].Cells[3].Value = listProbabilidad.Text;
            dgvMosler.Rows[n].Cells[4].Value = listImpacto.Text;
            dgvMosler.Rows[n].Cells[5].Value = txtMitigación.Text;
            dgvMosler.Rows[n].Cells[6].Value = Calculo;
            dgvMosler.Rows[n].Cells[7].Value = vl;

            //Limpiar los txt
            txtNombreRiesgo.Clear();
            txtDescripcion.Clear();
            txtMitigación.Clear();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (n != -1){

                dgvMosler.Rows.RemoveAt(n);
            }
        }
    }
}
