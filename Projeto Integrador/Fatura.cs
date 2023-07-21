using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Integrador
{
    public class Fatura

    {

        public int codigo { get; set; }

        public int codigoTitular { get; set; }

        public decimal valor { get; set; }

        public DateTime mesReferente { get; set; }

        public bool statusPagamento { get; set; }

        public DateTime dataVencimento { get; set; }
    }
}
