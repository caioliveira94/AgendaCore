using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Agenda.Domain.Entities
{
    public class Telefone
    {
        public int telefoneId { get; set; }
        public string numero { get; set; }
        public TipoTelefone tipoTelefone { get; set; }
    }
}
