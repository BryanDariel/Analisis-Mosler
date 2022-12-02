using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analisis_Mosler
{
    internal class Riesgos
    {
        public int ID { get; set; }
        public string Nombre{ get; set; }
        public string Descripcion { get; set; }
        //Espacio :P
        public string Funcion { get; set; }
        public string Sustitucion { get; set; }
        public string Profundidad { get; set; }
        public string Extension { get; set; }
        public string Agresion { get; set; }
        public string Vulnerabilidad { get; set; }
        //Espacio :P
        public string Mitigacion { get; set; }
        public string Nivel { get; set; }
        public string Total { get; set; }

    }
}