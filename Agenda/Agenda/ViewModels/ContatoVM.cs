using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Agenda.Presentation.ViewModels
{
    public class ContatoVM
    {
        public int contatoId { get; set; }
        public string Nome { get; set; }
        public string Telefones { get; set; }
        public string Emails { get; set; }
        public string Empresa { get; set; }
        public string Endereco { get; set; }
    }
}
