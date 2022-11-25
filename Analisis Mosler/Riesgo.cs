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
        public string Nombre{ get; set; }
        public string Descripcion { get; set; }
        public string Probabilidad { get; set; }
        public string Impacto { get; set; }
        public string Mitigacion { get; set; }
        public int Total { get; set; }
        public string Nivel { get; set; }

    }
}
