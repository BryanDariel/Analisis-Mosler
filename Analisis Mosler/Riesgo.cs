using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analisis_Mosler
{
    internal class Riesgo
    {
        public int ID { get; set; }
        public string NombreRiesgo { get; set; }
        public string DescripcionRiesgo { get; set; }
        public int Probabilidad { get; set; }
        public int Impacto { get; set; }
        public string Mitigacion { get; set; }
        public int Total { get; set; }
        public string Nivel { get; set; }

    }
}
