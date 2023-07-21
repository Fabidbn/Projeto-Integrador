using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Integrador
{
    public class Exames
    {
        public int codigo { get; set; }
        public int codigoTitular { get; set; }
        public string tipo { get; set; }
        public string descricao { get; set; }
        public DateTime dataRealizacao { get; set; }
        public bool status { get; set; }
    }
}
