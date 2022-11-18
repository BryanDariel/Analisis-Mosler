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
        }

        //Variables

        private int n = 0; //Este es el numero de filas
        int nProbabilidad = 0, nImpacto = 0; //Estos son los datos que tomaremos para calcular el total del riesgo
        int Calculo = 0;
        string vl; //Este es el texto que debe caer dentro de Nivel
        int id = 0; //El ID

        private void btnAgregarRiesgo_Click(object sender, EventArgs e){

            //Funcion de añadir nueva fila

            int n = dgvMosler.Rows.Add();

            //ID del riesgo que vaya aumentando segun el numero de filas y se coloque en la primera celda

            for(id = 0; id <= n; id++)
            {
                dgvMosler.Rows[n].Cells[0].Value = id + 1;
            }

            //Convertimos los valores de las ListBox a numeros para luego hacer las operaciones
            //Traté de hacerlo con texto, pero no me funcoina al hacerlo

            //Probabilidad
            nProbabilidad = Convert.ToInt16(listProbabilidad.Text);

            //Impacto
            nImpacto = Convert.ToInt16(listImpacto.Text);

            //Con las pocas variables que tenemos ahora, vamos a hacer una multiplicacion y colocamos los resultado en "Total"

            Calculo = nProbabilidad * nImpacto;

            //El valor minimo es 1 y el maximo es 25, asi que vamos a tomar 5 numeros para cada Nivel de riesgo
            //A cada nivel de dificultad le asignaremos un color para identificar qué tan grave es sin leer el texto

            if (Calculo >= 1 && Calculo <= 5)
            {
                vl = "1-Riesgo muy bajo";
                dgvMosler.Rows[n].Cells[7].Style.BackColor = Color.GreenYellow; //BackColor es el color de fondo, el color de adentro de la celda
                dgvMosler.Rows[n].Cells[7].Style.ForeColor = Color.White; //ForeColor es el color de las letras
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

            //Recuerden que la celda 0 esta arriba, utilizandose para la ID, como ya tenemos esa, empezamos en la celda 1
            dgvMosler.Rows[n].Cells[1].Value = txtNombreRiesgo.Text;
            dgvMosler.Rows[n].Cells[2].Value = txtDescripcion.Text;
            dgvMosler.Rows[n].Cells[3].Value = listProbabilidad.Text;
            dgvMosler.Rows[n].Cells[4].Value = listImpacto.Text;
            dgvMosler.Rows[n].Cells[5].Value = txtMitigación.Text;
            dgvMosler.Rows[n].Cells[6].Value = Calculo;
            dgvMosler.Rows[n].Cells[7].Value = vl;

            //Limpiar los txt al haber colocado los datos
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
