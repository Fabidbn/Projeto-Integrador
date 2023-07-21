using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Integrador
{
    public class EventoConfirmado
    {
        public int codigo { get; set; }
        public string nome { get; set; }
        public string descricao { get; set; }
        public string local { get; set; }
        public DateTime dataEvento { get; set; }
        public TimeSpan horaEvento { get; set; }
    }
}
